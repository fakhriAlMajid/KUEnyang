using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KUEnyang_8
{
    public partial class FormKondisi : Form
    {
        public FormKondisi()
        {
            InitializeComponent();
        }

        private void FormKondisi_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.Insert(0, "-- Filter --");
            cmbFilter.SelectedIndex = 0;
        }
    }
}
