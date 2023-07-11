﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRoti.Clases {
    internal class CPedidoDelivery : CPedido{

		private string _direccion;

		public string Direccion {
			get { return _direccion; }
			set { _direccion = value; }
		}



		public CPedidoDelivery(CCliente cliente, string direccion):base(cliente) {
			this.ControlAsociado.BackColor = Color.Gold;
			this._direccion = direccion;
        }
    }
}