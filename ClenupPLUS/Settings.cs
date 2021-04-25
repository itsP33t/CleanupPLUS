using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanupPLUS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Process.Start("http://dl.dafont.com/dl/?f=lemon_milk");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            normal normal = new normal();
            normal.Show();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
