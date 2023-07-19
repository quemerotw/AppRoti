using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRoti;
using AppRoti.Clases;
using WindowsFormsApp1.Controls;

namespace AppRoti.Vistas
{
    public partial class FrmMuroPedidos : BaseForm
    {
        private Point ultimo = new Point();
        private Point selec = new Point();
        bool aux = false;

        static internal List<CPedido> listadoPedidos = new List<CPedido>();
 

        public FrmMuroPedidos()
        {
            InitializeComponent();
        }

        private void ctrPedido1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           PedidoAM a = new PedidoAM();
            a.FormComplete += new FormEvent(f_FormComplete);
            a.ShowIngresoPedido();
        }


        private void ctrPedido1_MouseDown(object sender, MouseEventArgs e)
        {
            aux = true;
        }

        private void ctrPedido1_MouseMove(object sender, MouseEventArgs e)
        {
            if (aux) {
                Control controlAux = (sender as Control);
                Point m = controlAux.TopLevelControl.PointToClient(Cursor.Position);
                m.X -= controlAux.TopLevelControl.Location.X;
                m.Y -= controlAux.TopLevelControl.Location.Y;
                selec = controlAux.Location;
                controlAux.Location = m;
                bool teEncontrePuto = false;
                foreach (Control item in PedidosPanel.Controls) {
                    if (!item.Equals(controlAux)) {
                        if (item.Bounds.IntersectsWith(controlAux.Bounds)) {
                            teEncontrePuto = true;
                            ultimo = item.Location;
                            ultimo.X += item.Width;
                            controlAux.Location = ultimo;
                        }
                    }
                }
            }
        }

        private void ctrPedido1_MouseEnter(object sender, EventArgs e) {
            if (aux) {
                Control controlAux = (sender as Control);
                if (selec.X > controlAux.Location.X) {
                    selec.X -= controlAux.Width;
                    selec.Y = controlAux.ClientRectangle.Top;
                    controlAux.Location = selec;
                }
            }
        }

        private void ctrPedido1_MouseUp(object sender, MouseEventArgs e)
        {
            aux = false;
            Control controlAux = (sender as Control);
            //ultimo.X -= controlAux.Width;
            //controlAux.Location = ultimo;
        }


        internal void f_FormComplete(object sender, EventArgDom ev) {
            if (ev.Status == CompleteStatus.completed) {
                CPedido pedido;
                pedido = ev.ObjProcess as CPedido;
                pedido.ControlAsociado.MouseEnter += ctrPedido1_MouseEnter;
                pedido.ControlAsociado.MouseMove += ctrPedido1_MouseMove;
                pedido.ControlAsociado.MouseUp += ctrPedido1_MouseUp;
                pedido.ControlAsociado.MouseDown += ctrPedido1_MouseDown;
                (pedido.ControlAsociado.Controls.Find("CancelarBtn", false)[0] as Button).MouseClick += BtnCancelarPedido_MouseClick;
                (pedido.ControlAsociado.Controls.Find("CancelarBtn", false)[0] as Button).Tag = pedido;
                (pedido.ControlAsociado.Controls.Find("CompletadoBtn", false)[0] as Button).MouseClick += BtnAceptarPedido_MouseClick;
                (pedido.ControlAsociado.Controls.Find("CompletadoBtn", false)[0] as Button).Tag = pedido;
                (pedido.ControlAsociado.Controls.Find("DetalleList", true)[0] as ListBox).DataSource = pedido.DetallePedido;
                (pedido.ControlAsociado.Controls.Find("TotalLbl", false)[0] as Label).Text += string.Format("{0}", pedido.Subtotal + pedido.Descuento);
                if (PedidosPanel.Controls.Count > 0) {
                    //buscar la ubicacion del ultimo ControlAsociado del panel
                    Point posAnt = PedidosPanel.Controls[PedidosPanel.Controls.Count - 1].Location;
                    posAnt.X += pedido.ControlAsociado.Size.Width;
                    pedido.ControlAsociado.Location = posAnt;
                }
                pedido.ControlAsociado.Anchor = AnchorStyles.Top;
                listadoPedidos.Add(pedido);
                PedidosPanel.Controls.Add(pedido.ControlAsociado);
            }
            else {
                MessageBox.Show("Test");
            }
        }

        private void BtnAceptarPedido_MouseClick(object sender, MouseEventArgs e) {
            Program.ListadoPedidosFinal.Add((CPedido)(sender as Button).Tag);
        }

        private void BtnCancelarPedido_MouseClick(object sender, MouseEventArgs e) {
            CPedido pedAux = (CPedido)(sender as Button).Tag;
        }

        private void FrmMuroPedidos_FormClosing(object sender, FormClosingEventArgs e) {
            if (PedidosPanel.Controls.Count>0) {
                MessageBox.Show(string.Format("Imposible cerrar el muro de pedidos todavia quedan {0} pedidos activos, complete los pedidos y luego cierre",PedidosPanel.Controls.Count),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
