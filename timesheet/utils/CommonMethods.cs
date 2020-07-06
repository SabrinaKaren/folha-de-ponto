using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using timesheet.database;
using timesheet.database.selectCollections;

namespace timesheet.utils
{
    public class CommonMethods
    {

        public string generateToken(int employeeId, MySqlConnection connectionObject)
        {

            // data de expiração do token
            DateTime now = new DateTime();
            DateTime validate = now.AddHours(2);

            // gero nova string para o token
            string token = "aaabbbccc000111222";

            string updateQuery = "UPDATE token SET validate = @validate, token = @token WHERE token_employee_id = @employeeId";
            MySqlCommand cmd = new MySqlCommand(updateQuery, connectionObject);
            cmd.Parameters.AddWithValue("@validate", validate);
            cmd.Parameters.AddWithValue("@token", token);
            cmd.Parameters.AddWithValue("@employeeId", employeeId);
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                // abrir tela de ponto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar o token: " + ex.ToString());
            }

            return token;

        }

    }

}