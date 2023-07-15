namespace AppRoti.Vistas{
    partial class ListSelector {
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
            this.ClientesGrBx = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClientesGridView = new System.Windows.Forms.DataGridView();
            this.ProductosGrBx = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ProdGridView = new System.Windows.Forms.DataGridView();
            this.VentasGrBx = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.VentasGridView = new System.Windows.Forms.DataGridView();
            this.ClientesGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGridView)).BeginInit();
            this.ProductosGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGridView)).BeginInit();
            this.VentasGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesGrBx
            // 
            this.ClientesGrBx.Controls.Add(this.button1);
            this.ClientesGrBx.Controls.Add(this.ClientesGridView);
            this.ClientesGrBx.Location = new System.Drawing.Point(13, 13);
            this.ClientesGrBx.Name = "ClientesGrBx";
            this.ClientesGrBx.Size = new System.Drawing.Size(272, 425);
            this.ClientesGrBx.TabIndex = 0;
            this.ClientesGrBx.TabStop = false;
            this.ClientesGrBx.Text = "Clientes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 103);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClientesGridView
            // 
            this.ClientesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesGridView.Location = new System.Drawing.Point(7, 20);
            this.ClientesGridView.Name = "ClientesGridView";
            this.ClientesGridView.Size = new System.Drawing.Size(259, 289);
            this.ClientesGridView.TabIndex = 0;
            // 
            // ProductosGrBx
            // 
            this.ProductosGrBx.Controls.Add(this.button2);
            this.ProductosGrBx.Controls.Add(this.ProdGridView);
            this.ProductosGrBx.Location = new System.Drawing.Point(291, 13);
            this.ProductosGrBx.Name = "ProductosGrBx";
            this.ProductosGrBx.Size = new System.Drawing.Size(272, 425);
            this.ProductosGrBx.TabIndex = 1;
            this.ProductosGrBx.TabStop = false;
            this.ProductosGrBx.Text = "Productos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 103);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ProdGridView
            // 
            this.ProdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdGridView.Location = new System.Drawing.Point(7, 20);
            this.ProdGridView.Name = "ProdGridView";
            this.ProdGridView.Size = new System.Drawing.Size(259, 289);
            this.ProdGridView.TabIndex = 0;
            // 
            // VentasGrBx
            // 
            this.VentasGrBx.Controls.Add(this.button3);
            this.VentasGrBx.Controls.Add(this.VentasGridView);
            this.VentasGrBx.Location = new System.Drawing.Point(569, 13);
            this.VentasGrBx.Name = "VentasGrBx";
            this.VentasGrBx.Size = new System.Drawing.Size(272, 425);
            this.VentasGrBx.TabIndex = 2;
            this.VentasGrBx.TabStop = false;
            this.VentasGrBx.Text = "Ventas";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 103);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // VentasGridView
            // 
            this.VentasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasGridView.Location = new System.Drawing.Point(6, 20);
            this.VentasGridView.Name = "VentasGridView";
            this.VentasGridView.Size = new System.Drawing.Size(260, 289);
            this.VentasGridView.TabIndex = 1;
            // 
            // ListSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.VentasGrBx);
            this.Controls.Add(this.ProductosGrBx);
            this.Controls.Add(this.ClientesGrBx);
            this.Name = "ListSelector";
            this.Text = "ListSelector";
            this.Load += new System.EventHandler(this.ListSelector_Load);
            this.ClientesGrBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGridView)).EndInit();
            this.ProductosGrBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProdGridView)).EndInit();
            this.VentasGrBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentasGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientesGrBx;
        private System.Windows.Forms.GroupBox ProductosGrBx;
        private System.Windows.Forms.GroupBox VentasGrBx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ClientesGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView ProdGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView VentasGridView;
    }
}