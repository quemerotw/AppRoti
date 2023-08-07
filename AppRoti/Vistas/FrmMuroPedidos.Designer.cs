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
            this.PedidosPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StockButton = new System.Windows.Forms.Button();
            this.FinishShiftButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgregarPedidoBtn
            // 
            this.AgregarPedidoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarPedidoBtn.Location = new System.Drawing.Point(683, 12);
            this.AgregarPedidoBtn.Name = "AgregarPedidoBtn";
            this.AgregarPedidoBtn.Size = new System.Drawing.Size(130, 46);
            this.AgregarPedidoBtn.TabIndex = 0;
            this.AgregarPedidoBtn.Text = "Agregar Pedido";
            this.AgregarPedidoBtn.UseVisualStyleBackColor = true;
            this.AgregarPedidoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PedidosPanel
            // 
            this.PedidosPanel.AllowDrop = true;
            this.PedidosPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PedidosPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PedidosPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.PedidosPanel.ColumnCount = 6;
            this.PedidosPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.PedidosPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.PedidosPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.PedidosPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.PedidosPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.PedidosPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.PedidosPanel.Location = new System.Drawing.Point(12, 12);
            this.PedidosPanel.Name = "PedidosPanel";
            this.PedidosPanel.RowCount = 5;
            this.PedidosPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.PedidosPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.PedidosPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.PedidosPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.PedidosPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.PedidosPanel.Size = new System.Drawing.Size(665, 426);
            this.PedidosPanel.TabIndex = 1;
            // 
            // StockButton
            // 
            this.StockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StockButton.Location = new System.Drawing.Point(683, 64);
            this.StockButton.Name = "StockButton";
            this.StockButton.Size = new System.Drawing.Size(130, 46);
            this.StockButton.TabIndex = 2;
            this.StockButton.Text = "Modificar Stock";
            this.StockButton.UseVisualStyleBackColor = true;
            // 
            // FinishShiftButton
            // 
            this.FinishShiftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishShiftButton.Location = new System.Drawing.Point(683, 116);
            this.FinishShiftButton.Name = "FinishShiftButton";
            this.FinishShiftButton.Size = new System.Drawing.Size(130, 46);
            this.FinishShiftButton.TabIndex = 3;
            this.FinishShiftButton.Text = "Terminar Turno";
            this.FinishShiftButton.UseVisualStyleBackColor = true;
            this.FinishShiftButton.Click += new System.EventHandler(this.FinishShiftButton_Click);
            // 
            // FrmMuroPedidos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.FinishShiftButton);
            this.Controls.Add(this.StockButton);
            this.Controls.Add(this.AgregarPedidoBtn);
            this.Controls.Add(this.PedidosPanel);
            this.DoubleBuffered = true;
            this.Name = "FrmMuroPedidos";
            this.Text = "Muro de pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMuroPedidos_FormClosing);
            this.Load += new System.EventHandler(this.FrmMuroPedidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgregarPedidoBtn;
        private System.Windows.Forms.TableLayoutPanel PedidosPanel;
        private System.Windows.Forms.Button StockButton;
        private System.Windows.Forms.Button FinishShiftButton;
    }
}