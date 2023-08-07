namespace AppRoti.Vistas {
    partial class CierreTurno {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ProductosChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VentasGridView = new System.Windows.Forms.DataGridView();
            this.NomClientePedidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPedidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ProductosChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ProductosChart.Legends.Add(legend2);
            this.ProductosChart.Location = new System.Drawing.Point(394, 12);
            this.ProductosChart.Name = "ProductosChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ProductosChart.Series.Add(series2);
            this.ProductosChart.Size = new System.Drawing.Size(366, 300);
            this.ProductosChart.TabIndex = 0;
            this.ProductosChart.Text = "chart1";
            // 
            // VentasGridView
            // 
            this.VentasGridView.AllowUserToAddRows = false;
            this.VentasGridView.AllowUserToDeleteRows = false;
            this.VentasGridView.AllowUserToResizeColumns = false;
            this.VentasGridView.AllowUserToResizeRows = false;
            this.VentasGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VentasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomClientePedidoCol,
            this.TotalPedidoCol});
            this.VentasGridView.Location = new System.Drawing.Point(99, 23);
            this.VentasGridView.Name = "VentasGridView";
            this.VentasGridView.ReadOnly = true;
            this.VentasGridView.RowHeadersVisible = false;
            this.VentasGridView.Size = new System.Drawing.Size(260, 289);
            this.VentasGridView.TabIndex = 2;
            // 
            // NomClientePedidoCol
            // 
            this.NomClientePedidoCol.DataPropertyName = "Cliente";
            this.NomClientePedidoCol.HeaderText = "Cliente";
            this.NomClientePedidoCol.Name = "NomClientePedidoCol";
            this.NomClientePedidoCol.ReadOnly = true;
            // 
            // TotalPedidoCol
            // 
            this.TotalPedidoCol.DataPropertyName = "CalcularTotal";
            this.TotalPedidoCol.HeaderText = "Total Pedido";
            this.TotalPedidoCol.Name = "TotalPedidoCol";
            this.TotalPedidoCol.ReadOnly = true;
            // 
            // CierreTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VentasGridView);
            this.Controls.Add(this.ProductosChart);
            this.Name = "CierreTurno";
            this.Text = "CierreTurno";
            this.Load += new System.EventHandler(this.CierreTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ProductosChart;
        private System.Windows.Forms.DataGridView VentasGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomClientePedidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPedidoCol;
    }
}