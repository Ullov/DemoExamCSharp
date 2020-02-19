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
    public partial class DeleteFood : Form
    {
        public DeleteFood()
        {
            InitializeComponent();

            label6.Visible = false;
            DbHandler dbh = new DbHandler();
            dbh.addItemsToComboBox(comboBox3, 0, 1, "HowPrepare", 2);
            dbh.addItemsToComboBox(comboBox1, 0, 1, "MeasurementUnits", -1);
            dbh.addItemsToComboBox(comboBox4, 0, 2, "Food", -1);
            dbh.refreshListBox(listBox1, "foodChange", (int)comboBox4.SelectedValue);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbHandler dbh = new DbHandler();
            dbh.refreshListBox(listBox1, "foodChange", (int)comboBox4.SelectedValue);
            SqlDataReader sdr = dbh.read("select * from Food where id=" + (int)comboBox4.SelectedValue);
            sdr.Read();
            comboBox1.SelectedValue = sdr.GetInt32(1);
            comboBox3.SelectedValue = sdr.GetInt32(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbHandler dbh = new DbHandler();
            dbh.update("delete from Food where id =" + ((KeyValuePair<int, string>)comboBox4.SelectedItem).Key);
            dbh.addItemsToComboBox(comboBox4, 0, 2, "Food", -1);
            dbh.showHideLabel(label6);
        }
    }
}
