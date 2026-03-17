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
    public partial class FormKasir : Form
    {
        private string namaKaryawan;
        public FormKasir(string nama)
        {
            InitializeComponent();
            namaKaryawan = nama;
            labelProfilKasir.Text = namaKaryawan;
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public FormKasir()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public void TampilkanFormDalamPanel(Form formTujuan)
        {
            // Tutup dan dispose form sebelumnya (jika ada)
            foreach (Control ctrl in panelKasir.Controls)
            {
                if (ctrl is Form oldForm)
                {
                    oldForm.Close();    // Tutup form dengan event-nya
                    oldForm.Dispose();  // Bebaskan memori
                }
            }

            panelKasir.Controls.Clear(); // Kosongkan panel

            // Tambahkan form baru ke panel
            formTujuan.TopLevel = false;
            formTujuan.FormBorderStyle = FormBorderStyle.None;
            formTujuan.Dock = DockStyle.Fill;

            panelKasir.Controls.Add(formTujuan);
            formTujuan.Show();
        }


        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            TampilkanFormDalamPanel(new FormTambahPenjualan());
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
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

        private void labelProfilKasir_Click(object sender, EventArgs e)
        {

        }
        public void SetProfilKasir(string nama)
        {
            labelProfilKasir.Text = nama;
        }

        private void FormKasir_Load(object sender, EventArgs e)
        {

        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            TampilkanFormDalamPanel(new FormTambahPreorder());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormKasir kasir = new FormKasir(FormLogin.NamaLoginAktif);
            this.Hide(); // Sembunyikan form login
            kasir.Show(); // Tampilkan FormUtama dulu
            TampilkanFormDalamPanel(new FormKasir());
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
