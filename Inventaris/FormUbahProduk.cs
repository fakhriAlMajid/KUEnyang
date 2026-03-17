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

namespace KUEnyang_8.Inventaris
{
    public partial class FormUbahProduk : Form
    {
        public FormUbahProduk()
        {
            InitializeComponent();
        }
        public FormUbahProduk(string idProduk, string namaKategori, string namaProduk, decimal hargaJual, int stok, DateTime tglKadaluarsa, string status)
        {
            InitializeComponent();

            // Isi kontrol dengan data dari baris dipilih
            txtIdProduk.Text = idProduk;
            txtIdProduk.ReadOnly = true; // Id biasanya tidak boleh diubah

            // Pastikan ComboBox kategori sudah terisi sebelum set SelectedItem
            LoadKategoriKeComboBox(); // Metode ini mengisi cmbKategori dari database
            cmbKategori.SelectedItem = namaKategori;

            txtNamaProduk.Text = namaProduk;
            txtHarga.Text = hargaJual.ToString("N0"); // Format ribuan
            txtStok.Text = stok.ToString();
            try
            {
                if (tglKadaluarsa >= dtpKadaluarsa.MinDate && tglKadaluarsa <= dtpKadaluarsa.MaxDate)
                {
                    dtpKadaluarsa.Value = tglKadaluarsa;
                }
                else
                {
                    dtpKadaluarsa.Value = DateTime.Today;
                }
            }
            catch
            {
                dtpKadaluarsa.Value = DateTime.Today;
            }
            txtStatus.Text = status;
        }
        private void LoadKategoriKeComboBox()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;"))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IdKategori, NamaKategori FROM KategoriProduk", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbKategori.DataSource = dt;
                cmbKategori.DisplayMember = "NamaKategori";
                cmbKategori.ValueMember = "IdKategori";
            }
        }


        private void FormUbahProduk_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string idProduk = txtIdProduk.Text.Trim();
            string idKategori = cmbKategori.SelectedValue?.ToString(); // pastikan ini tidak null
            string namaProduk = txtNamaProduk.Text.Trim();
            decimal hargaJual = decimal.Parse(txtHarga.Text);
            int stok = int.Parse(txtStok.Text);
            DateTime tglKadaluarsa = dtpKadaluarsa.Value;
            string status = txtStatus.Text;

            if (string.IsNullOrEmpty(idProduk) || string.IsNullOrEmpty(namaProduk))
            {
                MessageBox.Show("Lengkapi semua data!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_ubah_produk", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdProduk", idProduk);
                    cmd.Parameters.AddWithValue("@IdKategori", idKategori ?? (object)DBNull.Value); // pastikan aman dari null
                    cmd.Parameters.AddWithValue("@NamaProduk", namaProduk);
                    cmd.Parameters.AddWithValue("@HargaJual", hargaJual);
                    cmd.Parameters.AddWithValue("@Stok", stok);
                    cmd.Parameters.AddWithValue("@TanggalKadaluarsa", tglKadaluarsa);
                    cmd.Parameters.AddWithValue("@Status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data produk berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Akses form pemilik (owner) dan refresh data
                        if (this.Owner is FormCRUDProduk formCrud)
                        {
                            formCrud.RefreshData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengubah data produk.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }


    }
}
