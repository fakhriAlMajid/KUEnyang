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

namespace KUEnyang_8.Admin
{
    public partial class FormUbahKaryawan : Form
    {
        public FormUbahKaryawan()
        {
            InitializeComponent();
        }
        public FormUbahKaryawan(string id, string nama, string alamat, string nohp, string jabatan, string username, string password)
        {
            InitializeComponent();

            txtIdKaryawan.Text = id;
            txtNamaKaryawan.Text = nama;
            txtAlamat.Text = alamat;
            txtNoHP.Text = nohp;
            cmbJabatan.SelectedValue = jabatan;
            txtUsername.Text = username;
            txtPassword.Text = password;

            txtIdKaryawan.ReadOnly = true;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormUbahKaryawan_Load(object sender, EventArgs e)
        {
            LoadComboBoxJabatan();
        }
        private void LoadComboBoxJabatan()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IdJabatan, NamaJabatan FROM Jabatan";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbJabatan.DataSource = dt;
                    cmbJabatan.DisplayMember = "NamaJabatan"; // yang ditampilkan
                    cmbJabatan.ValueMember = "IdJabatan";     // nilai yang tersembunyi
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data jabatan: " + ex.Message);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            // Ambil data dari form
            string idKaryawan = txtIdKaryawan.Text;
            string nama = txtNamaKaryawan.Text;
            string alamat = txtAlamat.Text;
            string nohp = txtNoHP.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string idJabatan = cmbJabatan.SelectedValue?.ToString();

            // Validasi input
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(alamat) ||
                string.IsNullOrWhiteSpace(nohp) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(idJabatan))
            {
                MessageBox.Show("Semua kolom wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menyimpan perubahan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_ubah_karyawan", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Tambahkan parameter
                    cmd.Parameters.AddWithValue("@IdKaryawan", idKaryawan);
                    cmd.Parameters.AddWithValue("@NamaKaryawan", nama);
                    cmd.Parameters.AddWithValue("@Alamat", alamat);
                    cmd.Parameters.AddWithValue("@NoTelepon", nohp);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@IdJabatan", idJabatan);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Data karyawan berhasil diubah.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Akses form pemilik (owner) dan refresh data
                        if (this.Owner is FormCRUDKaryawan formCrud)
                        {
                            formCrud.RefreshData();
                        }

                        // Tidak perlu tutup form jika ingin tetap terbuka
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNamaKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cek apakah karakter bukan huruf, spasi, atau tombol kontrol (seperti backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Tolak karakter
                return;
            }

            // Batasi maksimal 25 karakter
            TextBox txt = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 25)
            {
                e.Handled = true; // Tolak input jika melebihi 25 karakter
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 25)
            {
                e.Handled = true; // Tolak input jika melebihi 25 karakter
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 15)
            {
                e.Handled = true; // Tolak input jika melebihi 25 karakter
            }
        }

        private void txtAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 50)
            {
                e.Handled = true; // Tolak input jika melebihi 25 karakter
            }
        }

        private void txtNoHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Hanya izinkan angka dan tombol kontrol (seperti backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Batasi panjang maksimal 13 digit
            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 13)
            {
                e.Handled = true;
            }
        }

    }
}
