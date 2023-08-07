using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRoti.Clases {

	[Serializable]
    internal class CPedidoDelivery : CPedido{

		private double _precioEnvio;

		public double PrecioEnvio {
			get { return _precioEnvio; }
			set { _precioEnvio = value; }
		}


		private string _direccion;
		

		public string Direccion {
			get { return _direccion; }
			set { _direccion = value; }
		}

		public CPedidoDelivery() {

		}

		public CPedidoDelivery(CCliente cliente, string direccion):base(cliente) {
			this._direccion = direccion;
        }

        public override double CalcularTotal() {
            return base.CalcularTotal() + this.PrecioEnvio;
        }
    }
}
