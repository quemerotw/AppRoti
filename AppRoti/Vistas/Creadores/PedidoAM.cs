using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRoti.Clases;

namespace AppRoti.Vistas
{
    public partial class PedidoAM : BaseForm {
        public override event FormEvent FormComplete;
        internal CPedido _pedidoModif = null;
        private List<CProducto> OrdenesList= new List<CProducto>();
        private BindingList<CProducto> _bindingList;
        private BindingSource _bindingSource;
        private bool _half = false;

        public PedidoAM() {
            InitializeComponent();
        }

        private void PedidoAM_Load(object sender, EventArgs e) {
            RotiDbContext rotiDb = new RotiDbContext();

            ClienteCbo.DataSource = rotiDb.ClientesTable.ToList();
            ClienteCbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ClienteCbo.AutoCompleteSource = AutoCompleteSource.ListItems;
 

            DireccionCbo.DataSource = Program.ListadoClientes;
            DireccionCbo.ValueMember = "Direccion";
            DireccionCbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DireccionCbo.AutoCompleteSource = AutoCompleteSource.ListItems;

            TelComboBox.DataSource = Program.ListadoClientes;
            TelComboBox.ValueMember = "Telefono";
            TelComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TelComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;



            OrdenesListView.AutoGenerateColumns = false;

            ProductosListWv.View = View.LargeIcon;
            ProductosListWv.LargeImageList = Program.ImageList;

            foreach (CProducto prodAux in Program.ListadoProductos) {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = prodAux.IndexIconoProducto;
                item.Name = prodAux.Nombre;
                item.Text = string.Format("{0} - ${1} \n Stock: {2}", prodAux.Nombre, prodAux.PrecioVenta,prodAux.Stock);
                item.Tag = prodAux;
                ProductosListWv.Items.Add(item);
            }
            DireccionCbo.Text = "";
            ClienteCbo.Text = "";
        }

        private void ProductosListWv_ItemActivate(object sender, EventArgs e) {

        }

        private void AceptarBtn_Click(object sender, EventArgs e) {
            if (_half) {
                MessageBox.Show("Hay Una mitad de pizza suelta","Error, Completar El Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (OrdenesListView.Rows.Count < 0) {
                MessageBox.Show("Por favor seleccione los productos del pedido", "Error, Pedido Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TelComboBox.Text == "") {
                MessageBox.Show("Por favor Escriba el numero de telefono", "Error, Telefono Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TelComboBox.Focus();
                return;
            }
            if (ClienteCbo.Text == "") {
                MessageBox.Show("Por favor seleccione el cliente o escriba el nombre de un nuevo cliente", "Error, Cliente Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClienteCbo.Focus();
                return;
            }
            if (DireccionCbo.Text == "" && ConEnvioChk.Checked) {
                MessageBox.Show("por favor seleecione o escriba una direccion", "Error, Direccion vacia para pedido con envio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DireccionCbo.Focus();
                return;
            }
            CCliente cliente = new CCliente(ClienteCbo.Text, DireccionCbo.Text,TelComboBox.Text); ;
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
                CProducto envio = new CProducto("Envio", (double)PrecioEnvioNUP.Value);
                (pedido as CPedidoDelivery).PrecioEnvio = 0;
                pedido.DetallePedido.Add(envio);
            }
            else {
                pedido = new CPedido(cliente);
            }
            foreach (CProducto aux in OrdenesList) {
                pedido.DetallePedido.Add(aux);
            }
            pedido.Cliente.CantPedidos += 1;
            pedido.DetallePedido.Sort((x, y) => y.PrecioVenta.CompareTo(x.PrecioVenta));
            pedido.Subtotal += pedido.CalcularSubtotal();
            pedido.Descuento = 0;
            if (FormComplete != null) {
                if (true) { // implementar mensaje de error
                    FormComplete(pedido, new EventArgDom { ObjProcess = pedido, Status = CompleteStatus.completed });
                }
                else {
                    FormComplete(pedido, new EventArgDom { ObjProcess = pedido, Status = CompleteStatus.error, Msj = "Err" });
                }
            }
            this.Close();
        }

        public override FrmOperacion OperacionForm {
            get { return base.OperacionForm; }
            set {
                base.OperacionForm = value;
                if (value == FrmOperacion.frmAlta) {
                    this.Text = "Nuevo Pedido";
                }
            }
        }

        public void ShowIngresoPedido(BaseForm invoker) {
            this.InvokerForm = invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.Show();
        }
        public void ShowIngresoPedido() {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.Show();
        }




        private void DescChk_CheckedChanged(object sender, EventArgs e) {
            this.RefreshProductos();
            DescTxt.Enabled = DescChk.Checked;
        }

        private void RecargoChk_CheckedChanged(object sender, EventArgs e) {
            this.RefreshProductos();
            RecargoTxt.Enabled = RecargoChk.Checked;
        }

        private void DescTxt_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && (((short)e.KeyChar) != 8))
                e.Handled = true;
            this.RefreshProductos();
        }

        private void RecargoTxt_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && (((short)e.KeyChar) != 8))
                e.Handled = true;
            this.RefreshProductos();
        }

        private void CancelarBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ConEnvioChk_CheckedChanged(object sender, EventArgs e) {
            this.RefreshProductos();
            PrecioEnvioNUP.Enabled = ConEnvioChk.Checked;
            DireccionCbo.Enabled = ConEnvioChk.Checked;
        }

        private void ProductosListWv_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                CProducto productoSeleccionado = ProductosListWv.FocusedItem.Tag as CProducto;
                if (productoSeleccionado.Stock < 1) {
                    MessageBox.Show("no hay mas "+productoSeleccionado.Nombre);
                    return;
                }
                OrdenesList.Add(productoSeleccionado.GenerarVenta(1));
                this.RefreshProductos();
                _bindingList = new BindingList<CProducto>(OrdenesList);
                _bindingSource = new BindingSource(_bindingList, null);
                OrdenesListView.DataSource = _bindingSource;
            }
        }

        private void ProductosListWv_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                ProductoContextMenu.Show(sender as Control,e.Location);
            }
        }

        private void ProductoContextMenu_Opening(object sender, CancelEventArgs e) {
            if (!(ProductosListWv.FocusedItem.Tag as CProducto).IsDivisible) {
                ProductoContextMenu.Items.Find("MediaPizzaCM", false)[0].Visible =false;
            }
            else {
                ProductoContextMenu.Items.Find("MediaPizzaCM", false)[0].Visible = true;
            }
        }

        private void mediaPizza_Click(object sender, EventArgs e) {
            _half = !_half;
            CProducto productoSeleccionado = ProductosListWv.FocusedItem.Tag as CProducto;
            if (productoSeleccionado.Stock < 0.5) {
                MessageBox.Show("no hay mas " + productoSeleccionado.Nombre);
                return;
            }
            OrdenesList.Add(productoSeleccionado.GenerarVenta(0.5));
            this.RefreshProductos();
            _bindingList = new BindingList<CProducto>(OrdenesList);
            _bindingSource = new BindingSource(_bindingList,null);
            OrdenesListView.DataSource = _bindingSource;
        }


        private void OrdenesListView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            Program.ListadoProductos.Find(x => x.Nombre == e.Row.Cells[1].Value.ToString()).Stock += double.Parse(e.Row.Cells[0].Value.ToString());
            this.RefreshProductos();
        }

        private void RefreshProductos() {
            var total = 0.0;
            foreach (CProducto item in OrdenesList) {
                total += item.PrecioVenta;
            }
            total += double.Parse(RecargoTxt.Text);
            total -= double.Parse(DescTxt.Text);
            if (ConEnvioChk.Checked) {
                total += (double)PrecioEnvioNUP.Value;
            }
            TotalLbl.Text = string.Format("Total :{0}$",total);
            ProductosListWv.Items.Clear();
            foreach (CProducto prodAux in Program.ListadoProductos) {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = prodAux.IndexIconoProducto;
                item.Name = prodAux.Nombre;
                item.Text = string.Format("{0} - ${1} \n Porciones Restantes: {2}", prodAux.Nombre, prodAux.PrecioVenta, prodAux.Stock);
                item.Tag = prodAux;
                ProductosListWv.Items.Add(item);
            }
        }
    }
}
