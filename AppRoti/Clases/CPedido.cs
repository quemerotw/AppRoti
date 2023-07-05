using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRoti;

namespace AppRoti.Clases
{
    internal class CPedido
    {
        private bool aux = false;
        private WindowsFormsApp1.Controls.CtrPedido _controlAsoc;
        private static int numPedido=1;

        public WindowsFormsApp1.Controls.CtrPedido ControlAsociado

        {
            get { return _controlAsoc; }
            set { _controlAsoc = value; }
        }

        public CPedido() {
            string _nombre = string.Format("pedido{0}", numPedido);
            _controlAsoc = new WindowsFormsApp1.Controls.CtrPedido();
            _controlAsoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _controlAsoc.BackColor = System.Drawing.Color.LawnGreen;
            _controlAsoc.Location = new System.Drawing.Point(0, 0);
            _controlAsoc.Name = _nombre;
            _controlAsoc.Size = new System.Drawing.Size(134, 159);
            _controlAsoc.MouseDown += new System.Windows.Forms.MouseEventHandler(ctrPedido1_MouseDown);
            _controlAsoc.MouseMove += new System.Windows.Forms.MouseEventHandler(ctrPedido1_MouseMove);
            _controlAsoc.MouseUp += new System.Windows.Forms.MouseEventHandler(ctrPedido1_MouseUp);
            numPedido++;
        }
        private void ctrPedido1_MouseDown(object sender, MouseEventArgs e)
        {
            aux = true;
        }

        private void ctrPedido1_MouseMove(object sender, MouseEventArgs e)
        {
            Point m = (sender as Control).PointToClient(Cursor.Position);
            if (aux)
            {
                (sender as Control).Location = m;
            }
        }

        private void ctrPedido1_MouseUp(object sender, MouseEventArgs e)
        {
            aux = false;
        }
    }
}
