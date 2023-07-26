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
            this.AgregarPedidoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarPedidoBtn.Location = new System.Drawing.Point(658, 392);
            this.AgregarPedidoBtn.Name = "AgregarPedidoBtn";
            this.AgregarPedidoBtn.Size = new System.Drawing.Size(130, 46);
            this.AgregarPedidoBtn.TabIndex = 0;
            this.AgregarPedidoBtn.Text = "Agregar Pedido";
            this.AgregarPedidoBtn.UseVisualStyleBackColor = true;
            this.AgregarPedidoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PedidosPanel
            // 
            this.PedidosPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PedidosPanel.AutoScroll = true;
            this.PedidosPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PedidosPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PedidosPanel.Location = new System.Drawing.Point(11, 12);
            this.PedidosPanel.Margin = new System.Windows.Forms.Padding(20);
            this.PedidosPanel.Name = "PedidosPanel";
            this.PedidosPanel.Size = new System.Drawing.Size(641, 428);
            this.PedidosPanel.TabIndex = 1;
            this.PedidosPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PedidosPanel_Paint);
            // 
            // FrmMuroPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
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