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
using AppRoti.Vistas;

namespace AppRoti
{
    public partial class MainForm : Form
    {
        static private List<CCliente> _listadoClientes;

        static internal List<CCliente> ListadoClientes {
            get { return _listadoClientes; }
            set { _listadoClientes = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            ListadoClientes.Add(new CCliente("ALejo"));
        }

        private void auxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMuroPedidos().Show();
        }
    }
}
