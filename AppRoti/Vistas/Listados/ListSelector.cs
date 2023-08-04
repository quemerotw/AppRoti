using AppRoti.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRoti.Vistas {
    public partial class ListSelector : Form {
        BindingList<CCliente> bindingListCliente;
        BindingSource bindingSourceCliente;
        BindingList<CPedido> bindingListPedido;
        BindingSource bindingSourcePedido;
        BindingList<CProducto> bindingListProducto;
        BindingSource bindingSourceProducto;
        public ListSelector() {
            InitializeComponent();
        }

        private void ListSelector_Load(object sender, EventArgs e) {
            /*ClientesGridView.AutoGenerateColumns = false;
            VentasGridView.AutoGenerateColumns = false;
            ProdGridView.AutoGenerateColumns = false;
            bindingListCliente = new BindingList<CCliente>(Program.ListadoClientes);
            bindingSourceCliente = new BindingSource(bindingListCliente,null);
            this.ClientesGridView.DataSource = bindingSourceCliente;
            bindingListPedido = new BindingList<CPedido>(Program.ListadoPedidosFinal);
            bindingSourcePedido = new BindingSource(bindingListPedido, null);
            this.VentasGridView.DataSource = bindingSourcePedido;
            bindingListProducto = new BindingList<CProducto>(Program.ListadoProductos);
            bindingSourceProducto = new BindingSource(bindingListProducto, null);
            this.ProdGridView.DataSource = bindingSourceProducto;*/
        }

        private void VentasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
