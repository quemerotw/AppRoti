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
    public partial class PedidoAM : BaseForm
    {
        public override event FormEvent FormComplete;
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


            foreach (CProducto prodAux in Program.ListadoProductos) {
                ListViewItem item = new ListViewItem();

                item.Name = prodAux.Nombre;
                item.Text = string.Format("{0} - ${1}", prodAux.Nombre, prodAux.PrecioVenta); 
                ProductosListWv.Items.Add(item);
            }
        }

        private void ProductosListWv_ItemActivate(object sender, EventArgs e)
        {
            OrdenesList.Items.Add((sender as ListView).FocusedItem.Name,true);
        }

        private void AceptarBtn_Click(object sender, EventArgs e) {
            if (ClienteCbo.Text != "" ){
                if (OrdenesList.Items.Count > 0) {
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
                        (pedido as CPedidoDelivery).PrecioEnvio = 0;
                        pedido.DetallePedido.Add(envio);
                    }
                    else {
                        pedido = new CPedido(cliente);
                    }
                    foreach (string aux in OrdenesList.CheckedItems) {
                        pedido.DetallePedido.Add(Program.ListadoProductos.Find(x => x.Nombre == aux));
                    }
                    pedido.DetallePedido.Sort((x, y) => y.PrecioVenta.CompareTo(x.PrecioVenta));
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

        public override FrmOperacion OperacionForm {
            get { return base.OperacionForm; }
            set {
                base.OperacionForm = value;
                if (value == FrmOperacion.frmAlta) {
                    this.Text = "Creando Pedido";
                }
            }
        }

        public void ShowIngresoPedido(BaseForm invoker) {
            this.InvokerForm = invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoPedido() {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }


        private void ConEnvioChk_CheckedChanged(object sender, EventArgs e) {
            PrecioEnvioNUP.Enabled = ConEnvioChk.Checked;
        }

        private void DescChk_CheckedChanged(object sender, EventArgs e) {
            DescTxt.Enabled = DescChk.Checked;
        }

        private void RecargoChk_CheckedChanged(object sender, EventArgs e) {
            RecargoTxt.Enabled = RecargoChk.Checked;
        }

        private void DescTxt_KeyPress(object sender, KeyPressEventArgs e) { 
            if (!char.IsDigit(e.KeyChar) && (((short)e.KeyChar) != 8))
                e.Handled = true;
        }

        private void RecargoTxt_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && (((short)e.KeyChar) != 8))
                e.Handled = true;
        }

        private void CancelarBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
