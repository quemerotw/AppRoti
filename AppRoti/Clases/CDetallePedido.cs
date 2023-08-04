using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRoti.Clases {
    public class CDetallePedido {
        public int Id { get; set; }
        public virtual CPedido Pedido { get; set; }
        public virtual CProducto Producto { get; set; }
        public double Cantidad { get; set; }

        public CDetallePedido()
        {
              
        }

        public CDetallePedido(double cant,CProducto prod)
        {
            this.Producto = prod;
            this.Cantidad = cant;
        }
    }
}
