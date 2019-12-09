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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Formertre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g71_Below_SaidakhmatovDataSet.ViewRunnerInfo' table. You can move, or remove it, as needed.
            //this.viewRunnerInfoTableAdapter.Fill(this.g71_Below_SaidakhmatovDataSet.ViewRunnerInfo);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start- DateTime.Now;
            label4.Text = t.Days.ToString() + " days, " + t.Hours.ToString() + " hours, " + t.Minutes.ToString() + " minutes";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Enter your name");
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Select runner");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter cardholder");
                return;
            }
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Enter card");
                return;
            }
            if (maskedTextBox1.Text.Length != 16)
            {
                MessageBox.Show("Enter card");
                return;
            }
            if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("Enter month");
                return;
            }
            if (maskedTextBox3.Text == "")
            {
                MessageBox.Show("Enter year");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Enter cvc");
                return;
            }
            DateTime t = DateTime.Now;
            int m = int.Parse(maskedTextBox2.Text);
            int y = int.Parse(maskedTextBox3.Text);
            bool inv = false;
            if (t.Year <= y)
            {
                if (t.Year == y)
                {
                    if (t.Month > m) inv = true;
                }
            }
            else inv=true;
            if (inv == true)
            {
                MessageBox.Show("Invalid card");
                return;
            }
            int n = 0;
            for (int i = 0; i < maskedTextBox1.Text.Length; i++)
                if (maskedTextBox1.Text[i] == ' ') n++;
            string s = maskedTextBox1.Text;
            s=s.Replace(" ","");
            s = s.Replace(" ", "");
            s = s.Replace(" ", "");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int v = int.Parse(textBox2.Text);
            textBox2.Text = (v - 10).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int v =int.Parse(textBox2.Text);
            textBox2.Text = (v + 10).ToString();
        }

       
    }
}
