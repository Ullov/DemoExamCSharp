using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            TimerHandler th = new TimerHandler(label4);
            label3.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RunnerSponsor f6 = new RunnerSponsor();
            f6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }
    }
}
