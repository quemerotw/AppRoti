namespace AppRoti.Vistas {
    partial class EndShift {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.PedidosGridView = new System.Windows.Forms.DataGridView();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidosGridView
            // 
            this.PedidosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosGridView.Location = new System.Drawing.Point(256, 13);
            this.PedidosGridView.Name = "PedidosGridView";
            this.PedidosGridView.Size = new System.Drawing.Size(225, 345);
            this.PedidosGridView.TabIndex = 0;
            // 
            // Grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.Grafico.ChartAreas.Add(chartArea1);
            this.Grafico.Location = new System.Drawing.Point(488, 13);
            this.Grafico.Name = "Grafico";
            this.Grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.Grafico.Size = new System.Drawing.Size(300, 300);
            this.Grafico.TabIndex = 1;
            this.Grafico.Text = "chart1";
            // 
            // EndShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grafico);
            this.Controls.Add(this.PedidosGridView);
            this.Name = "EndShift";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EndShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PedidosGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
    }
}