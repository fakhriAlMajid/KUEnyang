namespace KUEnyang_8
{
    partial class FormTambahPenjualan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSimpanPenjualan = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambahPenjualan = new Guna.UI2.WinForms.Guna2Button();
            this.tabelKaryawan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NamaProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriKue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabelKaryawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(969, 808);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(86, 33);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "Total :";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // btnSimpanPenjualan
            // 
            this.btnSimpanPenjualan.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpanPenjualan.BorderColor = System.Drawing.Color.Transparent;
            this.btnSimpanPenjualan.BorderRadius = 39;
            this.btnSimpanPenjualan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpanPenjualan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpanPenjualan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpanPenjualan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimpanPenjualan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnSimpanPenjualan.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpanPenjualan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnSimpanPenjualan.Location = new System.Drawing.Point(180, 796);
            this.btnSimpanPenjualan.Name = "btnSimpanPenjualan";
            this.btnSimpanPenjualan.Size = new System.Drawing.Size(276, 65);
            this.btnSimpanPenjualan.TabIndex = 7;
            this.btnSimpanPenjualan.Text = "Simpan";
            this.btnSimpanPenjualan.Click += new System.EventHandler(this.btnSimpanPenjualan_Click);
            // 
            // btnTambahPenjualan
            // 
            this.btnTambahPenjualan.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahPenjualan.BorderColor = System.Drawing.Color.Transparent;
            this.btnTambahPenjualan.BorderRadius = 39;
            this.btnTambahPenjualan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahPenjualan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahPenjualan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambahPenjualan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambahPenjualan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnTambahPenjualan.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPenjualan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnTambahPenjualan.Location = new System.Drawing.Point(80, 29);
            this.btnTambahPenjualan.Name = "btnTambahPenjualan";
            this.btnTambahPenjualan.Size = new System.Drawing.Size(289, 67);
            this.btnTambahPenjualan.TabIndex = 6;
            this.btnTambahPenjualan.Text = "Tambah";
            this.btnTambahPenjualan.Click += new System.EventHandler(this.btnTambahPenjualan_Click);
            // 
            // tabelKaryawan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelKaryawan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelKaryawan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelKaryawan.ColumnHeadersHeight = 33;
            this.tabelKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabelKaryawan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaProduk,
            this.KategoriKue,
            this.Quantity,
            this.Harga});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelKaryawan.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabelKaryawan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabelKaryawan.Location = new System.Drawing.Point(71, 127);
            this.tabelKaryawan.Name = "tabelKaryawan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelKaryawan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabelKaryawan.RowHeadersVisible = false;
            this.tabelKaryawan.Size = new System.Drawing.Size(1200, 629);
            this.tabelKaryawan.TabIndex = 15;
            this.tabelKaryawan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tabelKaryawan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tabelKaryawan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tabelKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tabelKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tabelKaryawan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tabelKaryawan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabelKaryawan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tabelKaryawan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabelKaryawan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelKaryawan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabelKaryawan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabelKaryawan.ThemeStyle.HeaderStyle.Height = 33;
            this.tabelKaryawan.ThemeStyle.ReadOnly = false;
            this.tabelKaryawan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tabelKaryawan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabelKaryawan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelKaryawan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tabelKaryawan.ThemeStyle.RowsStyle.Height = 22;
            this.tabelKaryawan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabelKaryawan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(59, 127);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1225, 629);
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // NamaProduk
            // 
            this.NamaProduk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NamaProduk.FillWeight = 300F;
            this.NamaProduk.HeaderText = "Produk";
            this.NamaProduk.MinimumWidth = 20;
            this.NamaProduk.Name = "NamaProduk";
            this.NamaProduk.Width = 300;
            // 
            // KategoriKue
            // 
            this.KategoriKue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KategoriKue.FillWeight = 300F;
            this.KategoriKue.HeaderText = "Kategori";
            this.KategoriKue.Name = "KategoriKue";
            this.KategoriKue.Width = 300;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.FillWeight = 250F;
            this.Quantity.HeaderText = "Kuantitas";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 300;
            // 
            // Harga
            // 
            this.Harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Harga.FillWeight = 300F;
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            this.Harga.Width = 300;
            // 
            // FormTambahPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::KUEnyang_8.Properties.Resources.Dashboard_Admin__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1474, 883);
            this.Controls.Add(this.tabelKaryawan);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnSimpanPenjualan);
            this.Controls.Add(this.btnTambahPenjualan);
            this.DoubleBuffered = true;
            this.Name = "FormTambahPenjualan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTambahPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelKaryawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSimpanPenjualan;
        private Guna.UI2.WinForms.Guna2Button btnTambahPenjualan;
        private Guna.UI2.WinForms.Guna2DataGridView tabelKaryawan;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriKue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
    }
}