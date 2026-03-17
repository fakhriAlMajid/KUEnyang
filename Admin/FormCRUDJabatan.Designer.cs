namespace KUEnyang_8.Admin
{
    partial class FormCRUDJabatan
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
            this.tabelJabatan = new System.Windows.Forms.DataGridView();
            this.txtIdJabatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNamaJabatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTambahJabatan = new Guna.UI2.WinForms.Guna2Button();
            this.btnUbah = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelJabatan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelJabatan
            // 
            this.tabelJabatan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.tabelJabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelJabatan.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabelJabatan.Location = new System.Drawing.Point(61, 53);
            this.tabelJabatan.Name = "tabelJabatan";
            this.tabelJabatan.ReadOnly = true;
            this.tabelJabatan.Size = new System.Drawing.Size(688, 769);
            this.tabelJabatan.TabIndex = 14;
            this.tabelJabatan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelJabatan_CellClick);
            // 
            // txtIdJabatan
            // 
            this.txtIdJabatan.BackColor = System.Drawing.Color.Transparent;
            this.txtIdJabatan.BorderRadius = 10;
            this.txtIdJabatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdJabatan.DefaultText = "";
            this.txtIdJabatan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdJabatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdJabatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdJabatan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdJabatan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(204)))), ((int)(((byte)(164)))));
            this.txtIdJabatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdJabatan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIdJabatan.ForeColor = System.Drawing.Color.Black;
            this.txtIdJabatan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdJabatan.Location = new System.Drawing.Point(812, 329);
            this.txtIdJabatan.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdJabatan.Name = "txtIdJabatan";
            this.txtIdJabatan.PlaceholderText = "";
            this.txtIdJabatan.SelectedText = "";
            this.txtIdJabatan.Size = new System.Drawing.Size(600, 38);
            this.txtIdJabatan.TabIndex = 16;
            // 
            // txtNamaJabatan
            // 
            this.txtNamaJabatan.BackColor = System.Drawing.Color.Transparent;
            this.txtNamaJabatan.BorderRadius = 10;
            this.txtNamaJabatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaJabatan.DefaultText = "";
            this.txtNamaJabatan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaJabatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaJabatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaJabatan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaJabatan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(204)))), ((int)(((byte)(164)))));
            this.txtNamaJabatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaJabatan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNamaJabatan.ForeColor = System.Drawing.Color.Black;
            this.txtNamaJabatan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaJabatan.Location = new System.Drawing.Point(812, 445);
            this.txtNamaJabatan.Margin = new System.Windows.Forms.Padding(5);
            this.txtNamaJabatan.Name = "txtNamaJabatan";
            this.txtNamaJabatan.PlaceholderText = "";
            this.txtNamaJabatan.SelectedText = "";
            this.txtNamaJabatan.Size = new System.Drawing.Size(600, 38);
            this.txtNamaJabatan.TabIndex = 17;
            this.txtNamaJabatan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaJabatan_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(824, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "Id Jabatan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(824, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nama Jabatan";
            // 
            // btnTambahJabatan
            // 
            this.btnTambahJabatan.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahJabatan.BorderColor = System.Drawing.Color.Transparent;
            this.btnTambahJabatan.BorderRadius = 10;
            this.btnTambahJabatan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahJabatan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahJabatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambahJabatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambahJabatan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.btnTambahJabatan.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahJabatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnTambahJabatan.Location = new System.Drawing.Point(812, 539);
            this.btnTambahJabatan.Name = "btnTambahJabatan";
            this.btnTambahJabatan.Size = new System.Drawing.Size(266, 57);
            this.btnTambahJabatan.TabIndex = 28;
            this.btnTambahJabatan.Text = "Tambah";
            this.btnTambahJabatan.Click += new System.EventHandler(this.btnTambahJabatan_Click);
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
            this.btnUbah.Location = new System.Drawing.Point(1134, 539);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(266, 57);
            this.btnUbah.TabIndex = 29;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Visible = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
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
            this.btnHapus.Location = new System.Drawing.Point(814, 539);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(264, 57);
            this.btnHapus.TabIndex = 30;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Visible = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // FormCRUDJabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KUEnyang_8.Properties.Resources.Dashboard_Admin__2_1;
            this.ClientSize = new System.Drawing.Size(1474, 883);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambahJabatan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaJabatan);
            this.Controls.Add(this.txtIdJabatan);
            this.Controls.Add(this.tabelJabatan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDJabatan";
            this.Text = "FormCRUDJabatan";
            this.Load += new System.EventHandler(this.FormCRUDJabatan_Load_1);
            this.Click += new System.EventHandler(this.FormCRUDJabatan_Click);
            ((System.ComponentModel.ISupportInitialize)(this.tabelJabatan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelJabatan;
        private Guna.UI2.WinForms.Guna2TextBox txtIdJabatan;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaJabatan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTambahJabatan;
        private Guna.UI2.WinForms.Guna2Button btnUbah;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
    }
}