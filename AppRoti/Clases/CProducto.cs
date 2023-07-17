using AppRoti.Clases.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRoti.Clases
{
    [Serializable]
    public class CProducto : BaseClass {


        private double _stock;

        public double Stock {
            get { return _stock; }
            set { _stock = value; }
        }



        public string Nombre { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCosto { get; set; }
        public string Descripcion { get; set; }


        public CProducto(string nombre, double precioVenta) {
            Nombre = nombre;
            PrecioVenta = precioVenta;
        }

        public CProducto(double stock, string nombre, double precioVenta, double precioCosto, string descripcion) {
            Stock = stock;
            Nombre = nombre;
            PrecioVenta = precioVenta;
            PrecioCosto = precioCosto;
        }

        public override string ToString()
        {
            return this.Nombre +" $"+  this.PrecioVenta; 
        }

        public double CalcularGanancia() {
            return this.PrecioVenta - this.PrecioCosto;
        }

        public CProducto GenerarVenta(double cant) {
            return new CProducto(cant,this.Nombre,this.PrecioVenta*cant,this.PrecioCosto,this.Descripcion);
        }
    }
}
