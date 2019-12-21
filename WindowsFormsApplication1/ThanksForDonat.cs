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
    public partial class ThanksForDonat : Form
    {
        public string name;
        public string money;
        public string runnerNumber;
        public ThanksForDonat()
        {
            InitializeComponent();
            TimerHandler th = new TimerHandler(label4);
        }

        private void ThanksForDonat_Shown(object sender, EventArgs e)
        {
            label6.Text = "$" + money;
            label7.Text = runnerNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
