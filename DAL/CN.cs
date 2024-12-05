using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccountsSystem_AliAL_Ward_Development.DAL
{
    class CN
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();

        // الدالة التالية كونستركتر نص الاتصال
        public CN()
        {
            string mode = Properties.Settings.Default.mode;
            if (mode == "win")
            {
                conn = new SqlConnection(@"server="+ Properties.Settings.Default.server+ ";database=" + Properties.Settings.Default.DB + ";integrated security=true");

            }
            else
            {
                conn = new SqlConnection(@"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.DB + ";integrated security=false;user_id=" + Properties.Settings.Default.user + ";password=" + Properties.Settings.Default.pwd + "");

            }

        }

        // الدالة التالية لفتح الاتصال
        public void openconn()
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            
        }

        //الدالة التالية لاغلاق الاتصال
        public void cloasConn()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //الدالة التالية لتفيذ الاجراءات المخزنة في ثاعدة البيانات

        public void ExcuCmd(string sp,SqlParameter [] para)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = conn;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            cmd.ExecuteNonQuery();
        }

        // الدالة التالية تقوم بقراءة البيانات من قاعدة البيانات

        public DataTable selectData(string sp, SqlParameter[] para)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = conn;
            if (para != null)
            {
                for(int j=0; j < para.Length; j++)
                {
                    cmd.Parameters.Add(para[j]);
                }
            }

            SqlDataAdapter spd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            spd.Fill(dt);
            return dt;

        }

    }

}
