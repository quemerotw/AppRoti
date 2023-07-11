using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRoti.Clases {
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



		public CPedidoDelivery(CCliente cliente, string direccion):base(cliente) {
			this.ControlAsociado.BackColor = Color.Gold;
			this._direccion = direccion;
			this.ControlAsociado.Controls.Find("DireccionLbl", false)[0].Visible = true;
            (this.ControlAsociado.Controls.Find("DireccionLbl", false)[0] as Label).Text += " " + this._direccion;
        }
    }
}
