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
    public partial class normal : Form
    {
        private string strComputerName;

        public normal()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            understand understand = new understand();
            understand.Show();
          
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.Show();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About();
            about.Show();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void normal_Load(object sender, EventArgs e)
        {
        
        

        }
    }
}
