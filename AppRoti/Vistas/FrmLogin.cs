
using AppRoti;
using AppRoti.Clases;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            CUsers usuario = Program.ListadoUsers.Find(x => (x.Nombre == UsuarioTxt.Text));
            if (usuario != null) {
                if (usuario.Clave == ClaveTxt.Text) {
                    MainForm._usuario = usuario;
                    this.Close();
                }
                else {
                    MessageBox.Show("Clave Erronea");
                }
            }
            else {
                MessageBox.Show("Usuario Erroneo");
                if (MessageBox.Show("Desea entrar como Visitante?", "Usuario no encontrado", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    MainForm._usuario = new CUsers(1000, "Invitado", "0", UserRank.Visit);
                    this.Close();
                }
            }
        } 
    }
}
