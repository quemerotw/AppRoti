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
    public partial class CierreTurno : BaseForm {
        BindingList<CPedido> bindingListPedido;
        BindingSource bindingSourcePedido;
        readonly RotiDbContext rotiDb = Program.RotiDbInstance;
        public CierreTurno() {
            InitializeComponent();
        }

        private void CierreTurno_Load(object sender, EventArgs e) {
            VentasGridView.AutoGenerateColumns = false;
            bindingListPedido = new BindingList<CPedido>(rotiDb.PedidosTable.ToList().Where(p => p.Fecha.Day >= DateTime.Now.Date.Day).ToList());
            bindingSourcePedido = new BindingSource(bindingListPedido, null);
            this.VentasGridView.DataSource = bindingSourcePedido;
            List<CDetallePedido> prodVendidos = new List<CDetallePedido>();
            this.ProductosChart.Series.Clear();
            var list = rotiDb.PedidosTable.ToList().Where(p => p.Fecha.Day >= DateTime.Now.Date.Day);
            Series series = ProductosChart.Series.Add("Productos Vendidos");
            series.ChartType = SeriesChartType.Pie;
            foreach (CPedido item in list) {
                if (item != null) {
                    item.DetallePedido = rotiDb.DetallesTable.ToList().Where(d => d.Pedido.Equals(item)).ToList();
                    foreach (CDetallePedido det in item.DetallePedido) {
                        if (prodVendidos.FirstOrDefault(p => p.Producto == det.Producto) != null) {
                            prodVendidos.FirstOrDefault(p => p.Producto == det.Producto).Cantidad++;
                        }
                        else {
                            prodVendidos.Add(new CDetallePedido(det.Cantidad, det.Producto));
                        }
                    }
                }
            }
            foreach (CDetallePedido item in prodVendidos) {
                series.Points.AddXY(item.Producto.Nombre, item.Cantidad);
            }
            series.IsValueShownAsLabel = true;
            series["PieLabelStyle"] = "Outside";
            series.Label = "#PERCENT{P0}";

            // Ajusta la leyenda
            ProductosChart.Legends.Clear();
            Legend legend = new Legend("Legend1");
            ProductosChart.Legends.Add(legend);

            // Ajusta el aspecto visual del gráfico de torta
            ProductosChart.Palette = ChartColorPalette.Pastel;

            // Ajusta el área de dibujo del gráfico de torta
            ProductosChart.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
    }
}
