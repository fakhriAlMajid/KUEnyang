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
    public partial class FormDetailProduk : Form
    {
        public FormDetailProduk()
        {
            InitializeComponent();
            IsiComboBoxKategori(); // jika ada combobox kategori
            GenerateIdProdukOtomatis();
        }

        private void btnSimpanDetailProduk_Click(object sender, EventArgs e)
        {
            // Ambil data dari input form
            string idProduk = txtIdProduk.Text.Trim();
            string idKategori = cmbKategori.SelectedValue?.ToString(); // Pastikan ValueMember diset ke IdKategori
            string namaProduk = txtNamaProduk.Text.Trim();
            decimal hargaJual = decimal.Parse(txtHarga.Text);
            int stok = int.Parse(txtStok.Text);
            DateTime tglKadaluarsa = txtTanggallkadaluarsa.Value;
            string status = txtStatus.Text.Trim();

            // Validasi singkat (opsional)
            if (string.IsNullOrEmpty(idProduk) || string.IsNullOrEmpty(idKategori))
            {
                MessageBox.Show("Lengkapi semua data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_tambah_produk", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdProduk", idProduk);
                    cmd.Parameters.AddWithValue("@IdKategori", idKategori);
                    cmd.Parameters.AddWithValue("@NamaProduk", namaProduk);
                    cmd.Parameters.AddWithValue("@HargaJual", hargaJual);
                    cmd.Parameters.AddWithValue("@Stok", stok);
                    cmd.Parameters.AddWithValue("@TanggalKadaluarsa", tglKadaluarsa);
                    cmd.Parameters.AddWithValue("@Status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produk berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // atau reset form
                    }
                    else
                    {
                        MessageBox.Show("Produk gagal disimpan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                GenerateIdProdukOtomatis();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan produk: " + ex.Message);
            }
        }
        private void IsiComboBoxKategori()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IdKategori, NamaKategori FROM KategoriProduk";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbKategori.DataSource = dt;
                    cmbKategori.DisplayMember = "NamaKategori"; // tampil yang dibaca user
                    cmbKategori.ValueMember = "IdKategori";     // ambil ID-nya untuk database
                    cmbKategori.SelectedIndex = -1; // tidak pilih apapun awalnya
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data kategori: " + ex.Message);
                }
            }
        }
        private void GenerateIdProdukOtomatis()
        {
            string prefix = "PRD";
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Ambil ID terakhir yang diawali dengan 'PRD'
                string query = "SELECT MAX(IdProduk) FROM Produk WHERE IdProduk LIKE @prefix + '%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@prefix", prefix);

                object result = cmd.ExecuteScalar();
                string newId = prefix + "0001"; // default jika belum ada data

                if (result != DBNull.Value && result != null)
                {
                    string lastId = result.ToString(); // contoh: PRD0023
                    int lastNumber = int.Parse(lastId.Substring(3)); // ambil angka setelah "PRD"
                    int nextNumber = lastNumber + 1;
                    newId = prefix + nextNumber.ToString("D4"); // format: PRD + 4 digit angka
                }

                txtIdProduk.Text = newId;
                txtIdProduk.ReadOnly = true;
            }
        }

        private void btnKembaliTambahProduk_Click(object sender, EventArgs e)
        {
            FormInventaris inven = new FormInventaris(FormLogin.NamaLoginAktif);
            FormCRUDProduk form = new FormCRUDProduk();

            this.Hide();
            inven.Show();
            inven.TampilkanFormDalamPanel(form);
        }

        private void FormDetailProduk_Load(object sender, EventArgs e)
        {

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHarga.Text)) return;

            // Simpan posisi kursor
            int selectionStart = txtHarga.SelectionStart;
            int lengthBefore = txtHarga.Text.Length;

            // Hapus semua karakter selain angka
            string cleaned = new string(txtHarga.Text.Where(char.IsDigit).ToArray());

            if (decimal.TryParse(cleaned, out decimal value))
            {
                // Format angka dengan pemisah ribuan
                txtHarga.Text = string.Format("{0:N0}", value);

                // Perbarui posisi kursor agar tidak pindah ke akhir
                int lengthAfter = txtHarga.Text.Length;
                txtHarga.SelectionStart = selectionStart + (lengthAfter - lengthBefore);
            }
        }

        private void txtNamaProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamaProduk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
