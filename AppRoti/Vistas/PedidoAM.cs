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
            p.Nombre = "Notti";
            p.PrecioVenta = 2000.0;
            CProducto p2 = new CProducto();
            p2.Nombre = "muzza";
            p2.PrecioVenta = 1000.0;
            Program.ListadoProductos.Add(p);
            Program.ListadoProductos.Add(p2);
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
            if (ClienteCbo.Text != "" ){
                if (OrdenesList.Items.Count>0) {
                    CCliente cliente = new CCliente(ClienteCbo.Text, DireccionCbo.Text); ;
                    CPedido pedido;
                    if (ClienteCbo.SelectedIndex < 0) {
                        if (MessageBox.Show("Crear nuevo cliente?", "cliente nuevo", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                            Program.ListadoClientes.Add(cliente);
                        }
                    }
                    else {
                        cliente = ClienteCbo.SelectedItem as CCliente;
                    }
                    if (ConEnvioChk.Checked) {
                        pedido = new CPedidoDelivery(cliente, cliente.Direccion);
                        CProducto envio = new CProducto();
                        envio.Nombre = "Envio";
                        envio.PrecioVenta = (double)PrecioEnvioNUP.Value;
                        pedido.DetallePedido.Add(envio);
                    }
                    else {
                        pedido = new CPedido(cliente);
                        pedido.Subtotal = 0;
                    }
                    foreach (string aux in OrdenesList.CheckedItems) {
                        pedido.DetallePedido.Add(Program.ListadoProductos.Find(x => x.Nombre == aux));
                    }
                    pedido.DetallePedido.Sort((x,y) => y.PrecioVenta.CompareTo(x.PrecioVenta));
                    pedido.Subtotal += pedido.CalcularSubtotal();
                    pedido.Descuento = 0;
                    FrmMuroPedidos.listadoPedidos.Add(pedido);
                    this.Close();
                }
                else {
                    MessageBox.Show("Pedido Vacio");
                }
            }
            else {
                MessageBox.Show("Cliente Vacio");
                ClienteCbo.Focus();
            }
        }

        private void ConEnvioChk_CheckedChanged(object sender, EventArgs e) {
            PrecioEnvioNUP.Enabled = ConEnvioChk.Checked;
        }
    }
}
