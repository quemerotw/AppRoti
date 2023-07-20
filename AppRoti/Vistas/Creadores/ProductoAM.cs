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

namespace AppRoti.Vistas.Creadores {
    public partial class ProductoAM : BaseForm {
        public override event FormEvent FormComplete;
        internal CPedido _pedidoModif = null;
        private ListViewItem VistaPreviaitem = new ListViewItem();


        public ProductoAM() {
            InitializeComponent();
        }

        private void ProductoAM_Load(object sender, EventArgs e) {
            int i = 0;
            IconosListVw.LargeImageList = Program.ImageList;
            foreach (Image img in Program.ImageList.Images) {
                ListViewItem item = new ListViewItem();
                item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = string.Format("{0} - {1}",img.Tag=i,img.Flags);
                i++;
                IconosListVw.Items.Add(item);
            }
            VistaPreviaListVw.Items.Add(VistaPreviaitem);
            VistaPreviaListVw.LargeImageList = Program.ImageList;
        }

        public override FrmOperacion OperacionForm {
            get { return base.OperacionForm; }
            set {
                base.OperacionForm = value;
                if (value == FrmOperacion.frmAlta) {
                    this.Text = "Nuevo Producto";
                }
            }
        }

        public void ShowIngresoProducto(BaseForm invoker) {
            this.InvokerForm = invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoProducto() {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void AceptarButton_Click(object sender, EventArgs e) {
            if (NombreTextBox.Text == "") {
                MessageBox.Show("Nombre del Producto vacio", "Error, Completar El Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreTextBox.Focus();
                return;
            }
            if (PrecioVentatextBox.Text == "") {
                MessageBox.Show("Precio De Venta del Producto vacio", "Error, Completar El Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrecioVentatextBox.Focus();
                return;
            }
            if (int.Parse(PrecioVentatextBox.Text) < 0) {
                MessageBox.Show("Precio de venta incorrecto del Producto", "Error, Completar El Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrecioVentatextBox.Focus();
                return;
            }
            if (PrecioCostotextBox.Text == "") {
                MessageBox.Show("Precio De costo del Producto vacio", "Error, Completar El Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrecioVentatextBox.Focus();
                return;
            }
            if (int.Parse(PrecioCostotextBox.Text) < 0) {
                MessageBox.Show("Precio de costo incorrecto del Producto", "Error, Completar El Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrecioVentatextBox.Focus();
                return;
            }
            if (int.Parse(PrecioCostotextBox.Text) < 0) {
                MessageBox.Show("Precio de costo incorrecto del Producto", "Error, Completar El Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrecioVentatextBox.Focus();
                return;
            }
            if (VistaPreviaListVw.Items[0].ImageIndex <0) {
                MessageBox.Show("Seleccione el icono del Producto", "Error, Completar El Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CProducto prodAux = new CProducto(10,NombreTextBox.Text,double.Parse(PrecioVentatextBox.Text), double.Parse(PrecioCostotextBox.Text),textBox3.Text,IsDivisibleSiradioButton.Checked, VistaPreviaListVw.Items[0].ImageIndex);
            if (FormComplete != null) {
                if (true) { // implementar mensaje de error
                    FormComplete(prodAux, new EventArgDom { ObjProcess = prodAux, Status = CompleteStatus.completed });
                }
                else {
                    FormComplete(prodAux, new EventArgDom { ObjProcess = prodAux, Status = CompleteStatus.error, Msj = "Err" });
                }
            }
            this.Close();
        }

        private void IconosListVw_SelectedIndexChanged(object sender, EventArgs e) {
            if (IconosListVw.SelectedItems.Count>0) {
                VistaPreviaListVw.Items[0].ImageIndex = IconosListVw.SelectedItems[0].ImageIndex;
            }
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsLetter(e.KeyChar) && (((short)e.KeyChar) != 8))
                e.Handled = true;
            VistaPreviaListVw.Items[0].Text = string.Format("{0} - ${1} \n Stock: {2}", NombreTextBox.Text,PrecioVentatextBox.Text, "X");
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && (((short)e.KeyChar) != 8))
                e.Handled = true;
            VistaPreviaListVw.Items[0].Text = string.Format("{0} - ${1} \n Stock: {2}", NombreTextBox.Text, PrecioVentatextBox.Text, "X");
        }

        private void PrecioCostotextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && (((short)e.KeyChar) != 8))
                e.Handled = true;
            VistaPreviaListVw.Items[0].Text = string.Format("{0} - ${1} \n Stock: {2}", NombreTextBox.Text, PrecioVentatextBox.Text, "X");
        }
    }
}
