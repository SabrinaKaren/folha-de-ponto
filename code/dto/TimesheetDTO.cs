using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folha_de_ponto.code.dto
{
    class TimesheetDTO
    {

        private int timesheet_id;
        private int timesheet_employee_id;
        private DateTime dateTime;
        private int timesheet_type_id;

        public TimesheetDTO()
        {
        }

        public int getTimesheetId()
        {
            return this.timesheet_id;
        }

        public void setTimesheetId(int timesheet_id)
        {
            this.timesheet_id = timesheet_id;
        }

        public int getTimesheetEmployeeId()
        {
            return this.timesheet_employee_id;
        }

        public void setTimesheetEmployeeId(int timesheet_employee_id)
        {
            this.timesheet_employee_id = timesheet_employee_id;
        }

        public DateTime getDateTime()
        {
            return this.dateTime;
        }

        public void setDateTime(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public int getTimesheetTypeId()
        {
            return this.timesheet_type_id;
        }

        public void setTimesheetTypeId(int timesheet_type_id)
        {
            this.timesheet_type_id = timesheet_type_id;
        }

    }
}