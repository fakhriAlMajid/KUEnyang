namespace KUEnyang_8
{
    partial class FormKondisi
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
            this.tabelKondisiProduk = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IdProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriKue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalKadaluarsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSimpanPenjualan = new Guna.UI2.WinForms.Guna2Button();
            this.cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelKondisiProduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelKondisiProduk
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelKondisiProduk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelKondisiProduk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelKondisiProduk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelKondisiProduk.ColumnHeadersHeight = 33;
            this.tabelKondisiProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabelKondisiProduk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduk,
            this.NamaProduk,
            this.KategoriKue,
            this.Stok,
            this.TanggalKadaluarsa,
            this.Harga});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelKondisiProduk.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabelKondisiProduk.GridColor = System.Drawing.Color.White;
            this.tabelKondisiProduk.Location = new System.Drawing.Point(135, 146);
            this.tabelKondisiProduk.Name = "tabelKondisiProduk";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelKondisiProduk.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabelKondisiProduk.RowHeadersVisible = false;
            this.tabelKondisiProduk.Size = new System.Drawing.Size(1201, 629);
            this.tabelKondisiProduk.TabIndex = 25;
            this.tabelKondisiProduk.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tabelKondisiProduk.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tabelKondisiProduk.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tabelKondisiProduk.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tabelKondisiProduk.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tabelKondisiProduk.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            this.tabelKondisiProduk.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.tabelKondisiProduk.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tabelKondisiProduk.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabelKondisiProduk.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelKondisiProduk.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabelKondisiProduk.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabelKondisiProduk.ThemeStyle.HeaderStyle.Height = 33;
            this.tabelKondisiProduk.ThemeStyle.ReadOnly = false;
            this.tabelKondisiProduk.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tabelKondisiProduk.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabelKondisiProduk.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelKondisiProduk.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tabelKondisiProduk.ThemeStyle.RowsStyle.Height = 22;
            this.tabelKondisiProduk.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabelKondisiProduk.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // IdProduk
            // 
            this.IdProduk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdProduk.HeaderText = "ID";
            this.IdProduk.Name = "IdProduk";
            // 
            // NamaProduk
            // 
            this.NamaProduk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NamaProduk.FillWeight = 250F;
            this.NamaProduk.HeaderText = "Produk";
            this.NamaProduk.MinimumWidth = 20;
            this.NamaProduk.Name = "NamaProduk";
            this.NamaProduk.Width = 250;
            // 
            // KategoriKue
            // 
            this.KategoriKue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KategoriKue.FillWeight = 220F;
            this.KategoriKue.HeaderText = "Kategori";
            this.KategoriKue.Name = "KategoriKue";
            this.KategoriKue.Width = 220;
            // 
            // Stok
            // 
            this.Stok.HeaderText = "Stok";
            this.Stok.Name = "Stok";
            // 
            // TanggalKadaluarsa
            // 
            this.TanggalKadaluarsa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TanggalKadaluarsa.FillWeight = 400F;
            this.TanggalKadaluarsa.HeaderText = "Tanggal Kadaluarsa";
            this.TanggalKadaluarsa.Name = "TanggalKadaluarsa";
            this.TanggalKadaluarsa.Width = 400;
            // 
            // Harga
            // 
            this.Harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Harga.FillWeight = 220F;
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            this.Harga.Width = 220;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(123, 146);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1225, 629);
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1033, 827);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(86, 33);
            this.guna2HtmlLabel1.TabIndex = 23;
            this.guna2HtmlLabel1.Text = "Total :";
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
            this.btnSimpanPenjualan.Location = new System.Drawing.Point(244, 815);
            this.btnSimpanPenjualan.Name = "btnSimpanPenjualan";
            this.btnSimpanPenjualan.Size = new System.Drawing.Size(276, 65);
            this.btnSimpanPenjualan.TabIndex = 22;
            this.btnSimpanPenjualan.Text = "Simpan";
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilter.ItemHeight = 30;
            this.cmbFilter.Location = new System.Drawing.Point(123, 61);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(294, 36);
            this.cmbFilter.TabIndex = 26;
            // 
            // FormKondisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KUEnyang_8.Properties.Resources.Dashboard_Admin__2_;
            this.ClientSize = new System.Drawing.Size(1471, 929);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.tabelKondisiProduk);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnSimpanPenjualan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKondisi";
            this.Text = "FormKondisi";
            this.Load += new System.EventHandler(this.FormKondisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelKondisiProduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView tabelKondisiProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriKue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalKadaluarsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSimpanPenjualan;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
    }
}