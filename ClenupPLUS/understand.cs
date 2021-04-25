using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanupPLUS
{
    public partial class understand : Form
    {
        public understand()
        {
            InitializeComponent();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {


            
            var tempFilePath = Path.GetTempFileName();
            var filee = new FileInfo(tempFilePath);
            filee.Delete();
            var file = new FileInfo(tempFilePath);
            file.Delete();
            this.Hide();
            Process.Start("Temp");
            Process.Start("Prefetch");
            FileInfo fileInfo = new FileInfo(tempFilePath);
        

        }

        private void understand_Load(object sender, EventArgs e)
        {

        }
    }
}
