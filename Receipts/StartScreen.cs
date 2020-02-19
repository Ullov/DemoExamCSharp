using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receipts
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFood af = new AddFood();
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPartOfFood apof = new AddPartOfFood();
            apof.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PartOfFood pof = new PartOfFood();
            pof.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeFood cf = new ChangeFood();
            cf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangePartsOfFood cpof = new ChangePartsOfFood();
            cpof.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteFood df = new DeleteFood();
            df.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeletePartsOfFood dpof = new DeletePartsOfFood();
            dpof.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FindFood ff = new FindFood();
            ff.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FindPartsOfFood fpof = new FindPartsOfFood();
            fpof.Show();
        }
    }
}
