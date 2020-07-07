using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace timesheet.database.selectCollections
{
    class EmployeeBLL
    {

        DatabaseAccess db = new DatabaseAccess();

        public void loginUser(EmployeeDTO employeeObject)
        {
            
            try
            {
                
                db.connect();

                string sql = "SELECT * FROM employee WHERE user = '" + employeeObject.getUser() + "' AND password = '" + employeeObject.getPassword() + "'";
                db.getDataTable(sql); //  verificar se possui retorno

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o login: " + ex.Message.ToString());
            }

        }

    }

}