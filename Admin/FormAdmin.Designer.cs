namespace KUEnyang_8
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.btnLaporan = new Guna.UI2.WinForms.Guna2Button();
            this.btnJabatan = new Guna.UI2.WinForms.Guna2Button();
            this.btnKeluar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.labelProfilAdmin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnKaryawan = new Guna.UI2.WinForms.Guna2Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.Transparent;
            this.btnLaporan.BorderRadius = 5;
            this.btnLaporan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLaporan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLaporan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnLaporan.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnLaporan.Image = global::KUEnyang_8.Properties.Resources.lsicon_report_filled;
            this.btnLaporan.ImageOffset = new System.Drawing.Point(-6, 0);
            this.btnLaporan.ImageSize = new System.Drawing.Size(41, 42);
            this.btnLaporan.Location = new System.Drawing.Point(58, 691);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(314, 87);
            this.btnLaporan.TabIndex = 13;
            this.btnLaporan.Text = "Laporan";
            // 
            // btnJabatan
            // 
            this.btnJabatan.BackColor = System.Drawing.Color.Transparent;
            this.btnJabatan.BorderRadius = 5;
            this.btnJabatan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJabatan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJabatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJabatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJabatan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnJabatan.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJabatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnJabatan.Image = global::KUEnyang_8.Properties.Resources.Logo_Jabatan;
            this.btnJabatan.ImageOffset = new System.Drawing.Point(-9, 0);
            this.btnJabatan.ImageSize = new System.Drawing.Size(43, 38);
            this.btnJabatan.Location = new System.Drawing.Point(58, 534);
            this.btnJabatan.Name = "btnJabatan";
            this.btnJabatan.Size = new System.Drawing.Size(314, 87);
            this.btnJabatan.TabIndex = 15;
            this.btnJabatan.Text = "Jabatan";
            this.btnJabatan.TextOffset = new System.Drawing.Point(-3, 0);
            this.btnJabatan.Click += new System.EventHandler(this.btnJabatan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnKeluar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnKeluar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnKeluar.Image = ((System.Drawing.Image)(resources.GetObject("btnKeluar.Image")));
            this.btnKeluar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnKeluar.ImageRotate = 0F;
            this.btnKeluar.Location = new System.Drawing.Point(1786, 80);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnKeluar.Size = new System.Drawing.Size(64, 71);
            this.btnKeluar.TabIndex = 17;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // labelProfilAdmin
            // 
            this.labelProfilAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelProfilAdmin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfilAdmin.Location = new System.Drawing.Point(1357, 73);
            this.labelProfilAdmin.Name = "labelProfilAdmin";
            this.labelProfilAdmin.Size = new System.Drawing.Size(18, 51);
            this.labelProfilAdmin.TabIndex = 18;
            this.labelProfilAdmin.Text = "-";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.guna2Button1.Image = global::KUEnyang_8.Properties.Resources.mingcute_back_fill;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-7, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(42, 41);
            this.guna2Button1.Location = new System.Drawing.Point(58, 988);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(314, 87);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Kembali";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.btnKaryawan.BorderRadius = 5;
            this.btnKaryawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaryawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnKaryawan.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaryawan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnKaryawan.Image = global::KUEnyang_8.Properties.Resources.Logo_Karyawan;
            this.btnKaryawan.ImageSize = new System.Drawing.Size(43, 42);
            this.btnKaryawan.Location = new System.Drawing.Point(58, 384);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(314, 87);
            this.btnKaryawan.TabIndex = 11;
            this.btnKaryawan.Text = "Karyawan";
            this.btnKaryawan.TextOffset = new System.Drawing.Point(5, 0);
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackgroundImage = global::KUEnyang_8.Properties.Resources.Dashboard_Admin__2_1;
            this.panelAdmin.Location = new System.Drawing.Point(437, 264);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1474, 883);
            this.panelAdmin.TabIndex = 21;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KUEnyang_8.Properties.Resources.Dashboard_Admin1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1161);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.labelProfilAdmin);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnJabatan);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnKaryawan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnLaporan;
        private Guna.UI2.WinForms.Guna2Button btnJabatan;
        private Guna.UI2.WinForms.Guna2ImageButton btnKeluar;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelProfilAdmin;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnKaryawan;
        private System.Windows.Forms.Panel panelAdmin;
    }
}