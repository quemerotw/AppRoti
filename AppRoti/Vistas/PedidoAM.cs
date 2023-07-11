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
        private List<CProducto> _listaPoductos = new List<CProducto>();
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

            CProducto a= new CProducto();
            a.Nombre = "Pizza - $2000";
            _listaPoductos.Add(a);
            foreach (CProducto prodAux in _listaPoductos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = prodAux.ToString();
                ProductosListWv.Items.Add(item);
            }
        }

        private void ProductosListWv_ItemActivate(object sender, EventArgs e)
        {
            OrdenesList.Items.Add((sender as ListView).FocusedItem.Text,true);
        }

        private void AceptarBtn_Click(object sender, EventArgs e) {
            if (ClienteCbo.SelectedIndex <0) {
                if (MessageBox.Show("Crear nuevo cliente?","cliente nuevo",MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    Program.ListadoClientes.Add(new CCliente(ClienteCbo.Text,DireccionCbo.Text));
                }
            }
        }
    }
}
