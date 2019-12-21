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
    public partial class Authorisation : Form
    {
        DateTime endTime = new DateTime(2020, 1, 1);
        public Authorisation()
        {
            InitializeComponent();
            TimerHandler th = new TimerHandler(label4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler();
            SqlDataReader sdr = dh.read("select * from User");
            while (sdr.Read())
            {
                if (textBox1.Text == sdr[0].ToString() && textBox2.Text == sdr[1].ToString())
                {
                    if (sdr[4].ToString() == "A")
                    {
                        // For administrator
                        AdministratorMenu am = new AdministratorMenu();
                        am.Show();
                    }
                    else if (sdr[4].ToString() == "C")
                    {
                        // For coordinator
                        CoordinatorMenu cm = new CoordinatorMenu();
                        cm.Show();
                    }
                    else if (sdr[4].ToString() == "R")
                    {
                        // For runner
                        RunnerMenu rm = new RunnerMenu();
                        rm.Show();
                    }
                    this.Close();
                }
            }
        }
    }
}
