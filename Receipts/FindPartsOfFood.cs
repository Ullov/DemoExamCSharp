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
using System.Text.RegularExpressions;

namespace Receipts
{
    public partial class FindPartsOfFood : Form
    {
        Dictionary<int, int> searchResults = new Dictionary<int, int>();
        public FindPartsOfFood()
        {
            InitializeComponent();

            DbHandler dbh = new DbHandler();
            dbh.addItemsToComboBox(comboBox2, 0, 1, "HowPrepare", 2, false);
            dbh.addItemsToComboBox(comboBox1, 0, 1, "MeasurementUnits", -1);
        }

        private void refreshFields()
        {
            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from PartsOfFood where id=" + searchResults[listBox2.SelectedIndex]);
            sdr.Read();
            textBox4.Text = sdr.GetInt32(2).ToString();
            textBox3.Text = sdr.GetInt32(3).ToString();
            comboBox1.SelectedValue = sdr.GetInt32(4);
            comboBox2.SelectedValue = sdr.GetInt32(5);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshFields();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from PartsOfFood");
            Regex regularExpression = new Regex(textBox2.Text);
            listBox2.Items.Clear();
            searchResults.Clear();
            int i = 0;
            while (sdr.Read())
            {
                string tmp = regularExpression.Match(sdr.GetString(1)).ToString();
                if (tmp != "")
                {
                    searchResults.Add(i, sdr.GetInt32(0));
                    listBox2.Items.Add(sdr.GetString(1));
                    i++;
                }
            }
        }
    }
}
