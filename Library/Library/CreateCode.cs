using System;
using System.Collections.Generic;
using System.Text;
using Oracle.DataAccess.Client;

namespace Library
{
    class CreateCode
    {
      
        public string getLibraryCode(int code1, int code2)
        {
            int code = getCode(code1, code2);
            code1 += 65;
            code2 += 65;
            if (code2 > 90)
            {
                code2 += 6;
            }
            char code3 = Convert.ToChar(code1);
            char code4 = Convert.ToChar(code2);

            string result = code3.ToString() + code4.ToString() + "-" + code.ToString("D3");
            return result;
        }

        public string getCityCode(int code1, int code2)
        {
            
            code1 += 65;
            code2 += 65;
            if (code2 > 90)
            {
                code2 += 6;
            }
            int codesum = code1 + code2;
            char code3 = Convert.ToChar(code1);
            char code4 = Convert.ToChar(code2);

            string result = code3.ToString() + code4.ToString() + "-" + codesum.ToString();
            return result;
        }

        private int getCode(int code1, int code2)
        {
            int code = 0;
            string strConn = "Data Source=solution;User id=mighty_ems;Password=mighty_ems;";
            string plant = getCityCode(code1, code2);
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT count(*) FROM sys_system_code_jh WHERE plant ='" + plant + "'";

            OracleDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                code = Int32.Parse(rdr["count(*)"].ToString());
            }
            conn.Close();
            rdr.Close();

            return code;
        }
    }
}
