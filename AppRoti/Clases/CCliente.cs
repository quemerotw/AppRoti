using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRoti.Clases.Orm;

namespace AppRoti.Clases{
    [Serializable]
    internal class CCliente : BaseClass {
        private static int numConst = Program.ListadoClientes.Count();
        private int Id { get; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public int CantPedidos { get; set; }

        public CCliente(string nombre,string direccion)
        {
            Id = numConst++;
            this.Direccion = direccion;
            this.Nombres = nombre;
        }

        public override string ToString() {
            return this.Nombres;
        }
    }
}
