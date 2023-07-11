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
    [Serializable]
    internal class CPedido
    {
        private static int _numPedido=1;
        private double _descuento;
        private double _total;
        public CCliente Cliente { get;}
        private WindowsFormsApp1.Controls.CtrPedido _controlAsoc;

        private List<CProducto> _detallePedido;

        public List<CProducto> DetallePedido {
            get { return _detallePedido; }
            set { _detallePedido = value; }
        }


        public WindowsFormsApp1.Controls.CtrPedido ControlAsociado

        {
            get { return _controlAsoc; }
            set { _controlAsoc = value; }
        }

        public CPedido(CCliente cliente) {
            string _nombre = string.Format("pedido{0}", _numPedido);
            _detallePedido = new List<CProducto>();
            _controlAsoc = new WindowsFormsApp1.Controls.CtrPedido();
            _controlAsoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _controlAsoc.BackColor = System.Drawing.Color.LawnGreen;
            _controlAsoc.Location = new System.Drawing.Point(0, 0);
            _controlAsoc.Name = _nombre;
            _controlAsoc.Size = new System.Drawing.Size(134, 159);
            _controlAsoc.Controls[0].Text += string.Format("{0}", _numPedido);
            _numPedido++;
            Cliente = cliente;
        }
    }
}
