﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Receipts
{
    class DbHandler
    {
        public DbHandler()
        {
            con = new SqlConnection(source);
            con.Open();
        }

        private const string source = "Data Source=Volk-ПК\\SQLEXPRESS;Initial Catalog=Receipts;Integrated Security=True";
        SqlConnection con;

        public SqlDataReader read(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteReader();
        }

        public void write(string query)
        {
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
        }

        public int getMaxId(string dbName, string idName)
        {
            SqlCommand sc = new SqlCommand("select max(" + idName + ") as maxId from " + dbName, con);
            return Int32.Parse(sc.ExecuteScalar().ToString());
        }
    }
}
