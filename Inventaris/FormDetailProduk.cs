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
    public partial class FormDetailProduk : Form
    {
        public FormDetailProduk()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnKembaliTambahProduk_Click(object sender, EventArgs e)
        {
          
            FormInventaris inven = new FormInventaris();
            FormTambahProduk tambahProduk = new FormTambahProduk();

            this.Hide(); // Sembunyikan form login
            inven.Show(); // Tampilkan FormUtama dulu
            inven.TampilkanFormDalamPanel(tambahProduk); // Masukkan dashboard ke panel
         
        }
    }
}
