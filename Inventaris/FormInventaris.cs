using KUEnyang_8.Inventaris;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUEnyang_8
{
    public partial class FormInventaris : Form
    {
        private string namaKaryawan;
        public FormInventaris(string nama)
        {
            InitializeComponent();
            namaKaryawan = nama;
            labelProfilInventaris.Text = namaKaryawan;
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public FormInventaris()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public void TampilkanFormDalamPanel(Form form)
        {
            // Tutup dan bersihkan form lama jika ada
            foreach (Control ctrl in panelInventaris.Controls)
            {
                if (ctrl is Form oldForm)
                {
                    oldForm.Close();    // Tutup form dengan benar
                    oldForm.Dispose();  // Bebaskan memori
                }
            }

            panelInventaris.Controls.Clear(); // Kosongkan panel

            // Tambahkan form baru ke panel
            form.TopLevel = false;                         // Supaya bisa masuk ke panel
            form.FormBorderStyle = FormBorderStyle.None;   // Hilangkan header/border
            form.Dock = DockStyle.Fill;                    // Penuhi area panel
            panelInventaris.Controls.Add(form);            // Tambahkan ke panel
            form.Show();
            panelInventaris.SuspendLayout();
            // tambahkan form
            panelInventaris.ResumeLayout();
            // Tampilkan
        }


        private void btnKeluar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin login = new FormLogin();
                login.FormClosed += (s, args) => this.Close();
                login.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormInventaris inven = new FormInventaris(FormLogin.NamaLoginAktif);
            this.Hide(); // Sembunyikan form login
            inven.Show(); // Tampilkan FormUtama dulu
            TampilkanFormDalamPanel(new FormAdmin());
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void FormInventaris_Load(object sender, EventArgs e)
        {

        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            TampilkanFormDalamPanel(new FormCRUDProduk());
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            TampilkanFormDalamPanel(new FormKondisi());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            TampilkanFormDalamPanel(new FormKategori());
        }
    }
}
