using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace timesheet
{
    class DatabaseAccess
    {

        private MySqlConnection connection;
        private DataTable dataTable;
        private MySqlDataAdapter dataAdapter;
        //private MySqlDataReader dataReader;
        private MySqlCommandBuilder commandBuilder;

        private String server = "localhost";
        private String user = "root";
        private String password = "";
        private String database = "folha_de_ponto";

        public void connect()
        {

            if (connection != null)
            {
                connection.Close();
            }

            string connectionString = String.Format("server={0}; user id={1}; password={2}; database={3}", server, user, password, database);

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void executeSql(string sql)
        {
            MySqlCommand sqlCommand = new MySqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable getDataTable(string sql)
        {

            dataTable = new DataTable();
            dataAdapter = new MySqlDataAdapter(sql, connection);
            commandBuilder = new MySqlCommandBuilder(dataAdapter);

            dataAdapter.Fill(dataTable);

            return dataTable;

        }

        public MySqlDataReader getDataReader(string sql)
        {

            MySqlCommand sqlCommand = new MySqlCommand(sql, connection);
            MySqlDataReader dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();

            return dataReader;

        }

    }

}