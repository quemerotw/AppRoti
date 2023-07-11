﻿using AppRoti.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AppRoti {
    internal static class Program {
        static private List<CCliente> _listadoClientes = new List<CCliente>();


        static internal List<CCliente> ListadoClientes {
            get { return _listadoClientes; }
            set { _listadoClientes = value; }
        }

        static internal List<CProducto> _listadoProductos;

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
