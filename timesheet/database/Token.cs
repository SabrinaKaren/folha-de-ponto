using System;
using System.Collections.Generic;
using System.Text;

namespace timesheet.database
{
    class Token
    {

        private int token_id;
        private int token_employee_id;
        private string token;
        private DateTime begin;
        private DateTime validate;

        public Token()
        {
        }

        public int getTokenId()
        {
            return this.token_id;
        }

        public void setTokenId(int tokenId)
        {
            this.token_id = tokenId;
        }

        public int getTokenEmployeeId()
        {
            return this.token_employee_id;
        }

        public void setTokenEmployeeId(int tokenEmployeeId)
        {
            this.token_employee_id = tokenEmployeeId;
        }

        public string getToken()
        {
            return this.token;
        }

        public void setToken(string token)
        {
            this.token = token;
        }

        public DateTime getBegin()
        {
            return this.begin;
        }

        public void setBegin(DateTime begin)
        {
            this.begin = begin;
        }

        public DateTime getValidate()
        {
            return this.validate;
        }

        public void setValidate(DateTime validate)
        {
            this.validate = validate;
        }

    }
}