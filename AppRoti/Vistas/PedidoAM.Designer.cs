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
            this.components = new System.ComponentModel.Container();
            this.ProductosListWv = new System.Windows.Forms.ListView();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.ProdAgregadosLbl = new System.Windows.Forms.Label();
            this.CartaLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrecioEnvioNUP = new System.Windows.Forms.NumericUpDown();
            this.ConEnvioChk = new System.Windows.Forms.CheckBox();
            this.DireccionCbo = new System.Windows.Forms.ComboBox();
            this.ClienteCbo = new System.Windows.Forms.ComboBox();
            this.DireccionLbl = new System.Windows.Forms.Label();
            this.ClienteLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransferRadioButton = new System.Windows.Forms.RadioButton();
            this.EfectivoRadioBtn = new System.Windows.Forms.RadioButton();
            this.RecargoChk = new System.Windows.Forms.CheckBox();
            this.RecargoTxt = new System.Windows.Forms.TextBox();
            this.DescChk = new System.Windows.Forms.CheckBox();
            this.DescTxt = new System.Windows.Forms.TextBox();
            this.ProductoContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MediaPizzaCM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenesListView = new System.Windows.Forms.DataGridView();
            this.CantidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioEnvioNUP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.ProductoContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenesListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosListWv
            // 
            this.ProductosListWv.HideSelection = false;
            this.ProductosListWv.Location = new System.Drawing.Point(203, 43);
            this.ProductosListWv.Name = "ProductosListWv";
            this.ProductosListWv.ShowGroups = false;
            this.ProductosListWv.Size = new System.Drawing.Size(358, 199);
            this.ProductosListWv.TabIndex = 0;
            this.ProductosListWv.UseCompatibleStateImageBehavior = false;
            this.ProductosListWv.ItemActivate += new System.EventHandler(this.ProductosListWv_ItemActivate);
            this.ProductosListWv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductosListWv_MouseClick);
            this.ProductosListWv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProductosListWv_MouseDoubleClick);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(112, 219);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 9;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // ProdAgregadosLbl
            // 
            this.ProdAgregadosLbl.AutoSize = true;
            this.ProdAgregadosLbl.Location = new System.Drawing.Point(566, 27);
            this.ProdAgregadosLbl.Name = "ProdAgregadosLbl";
            this.ProdAgregadosLbl.Size = new System.Drawing.Size(109, 13);
            this.ProdAgregadosLbl.TabIndex = 11;
            this.ProdAgregadosLbl.Text = "Productos Agregados";
            // 
            // CartaLbl
            // 
            this.CartaLbl.AutoSize = true;
            this.CartaLbl.Location = new System.Drawing.Point(200, 27);
            this.CartaLbl.Name = "CartaLbl";
            this.CartaLbl.Size = new System.Drawing.Size(98, 13);
            this.CartaLbl.TabIndex = 16;
            this.CartaLbl.Text = "Carta de Productos";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(16, 219);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 17;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrecioEnvioNUP);
            this.groupBox1.Controls.Add(this.ConEnvioChk);
            this.groupBox1.Controls.Add(this.DireccionCbo);
            this.groupBox1.Controls.Add(this.ClienteCbo);
            this.groupBox1.Controls.Add(this.DireccionLbl);
            this.groupBox1.Controls.Add(this.ClienteLbl);
            this.groupBox1.Location = new System.Drawing.Point(8, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 108);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Cliente";
            // 
            // PrecioEnvioNUP
            // 
            this.PrecioEnvioNUP.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PrecioEnvioNUP.Location = new System.Drawing.Point(88, 54);
            this.PrecioEnvioNUP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PrecioEnvioNUP.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PrecioEnvioNUP.Name = "PrecioEnvioNUP";
            this.PrecioEnvioNUP.Size = new System.Drawing.Size(91, 20);
            this.PrecioEnvioNUP.TabIndex = 21;
            this.PrecioEnvioNUP.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // ConEnvioChk
            // 
            this.ConEnvioChk.AutoSize = true;
            this.ConEnvioChk.Checked = true;
            this.ConEnvioChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConEnvioChk.Location = new System.Drawing.Point(8, 55);
            this.ConEnvioChk.Name = "ConEnvioChk";
            this.ConEnvioChk.Size = new System.Drawing.Size(74, 17);
            this.ConEnvioChk.TabIndex = 20;
            this.ConEnvioChk.Text = "Con envio";
            this.ConEnvioChk.UseVisualStyleBackColor = true;
            this.ConEnvioChk.CheckedChanged += new System.EventHandler(this.ConEnvioChk_CheckedChanged);
            // 
            // DireccionCbo
            // 
            this.DireccionCbo.FormattingEnabled = true;
            this.DireccionCbo.Location = new System.Drawing.Point(58, 81);
            this.DireccionCbo.Name = "DireccionCbo";
            this.DireccionCbo.Size = new System.Drawing.Size(121, 21);
            this.DireccionCbo.TabIndex = 19;
            // 
            // ClienteCbo
            // 
            this.ClienteCbo.FormattingEnabled = true;
            this.ClienteCbo.Location = new System.Drawing.Point(58, 22);
            this.ClienteCbo.Name = "ClienteCbo";
            this.ClienteCbo.Size = new System.Drawing.Size(121, 21);
            this.ClienteCbo.TabIndex = 18;
            // 
            // DireccionLbl
            // 
            this.DireccionLbl.AutoSize = true;
            this.DireccionLbl.Location = new System.Drawing.Point(5, 84);
            this.DireccionLbl.Name = "DireccionLbl";
            this.DireccionLbl.Size = new System.Drawing.Size(52, 13);
            this.DireccionLbl.TabIndex = 17;
            this.DireccionLbl.Text = "Direccion";
            // 
            // ClienteLbl
            // 
            this.ClienteLbl.AutoSize = true;
            this.ClienteLbl.Location = new System.Drawing.Point(5, 25);
            this.ClienteLbl.Name = "ClienteLbl";
            this.ClienteLbl.Size = new System.Drawing.Size(44, 13);
            this.ClienteLbl.TabIndex = 16;
            this.ClienteLbl.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TransferRadioButton);
            this.groupBox2.Controls.Add(this.EfectivoRadioBtn);
            this.groupBox2.Controls.Add(this.RecargoChk);
            this.groupBox2.Controls.Add(this.RecargoTxt);
            this.groupBox2.Controls.Add(this.DescChk);
            this.groupBox2.Controls.Add(this.DescTxt);
            this.groupBox2.Location = new System.Drawing.Point(8, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 78);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // TransferRadioButton
            // 
            this.TransferRadioButton.AutoSize = true;
            this.TransferRadioButton.Location = new System.Drawing.Point(88, 55);
            this.TransferRadioButton.Name = "TransferRadioButton";
            this.TransferRadioButton.Size = new System.Drawing.Size(90, 17);
            this.TransferRadioButton.TabIndex = 5;
            this.TransferRadioButton.Text = "Transferencia";
            this.TransferRadioButton.UseVisualStyleBackColor = true;
            // 
            // EfectivoRadioBtn
            // 
            this.EfectivoRadioBtn.AutoSize = true;
            this.EfectivoRadioBtn.Checked = true;
            this.EfectivoRadioBtn.Location = new System.Drawing.Point(8, 55);
            this.EfectivoRadioBtn.Name = "EfectivoRadioBtn";
            this.EfectivoRadioBtn.Size = new System.Drawing.Size(64, 17);
            this.EfectivoRadioBtn.TabIndex = 4;
            this.EfectivoRadioBtn.TabStop = true;
            this.EfectivoRadioBtn.Text = "Efectivo";
            this.EfectivoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RecargoChk
            // 
            this.RecargoChk.AutoSize = true;
            this.RecargoChk.Location = new System.Drawing.Point(8, 34);
            this.RecargoChk.Name = "RecargoChk";
            this.RecargoChk.Size = new System.Drawing.Size(67, 17);
            this.RecargoChk.TabIndex = 3;
            this.RecargoChk.Text = "Recargo";
            this.RecargoChk.UseVisualStyleBackColor = true;
            this.RecargoChk.CheckedChanged += new System.EventHandler(this.RecargoChk_CheckedChanged);
            // 
            // RecargoTxt
            // 
            this.RecargoTxt.Enabled = false;
            this.RecargoTxt.Location = new System.Drawing.Point(88, 32);
            this.RecargoTxt.Name = "RecargoTxt";
            this.RecargoTxt.Size = new System.Drawing.Size(90, 20);
            this.RecargoTxt.TabIndex = 2;
            this.RecargoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RecargoTxt_KeyPress);
            // 
            // DescChk
            // 
            this.DescChk.AutoSize = true;
            this.DescChk.Location = new System.Drawing.Point(8, 10);
            this.DescChk.Name = "DescChk";
            this.DescChk.Size = new System.Drawing.Size(78, 17);
            this.DescChk.TabIndex = 1;
            this.DescChk.Text = "Descuento";
            this.DescChk.UseVisualStyleBackColor = true;
            this.DescChk.CheckedChanged += new System.EventHandler(this.DescChk_CheckedChanged);
            // 
            // DescTxt
            // 
            this.DescTxt.Enabled = false;
            this.DescTxt.Location = new System.Drawing.Point(88, 8);
            this.DescTxt.Name = "DescTxt";
            this.DescTxt.Size = new System.Drawing.Size(91, 20);
            this.DescTxt.TabIndex = 0;
            this.DescTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescTxt_KeyPress);
            // 
            // ProductoContextMenu
            // 
            this.ProductoContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MediaPizzaCM,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4});
            this.ProductoContextMenu.Name = "ProductoContextMenu";
            this.ProductoContextMenu.Size = new System.Drawing.Size(92, 70);
            this.ProductoContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ProductoContextMenu_Opening);
            // 
            // MediaPizzaCM
            // 
            this.MediaPizzaCM.Name = "MediaPizzaCM";
            this.MediaPizzaCM.Size = new System.Drawing.Size(91, 22);
            this.MediaPizzaCM.Text = "1/2";
            this.MediaPizzaCM.Click += new System.EventHandler(this.mediaPizza_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem2.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // OrdenesListView
            // 
            this.OrdenesListView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrdenesListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.OrdenesListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdenesListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CantidadCol,
            this.Nombre,
            this.Precio});
            this.OrdenesListView.Location = new System.Drawing.Point(567, 43);
            this.OrdenesListView.Name = "OrdenesListView";
            this.OrdenesListView.RowHeadersVisible = false;
            this.OrdenesListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdenesListView.Size = new System.Drawing.Size(168, 199);
            this.OrdenesListView.TabIndex = 20;
            // 
            // CantidadCol
            // 
            this.CantidadCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CantidadCol.DataPropertyName = "Stock";
            this.CantidadCol.Frozen = true;
            this.CantidadCol.HeaderText = "Cant";
            this.CantidadCol.Name = "CantidadCol";
            this.CantidadCol.ReadOnly = true;
            this.CantidadCol.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 80;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Precio.DataPropertyName = "PrecioVenta";
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Precio.Width = 62;
            // 
            // PedidoAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 262);
            this.Controls.Add(this.OrdenesListView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.CartaLbl);
            this.Controls.Add(this.ProdAgregadosLbl);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.ProductosListWv);
            this.Name = "PedidoAM";
            this.Text = "PedidoAM";
            this.Load += new System.EventHandler(this.PedidoAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioEnvioNUP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ProductoContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenesListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProductosListWv;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Label ProdAgregadosLbl;
        private System.Windows.Forms.Label CartaLbl;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown PrecioEnvioNUP;
        private System.Windows.Forms.CheckBox ConEnvioChk;
        private System.Windows.Forms.ComboBox DireccionCbo;
        private System.Windows.Forms.ComboBox ClienteCbo;
        private System.Windows.Forms.Label DireccionLbl;
        private System.Windows.Forms.Label ClienteLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox RecargoChk;
        private System.Windows.Forms.TextBox RecargoTxt;
        private System.Windows.Forms.CheckBox DescChk;
        private System.Windows.Forms.TextBox DescTxt;
        private System.Windows.Forms.ContextMenuStrip ProductoContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MediaPizzaCM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.DataGridView OrdenesListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCol;
        private System.Windows.Forms.RadioButton TransferRadioButton;
        private System.Windows.Forms.RadioButton EfectivoRadioBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}