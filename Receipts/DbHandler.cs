using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace Receipts
{
    class DbHandler
    {
        public DbHandler() {}

        private const string source = "Data Source=ULLOV-PC\\SQLEXPRESS;Initial Catalog=Receipts;Integrated Security=True";
        SqlConnection con;
        private Timer timer;
        private Label timedLabel;

        public SqlDataReader read(string query)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteReader();
        }

        public void write(string query)
        {
            openConnection();
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
        }

        public int getMaxId(string dbName, string idName)
        {
            openConnection();
            SqlCommand sc = new SqlCommand("select max(" + idName + ") as maxId from " + dbName, con);
            return Int32.Parse(sc.ExecuteScalar().ToString());
        }

        private void openConnection()
        {
            con = new SqlConnection(source);
            con.Open();
        }

        public void addItemsToComboBox(ComboBox comBox, int keyPosition, int valuePosition, string table, int conditionPosition, bool compareConditionTo = true)
        {
            try
            {
                openConnection();
                DbHandler dbh = new DbHandler();
                SqlDataReader sdr = dbh.read("select * from " + table);
                Dictionary<int, string> comboboxItems = new Dictionary<int, string>();
                if (conditionPosition != -1)
                    while (sdr.Read())
                        if (sdr.GetBoolean(conditionPosition) == compareConditionTo)
                            comboboxItems.Add(sdr.GetInt32(keyPosition), sdr.GetString(valuePosition));
                        else {}
                else
                    while (sdr.Read())
                        comboboxItems.Add(sdr.GetInt32(keyPosition), sdr.GetString(valuePosition));
                comBox.DataSource = new BindingSource(comboboxItems, null);
                comBox.DisplayMember = "Value";
                comBox.ValueMember = "Key";
            }
            catch {}
        }

        public void addItemsInListBox(ListBox listBox, int textValuePosition, string table)
        {
            try
            {
                openConnection();
                SqlDataReader sdr = this.read("select * from " + table);
                while (sdr.Read())
                    listBox.Items.Add(sdr.GetString(textValuePosition));
            }
            catch {}
        }

        public Dictionary<int, string> getPartsOfFoodInfo(int id)
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from Food where id=" + id);

            sdr.Read();
            string partsOfFood = sdr.GetString(4);
            string[] solePartOfFood = partsOfFood.Split(new[] { ';' }, System.StringSplitOptions.RemoveEmptyEntries);
            //Dictionary<int, string> currentResultItem = new Dictionary<int, string>();

            foreach (string item in solePartOfFood)
            {
                string[] partsOfFoodInfo = item.Split('x');
                // [0]number; [1]PartOfFoodsId
                sdr = dbh.read("select * from PartsOfFood where id=" + partsOfFoodInfo[1]);
                sdr.Read();
                string name = sdr.GetString(1);
                int mui = sdr.GetInt32(4);
                sdr = dbh.read("select * from MeasurementUnits where id=" + mui);
                sdr.Read();
                result.Add(Int32.Parse(partsOfFoodInfo[1]), name + partsOfFoodInfo[0] + " " + sdr.GetString(1));
            }
            return result;
        }

        public Dictionary<int, string> refreshListBox(ListBox listBox, string type, int id)
        {
            listBox.Items.Clear();
            DbHandler dbh = new DbHandler();
            //foodId = (int)comboBox4.SelectedValue;
            Dictionary<int, string> pofi = new Dictionary<int, string>();
            if (type == "foodChange")
                pofi = dbh.getPartsOfFoodInfo(id);
            foreach (KeyValuePair<int, string> item in pofi)
            {
                listBox.Items.Add(item.Value);
            }
            return pofi;
        }

        public Dictionary<int, string> dserializePartsOfFood(int id)
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            DbHandler dbh = new DbHandler();
            SqlDataReader sdr = dbh.read("select * from Food where id=" + id);

            sdr.Read();
            string partsOfFood = sdr.GetString(4);
            string[] solePartOfFood = partsOfFood.Split(new[] { ';' }, System.StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in solePartOfFood)
            {
                string[] partsOfFoodInfo = item.Split('x');
                // [0]number; [1]PartOfFoodsId
                sdr = dbh.read("select * from PartsOfFood where id=" + partsOfFoodInfo[1]);
                sdr.Read();
                string name = sdr.GetString(1);
                int mui = sdr.GetInt32(4);
                sdr = dbh.read("select * from MeasurementUnits where id=" + mui);
                sdr.Read();
                result.Add(Int32.Parse(partsOfFoodInfo[1]), name + partsOfFoodInfo[0] + " " + sdr.GetString(1));
            }
            return result;
        }

        public string serializePartsOfFood(Dictionary<int, string> parts)
        {
            string result = "";
            foreach (KeyValuePair<int, string> solePart in parts)
            {
                int tmp4 = Int32.Parse(Regex.Match(solePart.Value, @"\d+").Value);
                result += tmp4 + "x" + solePart.Key + ";";
            }
            return result;
        }

        public void showHideLabel(Label label)
        {
            timedLabel = label;
            label.Visible = true;
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += hideLabel;
            timer.Start();
        }

        private void hideLabel(object sender, EventArgs e)
        {
            timedLabel.Visible = false;
            timer.Stop();
        }

        public void update(string query)
        {
            openConnection();
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
        }

        public void delete(string query)
        {
            openConnection();
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
        }
    }
}
