using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRoti.Clases {
    [Serializable]
    internal class CCliente {
        private static int numConst = 0;
        private int id { get; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public int CantPedidos { get; set; }

        public CCliente() { id = numConst++;}
        public CCliente(string nombre)
        {
            this.Nombres = nombre;
        }
    }
}
