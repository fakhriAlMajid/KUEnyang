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
    public partial class FormTamPen : Form
    {
        public FormTamPen()
        {
            InitializeComponent();
        }

        private void FormTamPen_Load(object sender, EventArgs e)
        {

        }

        private void btnKembaliTmbahKar_Click(object sender, EventArgs e)
        {
            FormKasir kasir = new FormKasir();
            FormTambahPenjualan tambahPenjualan = new FormTambahPenjualan();

            this.Hide(); // Sembunyikan form login
            kasir.Show(); // Tampilkan FormUtama dulu
            kasir.TampilkanFormDalamPanel(tambahPenjualan); // Masukkan dashboard ke panel
        }

        private void guna2GroupBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
