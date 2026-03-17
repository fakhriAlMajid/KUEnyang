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
    public partial class FormAwal : Form
    {
        public FormAwal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormAwal_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void FormAwal_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }
    }
}
