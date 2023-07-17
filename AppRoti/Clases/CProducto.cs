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

        private bool _isDivisible;

        public bool IsDivisible {
            get { return _isDivisible; }
            set { _isDivisible = value; }
        }


        private string _nombre;

        public string Nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private double _precioVenta;

        public double PrecioVenta {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }

        private double _precioCosto;

        public double PrecioCosto {
            get { return _precioCosto; }
            set { _precioCosto = value; }
        }

        private string _descripcion;

        public string Descripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }



        public CProducto(string nombre, double precioVenta) {
            Nombre = nombre;
            PrecioVenta = precioVenta;
        }

        public CProducto(double stock, string nombre, double precioVenta, double precioCosto, string descripcion, bool isDivisible) {
            Stock = stock;
            _nombre = nombre;
            _precioVenta = precioVenta;
            _precioCosto = precioCosto;
            _descripcion = descripcion;
            _isDivisible = isDivisible;
        }

        public override string ToString()
        {
            return this.Nombre +" $"+  this.PrecioVenta; 
        }

        public double CalcularGanancia() {
            return this.PrecioVenta - this.PrecioCosto;
        }

        public CProducto GenerarVenta(double cant) {
            this.Stock -= cant;
            return new CProducto(cant,this._nombre,this._precioVenta*cant,this._precioCosto,this._descripcion,this._isDivisible);
        }
    }
}
