using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRoti.Clases;

namespace AppRoti.Vistas
{
    public partial class PedidoAM : Form
    {
        
        public PedidoAM()
        {
            InitializeComponent();
        }

        private void PedidoAM_Load(object sender, EventArgs e)
        {
            ClienteCbo.DataSource = Program.ListadoClientes;
            ClienteCbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ClienteCbo.AutoCompleteSource = AutoCompleteSource.ListItems;
            ClienteCbo.Text = "";

            DireccionCbo.DataSource = Program.ListadoClientes;
            DireccionCbo.ValueMember = "Direccion";
            DireccionCbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DireccionCbo.AutoCompleteSource = AutoCompleteSource.ListItems;
            DireccionCbo.Text = "";

            CProducto p = new CProducto();
            p.Nombre = "pizza";
            Program.ListadoProductos.Add(p);
            foreach (CProducto prodAux in Program.ListadoProductos)
            {
                ListViewItem item = new ListViewItem();
                item.Name = prodAux.Nombre;
                item.Text = prodAux.Nombre;
                ProductosListWv.Items.Add(item);
            }
        }

        private void ProductosListWv_ItemActivate(object sender, EventArgs e)
        {
            OrdenesList.Items.Add((sender as ListView).FocusedItem.Name,true);
        }

        private void AceptarBtn_Click(object sender, EventArgs e) {
            CCliente cliente = new CCliente(ClienteCbo.Text, DireccionCbo.Text); ;
            CPedido pedido;
            if (ClienteCbo.SelectedIndex <0) {
                if (MessageBox.Show("Crear nuevo cliente?","cliente nuevo",MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    Program.ListadoClientes.Add(cliente);
                }
            }
            else {
                cliente = ClienteCbo.SelectedItem as CCliente;
            }
            pedido = new CPedido(cliente);
            foreach (string aux in OrdenesList.Items) {
                pedido.DetallePedido.Add(Program.ListadoProductos.Find(x => x.Nombre == aux));
            }
            pedido.Subtotal = pedido.CalcularSubtotal();
            pedido.Descuento = 0;
            MessageBox.Show(pedido.Cliente.ToString()+pedido.Subtotal);
            FrmMuroPedidos.listadoPedidos.Add(pedido);
            this.Close();
        }
    }
}
