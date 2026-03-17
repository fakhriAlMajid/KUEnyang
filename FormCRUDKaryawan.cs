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
    public partial class FormCRUDKaryawan : Form
    {
        public FormCRUDKaryawan()
        {
            InitializeComponent();
        }

        private void btnTambahPenjualan_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            FormTambahKaryawan tamKar = new FormTambahKaryawan();

            admin.Show(); // Tampilkan FormUtama dulu
            admin.TampilkanFormDalamPanel(tamKar); // Masukkan dashboard ke panel
            this.Hide(); // Sembunyikan form login
        }

        private void dataGridViewKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
