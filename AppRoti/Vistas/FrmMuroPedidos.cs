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
        private List<CPedido> listadoPedidos =  new List<CPedido>();

        public FrmMuroPedidos()
        {
            InitializeComponent();
        }

        private void ctrPedido1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CPedido pedido = new CPedido();
            listadoPedidos.Add(pedido);
            
            this.Controls.Add(pedido.ControlAsociado);
        }
    }
}
