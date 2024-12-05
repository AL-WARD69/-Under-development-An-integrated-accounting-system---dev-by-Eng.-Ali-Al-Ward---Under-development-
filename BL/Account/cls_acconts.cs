using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccountsSystem_AliAL_Ward_Development.BL.Account
{
    class cls_acconts
    {
        public DataTable get_all_fainlacc()
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            dt = conn.selectData("Get_all_AccReports", null);
            conn.cloasConn();

            return dt;
        }
        public DataTable get_all_acctyep()
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            dt = conn.selectData("Get_all_AccTypes", null);
            conn.cloasConn();

            return dt;
        }

        public DataTable get_all_acconts()
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            dt = conn.selectData("Get_Acc_All", null);
            conn.cloasConn();

            return dt;
        }
        public DataTable Get_accont_Alone(int accNo)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = accNo;
            dt = conn.selectData("Get_acc_alons", para);
            conn.cloasConn();

            return dt;
        }
        public DataTable Accoant_test(int accNo)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = accNo;
            dt = conn.selectData("Accoant_test", para);
            conn.cloasConn();

            return dt;
        }
        public DataTable jounr_test(int accNo)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Acc__No", SqlDbType.Int);
            para[0].Value = accNo;
            dt = conn.selectData("jounr_test", para);
            conn.cloasConn();

            return dt;
        }
        public void add_accoant(int noacc, int Pacc, string nameacc, int accolav, double mad, double dan, double ras, int accrep,int acctyp)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = noacc;
            para[1] = new SqlParameter("@Acc_Parent_No", SqlDbType.Int);
            para[1].Value = Pacc;
            para[2] = new SqlParameter("@Acc_Aname", SqlDbType.NVarChar, 100);
            para[2].Value = nameacc;
            para[3] = new SqlParameter("@Acc_Level", SqlDbType.Int);
            para[3].Value = accolav;
            para[4] = new SqlParameter("@Acc_Debit", SqlDbType.Decimal);
            para[4].Value = mad;
            para[5] = new SqlParameter("@Acc_Credit", SqlDbType.Decimal);
            para[5].Value = dan;
            para[6] = new SqlParameter("@Acc_Balance", SqlDbType.Decimal);
            para[6].Value = ras;
            para[7] = new SqlParameter("@Acc_Report", SqlDbType.Int);
            para[7].Value = accrep;
            para[8] = new SqlParameter("@Acc_Type", SqlDbType.Int);
            para[8].Value = acctyp;

            conn.ExcuCmd("Acc_Add ", para);
            conn.cloasConn();

        }

        public void update_accoant(int noacc, int Pacc, string nameacc, int accolav, double mad, double dan, double ras, int accrep, int acctyp)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = noacc;
            para[1] = new SqlParameter("@Acc_Parent_No", SqlDbType.Int);
            para[1].Value = Pacc;
            para[2] = new SqlParameter("@Acc_Aname", SqlDbType.NVarChar, 100);
            para[2].Value = nameacc;
            para[3] = new SqlParameter("@Acc_Level", SqlDbType.Int);
            para[3].Value = accolav;
            para[4] = new SqlParameter("@Acc_Debit", SqlDbType.Decimal);
            para[4].Value = mad;
            para[5] = new SqlParameter("@Acc_Credit", SqlDbType.Decimal);
            para[5].Value = dan;
            para[6] = new SqlParameter("@Acc_Balance", SqlDbType.Decimal);
            para[6].Value = ras;
            para[7] = new SqlParameter("@Acc_Report", SqlDbType.Int);
            para[7].Value = accrep;
            para[8] = new SqlParameter("@Acc_Type", SqlDbType.Int);
            para[8].Value = acctyp;

            conn.ExcuCmd("Acc_Update", para);
            conn.cloasConn();

        }
        public void del_acc(int noacc)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = noacc;
            conn.ExcuCmd("Acc_Del ", para);
            conn.cloasConn();
        }

        public DataTable sarsh_accont(string txt)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@txt", SqlDbType.NVarChar, 20);
            para[0].Value = txt;
            dt = conn.selectData("sarsh_accoant", para);
            conn.cloasConn();

            return dt;
        }
    }
}
