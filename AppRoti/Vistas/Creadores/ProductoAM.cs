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

        private void AceptarButton_Click(object sender, EventArgs e) {
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
