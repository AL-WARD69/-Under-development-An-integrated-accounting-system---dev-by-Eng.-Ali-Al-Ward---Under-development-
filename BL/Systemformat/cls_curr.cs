using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AccountsSystem_AliAL_Ward_Development.BL.Systemformat
{
    class cls_curr
    {
        #region get_all_curr

        public DataTable get_all_curr()
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            dt = conn.selectData("Get_Curr_All", null);
            conn.cloasConn();

            return dt;
        }
        #endregion
       

        #region add_curr
        public void add_curr(string aname, string ename, string rmz, double sarf, string fak, int type)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@Curr_Aname", SqlDbType.NVarChar, 20);
            para[0].Value = aname;
            para[1] = new SqlParameter("@Curr_Ename", SqlDbType.NVarChar, 20);
            para[1].Value = ename;
            para[2] = new SqlParameter("@Curr_Symbol", SqlDbType.NVarChar, 3);
            para[2].Value = rmz;
            para[3] = new SqlParameter("@Curr_Exch", SqlDbType.Decimal);
            para[3].Value = sarf;
            para[4] = new SqlParameter("@Curr_Part", SqlDbType.NVarChar, 10);
            para[4].Value = fak;
            para[5] = new SqlParameter("@Curr_Type", SqlDbType.Int);
            para[5].Value = type;
           conn.ExcuCmd("Curr_Add ", para);
            conn.cloasConn();

        }


        #endregion

        #region update_curr
        public void update_curr(int crrno,string aname, string ename, string rmz, double sarf, string fak, int type)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@Curr_No", SqlDbType.Int);
            para[0].Value = crrno;
            para[1] = new SqlParameter("@Curr_Aname", SqlDbType.NVarChar, 20);
            para[1].Value = aname;
            para[2] = new SqlParameter("@Curr_Ename", SqlDbType.NVarChar, 20);
            para[2].Value = ename;
            para[3] = new SqlParameter("@Curr_Symbol", SqlDbType.NVarChar, 3);
            para[3].Value = rmz;
            para[4] = new SqlParameter("@Curr_Exch", SqlDbType.Decimal);
            para[4].Value = sarf;
            para[5] = new SqlParameter("@Curr_Part", SqlDbType.NVarChar, 10);
            para[5].Value = fak;
            para[6] = new SqlParameter("@Curr_Type", SqlDbType.Int);
            para[6].Value = type;
            conn.ExcuCmd("Curr_Update", para);
            conn.cloasConn();

        }


        #endregion




        #region del_curr
        public void del_curr(int currno)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Curr_No", SqlDbType.Int);
            para[0].Value = currno;
            conn.ExcuCmd("Curr_Del ", para);
            conn.cloasConn();
        }
        #endregion
    }
}
