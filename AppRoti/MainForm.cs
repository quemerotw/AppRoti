using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRoti.Clases;
using AppRoti.Vistas;
using AppRoti.Vistas.Creadores;
using clubApp.Views;

namespace AppRoti
{
    public partial class MainForm : BaseForm {

        internal static CUsers _usuario;


        public MainForm() { 
            InitializeComponent();
        }

        private void auxToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e) {
            FrmLogin frmLogin;
            this.Visible = false;
            frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Visible = true;
            monthCalendar1.TodayDate = DateTime.Now;
            _usuario.FechaLog = DateTime.Now;
            if (_usuario.UserRankValue == UserRank.Me) {
                this.crearUsuariosToolStripMenuItem.Visible = true;
            }
            if (_usuario.UserRankValue == UserRank.Visit) {
                this.CrearProductosBtn.Enabled = false;
                this.StartShiftBtn.Enabled = false;
            }
            groupBox1.Text = "Usuario Actual: " + _usuario.Nombre + " Hora Inicio Seccion "+ _usuario.FechaLog.ToString("HH:mm"); 
        }

        private void StartShiftBtn_Click(object sender, EventArgs e) {
            FrmMuroPedidos f = new FrmMuroPedidos(this);
            f.Show();
        }

        private void ListadosBtn_Click(object sender, EventArgs e) {
            new ListSelector().Show();
        }

        private void CrearProductosBtn_Click(object sender, EventArgs e) {
            ProductoAM fp = new ProductoAM();
            fp.FormComplete += Fp_FormComplete;
            fp.ShowIngresoProducto(this);
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