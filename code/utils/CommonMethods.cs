using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folha_de_ponto.code.utils
{
    class CommonMethods
    {

        public String generateRandomString(int size)
        {

            String randomString = "";

            String allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVYWXZ0123456789abcdefghijklmnopqrstuvywxz";

            char[] chars = new char[size];
            Random rd = new Random();
            for (int i = 0; i < size; i++)
            {
                chars[i] = allowedCharacters[rd.Next(0, allowedCharacters.Length)];
            }

            randomString = new string(chars);

            return randomString;

        }

        public string convertDateTimeInDbFormatString(DateTime brazilDateTime)
        {
            return String.Format("{0:yyyy-MM-dd HH:mm:ss}", brazilDateTime);
        }

        public Boolean tokenIsValidate(String token, DateTime tokenValidate)
        {

            if (token == null || "".Equals(token) || tokenValidate == null)
            {
                return false;
            }

            DateTime now = DateTime.Now;

            if (now.CompareTo(tokenValidate) > 0)
            {
                return false;
            }

            return true;

        }

    }
}