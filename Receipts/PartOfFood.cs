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
    public partial class PartOfFood : Form
    {
        private Dictionary<int, int> idAndActualIdPairs = new Dictionary<int, int>();
        public PartOfFood()
        {
            InitializeComponent();
            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from PartsOfFood");
            for (int i = 0; sdr.Read(); i++)
            {
                listBox1.Items.Add(sdr.GetString(1));
                idAndActualIdPairs.Add(i, sdr.GetInt32(0));
            }
            label6.Text = "";
            label3.Text = "";
            label5.Text = "";
            label8.Text = "";
            label10.Text = "";
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int currId = idAndActualIdPairs[listBox1.SelectedIndex];
            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from PartsOfFood where id=" + currId);
            sdr.Read();
            label6.Text = sdr.GetString(1);
            label3.Text = sdr.GetInt32(2).ToString();
            label5.Text = sdr.GetInt32(3).ToString();
            int measurementUnitId = sdr.GetInt32(4);
            int howPrepareId = sdr.GetInt32(5);
            sdr = dbh.read("select * from MeasurementUnits where id=" + measurementUnitId);
            sdr.Read();
            label8.Text = sdr.GetString(1);
            sdr = dbh.read("select * from HowPrepare where id=" + howPrepareId);
            sdr.Read();
            label10.Text = sdr.GetString(1);
        }
    }
}
