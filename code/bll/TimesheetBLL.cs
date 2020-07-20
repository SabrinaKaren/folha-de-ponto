using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timesheet;
using folha_de_ponto.code.utils;

namespace folha_de_ponto.code.bll
{
    class TimesheetBLL
    {

        DatabaseAccess db = new DatabaseAccess();
        CommonMethods commonMethods = new CommonMethods();

        public DataTable getEmployeeTimesheetOfTodayByToken(String token)
        {

            DataTable sqlReturn = new DataTable();

            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            string todayInString = commonMethods.convertDateTimeInDbFormatString(today);
            string tomorrowInString = commonMethods.convertDateTimeInDbFormatString(tomorrow);

            try
            {
                db.connect();
                string sql = "SELECT timesheet.timesheet_id, timesheet.dateTime, type.description " +
                    "FROM timesheet " +
                    "JOIN token ON (timesheet.timesheet_employee_id = token.token_employee_id) " +
                    "JOIN type ON (timesheet.timesheet_type_id = type.type_id) " +
                    "WHERE timesheet.dateTime >= '" + todayInString + "' " +
                    "AND timesheet.dateTime < '" + tomorrowInString + "' " +
                    "AND token.token = '" + token + "'";
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