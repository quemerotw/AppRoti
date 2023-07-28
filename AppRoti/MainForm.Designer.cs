namespace AppRoti
{
    partial class MainForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.StartShiftBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ListadosBtn = new System.Windows.Forms.Button();
            this.CrearProductosBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuariosToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(711, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // StartShiftBtn
            // 
            this.StartShiftBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartShiftBtn.Location = new System.Drawing.Point(83, 40);
            this.StartShiftBtn.Name = "StartShiftBtn";
            this.StartShiftBtn.Size = new System.Drawing.Size(136, 129);
            this.StartShiftBtn.TabIndex = 1;
            this.StartShiftBtn.Text = "Comenzar Turno";
            this.StartShiftBtn.UseVisualStyleBackColor = true;
            this.StartShiftBtn.Click += new System.EventHandler(this.StartShiftBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(231, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // ListadosBtn
            // 
            this.ListadosBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ListadosBtn.Location = new System.Drawing.Point(491, 40);
            this.ListadosBtn.Name = "ListadosBtn";
            this.ListadosBtn.Size = new System.Drawing.Size(136, 129);
            this.ListadosBtn.TabIndex = 3;
            this.ListadosBtn.Text = "Listados";
            this.ListadosBtn.UseVisualStyleBackColor = true;
            this.ListadosBtn.Click += new System.EventHandler(this.ListadosBtn_Click);
            // 
            // CrearProductosBtn
            // 
            this.CrearProductosBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CrearProductosBtn.Location = new System.Drawing.Point(285, 204);
            this.CrearProductosBtn.Name = "CrearProductosBtn";
            this.CrearProductosBtn.Size = new System.Drawing.Size(136, 129);
            this.CrearProductosBtn.TabIndex = 4;
            this.CrearProductosBtn.Text = "Crear Productos";
            this.CrearProductosBtn.UseVisualStyleBackColor = true;
            this.CrearProductosBtn.Click += new System.EventHandler(this.CrearProductosBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartShiftBtn);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.ListadosBtn);
            this.groupBox1.Controls.Add(this.CrearProductosBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 349);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // crearUsuariosToolStripMenuItem
            // 
            this.crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            this.crearUsuariosToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.crearUsuariosToolStripMenuItem.Text = "Crear usuarios";
            this.crearUsuariosToolStripMenuItem.Visible = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Roti";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.Button StartShiftBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button ListadosBtn;
        private System.Windows.Forms.Button CrearProductosBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem;
    }
}

