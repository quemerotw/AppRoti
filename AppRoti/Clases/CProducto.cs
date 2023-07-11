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
        public int PrecioVenta { get; set; }
        public int PrecioCosto { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return this.Nombre; 
        }

        public int CalcularGanancia() {
            return this.PrecioVenta - this.PrecioCosto;
        }
    }
}
