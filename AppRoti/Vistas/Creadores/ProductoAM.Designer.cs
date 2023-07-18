namespace AppRoti.Vistas.Creadores {
    partial class ProductoAM {
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
            this.IconosListVw = new System.Windows.Forms.ListView();
            this.IconosLbl = new System.Windows.Forms.Label();
            this.VistaPreviaListVw = new System.Windows.Forms.ListView();
            this.VistaPreviaLbl = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IsNotDivisibleradioButton = new System.Windows.Forms.RadioButton();
            this.IsDivisibleSiradioButton = new System.Windows.Forms.RadioButton();
            this.PrecioCostotextBox = new System.Windows.Forms.TextBox();
            this.PrecioCostoLbl = new System.Windows.Forms.Label();
            this.PrecioVentatextBox = new System.Windows.Forms.TextBox();
            this.PrecioVentaLbl = new System.Windows.Forms.Label();
            this.DescripcionGr = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.DescripcionGr.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconosListVw
            // 
            this.IconosListVw.HideSelection = false;
            this.IconosListVw.Location = new System.Drawing.Point(323, 48);
            this.IconosListVw.Name = "IconosListVw";
            this.IconosListVw.Size = new System.Drawing.Size(323, 302);
            this.IconosListVw.TabIndex = 0;
            this.IconosListVw.UseCompatibleStateImageBehavior = false;
            this.IconosListVw.SelectedIndexChanged += new System.EventHandler(this.IconosListVw_SelectedIndexChanged);
            // 
            // IconosLbl
            // 
            this.IconosLbl.AutoSize = true;
            this.IconosLbl.Location = new System.Drawing.Point(320, 32);
            this.IconosLbl.Name = "IconosLbl";
            this.IconosLbl.Size = new System.Drawing.Size(39, 13);
            this.IconosLbl.TabIndex = 1;
            this.IconosLbl.Text = "Iconos";
            // 
            // VistaPreviaListVw
            // 
            this.VistaPreviaListVw.HideSelection = false;
            this.VistaPreviaListVw.Location = new System.Drawing.Point(201, 48);
            this.VistaPreviaListVw.Name = "VistaPreviaListVw";
            this.VistaPreviaListVw.Size = new System.Drawing.Size(105, 98);
            this.VistaPreviaListVw.TabIndex = 2;
            this.VistaPreviaListVw.UseCompatibleStateImageBehavior = false;
            // 
            // VistaPreviaLbl
            // 
            this.VistaPreviaLbl.AutoSize = true;
            this.VistaPreviaLbl.Location = new System.Drawing.Point(198, 32);
            this.VistaPreviaLbl.Name = "VistaPreviaLbl";
            this.VistaPreviaLbl.Size = new System.Drawing.Size(63, 13);
            this.VistaPreviaLbl.TabIndex = 3;
            this.VistaPreviaLbl.Text = "Vista Previa";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(67, 19);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreTextBox.TabIndex = 4;
            this.NombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTextBox_KeyPress);
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(17, 22);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(44, 13);
            this.NombreLbl.TabIndex = 5;
            this.NombreLbl.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IsNotDivisibleradioButton);
            this.groupBox1.Controls.Add(this.IsDivisibleSiradioButton);
            this.groupBox1.Controls.Add(this.PrecioCostotextBox);
            this.groupBox1.Controls.Add(this.PrecioCostoLbl);
            this.groupBox1.Controls.Add(this.PrecioVentatextBox);
            this.groupBox1.Controls.Add(this.PrecioVentaLbl);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.NombreLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 148);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Basica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Las Porciones Se Dividen?";
            // 
            // IsNotDivisibleradioButton
            // 
            this.IsNotDivisibleradioButton.AutoSize = true;
            this.IsNotDivisibleradioButton.Checked = true;
            this.IsNotDivisibleradioButton.Location = new System.Drawing.Point(107, 117);
            this.IsNotDivisibleradioButton.Name = "IsNotDivisibleradioButton";
            this.IsNotDivisibleradioButton.Size = new System.Drawing.Size(39, 17);
            this.IsNotDivisibleradioButton.TabIndex = 11;
            this.IsNotDivisibleradioButton.TabStop = true;
            this.IsNotDivisibleradioButton.Text = "No";
            this.IsNotDivisibleradioButton.UseVisualStyleBackColor = true;
            // 
            // IsDivisibleSiradioButton
            // 
            this.IsDivisibleSiradioButton.AutoSize = true;
            this.IsDivisibleSiradioButton.Location = new System.Drawing.Point(52, 117);
            this.IsDivisibleSiradioButton.Name = "IsDivisibleSiradioButton";
            this.IsDivisibleSiradioButton.Size = new System.Drawing.Size(34, 17);
            this.IsDivisibleSiradioButton.TabIndex = 10;
            this.IsDivisibleSiradioButton.Text = "Si";
            this.IsDivisibleSiradioButton.UseVisualStyleBackColor = true;
            // 
            // PrecioCostotextBox
            // 
            this.PrecioCostotextBox.Location = new System.Drawing.Point(91, 71);
            this.PrecioCostotextBox.Name = "PrecioCostotextBox";
            this.PrecioCostotextBox.Size = new System.Drawing.Size(76, 20);
            this.PrecioCostotextBox.TabIndex = 8;
            this.PrecioCostotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioCostotextBox_KeyPress);
            // 
            // PrecioCostoLbl
            // 
            this.PrecioCostoLbl.AutoSize = true;
            this.PrecioCostoLbl.Location = new System.Drawing.Point(17, 74);
            this.PrecioCostoLbl.Name = "PrecioCostoLbl";
            this.PrecioCostoLbl.Size = new System.Drawing.Size(67, 13);
            this.PrecioCostoLbl.TabIndex = 9;
            this.PrecioCostoLbl.Text = "Precio Costo";
            // 
            // PrecioVentatextBox
            // 
            this.PrecioVentatextBox.Location = new System.Drawing.Point(91, 45);
            this.PrecioVentatextBox.Name = "PrecioVentatextBox";
            this.PrecioVentatextBox.Size = new System.Drawing.Size(76, 20);
            this.PrecioVentatextBox.TabIndex = 6;
            this.PrecioVentatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // PrecioVentaLbl
            // 
            this.PrecioVentaLbl.AutoSize = true;
            this.PrecioVentaLbl.Location = new System.Drawing.Point(17, 48);
            this.PrecioVentaLbl.Name = "PrecioVentaLbl";
            this.PrecioVentaLbl.Size = new System.Drawing.Size(68, 13);
            this.PrecioVentaLbl.TabIndex = 7;
            this.PrecioVentaLbl.Text = "Precio Venta";
            // 
            // DescripcionGr
            // 
            this.DescripcionGr.Controls.Add(this.textBox3);
            this.DescripcionGr.Location = new System.Drawing.Point(15, 186);
            this.DescripcionGr.Name = "DescripcionGr";
            this.DescripcionGr.Size = new System.Drawing.Size(180, 159);
            this.DescripcionGr.TabIndex = 7;
            this.DescripcionGr.TabStop = false;
            this.DescripcionGr.Text = "Descripcion/Anotaciones";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 20);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 133);
            this.textBox3.TabIndex = 0;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(22, 362);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 8;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(104, 361);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 9;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // ProductoAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.DescripcionGr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VistaPreviaLbl);
            this.Controls.Add(this.VistaPreviaListVw);
            this.Controls.Add(this.IconosLbl);
            this.Controls.Add(this.IconosListVw);
            this.Name = "ProductoAM";
            this.Text = "ProductoAM";
            this.Load += new System.EventHandler(this.ProductoAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DescripcionGr.ResumeLayout(false);
            this.DescripcionGr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView IconosListVw;
        private System.Windows.Forms.Label IconosLbl;
        private System.Windows.Forms.ListView VistaPreviaListVw;
        private System.Windows.Forms.Label VistaPreviaLbl;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PrecioVentatextBox;
        private System.Windows.Forms.Label PrecioVentaLbl;
        private System.Windows.Forms.TextBox PrecioCostotextBox;
        private System.Windows.Forms.Label PrecioCostoLbl;
        private System.Windows.Forms.RadioButton IsDivisibleSiradioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton IsNotDivisibleradioButton;
        private System.Windows.Forms.GroupBox DescripcionGr;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
    }
}