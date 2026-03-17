using KUEnyang_8.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            TampilkanFormDalamPanel(new FormCRUDKaryawan());
        }

        public void TampilkanFormDalamPanel(Form form)
        {
            foreach (Control ctrl in panelAdmin.Controls)
            {
                if (ctrl is Form oldForm)
                {
                    oldForm.Close();   
                    oldForm.Dispose();  
                }
            }

            panelAdmin.Controls.Clear(); 

           
            form.TopLevel = false;                 
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;           
            panelAdmin.Controls.Add(form);        
            form.Show();                          
            panelAdmin.SuspendLayout();
            panelAdmin.ResumeLayout();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin(FormLogin.NamaLoginAktif);
            this.Hide();
            admin.Show(); 
            TampilkanFormDalamPanel(new FormAdmin());
        }

        private void btnJabatan_Click(object sender, EventArgs e)
        {
            TampilkanFormDalamPanel(new FormCRUDJabatan());
        }
        private void SetLabel()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT NamaKaryawan FROM Karyawan WHERE Username = @username";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", FormLogin.NamaLoginAktif);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    labelProfilAdmin.Text = reader["NamaKaryawan"].ToString();
                }
                else
                {
                    labelProfilAdmin.Text = "Tidak ditemukan";
                }
            }
        }



    }
}
