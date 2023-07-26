namespace AppRoti.Vistas {
    partial class LoadFrm {
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
            this.LoadprogressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadprogressBar
            // 
            this.LoadprogressBar.Location = new System.Drawing.Point(113, 201);
            this.LoadprogressBar.Name = "LoadprogressBar";
            this.LoadprogressBar.Size = new System.Drawing.Size(100, 23);
            this.LoadprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LoadprogressBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Image = global::AppRoti.Properties.Resources.HD_wallpaper_wind_in_savanah_life_wind_wild_savanah_lion_thumbnail;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 235);
            this.label1.Text = string.Format("TdlaspdLAeplsdsdw");
            this.label1.TabIndex = 2;
            // 
            // LoadFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(318, 253);
            this.Controls.Add(this.LoadprogressBar);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadFrm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar LoadprogressBar;
        private System.Windows.Forms.Label label1;
    }
}