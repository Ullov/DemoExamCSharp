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
    public partial class DeletePartsOfFood : Form
    {
        public DeletePartsOfFood()
        {
            InitializeComponent();

            label6.Visible = false;
            DbHandler dbh = new DbHandler();
            dbh.addItemsToComboBox(comboBox2, 0, 1, "HowPrepare", 2, false);
            dbh.addItemsToComboBox(comboBox1, 0, 1, "MeasurementUnits", -1);
            dbh.addItemsToComboBox(comboBox3, 0, 1, "PartsOfFood", -1);
            refreshFields();
        }

        private void refreshFields()
        {
            DbHandler dbh = new DbHandler();
            int pofId = ((KeyValuePair<int, string>)comboBox3.SelectedItem).Key;
            SqlDataReader sdr = dbh.read("select * from PartsOfFood where id=" + pofId);
            sdr.Read();
            textBox4.Text = sdr.GetInt32(2).ToString();
            textBox3.Text = sdr.GetInt32(3).ToString();
            comboBox1.SelectedValue = sdr.GetInt32(4);
            comboBox2.SelectedValue = sdr.GetInt32(5);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbHandler dbh = new DbHandler();
            dbh.delete("delete from PartsOfFood where id=" + ((KeyValuePair<int, string>)comboBox3.SelectedItem).Key);
            dbh.showHideLabel(label6);
            dbh.addItemsToComboBox(comboBox3, 0, 1, "PartsOfFood", -1);
        }
    }
}
