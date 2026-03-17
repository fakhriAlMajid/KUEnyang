namespace KUEnyang_8.Inventaris
{
    partial class FormKategori
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
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnUbah = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambahKategori = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaKategori = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdKategori = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabelKategori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.BorderColor = System.Drawing.Color.Transparent;
            this.btnHapus.BorderRadius = 10;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnHapus.Location = new System.Drawing.Point(813, 547);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(266, 57);
            this.btnHapus.TabIndex = 38;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Visible = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.Transparent;
            this.btnUbah.BorderColor = System.Drawing.Color.Transparent;
            this.btnUbah.BorderRadius = 10;
            this.btnUbah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUbah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUbah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUbah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUbah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnUbah.Location = new System.Drawing.Point(1135, 547);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(266, 57);
            this.btnUbah.TabIndex = 37;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Visible = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambahKategori
            // 
            this.btnTambahKategori.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahKategori.BorderColor = System.Drawing.Color.Transparent;
            this.btnTambahKategori.BorderRadius = 10;
            this.btnTambahKategori.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahKategori.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambahKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambahKategori.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnTambahKategori.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnTambahKategori.Location = new System.Drawing.Point(813, 547);
            this.btnTambahKategori.Name = "btnTambahKategori";
            this.btnTambahKategori.Size = new System.Drawing.Size(266, 57);
            this.btnTambahKategori.TabIndex = 36;
            this.btnTambahKategori.Text = "Tambah";
            this.btnTambahKategori.Click += new System.EventHandler(this.btnTambahKategori_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(825, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nama Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(825, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 37);
            this.label3.TabIndex = 34;
            this.label3.Text = "Id Kategori Produk";
            // 
            // txtNamaKategori
            // 
            this.txtNamaKategori.BackColor = System.Drawing.Color.Transparent;
            this.txtNamaKategori.BorderRadius = 10;
            this.txtNamaKategori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaKategori.DefaultText = "";
            this.txtNamaKategori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaKategori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaKategori.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(204)))), ((int)(((byte)(164)))));
            this.txtNamaKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaKategori.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNamaKategori.ForeColor = System.Drawing.Color.Black;
            this.txtNamaKategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaKategori.Location = new System.Drawing.Point(813, 453);
            this.txtNamaKategori.Margin = new System.Windows.Forms.Padding(5);
            this.txtNamaKategori.Name = "txtNamaKategori";
            this.txtNamaKategori.PlaceholderText = "";
            this.txtNamaKategori.SelectedText = "";
            this.txtNamaKategori.Size = new System.Drawing.Size(600, 38);
            this.txtNamaKategori.TabIndex = 33;
            this.txtNamaKategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaKategori_KeyPress);
            // 
            // txtIdKategori
            // 
            this.txtIdKategori.BackColor = System.Drawing.Color.Transparent;
            this.txtIdKategori.BorderRadius = 10;
            this.txtIdKategori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdKategori.DefaultText = "";
            this.txtIdKategori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdKategori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdKategori.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(204)))), ((int)(((byte)(164)))));
            this.txtIdKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdKategori.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIdKategori.ForeColor = System.Drawing.Color.Black;
            this.txtIdKategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdKategori.Location = new System.Drawing.Point(813, 337);
            this.txtIdKategori.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdKategori.Name = "txtIdKategori";
            this.txtIdKategori.PlaceholderText = "";
            this.txtIdKategori.SelectedText = "";
            this.txtIdKategori.Size = new System.Drawing.Size(600, 38);
            this.txtIdKategori.TabIndex = 32;
            // 
            // tabelKategori
            // 
            this.tabelKategori.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.tabelKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelKategori.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabelKategori.Location = new System.Drawing.Point(62, 61);
            this.tabelKategori.Name = "tabelKategori";
            this.tabelKategori.ReadOnly = true;
            this.tabelKategori.Size = new System.Drawing.Size(688, 769);
            this.tabelKategori.TabIndex = 31;
            this.tabelKategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelKategori_CellClick);
            // 
            // FormKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KUEnyang_8.Properties.Resources.Dashboard_Admin__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1474, 890);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambahKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaKategori);
            this.Controls.Add(this.txtIdKategori);
            this.Controls.Add(this.tabelKategori);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKategori";
            this.Text = "FormKategori";
            this.Load += new System.EventHandler(this.FormKategori_Load);
            this.Click += new System.EventHandler(this.FormKategori_Click);
            ((System.ComponentModel.ISupportInitialize)(this.tabelKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnUbah;
        private Guna.UI2.WinForms.Guna2Button btnTambahKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaKategori;
        private Guna.UI2.WinForms.Guna2TextBox txtIdKategori;
        private System.Windows.Forms.DataGridView tabelKategori;
    }
}