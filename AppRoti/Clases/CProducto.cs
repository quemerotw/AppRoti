using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRoti.Clases
{
    [Serializable]
    public class CProducto
    {
        public string Nombre { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCosto { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return this.Nombre +" $"+  this.PrecioVenta; 
        }

        public double CalcularGanancia() {
            return this.PrecioVenta - this.PrecioCosto;
        }
    }
}
