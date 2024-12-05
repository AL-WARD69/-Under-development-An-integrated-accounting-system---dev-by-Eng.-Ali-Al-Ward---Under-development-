using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AccountsSystem_AliAL_Ward_Development.BL.Users
{
    class login
    {

        public DataTable loggin(string user,string pwd)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@U_name", SqlDbType.NVarChar, 60);
            para[0].Value = user;
            para[1] = new SqlParameter("@pwd", SqlDbType.NVarChar, 50);
            para[1].Value = pwd;
            DataTable dt = new DataTable();
            dt = conn.selectData("test_login", para);
            conn.cloasConn();
            return dt;
        }



    }
}
