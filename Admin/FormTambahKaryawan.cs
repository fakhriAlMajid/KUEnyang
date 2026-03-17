using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KUEnyang_8
{
    public partial class FormTambahKaryawan : Form
    {
        public FormTambahKaryawan()
        {
            InitializeComponent();

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpanKar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            // Validasi dulu (jika kosong)
            if (string.IsNullOrWhiteSpace(txtNamaKaryawan.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtNoTelepon.Text) ||
                cmbJabatan.SelectedIndex == -1)
            {
                MessageBox.Show("Semua kolom wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // ID Otomatis
                    string idJabatan = cmbJabatan.SelectedValue.ToString();

                    SqlCommand cmd = new SqlCommand("sp_tambah_karyawan", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdKaryawan", txtIdKaryawan.Text);
                    cmd.Parameters.AddWithValue("@IdJabatan", idJabatan);
                    cmd.Parameters.AddWithValue("@NamaKaryawan", txtNamaKaryawan.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@NoTelepon", txtNoTelepon.Text);
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
                // Bersihkan input lainnya
                txtNamaKaryawan.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtNoTelepon.Text = "";
                cmbJabatan.SelectedIndex = -1;
                txtAlamat.Text = "";
            }
        }

        private void GenerateIdKaryawanOtomatis()
        {
            string tahun = DateTime.Now.Year.ToString();
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Ambil ID terakhir yang dimulai dengan tahun sekarang
                string query = "SELECT MAX(IdKaryawan) FROM Karyawan WHERE IdKaryawan LIKE @tahun + '%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tahun", tahun);

                object result = cmd.ExecuteScalar();
                string newId = tahun + "001"; // default jika belum ada

                if (result != DBNull.Value && result != null)
                {
                    string lastId = result.ToString(); // contoh: 2025012
                    int lastNumber = int.Parse(lastId.Substring(4)); // Ambil angka 3 digit terakhir
                    int nextNumber = lastNumber + 1;
                    newId = tahun + nextNumber.ToString("D3"); // format: 2025 + 3 digit
                }
                txtIdKaryawan.Text = newId;
                txtIdKaryawan.ReadOnly = true;
            }
        }


        private void btnKembaliTmbahKar_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin(FormLogin.NamaLoginAktif);
            FormCRUDKaryawan form = new FormCRUDKaryawan();

            this.Hide();
            admin.Show();
            admin.TampilkanFormDalamPanel(form);
        }


        private void FormTambahKaryawan_Load_1(object sender, EventArgs e)
        {
            GenerateIdKaryawanOtomatis(); // Panggil method yang sudah kamu buat
            isiComboBox();
            cmbJabatan.SelectedIndex = -1;
        }

        public void isiComboBox()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IdJabatan, NamaJabatan FROM Jabatan", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbJabatan.DataSource = dt;
                cmbJabatan.DisplayMember = "NamaJabatan";
                cmbJabatan.ValueMember = "IdJabatan";
            }
        }

        private void txtNamaKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya izinkan huruf, tombol backspace, dan spasi
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }

            // Batasi panjang maksimum 25 karakter (kecuali sedang menekan tombol kontrol seperti Backspace)
            if (!char.IsControl(e.KeyChar) && txtNamaKaryawan.Text.Length >= 25)
            {
                e.Handled = true;
            }
        }


        private void txtNoTelepon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cek apakah karakter yang ditekan bukan angka dan bukan kontrol (misalnya backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Batasi panjang maksimum 13 digit (kecuali sedang menekan tombol kontrol seperti Backspace)
            if (!char.IsControl(e.KeyChar) && txtNoTelepon.Text.Length >= 13)
            {
                e.Handled = true;
            }
        }

        private void txtAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Izinkan semua karakter tapi batasi maksimal 50 karakter
            if (!char.IsControl(e.KeyChar) && txtAlamat.Text.Length >= 50)
            {
                e.Handled = true; // Tolak input jika sudah mencapai 50 karakter
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && txtUsername.Text.Length >= 25)
            {
                e.Handled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && txtPassword.Text.Length >= 15)
            {
                e.Handled = true;
            }
        }
    }
}

