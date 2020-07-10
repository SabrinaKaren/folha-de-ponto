using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using folha_de_ponto.code.utils;
using folha_de_ponto.code.data;

namespace timesheet.database.selectCollections
{
    class TokenBLL
    {

        DatabaseAccess db = new DatabaseAccess();

        public TokenWithValidateData generateToken(int employeeId)
        {

            DataTable sqlReturn = new DataTable();
            CommonMethods commonMethods = new CommonMethods();

            try
            {
                db.connect();
                string sql = "SELECT * FROM token WHERE token_employee_id = '" + employeeId + "'";
                sqlReturn = db.getDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar recuperar os dados: " + ex.Message.ToString());
            }

            String newToken = commonMethods.generateRandomString(20);
            DateTime begin = new DateTime();
            DateTime validate = begin.AddHours(8);

            TokenDTO newTokenObj = new TokenDTO();
            newTokenObj.setTokenEmployeeId(employeeId);
            newTokenObj.setToken(newToken);
            newTokenObj.setBegin(begin);
            newTokenObj.setValidate(validate);

            if (sqlReturn.Select().Length > 0)
            {
                // atulizo o registro
                int tokenId = Convert.ToInt32(sqlReturn.Rows[0].ItemArray[1].ToString());
                newTokenObj.setTokenId(tokenId);
                this.updateToken(newTokenObj);
            } else
            {
                // insiro registro
                this.insertToken(newTokenObj);
            }

            TokenWithValidateData newTokenWithValidate = new TokenWithValidateData(newToken, validate);

            return newTokenWithValidate;

        }

        public void insertToken(TokenDTO tokenObj)
        {

            try
            {
                db.connect();
                string sql = "INSERT INTO token (token_id, token_employee_id, token, begin, validate) VALUES (NULL, '" + tokenObj.getTokenEmployeeId() +  "', '" + tokenObj.getToken() + "', '" + tokenObj.getBegin() + "', '" + tokenObj.getValidate() + "');";
                db.executeSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar inserir o token: " + ex.Message.ToString());
            }

        }

        public void updateToken(TokenDTO tokenObj)
        {

            try
            {
                db.connect();
                string sql = "UPDATE token SET token = '" + tokenObj.getToken() + "', begin = '" + tokenObj.getBegin() + "', validate = '" + tokenObj.getValidate() + "' WHERE token_id = '" + tokenObj.getTokenId() + "');";
                db.executeSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar o token: " + ex.Message.ToString());
            }

        }

    }

}