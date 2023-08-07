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
        readonly RotiDbContext rotiDb = Program.RotiDbInstance;

        public ListSelector() {
            InitializeComponent();
        }

        private void ListSelector_Load(object sender, EventArgs e) {
            ClientesGridView.AutoGenerateColumns = false;
            VentasGridView.AutoGenerateColumns = false;
            ProdGridView.AutoGenerateColumns = false;
            bindingListCliente = new BindingList<CCliente>(rotiDb.ClientesTable.ToList());
            bindingSourceCliente = new BindingSource(bindingListCliente,null);
            this.ClientesGridView.DataSource = bindingSourceCliente;
            bindingListPedido = new BindingList<CPedido>(rotiDb.PedidosTable.ToList());
            bindingSourcePedido = new BindingSource(bindingListPedido, null);
            this.VentasGridView.DataSource = bindingSourcePedido;
            bindingListProducto = new BindingList<CProducto>(rotiDb.ProductoTable.ToList());
            bindingSourceProducto = new BindingSource(bindingListProducto, null);
            this.ProdGridView.DataSource = bindingSourceProducto;
        }

        private void VentasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
