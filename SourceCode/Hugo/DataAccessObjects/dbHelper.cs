﻿using System;
using System.Data;
using Npgsql;

namespace Hugo.DataAccessObjects
{
    public class dbHelper
    {
        private static String host = "127.0.0.1",
            database = "Hugo",
            userId = "postgres",
            password = "uca";

        private static String sConnection =
            $"Server={host};Port=5432;User Id={userId};Password={password};Database = {database};";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            
            connection.Open();
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            
            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(String act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            connection.Open();
            
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            
            connection.Close();
        }
    }
}