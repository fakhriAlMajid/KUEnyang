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
            //FormKasir kasir = new FormKasir();
            //FormTambahPreorder tambahPre = new FormTambahPreorder();

            //this.Hide(); // Sembunyikan form login
            //kasir.Show(); // Tampilkan FormUtama dulu
            //LoadFormKePanel(new FormKasir());
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
