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

namespace Receipts
{
    public partial class AddPartOfFood : Form
    {
        public AddPartOfFood()
        {
            InitializeComponent();

            //List<string> fields = new List<string>(){"int", "int", "string", "string", "int"};
            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from measurementUnits");
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr.GetString(1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbHandler dbh = new DbHandler();
            dbh.write("insert into PartsOfFood (nname, price, energyOnGramm, measurementUnit) values ('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedValue + "')");
        }
    }
}

// Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db\receipts.accdb