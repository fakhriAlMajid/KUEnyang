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
    public partial class FormAdmin : Form
    {
        private string namaKaryawan;
        public FormAdmin(string nama)
        {
            InitializeComponent();
            namaKaryawan = nama;
            labelProfilAdmin.Text = namaKaryawan;
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public FormAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
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

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            LoadFormKePanel(new FormCRUDKaryawan());
        }

        private void LoadFormKePanel(Form formBaru)
        {
            if (formBaru == null) return;

            panelAdmin.Controls.Clear();                  // Kosongkan panel dulu
            formBaru.TopLevel = false;                    // Agar form bisa ditaruh di panel
            formBaru.FormBorderStyle = FormBorderStyle.None; // Hilangkan border
            formBaru.Dock = DockStyle.Fill;               // Agar form memenuhi panel
            formBaru.Parent = panelAdmin;                 // Set parent secara eksplisit
            panelAdmin.Controls.Add(formBaru);            // Tambahkan ke panel
            formBaru.Show();                              // Tampilkan form
            //formBaru.BringToFront();                      // Pastikan tampil paling depan
        }


        public void TampilkanFormDalamPanel(Form formTujuan)
        {
            panelAdmin.Controls.Clear();
            formTujuan.TopLevel = false;
            formTujuan.FormBorderStyle = FormBorderStyle.None;
            formTujuan.Dock = DockStyle.Fill;
            panelAdmin.Controls.Add(formTujuan);
            formTujuan.Show();
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            this.Hide(); // Sembunyikan form login
            admin.Show(); // Tampilkan FormUtama dulu
            LoadFormKePanel(new FormAdmin());
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
