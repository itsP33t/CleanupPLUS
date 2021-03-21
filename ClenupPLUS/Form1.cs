using CleanupPLUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClenupPLUS
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            loading.Text = ("Loading.");
            timer2.Stop();
            timer3.Start();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
            normal normal = new normal();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            loading.Text = ("Loading..");
            timer3.Stop();
            timer4.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            normal normal = new normal();
            this.Hide();
            normal.Show();
            timer1.Stop();
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            loading.Text = ("Loading...");
            timer4.Stop();
            timer2.Start();
        }
    }
}
