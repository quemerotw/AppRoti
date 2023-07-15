using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRoti;
using AppRoti.Clases.Orm;


namespace AppRoti.Clases 
{
    [Serializable]
    internal class CPedido : BaseClass {
        private static int _numPedido=1;

        private double _recargo;

        public double Recargo {
            get { return _recargo; }
            set { _recargo = value; }
        }

        private double _descuento;

        public double Descuento {
            get { return _descuento; }
            set { _descuento = value; }
        }

        private double _subTotal;

        public double Subtotal {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

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
            _controlAsoc.Size = new System.Drawing.Size(176, 190);
            (_controlAsoc.Controls.Find("NroPedidoLbl",false)[0] as Label).Text += string.Format("{0} - hora {1}:{2}", _numPedido,DateTime.Now.TimeOfDay.Hours,DateTime.Now.TimeOfDay.Minutes);
            (_controlAsoc.Controls.Find("idPedidoLbl", false)[0] as Label).Text += string.Format("{0}", cliente.ToString());
            _numPedido++;
            Cliente = cliente;
        }
        public double CalcularSubtotal() {
            double resultado = 0;
            foreach (CProducto item in this.DetallePedido) {
                resultado += item.PrecioVenta;
            }
            return resultado;
        }
    }
}
