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
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
            tabelKategori.EnableHeadersVisualStyles = false;
            tabelKategori.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("137; 78; 63"); // coklat
            tabelKategori.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#FFF2D8"); ;
            tabelKategori.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tabelKategori.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Warna baris dan font
            tabelKategori.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("240; 215; 167"); // kuning pastel
            tabelKategori.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("137; 78; 63");
            tabelKategori.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            tabelKategori.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F4C95D");
            tabelKategori.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void LoadDataKeGrid()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                // Panggil Stored Procedure untuk melihat data Jabatan
                SqlCommand cmd = new SqlCommand("sp_lihat_kategori", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabelKategori.DataSource = dt;

                // Atur lebar kolom setelah data di-load
                if (tabelKategori.Columns.Count >= 2)
                {
                    tabelKategori.Columns[0].Width = 322; // IdJabatan
                    tabelKategori.Columns[1].Width = 322; // NamaJabatan
                }

                // Nonaktifkan auto-resize agar lebar tetap sesuai set manual
                tabelKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                // Atur ukuran teks
                tabelKategori.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                tabelKategori.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void GenerateIdKategoriOtomatis()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MAX(IdKategori) FROM KategoriProduk WHERE IdKategori LIKE 'KT%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                string newId = "KT0001"; // default jika belum ada data

                if (result != DBNull.Value && result != null)
                {
                    string lastId = result.ToString(); // contoh: JB0007
                    int number = int.Parse(lastId.Substring(2)); // ambil angka saja
                    number++; // tambahkan
                    newId = "KT" + number.ToString("D4"); // hasilkan misal: JB0008
                }
                txtNamaKategori.Text = "";
                txtIdKategori.Text = newId;
                txtIdKategori.ReadOnly = true;
            }
        }

        private void FormKategori_Load(object sender, EventArgs e)
        {
            LoadDataKeGrid();
            GenerateIdKategoriOtomatis();
            btnUbah.Visible = false;
            btnHapus.Visible = false;
        }

        private void tabelKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabelKategori.Rows[e.RowIndex];

                txtIdKategori.Text = row.Cells[0].Value.ToString();
                txtNamaKategori.Text = row.Cells[1].Value.ToString();
            }
            btnHapus.Visible = true;
            btnUbah.Visible = true;
            btnTambahKategori.Visible = false;
        }

        private void FormKategori_Click(object sender, EventArgs e)
        {
            txtNamaKategori.Text = "";
            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnTambahKategori.Visible = true;

            // Generate ID otomatis kembali
            GenerateIdKategoriOtomatis();
        }

        private void btnTambahKategori_Click(object sender, EventArgs e)
        {
            string idKategori = txtIdKategori.Text.Trim().ToUpper();
            string namaKategori = txtNamaKategori.Text.Trim();

            if (string.IsNullOrEmpty(idKategori) || string.IsNullOrEmpty(namaKategori))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Cek apakah ID Kategori sudah ada
                    string cekQuery = "SELECT COUNT(*) FROM KategoriProduk WHERE IdKategori = @id";
                    SqlCommand cekCmd = new SqlCommand(cekQuery, conn);
                    cekCmd.Parameters.AddWithValue("@id", idKategori);

                    int count = (int)cekCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("ID Kategori sudah ada!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Panggil Stored Procedure untuk tambah kategori
                    SqlCommand cmd = new SqlCommand("sp_tambah_kategori", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdKategori", idKategori);
                    cmd.Parameters.AddWithValue("@NamaKategori", namaKategori);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kategori berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh & reset form
                    txtIdKategori.Clear();
                    txtNamaKategori.Clear();
                    LoadDataKeGrid();
                    GenerateIdKategoriOtomatis();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnUbah_Click(object sender, EventArgs e)
        {
            string idKategori = txtIdKategori.Text.Trim().ToUpper();
            string namaKategori = txtNamaKategori.Text.Trim();

            if (string.IsNullOrEmpty(idKategori) || string.IsNullOrEmpty(namaKategori))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi sebelum ubah
            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin mengubah kategori ini?",
                "Konfirmasi Ubah",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi != DialogResult.Yes)
                return;

            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Cek apakah ID Kategori ada
                    string cekQuery = "SELECT COUNT(*) FROM KategoriProduk WHERE IdKategori = @id";
                    SqlCommand cekCmd = new SqlCommand(cekQuery, conn);
                    cekCmd.Parameters.AddWithValue("@id", idKategori);

                    int count = (int)cekCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Kategori tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Panggil Stored Procedure untuk ubah kategori
                    SqlCommand cmd = new SqlCommand("sp_ubah_kategori", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdKategori", idKategori);
                    cmd.Parameters.AddWithValue("@NamaKategori", namaKategori);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kategori berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset form dan refresh
                    txtIdKategori.Clear();
                    txtNamaKategori.Clear();
                    LoadDataKeGrid();
                    GenerateIdKategoriOtomatis();
                    btnTambahKategori.Visible = true;
                    btnUbah.Visible = false;
                    btnHapus.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string idKategori = txtIdKategori.Text.Trim().ToUpper();
            string namaKategori = txtNamaKategori.Text.Trim();

            if (string.IsNullOrEmpty(idKategori) || string.IsNullOrEmpty(namaKategori))
            {
                MessageBox.Show("Silakan pilih kategori yang valid sebelum menghapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus kategori ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi != DialogResult.Yes)
                return;

            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Cek apakah kategori sedang digunakan di tabel Produk
                    string cekProdukQuery = "SELECT COUNT(*) FROM Produk WHERE IdKategori = @id";
                    SqlCommand cekCmd = new SqlCommand(cekProdukQuery, conn);
                    cekCmd.Parameters.AddWithValue("@id", idKategori);

                    int count = (int)cekCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Kategori ini tidak bisa dihapus karena masih digunakan oleh produk.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Jalankan Stored Procedure untuk hapus
                    SqlCommand cmd = new SqlCommand("sp_hapus_kategori", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdKategori", idKategori);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kategori berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdKategori.Clear();
                        txtNamaKategori.Clear();

                        LoadDataKeGrid();
                        GenerateIdKategoriOtomatis();
                        btnHapus.Visible = false;
                        btnUbah.Visible = false;
                        btnTambahKategori.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Kategori tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNamaKategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya izinkan huruf, spasi, dan tombol kontrol seperti backspace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Menolak input selain huruf, spasi, dan tombol kontrol
                return;
            }

            // Batasi maksimal 25 karakter
            if (!char.IsControl(e.KeyChar) && txtNamaKategori.Text.Length >= 25)
            {
                e.Handled = true; // Menolak input jika panjang teks sudah 25
            }
        }

    }
}
