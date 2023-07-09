namespace AppRoti.Vistas
{
    partial class PedidoAM
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
            this.ProductosListWv = new System.Windows.Forms.ListView();
            this.ClienteLbl = new System.Windows.Forms.Label();
            this.DireccionLbl = new System.Windows.Forms.Label();
            this.ClienteCbo = new System.Windows.Forms.ComboBox();
            this.DireccionCbo = new System.Windows.Forms.ComboBox();
            this.OrdenesList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ProductosListWv
            // 
            this.ProductosListWv.HideSelection = false;
            this.ProductosListWv.Location = new System.Drawing.Point(215, 8);
            this.ProductosListWv.Name = "ProductosListWv";
            this.ProductosListWv.Size = new System.Drawing.Size(517, 358);
            this.ProductosListWv.TabIndex = 0;
            this.ProductosListWv.UseCompatibleStateImageBehavior = false;
            this.ProductosListWv.ItemActivate += new System.EventHandler(this.ProductosListWv_ItemActivate);
            // 
            // ClienteLbl
            // 
            this.ClienteLbl.AutoSize = true;
            this.ClienteLbl.Location = new System.Drawing.Point(13, 30);
            this.ClienteLbl.Name = "ClienteLbl";
            this.ClienteLbl.Size = new System.Drawing.Size(44, 13);
            this.ClienteLbl.TabIndex = 2;
            this.ClienteLbl.Text = "Nombre";
            // 
            // DireccionLbl
            // 
            this.DireccionLbl.AutoSize = true;
            this.DireccionLbl.Location = new System.Drawing.Point(13, 65);
            this.DireccionLbl.Name = "DireccionLbl";
            this.DireccionLbl.Size = new System.Drawing.Size(52, 13);
            this.DireccionLbl.TabIndex = 4;
            this.DireccionLbl.Text = "Direccion";
            // 
            // ClienteCbo
            // 
            this.ClienteCbo.FormattingEnabled = true;
            this.ClienteCbo.Location = new System.Drawing.Point(66, 27);
            this.ClienteCbo.Name = "ClienteCbo";
            this.ClienteCbo.Size = new System.Drawing.Size(121, 21);
            this.ClienteCbo.TabIndex = 5;
            // 
            // DireccionCbo
            // 
            this.DireccionCbo.FormattingEnabled = true;
            this.DireccionCbo.Location = new System.Drawing.Point(66, 62);
            this.DireccionCbo.Name = "DireccionCbo";
            this.DireccionCbo.Size = new System.Drawing.Size(121, 21);
            this.DireccionCbo.TabIndex = 6;
            // 
            // OrdenesList
            // 
            this.OrdenesList.FormattingEnabled = true;
            this.OrdenesList.Location = new System.Drawing.Point(3, 129);
            this.OrdenesList.Name = "OrdenesList";
            this.OrdenesList.Size = new System.Drawing.Size(121, 199);
            this.OrdenesList.TabIndex = 7;
            // 
            // PedidoAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 373);
            this.Controls.Add(this.OrdenesList);
            this.Controls.Add(this.DireccionCbo);
            this.Controls.Add(this.ClienteCbo);
            this.Controls.Add(this.DireccionLbl);
            this.Controls.Add(this.ClienteLbl);
            this.Controls.Add(this.ProductosListWv);
            this.Name = "PedidoAM";
            this.Text = "PedidoAM";
            this.Load += new System.EventHandler(this.PedidoAM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProductosListWv;
        private System.Windows.Forms.Label ClienteLbl;
        private System.Windows.Forms.Label DireccionLbl;
        private System.Windows.Forms.ComboBox ClienteCbo;
        private System.Windows.Forms.ComboBox DireccionCbo;
        private System.Windows.Forms.CheckedListBox OrdenesList;
    }
}