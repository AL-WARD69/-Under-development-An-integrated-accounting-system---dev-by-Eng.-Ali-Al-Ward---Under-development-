using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AccountsSystem_AliAL_Ward_Development.BL.Systemformat
{
    class cls_cash
    {
        public DataTable Get_all_cash(int test)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@cash_test", SqlDbType.Int);
            para[0].Value = test;
            dt = conn.selectData("Get_Cash_All", para);
            conn.cloasConn();

            return dt;
        }
        public void add_cash(int noacc, string nameacc, int test)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = noacc;
            para[1] = new SqlParameter("@Acc_Aname", SqlDbType.NVarChar, 100);
            para[1].Value = nameacc;
            para[2] = new SqlParameter("@test", SqlDbType.Int);
            para[2].Value = test;
            conn.ExcuCmd("Cash_Add ", para);
            conn.cloasConn();

        }

        public void del_cash(int noacc,  int test)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = noacc;
            para[1] = new SqlParameter("@test", SqlDbType.Int);
            para[1].Value = test;
            conn.ExcuCmd("Cash_Del ", para);
            conn.cloasConn();

        }

    }
}
