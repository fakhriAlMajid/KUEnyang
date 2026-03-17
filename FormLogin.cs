using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KUEnyang_8
{
    public partial class FormLogin : Form
    {
        public string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
        public static string NamaLoginAktif;
        public FormLogin()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;

            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_Login", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string role = reader["idJabatan"].ToString().Trim().ToUpper();
                            string nama = reader["NamaKaryawan"].ToString().Trim();

                            NamaLoginAktif = nama;

                            switch (role)
                            {
                                case "JB0001": // Admin
                                    new FormAdmin(nama).Show();
                                    break;

                                case "JB0002": // Inventaris
                                    new FormInventaris(nama).Show();
                                    break;

                                case "JB0003": // Kasir
                                    new FormKasir(nama).Show();
                                    break;

                                default:
                                    MessageBox.Show("Jabatan tidak dikenali.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            welkom.Visible = false;
        }
    }
}
