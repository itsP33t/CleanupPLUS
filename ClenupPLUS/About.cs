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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://dsc.gg/p33t");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            normal normal = new normal();
            normal.Show();
        }
    }
}
