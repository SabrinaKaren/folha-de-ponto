using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folha_de_ponto.code.data
{
    class TokenWithValidateData
    {

        private String token;
        private DateTime validate;

        public TokenWithValidateData()
        {
        }

        public TokenWithValidateData(String token, DateTime validate)
        {
            this.token = token;
            this.validate = validate;
        }

        public String getToken()
        {
            return this.token;
        }

        public void setToken(String token)
        {
            this.token = token;
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