using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class DatabaseHandler
    {
        public DatabaseHandler()
        {
            con = new SqlConnection(source);
            con.Open();
        }

        private const string source = "Data Source=ULLOV-PC\\SQLEXPRESS;Initial Catalog=demoExamDb;Integrated Security=True";
        SqlConnection con;

        public SqlDataReader read(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteReader();
        }
    }
}
