using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRoti.Clases.Orm;

namespace AppRoti.Clases{
    [Serializable]
    [Table("Cliente")]
    public class CCliente : BaseClass {
        
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public int CantPedidos { get; set; }
        public string Telefono {get;set;}

        public CCliente()
        {
            
        }

        public CCliente(string nombre,string direccion,string telefono)
        {
            this.Direccion = direccion;
            this.Nombres = nombre;
            this.Telefono = telefono;
        }

        public override string ToString() {
            return this.Nombres;
        }
    }
}
