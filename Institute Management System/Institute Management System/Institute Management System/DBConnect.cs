using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Institute_Management_System
{
    class DBConnect
    {
        public static SqlConnection connection;

        public bool OpenConnection()
        {
            string strCn = ConfigurationManager.ConnectionStrings["MyConNew"].ConnectionString;
            encrypter encr = new encrypter();
            string str_cn_new = strCn;
            int userid_ind = str_cn_new.LastIndexOf(";User ID") + 9;
            int password_ind = str_cn_new.LastIndexOf(";Password") + 10;
            int unocode_index = str_cn_new.LastIndexOf(";Persist Security Info") + 9;

            string userid = str_cn_new.Substring(userid_ind, (password_ind - userid_ind - 10));

            string passowrd = str_cn_new.Substring(password_ind, unocode_index - password_ind - 9);

            string decr_username = encr.DecryptString(userid);
            string decr_password = encr.DecryptString(passowrd);

            str_cn_new = str_cn_new.Replace(userid, decr_username);
            str_cn_new = str_cn_new.Replace(passowrd, decr_password);
            connection = new SqlConnection(str_cn_new);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable ExecuteDataTable(string Query)
        {
            SqlDataAdapter da = new SqlDataAdapter(Query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
