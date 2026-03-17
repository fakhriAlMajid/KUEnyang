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
    public partial class FormTampre : Form
    {
        public FormTampre()
        {
            InitializeComponent();
        }

        private void KembaliTampre_Click(object sender, EventArgs e)
        {
            FormKasir kasir = new FormKasir();
            FormTambahPreorder FormTPre = new FormTambahPreorder();

            this.Hide(); // Sembunyikan form login
            kasir.Show(); // Tampilkan FormUtama dulu
            kasir.TampilkanFormDalamPanel(FormTPre); // Masukkan dashboard ke panel
        }

        private void FormTampre_Load(object sender, EventArgs e)
        {

        }
    }
}
