using AppRoti.Clases.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRoti.Clases {
    enum UserRank{
        Admin =0, Cajero = 1, Visit=2, Me =20
    }
    [Serializable]
    internal class CUsers : BaseClass {

        private int _id;
        private string _nombre;
        private string _clave;
        private DateTime _fechaLog;
        private UserRank _userRank;

        public int Id {
            get { return _id; }   
        }

        public string Nombre {
            get { return _nombre; }
        }

        public string Clave { 
            get { return _clave; }
        }
        public DateTime FechaLog {
            get { return _fechaLog; }
            set { _fechaLog = value; }
        }

        public CUsers(int id,string nombre,string clave,UserRank rank)
        {
            _id = id;
            _nombre = nombre;
            _clave = clave;
            _userRank = rank;
        }
    }
}
