using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRoti;
using AppRoti.Clases;

namespace AppRoti.Vistas
{
    public partial class FrmMuroPedidos : Form
    {
        private Point ultimo = new Point();
        private Point selec = new Point();
        private List<CPedido> listadoPedidos = new List<CPedido>();
        bool aux = false;

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
            a.Show();
            a.FormClosing += A_FormClosing;
           
        }

        private void A_FormClosing(object sender, FormClosingEventArgs e)
        //Instanciar una CPedido cuando el formulario de carga de info se cierra
        {
            CPedido pedido = new CPedido();
            pedido.ControlAsociado.MouseDown += new MouseEventHandler(ctrPedido1_MouseDown);
            pedido.ControlAsociado.MouseMove += new MouseEventHandler(ctrPedido1_MouseMove);
            pedido.ControlAsociado.MouseUp += new MouseEventHandler(ctrPedido1_MouseUp);
            pedido.ControlAsociado.MouseEnter += new EventHandler(ctrPedido1_MouseEnter);
            pedido.ControlAsociado.Anchor = AnchorStyles.Top;
            if (PedidosPanel.Controls.Count>0) {
                //buscar la ubicacion del ultimo ControlAsociado del panel
                Point posAnt = PedidosPanel.Controls[PedidosPanel.Controls.Count - 1].Location;
                posAnt.X += pedido.ControlAsociado.Size.Width;
                pedido.ControlAsociado.Location = posAnt;
            }
            listadoPedidos.Add(pedido);
            PedidosPanel.Controls.Add(pedido.ControlAsociado);
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
                else {
                    selec.X = 0;
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

        private void FrmMuroPedidos_Load(object sender, EventArgs e) {
            
        }
    }
}
