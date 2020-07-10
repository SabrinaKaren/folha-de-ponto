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

        public DataTable loginUser(EmployeeDTO employeeObject)
        {

            DataTable sqlReturn = new DataTable();

            try
            {
                db.connect();
                string sql = "SELECT * FROM employee WHERE user = '" + employeeObject.getUser() + "' AND password = '" + employeeObject.getPassword() + "'";
                sqlReturn = db.getDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o login: " + ex.Message.ToString());
            }

            return sqlReturn;

        }

    }

}