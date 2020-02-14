using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Receipts
{
    class DbHandler
    {
        public DbHandler() {}

        private const string source = "Data Source=ULLOV-PC\\SQLEXPRESS;Initial Catalog=Receipts;Integrated Security=True";
        SqlConnection con;

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
    }
}
