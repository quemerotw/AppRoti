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
            this.ctrPedido1 = new WindowsFormsApp1.Controls.CtrPedido();
            this.SuspendLayout();
            // 
            // ctrPedido1
            // 
            this.ctrPedido1.BackColor = System.Drawing.Color.LawnGreen;
            this.ctrPedido1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrPedido1.Location = new System.Drawing.Point(46, 121);
            this.ctrPedido1.Name = "ctrPedido1";
            this.ctrPedido1.Size = new System.Drawing.Size(134, 159);
            this.ctrPedido1.TabIndex = 0;
            this.ctrPedido1.Load += new System.EventHandler(this.ctrPedido1_Load);
            this.ctrPedido1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrPedido1_MouseDown);
            this.ctrPedido1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ctrPedido1_MouseMove);
            this.ctrPedido1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ctrPedido1_MouseUp);
            // 
            // FrmMuroPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrPedido1);
            this.Name = "FrmMuroPedidos";
            this.Text = "Muro de pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsApp1.Controls.CtrPedido ctrPedido1;
    }
}