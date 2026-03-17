using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using KUEnyang_8.Admin;


namespace KUEnyang_8
{
    public partial class FormCRUDKaryawan : Form
    {
        private DataGridViewRow barisDipilih;

        public FormCRUDKaryawan()
        {
            InitializeComponent();
            tabelKaryawan.EnableHeadersVisualStyles = false;
            tabelKaryawan.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("137; 78; 63"); // coklat
            tabelKaryawan.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#FFF2D8"); ; 
            tabelKaryawan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tabelKaryawan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Warna baris dan font
            tabelKaryawan.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("240; 215; 167"); // kuning pastel
            tabelKaryawan.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("137; 78; 63");
            tabelKaryawan.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            tabelKaryawan.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F4C95D");
            tabelKaryawan.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void btnTambahPenjualan_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin(FormLogin.NamaLoginAktif);
            FormTambahKaryawan form = new FormTambahKaryawan();

            admin.Shown += (s, args) =>
            {
                admin.TampilkanFormDalamPanel(form);
            };

            admin.Show(); 
            this.Hide();
        }

        private void LoadDataKeGrid()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_lihat_view_karyawan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabelKaryawan.DataSource = dt;

                // Atur lebar kolom setelah data di-load
                if (tabelKaryawan.Columns.Count >= 7)
                {
                    tabelKaryawan.Columns[0].Width = 100;
                    tabelKaryawan.Columns[1].Width = 150;
                    tabelKaryawan.Columns[2].Width = 250;
                    tabelKaryawan.Columns[3].Width = 168;
                    tabelKaryawan.Columns[4].Width = 168;
                    tabelKaryawan.Columns[5].Width = 250;
                    tabelKaryawan.Columns[6].Width = 150;
                }

                tabelKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            tabelKaryawan.Columns[0].HeaderText = "ID";
            tabelKaryawan.Columns[1].HeaderText = "Jabatan";
            tabelKaryawan.Columns[2].HeaderText = "Nama";
            tabelKaryawan.Columns[3].HeaderText = "Username";
            tabelKaryawan.Columns[4].HeaderText = "Password";
            tabelKaryawan.Columns[5].HeaderText = "Alamat";
            tabelKaryawan.Columns[6].HeaderText = "No HP";
            FormTambahKaryawan form = new FormTambahKaryawan();
            form.isiComboBox();

        }

        private void FormCRUDKaryawan_Load(object sender, EventArgs e)
        {
            LoadDataKeGrid();
            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnTambahKaryawan.Visible = true;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (barisDipilih == null)
            {
                MessageBox.Show("Pilih data karyawan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data dari baris yang diklik
            string id = barisDipilih.Cells[0].Value.ToString();
            string idJabatan = barisDipilih.Cells[1].Value.ToString(); // Value untuk SelectedValue
            string nama = barisDipilih.Cells[2].Value.ToString();
            string username = barisDipilih.Cells[3].Value.ToString();
            string password = barisDipilih.Cells[4].Value.ToString();
            string alamat = barisDipilih.Cells[5].Value.ToString();
            string nohp = barisDipilih.Cells[6].Value.ToString();

            // Kirim ke FormUbahKaryawan
            FormUbahKaryawan form = new FormUbahKaryawan(id, nama, alamat, nohp, idJabatan, username, password);
            form.Owner = this; // penting untuk akses balik
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnTambahKaryawan.Visible = true;
        }




        private void tabelKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                barisDipilih = tabelKaryawan.Rows[e.RowIndex];
            }
            btnHapus.Visible = true;
            btnUbah.Visible = true;
            btnTambahKaryawan.Visible = true;
        }
        public void RefreshData()
        {
            LoadDataKeGrid(); // Method yang kamu sudah buat
        }

        private void FormCRUDKaryawan_Click(object sender, EventArgs e)
        {
            btnHapus.Visible = false;
            btnUbah.Visible = false;
            btnTambahKaryawan.Visible = true;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (barisDipilih == null)
            {
                MessageBox.Show("Pilih data karyawan yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idKaryawan = barisDipilih.Cells[0].Value.ToString(); // ID karyawan dari kolom pertama

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus data karyawan ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (konfirmasi != DialogResult.Yes)
                return;

            string connectionString = @"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_hapus_karyawan", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdKaryawan", idKaryawan);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Data karyawan berhasil dihapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataKeGrid(); // Refresh isi tabel
                        barisDipilih = null;
                    }
                    else
                    {
                        MessageBox.Show("Data karyawan tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataGrid(string filter = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=KUEnyang8;User ID=majid;Password=risolmayo;"))
                {
                    conn.Open();

                    SqlCommand cmd;

                    if (!string.IsNullOrWhiteSpace(filter) && filter != "Semua")
                    {
                        string query = @"SELECT * FROM view_karyawan 
                                 WHERE NamaKaryawan LIKE @filter 
                                 OR NamaJabatan LIKE @filter 
                                 OR IdKaryawan LIKE @filter 
                                 OR Alamat LIKE @filter 
                                 ORDER BY IdKaryawan ASC";

                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                    }
                    else
                    {
                        // Kalau tidak ada filter, panggil stored procedure
                        cmd = new SqlCommand("sp_lihat_view_karyawan", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                    }
                    tabelKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    tabelKaryawan.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data Karyawan: " + ex.Message);
            }
        }


        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();
            LoadDataGrid(keyword);
        }

    }
}
