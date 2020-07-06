using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using timesheet.utils;

namespace timesheet.database.selectCollections
{
    public class EmployeeRepository
    {

        public string authUser(string user, string password)
        {

            string token = "";

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
                }
                catch (Exception error)
                {
                    MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados: " + error.Message.ToString());
                }

                // Criando o SqlCommand com parâmetro
                MySqlCommand query = new MySqlCommand("SELECT * FROM employee WHERE user = @user AND password = @password ", connectionObject);

                // Define as informações do parâmetro criado
                MySqlParameter userParam = new MySqlParameter();
                userParam.ParameterName = "@user";
                userParam.Value = user;

                MySqlParameter passwordParam = new MySqlParameter();
                passwordParam.ParameterName = "@password";
                passwordParam.Value = password;

                // Inserindo o parâmetro no comando
                query.Parameters.Add(userParam);
                query.Parameters.Add(passwordParam);

                // Executando o commando e obtendo o resultado
                MySqlDataReader reader = query.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Usuário e/ou senha inválido(s).");
                } else
                {

                    int employeeId = Int32.Parse(reader[0].ToString());
                    reader.Close();

                    // gerar token
                    CommonMethods newCommonMethods = new CommonMethods();
                    token = newCommonMethods.generateToken(employeeId, connectionObject);

                }

            }            

            return token;

        }

    }

}