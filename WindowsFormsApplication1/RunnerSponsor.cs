using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class RunnerSponsor : Form
    {
        private List<string> elements = new List<string>();
        public RunnerSponsor()
        {
            InitializeComponent();
            TimerHandler th = new TimerHandler(label4);
            DatabaseHandler dh = new DatabaseHandler();
            SqlDataReader sdr = dh.read("select * from Runner");
            while (sdr.Read())
            {
                elements.Add(sdr[0].ToString());
                comboBox2.Items.Add(sdr[0].ToString() + "  " + sdr[1].ToString() + "  " + sdr[2].ToString() + "  " + sdr[3].ToString() + "  " + sdr[4].ToString());
            }
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
            
            ThanksForDonat tfd = new ThanksForDonat();
            tfd.runnerNumber = elements[comboBox2.SelectedIndex];
            tfd.money = textBox2.Text;
            tfd.name = textBox6.Text;
            tfd.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int v = int.Parse(textBox2.Text);
            if (v > 0)
            {
                if ((v - 10) > 0)
                    textBox2.Text = (v - 10).ToString();
                else
                    textBox2.Text = (0).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int v =int.Parse(textBox2.Text);
            textBox2.Text = (v + 10).ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler();
            SqlDataReader sdr = dh.read("select * from Charity");
            sdr.Read();
            CustomMessageBox cmb = new CustomMessageBox();
            cmb.text = sdr[1].ToString() + "\n\n" + sdr[2].ToString();
            cmb.bmp = new Bitmap(Resource1.arise_logo);
            cmb.Show();
        }
    }
}
