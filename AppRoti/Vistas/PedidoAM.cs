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
            ClienteCbo.DataSource = MainForm.ListadoClientes;
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
    }
}
