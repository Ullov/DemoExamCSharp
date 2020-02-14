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
    public partial class AddFood : Form
    {
        Dictionary<int, int> ingredients = new Dictionary<int, int>();
        public AddFood()
        {
            InitializeComponent();
            label7.Text = "";

            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from HowPrepare");
            Dictionary<int, string> comboboxItems = new Dictionary<int, string>();
            while (sdr.Read())
            {
                // [0][int32]id;[1][string]nname;[2][bool]isForFood
                if (sdr.GetBoolean(2) == true)
                    comboboxItems.Add(sdr.GetInt32(0), sdr.GetString(1));//comboBox2.Items.Add(sdr.GetInt32(0).ToString(), sdr.GetString(1));
            }
            comboBox3.DataSource = new BindingSource(comboboxItems, null);
            comboBox3.DisplayMember = "Value";
            comboBox3.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ingr = "";
            foreach (KeyValuePair<int, int> item in ingredients)
            {
                ingr += item.Key + "x" + item.Value + ";";
            }
            ingr.Remove(ingr.Length - 1);
            DbHandler dbh = new DbHandler();
            dbh.write("insert into Food (measurementUnitsId, nname, howPrepareId, partsOfFood) values ('" + comboBox1.SelectedValue + "','" + textBox1.Text + "','" + comboBox3.SelectedValue + "','" + ingr + "')");
        }

        private void AddFood_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "receiptsDataSet.PartsOfFood". При необходимости она может быть перемещена или удалена.
            this.partsOfFoodTableAdapter.Fill(this.receiptsDataSet.PartsOfFood);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "receiptsDataSet.HowPrepare". При необходимости она может быть перемещена или удалена.
            this.howPrepareTableAdapter.Fill(this.receiptsDataSet.HowPrepare);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "receiptsDataSet.MeasurementUnits". При необходимости она может быть перемещена или удалена.
            this.measurementUnitsTableAdapter.Fill(this.receiptsDataSet.MeasurementUnits);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int tmp = Int32.Parse(textBox2.Text);
                int tmpKey = Int32.Parse(comboBox2.SelectedValue.ToString());
                ingredients.Add(tmp, tmpKey);
                textBox2.Text = "";
            }
            catch {}
        }
    }
}
