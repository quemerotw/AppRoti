namespace WindowsFormsApp1.Controls
{
    partial class CtrPedido
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.CompletadoBtn = new System.Windows.Forms.Button();
            this.NroPedidoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.DarkRed;
            this.CancelarBtn.Location = new System.Drawing.Point(21, 103);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(33, 32);
            this.CancelarBtn.TabIndex = 0;
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // CompletadoBtn
            // 
            this.CompletadoBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.CompletadoBtn.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CompletadoBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CompletadoBtn.Location = new System.Drawing.Point(85, 103);
            this.CompletadoBtn.Name = "CompletadoBtn";
            this.CompletadoBtn.Size = new System.Drawing.Size(36, 32);
            this.CompletadoBtn.TabIndex = 1;
            this.CompletadoBtn.UseVisualStyleBackColor = false;
            this.CompletadoBtn.Click += new System.EventHandler(this.CompletadoBtn_Click);
            // 
            // NroPedidoLbl
            // 
            this.NroPedidoLbl.AutoSize = true;
            this.NroPedidoLbl.Location = new System.Drawing.Point(21, 21);
            this.NroPedidoLbl.Name = "NroPedidoLbl";
            this.NroPedidoLbl.Size = new System.Drawing.Size(62, 13);
            this.NroPedidoLbl.TabIndex = 2;
            this.NroPedidoLbl.Text = "Pedido nro°";
            // 
            // CtrPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.NroPedidoLbl);
            this.Controls.Add(this.CompletadoBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Name = "CtrPedido";
            this.Size = new System.Drawing.Size(140, 162);
            this.Load += new System.EventHandler(this.CtrPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button CompletadoBtn;
        private System.Windows.Forms.Label NroPedidoLbl;
    }
}
