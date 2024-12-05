using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AccountsSystem_AliAL_Ward_Development.BL.Systemformat
{
    class cls_copm
    {
        #region add_copm
        public void add_copm(string aname, string ename, string aadd, string eadd, string tel, string fax, string email, string web ,Byte[] img)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@C_Aname", SqlDbType.NVarChar, 200);
            para[0].Value = aname;
            para[1] = new SqlParameter("@C_Ename", SqlDbType.NVarChar, 200);
            para[1].Value = ename;
            para[2] = new SqlParameter("@C_Apos", SqlDbType.NVarChar, 200);
            para[2].Value = aadd;
            para[3] = new SqlParameter("@C_Epos", SqlDbType.NVarChar, 200);
            para[3].Value = eadd;
            para[4] = new SqlParameter("@C_Tel", SqlDbType.NVarChar, 50);
            para[4].Value = tel;
            para[5] = new SqlParameter("@C_Fax", SqlDbType.NVarChar, 50);
            para[5].Value = fax;
            para[6] = new SqlParameter("@C_Email", SqlDbType.NVarChar, 50);
            para[6].Value = email;
            para[7] = new SqlParameter("@C_Web", SqlDbType.NVarChar, 100);
            para[7].Value = web;
            para[8] = new SqlParameter("@C_Logo", SqlDbType.Image);
            para[8].Value = img;

            conn.ExcuCmd("Comp_Add ", para);
            conn.cloasConn();

        }
        #endregion

        #region get_all_copm

        public DataTable get_all_comp()
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            dt = conn.selectData("get_all_comp", null);
            conn.cloasConn();

            return dt;
        }
        #endregion
        #region get_copm_alian

        public DataTable get_copm_alian(string name)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@C_Aname", SqlDbType.NVarChar, 60);
            para[0].Value = name;
            dt = conn.selectData("Get_Comp_Aloan", para);
            conn.cloasConn();

            return dt;
        }
        #endregion

        #region update_copm
        public void update_copm(int Nco ,string aname, string ename, string aadd, string eadd, string tel, string fax, string email, string web, Byte[] img)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@C_No", SqlDbType.Int);
            para[0].Value = Nco;
            para[1] = new SqlParameter("@C_Aname", SqlDbType.NVarChar, 200);
            para[1].Value = aname;
            para[2] = new SqlParameter("@C_Ename", SqlDbType.NVarChar, 200);
            para[2].Value = ename;
            para[3] = new SqlParameter("@C_Apos", SqlDbType.NVarChar, 200);
            para[3].Value = aadd;
            para[4] = new SqlParameter("@C_Epos", SqlDbType.NVarChar, 200);
            para[4].Value = eadd;
            para[5] = new SqlParameter("@C_Tel", SqlDbType.NVarChar, 50);
            para[5].Value = tel;
            para[6] = new SqlParameter("@C_Fax", SqlDbType.NVarChar, 50);
            para[6].Value = fax;
            para[7] = new SqlParameter("@C_Email", SqlDbType.NVarChar, 50);
            para[7].Value = email;
            para[8] = new SqlParameter("@C_Web", SqlDbType.NVarChar, 100);
            para[8].Value = web;
            para[9] = new SqlParameter("@C_Logo", SqlDbType.Image);
            para[9].Value = img;

            conn.ExcuCmd("Comp_Update ", para);
            conn.cloasConn();

        }
        #endregion

        #region del_copm
        public void del_copm(int Nco)
        {
            DAL.CN conn = new DAL.CN();
            conn.openconn();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@C_No", SqlDbType.Int);
            para[0].Value = Nco;
            conn.ExcuCmd("Comp_Del ", para);
            conn.cloasConn();
        }
        #endregion

    }
}
