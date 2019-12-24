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
    public partial class RunnerRegistration : Form
    {
        public RunnerRegistration()
        {
            InitializeComponent();
            TimerHandler th = new TimerHandler(label4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter your E-mail");
                return;
            }
            if (textBox2.Text == "" && textBox2.Text.Length > 5 && passwordCheck())
            {
                MessageBox.Show("Enter your password");
                return;
            }
            if (textBox4.Text == "" && textBox2.Text != textBox4.Text)
            {
                MessageBox.Show("Enter your password confirmation");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter your first name");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Enter your last name");
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Enter your gender");
                return;
            }
        }

        private bool passwordCheck()
        {
            if (textBox2.Text.IndexOf('!') > 0)
                return true;
            else if (textBox2.Text.IndexOf('@') > 0)
                return true;
            else if (textBox2.Text.IndexOf('#') > 0)
                return true;
            else if (textBox2.Text.IndexOf('$') > 0)
                return true;
            else if (textBox2.Text.IndexOf('%') > 0)
                return true;
            else if (textBox2.Text.IndexOf('^') > 0)
                return true;

            return false;
        }
    }
}
