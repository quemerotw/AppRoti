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
 

        public FrmMuroPedidos(BaseForm invoker)
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
                CtrPedido controlAsoc = pedido.CrearControl(pedido);
                controlAsoc = AsignarEventos(controlAsoc);
                if (PedidosPanel.Controls.Count > 0) {
                    //buscar la ubicacion del ultimo ControlAsociado del panel
                    Point posAnt = PedidosPanel.Controls[PedidosPanel.Controls.Count - 1].Location;
                    posAnt.X += controlAsoc.Size.Width;
                    controlAsoc.Location = posAnt;
                }
                controlAsoc.Anchor = AnchorStyles.Top;
                listadoPedidos.Add(pedido);
                PedidosPanel.Controls.Add(controlAsoc);
            }
            else {
                MessageBox.Show("Test");
            }
        }

        private CtrPedido AsignarEventos(CtrPedido controlAsoc) {
            controlAsoc.MouseEnter += ctrPedido1_MouseEnter;
            controlAsoc.MouseMove += ctrPedido1_MouseMove;
            controlAsoc.MouseUp += ctrPedido1_MouseUp;
            controlAsoc.MouseDown += ctrPedido1_MouseDown;
            (controlAsoc.Controls.Find("CancelarBtn", false)[0] as Button).MouseClick += BtnCancelarPedido_MouseClick;
            (controlAsoc.Controls.Find("CompletadoBtn", false)[0] as Button).MouseClick += BtnAceptarPedido_MouseClick;
            return controlAsoc;
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

        private void PedidosPanel_Paint(object sender, PaintEventArgs e) {

        }
    }
}
