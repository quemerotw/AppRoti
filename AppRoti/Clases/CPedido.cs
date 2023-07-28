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

        private DateTime _fecha;

        public DateTime Fecha {
            get { return _fecha; }
        }


        public static int NumPedido {
            get { return _numPedido; }
        }

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

        private List<CProducto> _detallePedido;

        public List<CProducto> DetallePedido {
            get { return _detallePedido; }
            set { _detallePedido = value; }
        }

        public CPedido(CCliente cliente) {
            string _nombre = string.Format("pedido{0}", _numPedido);
            _detallePedido = new List<CProducto>();
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
        public double CalcularTotal {
            get { 
            var Total = Subtotal -= Descuento;
            Total += Recargo;
            return Total;
            }
        }

        public WindowsFormsApp1.Controls.CtrPedido CrearControl(CPedido pedido) {
            WindowsFormsApp1.Controls.CtrPedido controlAsoc = new WindowsFormsApp1.Controls.CtrPedido();
            controlAsoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            controlAsoc.BackColor = System.Drawing.Color.LawnGreen;
            controlAsoc.Location = new System.Drawing.Point(0, 0);
            if (pedido is CPedidoDelivery) {
                controlAsoc.BackColor = Color.Gold;
                controlAsoc.Controls.Find("DireccionLbl", false)[0].Visible = true;
                (controlAsoc.Controls.Find("DireccionLbl", false)[0] as Label).Text += " " + (pedido as CPedidoDelivery).Direccion;
            }
            controlAsoc.Name = string.Format("ctrPedido-{0}", CPedido.NumPedido);
            controlAsoc.Size = new System.Drawing.Size(176, 190);
            (controlAsoc.Controls.Find("NroPedidoLbl", false)[0] as Label).Text += string.Format("{0} - hora {1}:{2}", CPedido.NumPedido, DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes);
            (controlAsoc.Controls.Find("idPedidoLbl", false)[0] as Label).Text += string.Format("{0}", pedido.Cliente.ToString());
            controlAsoc.Tag = pedido;
            (controlAsoc.Controls.Find("CancelarBtn", false)[0] as Button).Tag = pedido;
            
            (controlAsoc.Controls.Find("CompletadoBtn", false)[0] as Button).Tag = pedido;
            (controlAsoc.Controls.Find("DetalleList", true)[0] as ListBox).DataSource = pedido.DetallePedido;
            (controlAsoc.Controls.Find("TotalLbl", false)[0] as Label).Text += string.Format("{0}", pedido.Subtotal + pedido.Descuento);
            return controlAsoc;
        }
    }
}
