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
    public partial class FormCRUDJabatan : Form
    {
        public FormCRUDJabatan()
        {
            InitializeComponent();
            tabelJabatan.EnableHeadersVisualStyles = false;
            tabelJabatan.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("137; 78; 63"); // coklat
            tabelJabatan.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#FFF2D8"); ;
            tabelJabatan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tabelJabatan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Warna baris dan font
            tabelJabatan.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("240; 215; 167"); // kuning pastel
            tabelJabatan.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("137; 78; 63");
            tabelJabatan.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            tabelJabatan.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F4C95D");
            tabelJabatan.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void LoadDataKeGrid()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                // Panggil Stored Procedure untuk melihat data Jabatan
                SqlCommand cmd = new SqlCommand("sp_lihat_jabatan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabelJabatan.DataSource = dt;

                // Atur lebar kolom setelah data di-load
                if (tabelJabatan.Columns.Count >= 2)
                {
                    tabelJabatan.Columns[0].Width = 322; // IdJabatan
                    tabelJabatan.Columns[1].Width = 322; // NamaJabatan
                }

                // Nonaktifkan auto-resize agar lebar tetap sesuai set manual
                tabelJabatan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                // Atur ukuran teks
                tabelJabatan.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                tabelJabatan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
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


        private void FormCRUDJabatan_Load_1(object sender, EventArgs e)
        {
            LoadDataKeGrid();
            GenerateIdJabatanOtomatis();
        }

        private void btnTambahJabatan_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            // Ambil nilai dari textbox
            string idJabatan = txtIdJabatan.Text;
            string namaJabatan = txtNamaJabatan.Text;

            // Validasi input
            if (string.IsNullOrWhiteSpace(idJabatan) || string.IsNullOrWhiteSpace(namaJabatan))
            {
                MessageBox.Show("ID dan Nama Jabatan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_tambah_jabatan", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdJabatan", idJabatan);
                    cmd.Parameters.AddWithValue("@NamaJabatan", namaJabatan);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data jabatan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh tampilan dan reset form
                    LoadDataKeGrid();
                    GenerateIdJabatanOtomatis();

                    btnHapus.Visible = false;
                    btnUbah.Visible = false;
                    btnTambahJabatan.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data:\n" + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateIdJabatanOtomatis()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MAX(IdJabatan) FROM Jabatan WHERE IdJabatan LIKE 'JB%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                string newId = "JB0001"; // default jika belum ada data

                if (result != DBNull.Value && result != null)
                {
                    string lastId = result.ToString(); // contoh: JB0007
                    int number = int.Parse(lastId.Substring(2)); // ambil angka saja
                    number++; // tambahkan
                    newId = "JB" + number.ToString("D4"); // hasilkan misal: JB0008
                }
                txtNamaJabatan.Text = "";
                txtIdJabatan.Text = newId;
                txtIdJabatan.ReadOnly = true;
            }
        }

        private void tabelJabatan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabelJabatan.Rows[e.RowIndex];

                txtIdJabatan.Text = row.Cells[0].Value.ToString();
                txtNamaJabatan.Text = row.Cells[1].Value.ToString();        
            }
            btnHapus.Visible=true;
            btnUbah.Visible=true;
            btnTambahJabatan.Visible=false;
        }

        private void FormCRUDJabatan_Click(object sender, EventArgs e)
        {
            txtNamaJabatan.Text = "";
            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnTambahJabatan.Visible = true;

            // Generate ID otomatis kembali
            GenerateIdJabatanOtomatis();
        }


        private void btnUbah_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
            string idJabatan = txtIdJabatan.Text;
            string namaJabatan = txtNamaJabatan.Text;

            // Validasi input kosong
            if (string.IsNullOrWhiteSpace(idJabatan) || string.IsNullOrWhiteSpace(namaJabatan))
            {
                MessageBox.Show("ID dan Nama Jabatan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi pengguna sebelum update
            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin mengubah data jabatan ini?",
                "Konfirmasi Ubah Data",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("sp_ubah_jabatan", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdJabatan", idJabatan);
                        cmd.Parameters.AddWithValue("@NamaJabatan", namaJabatan);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data jabatan berhasil diubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataKeGrid();            // Refresh DataGridView
                            GenerateIdJabatanOtomatis(); // Reset form
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah data. ID tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat mengubah data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Reset tombol tampilan
            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnTambahJabatan.Visible = true;
        }


        private void btnHapus_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
            string idJabatan = txtIdJabatan.Text;

            // Validasi
            if (string.IsNullOrWhiteSpace(idJabatan))
            {
                MessageBox.Show("Pilih data jabatan yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus jabatan ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("sp_hapus_jabatan", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdJabatan", idJabatan);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data jabatan berhasil dihapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataKeGrid();             // Refresh tabel
                            GenerateIdJabatanOtomatis();  // Reset ID dan form
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan atau gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat menghapus data:\n" + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Reset tombol
                btnHapus.Visible = false;
                btnUbah.Visible = false;
                btnTambahJabatan.Visible = true;
            }
        }

        private void txtNamaJabatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya izinkan huruf, spasi, dan tombol kontrol seperti backspace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Menolak input selain huruf, spasi, dan tombol kontrol
                return;
            }

            // Batasi maksimal 25 karakter
            if (!char.IsControl(e.KeyChar) && txtNamaJabatan.Text.Length >= 25)
            {
                e.Handled = true; // Menolak input jika panjang teks sudah 25
            }
        }
    }
}
