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
            dbh.addItemsToComboBox(comboBox3, 0, 1, "HowPrepare", 2);
            dbh.addItemsToComboBox(comboBox1, 0, 1, "MeasurementUnits", -1);
            dbh.addItemsToComboBox(comboBox2, 0, 1, "PartsOfFood", -1);
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
            textBox1.Text = "";
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
