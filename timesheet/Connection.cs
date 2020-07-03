using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace timesheet
{
    public class Connection
    {
        public bool connectNow()
        {

            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "folha_de_ponto",
                UserID = "root",
                Password = ""
            };

            using (MySqlConnection connectionObject = new MySqlConnection(builder.ConnectionString))
            {
                try
                {
                    connectionObject.Open();
                    //MessageBox.Show("Conectou");
                    return true;
                }
                catch
                {
                    //MessageBox.Show(error.Message.ToString());
                    return false;
                }
            }

        }

    }

}