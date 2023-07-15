using AppRoti.Clases.Orm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRoti.Vistas {

    public enum FrmOperacion {
        frmAlta = 1,
        frmMod = 2,
        frmCon = 3
    }

    public enum CompleteStatus {
        completed =1,
        error =2
    }

    public class EventArgDom : EventArgs {
        public CompleteStatus Status { get; set; }
        public string Msj { get; set; }
        public Object ObjProcess { get; set; }
    }

    public delegate void FormEvent(object sender, EventArgDom ev);


    public partial class BaseForm : Form {
        public BaseForm() {
            InitializeComponent();
        }
        public virtual event FormEvent FormComplete = delegate { };
        public virtual FrmOperacion OperacionForm { get; set; }
        //TO DO permisos de usuario

        public BaseForm InvokerForm;
        public static void CompletarFormEditar(BaseForm frm, BaseClass obj) { 
            //Todo autocompletar los campos al editar un objeto
        }
    }
}
