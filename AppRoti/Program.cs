﻿using AppRoti.Clases;
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

namespace AppRoti {
    internal static class Program {


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

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadArch();
            Application.Run(new MainForm());
            SaveArch();
        }

        static private void LoadArch() {
            CProducto p = new CProducto(2,"Muzza",1000, 500, "",true);
            CProducto p2 = new CProducto(2,"Fuga",1200,500,"",true);
            CProducto p3 = new CProducto(3, "Empanada", 300, 100, "", false);
            Program.ListadoProductos.Add(p);
            Program.ListadoProductos.Add(p2);
            Program.ListadoProductos.Add(p3);

            Program.ImageList = new ImageList();
            Program.ImageList.ImageSize = new Size(32, 32);
            Program.ImageList.Images.Add(AppRoti.Properties.Resources.pizza_3_32);
            Program.ImageList.Images.Add(AppRoti.Properties.Resources.taco_32);
            BinaryFormatter f = new BinaryFormatter();
            try {
                FileStream file = new FileStream("arch.bin", FileMode.Open);
                ListadoClientes = (List<CCliente>)f.Deserialize(file);
            }
            catch (Exception) {
                MessageBox.Show("Listados Vacios");
            }
            finally {

            }
        }

        static private void SaveArch() {
            BinaryFormatter f = new BinaryFormatter();
            FileStream file = new FileStream("arch.bin", FileMode.OpenOrCreate);
            f.Serialize(file, ListadoClientes);
        }
    }
}
