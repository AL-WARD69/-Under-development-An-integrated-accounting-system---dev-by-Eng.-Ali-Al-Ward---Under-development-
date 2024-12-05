using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsSystem_AliAL_Ward_Development.PL.Systemformat
{
    public partial class frm_conform : Form
    {
        public frm_conform()
        {
            InitializeComponent();
        }

        private void tex_mode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_server.Focus();
            }
        }

        private void tex_server_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_DB.Focus();
            }
        }

        private void tex_DB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_user.Focus();
            }
        }

        private void tex_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_pwd.Focus();
            }
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            tex_mode.Enabled = true;
            tex_mode.Text = "";
            tex_mode.Focus();


            tex_server.Enabled = true;
            tex_server.Text = "";

            tex_DB.Enabled = true;
            tex_DB.Text = "";

            tex_user.Enabled = true;
            tex_user.Text = "";

            tex_pwd.Enabled = true;
            tex_pwd.Text = "";

            but_save.Enabled = true;
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mode = tex_mode.Text;
            Properties.Settings.Default.server = tex_server.Text;
            Properties.Settings.Default.DB = tex_DB.Text;
            Properties.Settings.Default.user = tex_user.Text;
            Properties.Settings.Default.pwd = tex_pwd.Text;
            MessageBox.Show("تم حفظ البيانات بنجاح");


        }


        private void but_bwroser_Click(object sender, EventArgs e)
        {
            tex_mode.Text = Properties.Settings.Default.mode;
            tex_server.Text = Properties.Settings.Default.server;
            tex_DB.Text = Properties.Settings.Default.DB;
            tex_user.Text = Properties.Settings.Default.user;
            tex_pwd.Text = Properties.Settings.Default.pwd;

        }

        private void but_del_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mode = "";
            Properties.Settings.Default.server = "";
            Properties.Settings.Default.DB = "";
            Properties.Settings.Default.user = "";
            Properties.Settings.Default.pwd = "";

            MessageBox.Show("تم حذف البيانات بنجاح");

        }

        private void tex_mode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
