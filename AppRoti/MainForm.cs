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
using AppRoti.Vistas.Creadores;

namespace AppRoti
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void auxToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void StartShiftBtn_Click(object sender, EventArgs e) {
            new FrmMuroPedidos().Show();
        }

        private void ListadosBtn_Click(object sender, EventArgs e) {
            new ListSelector().Show();
        }

        private void CrearProductosBtn_Click(object sender, EventArgs e) {
            new ProductoAM().Show();
        }
    }
}