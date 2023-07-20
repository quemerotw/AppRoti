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
    public partial class MainForm : BaseForm
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
            ProductoAM fp = new ProductoAM();
            fp.FormComplete += Fp_FormComplete;
            fp.Show();
        }

        private void Fp_FormComplete(object sender, EventArgDom ev) {
            if (ev.Status == CompleteStatus.completed) {
                var x = ev.ObjProcess as CProducto;
                Program.ListadoProductos.Add(x);
                MessageBox.Show("Producto Agregado","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Test");
            }
        }
    }
}