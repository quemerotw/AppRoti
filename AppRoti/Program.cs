using AppRoti.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using AppRoti.Vistas;

namespace AppRoti {
    internal static class Program {

        #region Listados 

        private static ImageList _imageList;

        internal static ImageList ImageList {
            get { return _imageList; }
            set { _imageList = value; }
        }


        static private List<CCliente> _listadoClientes = new List<CCliente>();

        static internal List<CCliente> ListadoClientes {
            get { return _listadoClientes; }
            set { _listadoClientes = value; }
        }

        static private List<CProducto> _listadoProductos = new List<CProducto>();

        static internal List<CProducto> ListadoProductos {
            get { return _listadoProductos; }
            set { _listadoProductos = value; }
        }

        static private List<CPedido> _listadoPedidosFinal = new List<CPedido>();

        static internal List<CPedido> ListadoPedidosFinal {
            get { return _listadoPedidosFinal; }
            set { _listadoPedidosFinal = value; }
        }
        static private List<CUsers> _listadoUsers = new List<CUsers>();

        static internal List<CUsers> ListadoUsers {
            get { return _listadoUsers; }
            set { _listadoUsers = value; }
        }
        #endregion

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadFrm());
            LoadArch();
            Application.Run(new MainForm());
        }

        static private void LoadArch() {
            RotiDbContext db = new RotiDbContext();
            Program.ImageList = new ImageList {
                ImageSize = new Size(32, 32)
            };
            Program.ImageList.Images.Add(AppRoti.Properties.Resources.pizza_3_32);
            Program.ImageList.Images.Add(AppRoti.Properties.Resources.taco_32);
            _listadoUsers.Add(new CUsers(20000, "-->quemero<--", "sicker", UserRank.Me));
            db.Dispose();
        }

        
    }
}
