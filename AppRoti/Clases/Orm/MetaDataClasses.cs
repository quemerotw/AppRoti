using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace AppRoti.Clases.Orm {



    public class PropiedadAttribute : Attribute {
        private Type _tipo;
        public PropiedadAttribute() {
            this.EsClave = false;
            this.EsNullable = false;
            this.EsAutoGenerado = false;
            this.Longitud = 0;
        }
        public string Name { get; set; }
        public Type Tipo {
            get { return _tipo; }
            set {
                if (value == typeof(DateTime))
                    this.Format = "yyyy-M-d hh:m:ss";
                _tipo = value;
            }
        }
        public bool EsClave { get; set; }
        public bool EsAutoGenerado { get; set; }
        public int Longitud { get; set; }
        public bool EsNullable { get; set; }
        public string Format { get; set; }
        public override string ToString() {
            return this.Name;
        }
    }

    public class TableAttribute : Attribute {
        public string Name { get; set; }
        public Type Tipo { get; set; }
        public override string ToString() {
            return this.Name;
        }
    }

    public class MetaDataClasses {

        public static object GetTable(Type clase) {
            return Attribute.GetCustomAttribute(clase,typeof(TableAttribute));
        }

        public static List<PropertyInfo> GetProps(Type clase, bool? keyColumns = null) {
            if (keyColumns == null) {
                return clase.GetProperties().Where(x => Attribute.IsDefined(x , typeof(PropiedadAttribute))).ToList();
            }
            return clase.GetProperties().Where(x => Attribute.IsDefined(x , typeof(PropiedadAttribute)) && (x.GetCustomAttributes(false).ToList()[0] as PropiedadAttribute).EsClave == keyColumns).ToList();
        }
    }
}
