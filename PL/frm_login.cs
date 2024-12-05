using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsSystem_AliAL_Ward_Development.PL
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void but_LOGIN_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BL.Users.login log = new BL.Users.login();
            dt = log.loggin(tex_user.Text, tex_PWS.Text);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                frm_Main frm = new PL.frm_Main();
                frm.Show();
            }
            else
            {
                MessageBox.Show("تأكد من كتابة اسم المسخدم وكلمة المرور بشكل صحيح");
            }
        }

        private void tex_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_PWS.Focus();
            }
        }

        private void tex_PWS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                but_LOGIN.Focus();
            }
        }
    }
}
