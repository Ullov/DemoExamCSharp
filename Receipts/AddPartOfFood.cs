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

            DbHandler dbh = new DbHandler();
            dbh.addItemsToComboBox(comboBox2, 0, 1, "HowPrepare", 2, false);
            dbh.addItemsToComboBox(comboBox1, 0, 1, "MeasurementUnits", -1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DbHandler dbh = new DbHandler();
                dbh.write("insert into PartsOfFood (nname, price, energyOnGram, measurementUnitsId, howPrepareId) values ('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedValue + "','" + ((KeyValuePair<int, string>)comboBox2.SelectedItem).Key + "')");
                textBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                dbh.showHideLabel(label6);
            }
            catch { }
        }
    }
}

// Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db\receipts.accdb