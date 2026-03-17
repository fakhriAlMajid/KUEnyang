using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUEnyang_8
{
    public partial class FormTambahPenjualan : Form
    {
        public FormTambahPenjualan()
        {
            InitializeComponent();
        }

        private void btnTambahPenjualan_Click(object sender, EventArgs e)
        {
       
            FormKasir kasir = new FormKasir();
            FormTamPen tamPen = new FormTamPen();

            kasir.Show(); // Tampilkan FormUtama dulu
            kasir.TampilkanFormDalamPanel(tamPen); // Masukkan dashboard ke panel
            this.Hide(); // Sembunyikan form login
    }

        private void FormTambahPenjualan_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpanPenjualan_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
