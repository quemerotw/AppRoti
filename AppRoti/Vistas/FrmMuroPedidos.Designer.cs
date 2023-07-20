namespace AppRoti.Vistas
{
    partial class FrmMuroPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgregarPedidoBtn = new System.Windows.Forms.Button();
            this.PedidosPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AgregarPedidoBtn
            // 
            this.AgregarPedidoBtn.Location = new System.Drawing.Point(647, 12);
            this.AgregarPedidoBtn.Name = "AgregarPedidoBtn";
            this.AgregarPedidoBtn.Size = new System.Drawing.Size(130, 46);
            this.AgregarPedidoBtn.TabIndex = 0;
            this.AgregarPedidoBtn.Text = "Agregar Pedido";
            this.AgregarPedidoBtn.UseVisualStyleBackColor = true;
            this.AgregarPedidoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PedidosPanel
            // 
            this.PedidosPanel.AutoScroll = true;
            this.PedidosPanel.BackColor = System.Drawing.SystemColors.Window;
            this.PedidosPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PedidosPanel.Location = new System.Drawing.Point(13, 13);
            this.PedidosPanel.Name = "PedidosPanel";
            this.PedidosPanel.Size = new System.Drawing.Size(611, 368);
            this.PedidosPanel.TabIndex = 1;
            // 
            // FrmMuroPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PedidosPanel);
            this.Controls.Add(this.AgregarPedidoBtn);
            this.Name = "FrmMuroPedidos";
            this.Text = "Muro de pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMuroPedidos_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgregarPedidoBtn;
        private System.Windows.Forms.Panel PedidosPanel;
    }
}