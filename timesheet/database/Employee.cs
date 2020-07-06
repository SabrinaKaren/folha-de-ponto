using System;
using System.Collections.Generic;
using System.Text;

namespace timesheet.database
{
    class Employee
    {

        private int employee_id;
        private string name;
        private string user;
        private string password;

        public Employee()
        {
        }

        public int getEmployeeId()
        {
            return this.employee_id;
        }

        public void setEmployeeId(int employee_id)
        {
            this.employee_id = employee_id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getUser()
        {
            return this.user;
        }

        public void setUser(string user)
        {
            this.user = user;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

    }

}