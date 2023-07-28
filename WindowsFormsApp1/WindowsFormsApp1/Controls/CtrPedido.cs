using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controls
{
    [Serializable]
    public partial class CtrPedido : UserControl
    {
        public CtrPedido()
        {
            InitializeComponent();
        }

        private void CtrPedido_Load(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CompletadoBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
       
    }
}
