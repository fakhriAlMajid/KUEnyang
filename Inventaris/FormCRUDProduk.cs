using KUEnyang_8.Inventaris;
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
    public partial class FormCRUDProduk : Form
    {
        private DataGridViewRow barisDipilih;
        public FormCRUDProduk()
        {
            InitializeComponent();
            tabelProduk.EnableHeadersVisualStyles = false;
            tabelProduk.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("137; 78; 63"); // coklat
            tabelProduk.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#FFF2D8"); ;
            tabelProduk.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tabelProduk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Warna baris dan font
            tabelProduk.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("240; 215; 167"); // kuning pastel
            tabelProduk.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("137; 78; 63");
            tabelProduk.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            tabelProduk.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F4C95D");
            tabelProduk.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void btnTambahProduk_Click_1(object sender, EventArgs e)
        {
            FormInventaris inven = new FormInventaris();
            FormDetailProduk detailProduk = new FormDetailProduk();

            inven.Show(); // Tampilkan FormUtama dulu
            inven.TampilkanFormDalamPanel(detailProduk); // Masukkan dashboard ke panel
            this.Hide(); // Sembunyikan form login

        }
        private void LoadDataKeGrid()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                // Ganti dengan SELECT dari view
                SqlCommand cmd = new SqlCommand("SELECT * FROM View_ProdukDenganKategori", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabelProduk.DataSource = dt;

                // Pastikan jumlah kolom sesuai dengan view
                if (tabelProduk.Columns.Count >= 7)
                {
                    tabelProduk.Columns[0].Width = 143;  // IdProduk
                    tabelProduk.Columns[1].Width = 220;  // NamaKategori
                    tabelProduk.Columns[2].Width = 220;  // NamaProduk
                    tabelProduk.Columns[3].Width = 200;  // HargaJual
                    tabelProduk.Columns[4].Width = 150;   // Stok
                    tabelProduk.Columns[5].Width = 250;  // TanggalKadaluarsa
                    tabelProduk.Columns[6].Width = 170;  // Status
                }

                tabelProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                // Header kolom
                tabelProduk.Columns[0].HeaderText = "ID Produk";
                tabelProduk.Columns[1].HeaderText = "Kategori";
                tabelProduk.Columns[2].HeaderText = "Nama Produk";
                tabelProduk.Columns[3].HeaderText = "Harga Jual";
                tabelProduk.Columns[4].HeaderText = "Stok";
                tabelProduk.Columns[5].HeaderText = "Kadaluarsa";
                tabelProduk.Columns[6].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data produk: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FormTambahProduk_Load(object sender, EventArgs e)
        {
            LoadDataKeGrid();
            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnTambahProduk.Visible = true;

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (barisDipilih == null)
            {
                MessageBox.Show("Pilih data produk terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data dari baris yang diklik
            string idProduk = barisDipilih.Cells[0].Value.ToString();
            string namaKategori = barisDipilih.Cells[1].Value.ToString(); // hanya untuk ditampilkan
            string namaProduk = barisDipilih.Cells[2].Value.ToString();
            decimal hargaJual = Convert.ToDecimal(barisDipilih.Cells[3].Value);
            int stok = Convert.ToInt32(barisDipilih.Cells[4].Value);
            DateTime tglKadaluarsa = Convert.ToDateTime(barisDipilih.Cells[5].Value);
            string status = barisDipilih.Cells[6].Value.ToString();

            // Kirim ke FormUbahProduk
            FormUbahProduk form = new FormUbahProduk(idProduk, namaKategori, namaProduk, hargaJual, stok, tglKadaluarsa, status);
            form.Owner = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();

            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnTambahProduk.Visible = true;
        }


        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (barisDipilih == null)
            {
                MessageBox.Show("Pilih produk yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idProduk = barisDipilih.Cells[0].Value.ToString();

            DialogResult konfirmasi = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus produk dengan ID '{idProduk}'?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("sp_hapus_produk", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProduk", idProduk);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produk berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataKeGrid(); // refresh tabel
                        }
                        else
                        {
                            MessageBox.Show("Produk tidak ditemukan atau gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat menghapus produk: " + ex.Message);
                }
            }
        }

        private void tabelProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                barisDipilih = tabelProduk.Rows[e.RowIndex];
            }
            btnHapus.Visible = true;
            btnUbah.Visible = true;
            btnTambahProduk.Visible = true;
        }

        private void FormCRUDProduk_Click(object sender, EventArgs e)
        {
            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnTambahProduk.Visible = true;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();
            LoadDataProduk(keyword);
        }

        private void LoadDataProduk(string filter = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;"))
                {
                    conn.Open();

                    SqlCommand cmd;

                    if (!string.IsNullOrWhiteSpace(filter) && filter != "Semua")
                    {
                        cmd = new SqlCommand("sp_cari_produk", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@filter", filter);
                    }
                    else
                    {
                        cmd = new SqlCommand("sp_lihat_produk", conn); // SP yang tanpa filter
                        cmd.CommandType = CommandType.StoredProcedure;
                    }
                    tabelProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    tabelProduk.DataSource = dt;
                    // Kunci ukuran kolom (misal 6 kolom)
                    if (tabelProduk.Columns.Count > 0)
                    {
                        tabelProduk.Columns[0].Width = 143;  // IdProduk
                        tabelProduk.Columns[1].Width = 220;  // NamaKategori
                        tabelProduk.Columns[2].Width = 220;  // NamaProduk
                        tabelProduk.Columns[3].Width = 200;  // HargaJual
                        tabelProduk.Columns[4].Width = 150;   // Stok
                        tabelProduk.Columns[5].Width = 250;  // TanggalKadaluarsa
                        tabelProduk.Columns[6].Width = 170;  // Contoh: Status

                        // Nonaktifkan resize oleh user
                        foreach (DataGridViewColumn col in tabelProduk.Columns)
                        {
                            col.Resizable = DataGridViewTriState.False;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data produk: " + ex.Message);
            }
        }
        public void RefreshData()
        {
            LoadDataKeGrid(); // Method yang kamu sudah buat
        }

    }
}