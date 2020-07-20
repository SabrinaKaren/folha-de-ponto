using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timesheet;

namespace folha_de_ponto.code.bll
{
    class TimesheetBLL
    {

        DatabaseAccess db = new DatabaseAccess();

        public DataTable getEmployeeTimesheetOfTodayByToken(String token)
        {

            DataTable sqlReturn = new DataTable();

            try
            {
                db.connect();
                string sql = "SELECT timesheet.timesheet_id, timesheet.dateTime, type.description FROM timesheet JOIN token ON (timesheet.timesheet_employee_id = token.token_employee_id) JOIN type ON (timesheet.timesheet_type_id = type.type_id) WHERE token.token = '" + token + "'";
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