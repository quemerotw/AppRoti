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
        {
            CPedido pedido = new CPedido();
            pedido.ControlAsociado.MouseDown += new System.Windows.Forms.MouseEventHandler(ctrPedido1_MouseDown);
            pedido.ControlAsociado.MouseMove += new System.Windows.Forms.MouseEventHandler(ctrPedido1_MouseMove);
            pedido.ControlAsociado.MouseUp += new System.Windows.Forms.MouseEventHandler(ctrPedido1_MouseUp);
            listadoPedidos.Add(pedido);
            this.ParedFlLy.Controls.Add(pedido.ControlAsociado);
        }

        private void ctrPedido1_MouseDown(object sender, MouseEventArgs e)
        {
            aux = true;
        }

        private void ctrPedido1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (aux)
            {
                Point m = (sender as Control).TopLevelControl.PointToClient(Cursor.Position);
                (sender as Control).Location = m;
            }
        }

        private void ctrPedido1_MouseUp(object sender, MouseEventArgs e)
        {
            aux = false;
        }
    }
}
