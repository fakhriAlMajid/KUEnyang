namespace KUEnyang_8
{
    partial class FormInventaris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventaris));
            this.btnPreOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnPenjualan = new Guna.UI2.WinForms.Guna2Button();
            this.labelProfilInventaris = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnKeluar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelInventaris = new Guna.UI2.WinForms.Guna2Panel();
            this.btnKategori = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnPreOrder.BorderRadius = 5;
            this.btnPreOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPreOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPreOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPreOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPreOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnPreOrder.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnPreOrder.Image = global::KUEnyang_8.Properties.Resources.lsicon_report_filled;
            this.btnPreOrder.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPreOrder.Location = new System.Drawing.Point(56, 676);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(314, 87);
            this.btnPreOrder.TabIndex = 17;
            this.btnPreOrder.Text = "Kondisi";
            this.btnPreOrder.TextOffset = new System.Drawing.Point(5, 0);
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.BackColor = System.Drawing.Color.Transparent;
            this.btnPenjualan.BorderRadius = 5;
            this.btnPenjualan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPenjualan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPenjualan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPenjualan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPenjualan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnPenjualan.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenjualan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnPenjualan.Image = global::KUEnyang_8.Properties.Resources.Vector__4_;
            this.btnPenjualan.ImageSize = new System.Drawing.Size(45, 21);
            this.btnPenjualan.Location = new System.Drawing.Point(56, 368);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(314, 87);
            this.btnPenjualan.TabIndex = 15;
            this.btnPenjualan.Text = "Produk";
            this.btnPenjualan.TextOffset = new System.Drawing.Point(5, 0);
            this.btnPenjualan.Click += new System.EventHandler(this.btnPenjualan_Click);
            // 
            // labelProfilInventaris
            // 
            this.labelProfilInventaris.BackColor = System.Drawing.Color.Transparent;
            this.labelProfilInventaris.Font = new System.Drawing.Font("Microsoft New Tai Lue", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfilInventaris.Location = new System.Drawing.Point(1358, 74);
            this.labelProfilInventaris.Name = "labelProfilInventaris";
            this.labelProfilInventaris.Size = new System.Drawing.Size(18, 51);
            this.labelProfilInventaris.TabIndex = 20;
            this.labelProfilInventaris.Text = "-";
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
            this.btnKeluar.Location = new System.Drawing.Point(1789, 80);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnKeluar.Size = new System.Drawing.Size(64, 71);
            this.btnKeluar.TabIndex = 19;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click_1);
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
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(56, 987);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(314, 87);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Kembali";
            this.guna2Button1.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panelInventaris
            // 
            this.panelInventaris.BackColor = System.Drawing.Color.Transparent;
            this.panelInventaris.Location = new System.Drawing.Point(435, 270);
            this.panelInventaris.Name = "panelInventaris";
            this.panelInventaris.Size = new System.Drawing.Size(1490, 879);
            this.panelInventaris.TabIndex = 24;
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.Transparent;
            this.btnKategori.BorderRadius = 5;
            this.btnKategori.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKategori.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKategori.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnKategori.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnKategori.Image = global::KUEnyang_8.Properties.Resources.Vector__4_;
            this.btnKategori.ImageSize = new System.Drawing.Size(45, 21);
            this.btnKategori.Location = new System.Drawing.Point(56, 522);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(314, 87);
            this.btnKategori.TabIndex = 25;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.TextOffset = new System.Drawing.Point(5, 0);
            this.btnKategori.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // FormInventaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KUEnyang_8.Properties.Resources.Dashboard_Inventaris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1161);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.panelInventaris);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.labelProfilInventaris);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.btnPenjualan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventaris";
            this.Text = "FormInventaris";
            this.Load += new System.EventHandler(this.FormInventaris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnPreOrder;
        private Guna.UI2.WinForms.Guna2Button btnPenjualan;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelProfilInventaris;
        private Guna.UI2.WinForms.Guna2ImageButton btnKeluar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel panelInventaris;
        private Guna.UI2.WinForms.Guna2Button btnKategori;
    }
}