using AppRoti.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppRoti.Vistas {
    public partial class EndShift : BaseForm {
        public EndShift() {
            InitializeComponent();
        }

        private void EndShift_Load(object sender, EventArgs e) {
            Series VentasSeries = new Series("Ventas");
            VentasSeries.ChartType = SeriesChartType.Bar;
            foreach (CPedido item in Program.ListadoPedidosFinal) {
                VentasSeries.Points.Add(item.CalcularTotal);
            }
            Grafico.Series.Add(VentasSeries);
        }
    }
}
