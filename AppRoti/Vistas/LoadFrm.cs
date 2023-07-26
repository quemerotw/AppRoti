using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRoti.Vistas {
    public partial class LoadFrm : BaseForm {
        public static int counter = 0;
        Timer f = new Timer();
        public LoadFrm() {
            InitializeComponent();
            Espera();
        }

        private void Espera() {
            f.Interval = 1000;
            f.Tick += F_Tick;
            f.Start();
            LoadprogressBar.Step = 30;
        }

        private void F_Tick(object sender, EventArgs e) {
            counter += 1;
            LoadprogressBar.PerformStep();
            if (counter > 4) {
                f.Stop();
                this.Close();
            }
        }
        }
    }

