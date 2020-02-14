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
    public partial class Form1 : Form
    {
        private Dictionary<int, int> idAndActualIdPairs = new Dictionary<int, int>();
        public Form1()
        {
            InitializeComponent();
            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from Food");
            for (int i = 0; sdr.Read(); i++)
            {
                listBox1.Items.Add(sdr.GetString(2));
                idAndActualIdPairs.Add(i, sdr.GetInt32(0));
            }
            listBox2.Items.Clear();
            label6.Text = "";
            label8.Text = "";
            label7.Text = "";
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            refreshFoodInfo();
        }

        private void refreshFoodInfo()
        {
            int currId = idAndActualIdPairs[listBox1.SelectedIndex];
            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from Food where id=" + currId);
            sdr.Read();
            label6.Text = sdr.GetString(2);
            int measurementUnitId = sdr.GetInt32(1);
            int howPrepareId = sdr.GetInt32(3);
            string partsOfFood = sdr.GetString(4);
            sdr = dbh.read("select * from MeasurementUnits where id=" + measurementUnitId);
            sdr.Read();
            label8.Text = sdr.GetString(1);
            string[] solePartOfFood = partsOfFood.Split(new[] { ';' }, System.StringSplitOptions.RemoveEmptyEntries);
            listBox2.Items.Clear();
            foreach (string item in solePartOfFood)
            {
                string[] partsOfFoodInfo = item.Split('x');
                sdr = dbh.read("select * from PartsOfFood where id=" + partsOfFoodInfo[1]);
                sdr.Read();
                string name = sdr.GetString(1);
                int mui = sdr.GetInt32(4);
                label1.Text = mui.ToString();
                sdr = dbh.read("select * from MeasurementUnits where id=" + mui);
                sdr.Read();
                //listBox2.Items.Add(name + partsOfFoodInfo[0] + " " + sdr.GetString(1));
                listBox2.Items.Add(name + partsOfFoodInfo[0] + " " + sdr.GetString(1));
            }
            sdr = dbh.read("select * from HowPrepare where id=" + howPrepareId);
            sdr.Read();
            label7.Text = sdr.GetString(1);
        }
    }
}
