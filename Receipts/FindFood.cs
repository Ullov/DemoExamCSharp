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
    public partial class FindFood : Form
    {
        Dictionary<int, int> searchResults = new Dictionary<int, int>();
        public FindFood()
        {
            InitializeComponent();

            DbHandler dbh = new DbHandler();
            dbh.addItemsToComboBox(comboBox3, 0, 1, "HowPrepare", 2);
            dbh.addItemsToComboBox(comboBox1, 0, 1, "MeasurementUnits", -1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from Food");
            Regex regularExpression = new Regex(textBox2.Text);
            listBox2.Items.Clear();
            searchResults.Clear();
            int i = 0;
            while(sdr.Read())
            {
                string tmp = regularExpression.Match(sdr.GetString(2)).ToString();
                if (tmp != "")
                {
                    searchResults.Add(i, sdr.GetInt32(0));
                    listBox2.Items.Add(sdr.GetString(2));
                    i++;
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbHandler dbh = new DbHandler();
            dbh.refreshListBox(listBox1, "foodChange", searchResults[listBox2.SelectedIndex]);
            SqlDataReader sdr = dbh.read("select * from Food where id=" + searchResults[listBox2.SelectedIndex]);
            sdr.Read();
            comboBox1.SelectedValue = sdr.GetInt32(1);
            comboBox3.SelectedValue = sdr.GetInt32(3);
        }
    }
}
