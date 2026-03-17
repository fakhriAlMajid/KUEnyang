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
    public partial class FormTambahPreorder : Form
    {
        public FormTambahPreorder()
        {
            InitializeComponent();
        }

        private void btnTambahPenjualan_Click(object sender, EventArgs e)
        {
            FormKasir kasir = new FormKasir();
            FormTampre tamPre = new FormTampre();

            kasir.Show(); // Tampilkan FormUtama dulu
            kasir.TampilkanFormDalamPanel(tamPre); // Masukkan dashboard ke panel
            this.Hide(); // Sembunyikan form login
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabelKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
