using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;
namespace AccountsSystem_AliAL_Ward_Development.PL.Users
{
    public partial class frm_users : Form
    {

        BL.Users.cls_user us = new BL.Users.cls_user();
        public frm_users()
        {
            InitializeComponent();
            data_view();
        }
         void data_view()
        {
            data_grid.DataSource = us.get_all_user();
            data_grid.Columns[0].Visible = false;
            data_grid.Columns[1].HeaderText = "اسم الرباعي";
            data_grid.Columns[2].HeaderText = "اسم المستخدم";
            data_grid.Columns[3].Visible = false;
            data_grid.Columns[4].HeaderText = "التلفون";
            data_grid.Columns[5].HeaderText = "البريد الالكتروني";
            data_grid.Columns[6].Visible = false;
            data_grid.Columns[7].Visible = false;
            data_grid.Columns[8].Visible = false;

          
        }
        private void but_new_Click(object sender, EventArgs e)
        {
            tex_name.Enabled = true;
            tex_name.Text = "";
            tex_name.Focus();

            tex_user.Enabled = true;
            tex_user.Text = "";

            tex_pwd.Enabled = true;
            tex_pwd.Text = "";

            tex_emil.Enabled = true;
            tex_emil.Text = "";

            tex_phon.Enabled = true;
            tex_phon.Text = "";

            but_brwos.Enabled = true;

            but_char.Enabled = true;

            but_save.Enabled = true;
            but_edit.Enabled = true;
            but_del.Enabled = true;
            data_grid.Enabled = true;

            tex_shersh.Enabled = true;
            img_user.Image = null;
        }

        private void but_brwos_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.FileName = "All file|*.gif;*.jpg;*png;*bmp";
            if (of.ShowDialog() == DialogResult.OK)
            {
                img_user.Image = Image.FromFile(of.FileName);
            }
        }

        private void but_char_Click(object sender, EventArgs e)
        {
            img_user.Image = null;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tex_name_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-ye"));

        }

        private void tex_user_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void tex_pwd_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void tex_emil_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void tex_phon_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void tex_emil_Validated(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+$");
            if (!re.IsMatch(tex_emil.Text))
            {
                MessageBox.Show("تأكد من كتابة البريد الالكتروني بشكل صحيح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tex_emil.Focus();
            }
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bim;
                int st = 0;
                int ty = 0;
                if (rd_stop.Checked == true)
                {
                    st = 1;
                }
                else
                {
                    st = 0;
                }
                if (rd_manger.Checked == true)
                {
                    ty = 1;
                }
                else
                {
                    ty = 0;
                }

                if (img_user.Image == null)
                {
                    MessageBox.Show("يجب اضافة صورة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    MemoryStream me = new MemoryStream();
                    img_user.Image.Save(me, img_user.Image.RawFormat);
                    byte[] bytee = me.ToArray();

                    us.add_user(tex_name.Text, tex_user.Text, tex_pwd.Text, tex_phon.Text, tex_emil.Text, st, ty, bytee);
                    MessageBox.Show("تم الحفظ بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data_view();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("هناك خطأ يرجى التأكد من صحة البيانات" + ex);
            }
               
                       
        }

        private void data_grid_DoubleClick(object sender, EventArgs e)
        {
            tex_name.Text = data_grid.CurrentRow.Cells[1].Value.ToString();
            tex_user.Text = data_grid.CurrentRow.Cells[2].Value.ToString();
            tex_pwd.Text = data_grid.CurrentRow.Cells[3].Value.ToString();
            tex_phon.Text = data_grid.CurrentRow.Cells[4].Value.ToString();
            tex_emil.Text = data_grid.CurrentRow.Cells[5].Value.ToString();
            if (Convert.ToInt32(data_grid.CurrentRow.Cells[6].Value) == 1)
            {
                rd_stop.Checked = true;
            }
            else
            {
                rd_stop.Checked = false;

            }
            if (Convert.ToInt32(data_grid.CurrentRow.Cells[7].Value) == 1)
            {
                rd_manger.Checked = true;
            }
            else
            {
                rd_mhdod.Checked = true;

            }
            byte[] bb = (byte[])data_grid.CurrentRow.Cells[8].Value;
            MemoryStream me = new MemoryStream(bb);
            img_user.Image = Image.FromStream(me);
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
         
                byte[] bim;
                int st = 0;
                int ty = 0;
                if (rd_stop.Checked == true)
                {
                    st = 1;
                }
                else
                {
                    st = 0;
                }
                if (rd_manger.Checked == true)
                {
                    ty = 1;
                }
                else
                {
                    ty = 0;
                }

                if (img_user.Image == null)
                {
                    MessageBox.Show("يجب اضافة صورة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    MemoryStream me = new MemoryStream();
                    img_user.Image.Save(me, img_user.Image.RawFormat);
                    byte[] bytee = me.ToArray();
                    int uon = Convert.ToInt32(data_grid.CurrentRow.Cells[0].Value);
                    us.update_user(uon,tex_name.Text, tex_user.Text, tex_pwd.Text, tex_phon.Text, tex_emil.Text, st, ty, bytee);
                    MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data_view();

                }

            
           
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("هل أنت متأكد من حذف هذا السجل", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {
                us.del_user(Convert.ToInt32(data_grid.CurrentRow.Cells[0].Value));
                data_view();
                MessageBox.Show("تم الحذف بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;
                        ((TextBox)c).Enabled = false;
                    }
                }

                but_brwos.Enabled = false;
                img_user.Image = null;


            }
        }

        private void data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tex_shersh_TextChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();

            dt1 = us.Get_Users_Alone(tex_shersh.Text);

            this.data_grid.DataSource = dt1;

        }

        private void tex_shersh_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
    }
}
