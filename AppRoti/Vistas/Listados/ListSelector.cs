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
        BindingSource bindingSource;
        public ListSelector() {
            InitializeComponent();
        }

        private void ListSelector_Load(object sender, EventArgs e) {
            bindingListCliente = new BindingList<CCliente>(Program.ListadoClientes);
            bindingSource = new BindingSource(bindingListCliente,null);
            this.ClientesGridView.DataSource = bindingSource;
        }
    }
}
