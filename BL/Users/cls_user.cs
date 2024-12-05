using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AccountsSystem_AliAL_Ward_Development.BL.Users
{
    class cls_user
    {
        #region get_all_user

        public DataTable get_all_user()
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            dt = conn.selectData("Get_All_Users", null);
            conn.cloasConn();

            return dt;
        }
        #endregion
        #region Get_Users_Alone

        public DataTable Get_Users_Alone(string uname)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@U_Fname", SqlDbType.NVarChar, 60);
            para[0].Value = uname;
            dt = conn.selectData("Get_Users_Alone", para);
            conn.cloasConn();

            return dt;
        }
        #endregion
        
        #region add_user
        public void add_user(string name, string user, string pass, string tel, string emil, int stt ,int type, Byte[] img)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@U_Fname", SqlDbType.NVarChar, 60);
            para[0].Value = name;
            para[1] = new SqlParameter("@U_Name", SqlDbType.NVarChar, 60);
            para[1].Value = user;
            para[2] = new SqlParameter("@U_PWD", SqlDbType.NVarChar, 50);
            para[2].Value = pass;
            para[3] = new SqlParameter("@U_Tel", SqlDbType.NVarChar, 20);
            para[3].Value = tel;
            para[4] = new SqlParameter("@U_Email", SqlDbType.NVarChar, 50);
            para[4].Value = emil;
            para[5] = new SqlParameter("@U_stat", SqlDbType.Int);
            para[5].Value = stt;
            para[6] = new SqlParameter("@U_type", SqlDbType.Int);
            para[6].Value = type;
            para[7] = new SqlParameter("@U_IMG", SqlDbType.Image);
            para[7].Value = img;

            conn.ExcuCmd("User_Add ", para);
            conn.cloasConn();

        }


        #endregion

        #region update_user
        public void update_user(int uno,string name, string user, string pass, string tel, string emil, int stt, int type, Byte[] img)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@U_No", SqlDbType.Int);
            para[0].Value = uno;
            para[1] = new SqlParameter("@U_Fname", SqlDbType.NVarChar, 60);
            para[1].Value = name;
            para[2] = new SqlParameter("@U_Name", SqlDbType.NVarChar, 60);
            para[2].Value = user;
            para[3] = new SqlParameter("@U_PWD", SqlDbType.NVarChar, 50);
            para[3].Value = pass;
            para[4] = new SqlParameter("@U_Tel", SqlDbType.NVarChar, 20);
            para[4].Value = tel;
            para[5] = new SqlParameter("@U_Email", SqlDbType.NVarChar, 50);
            para[5].Value = emil;
            para[6] = new SqlParameter("@U_stat", SqlDbType.Int);
            para[6].Value = stt;
            para[7] = new SqlParameter("@U_type", SqlDbType.Int);
            para[7].Value = type;
            para[8] = new SqlParameter("@U_IMG", SqlDbType.Image);
            para[8].Value = img;

            conn.ExcuCmd("User_Update", para);
            conn.cloasConn();

        }


        #endregion




        #region del_user
        public void del_user(int uno)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@U_No", SqlDbType.Int);
            para[0].Value = uno;
            conn.ExcuCmd("User_Del ", para);
            conn.cloasConn();
        }
        #endregion
    }
}
