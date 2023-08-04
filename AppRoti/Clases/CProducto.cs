﻿using AppRoti.Clases.Orm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRoti.Clases
{
    [Table("Producto")]
    [Serializable]
    public class CProducto : BaseClass {
        public int Id {get; set;}

        private int _icoProducto;

        public int IndexIconoProducto {
            get { return _icoProducto; }
            set { _icoProducto = value; }
        }


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

        private double _cantidadVentas;

        public double CantidadVentas {
            get { return _cantidadVentas; }
            set { _cantidadVentas = value; }
        }

        public double TotalVentas { get { return this.CantidadVentas * this.PrecioVenta; } }

        public CProducto()
        {
                
        }

        public CProducto(double stock, string nombre, double precioVenta, double precioCosto, string descripcion, bool isDivisible,int iconIndex) {
            Stock = stock;
            _nombre = nombre;
            _precioVenta = precioVenta;
            _precioCosto = precioCosto;
            _descripcion = descripcion;
            _isDivisible = isDivisible;
            _icoProducto = iconIndex;
        }

        public override string ToString()
        {
            return this.Nombre +" $"+  this.PrecioVenta; 
        }

        public double CalcularGanancia() {
            return this.PrecioVenta - this.PrecioCosto;
        }
    }
}
