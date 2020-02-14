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
            SqlDataReader sdr = dbh.read("select * from HowPrepare");
            Dictionary<int, string> comboboxItems = new Dictionary<int, string>();
            while (sdr.Read())
            {
                // [0][int32]id;[1][string]nname;[2][bool]isForFood
                if (sdr.GetBoolean(2) == false)
                    comboboxItems.Add(sdr.GetInt32(0), sdr.GetString(1));//comboBox2.Items.Add(sdr.GetInt32(0).ToString(), sdr.GetString(1));
            }
            comboBox2.DataSource = new BindingSource(comboboxItems, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DbHandler dbh = new DbHandler();
                dbh.write("insert into PartsOfFood (nname, price, energyOnGram, measurementUnitsId, howPrepareId) values ('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedValue + ((KeyValuePair<int, string>)comboBox2.SelectedItem).Key + "')");
                textBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch { }
        }

        private void AddPartOfFood_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "receiptsDataSet.MeasurementUnits". При необходимости она может быть перемещена или удалена.
            this.measurementUnitsTableAdapter.Fill(this.receiptsDataSet.MeasurementUnits);

        }
    }
}

// Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db\receipts.accdb