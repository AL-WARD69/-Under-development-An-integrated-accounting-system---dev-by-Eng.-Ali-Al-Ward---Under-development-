using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
namespace AccountsSystem_AliAL_Ward_Development.PL.Systemformat
{
    public partial class frm_curr : Form
    {
        BL.Systemformat.cls_curr curr = new BL.Systemformat.cls_curr();
        public frm_curr()
        {
            InitializeComponent();
            data_view();
        }
        void data_view()
        {
            data_grid.DataSource = curr.get_all_curr();
            data_grid.Columns[0].Visible = false;
            data_grid.Columns[1].HeaderText = "اسم العملة";
            data_grid.Columns[2].Visible = false;
            data_grid.Columns[3].HeaderText = "رمز العملة";
            data_grid.Columns[4].HeaderText = "سعر الصرف";
            data_grid.Columns[5].Visible = false;
            data_grid.Columns[6].Visible = false;


        }
        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_new_Click(object sender, EventArgs e)
        {
            tex_aname.Enabled = true;
            tex_aname.Text = "";
            tex_aname.Focus();
            tex_ename.Enabled = true;
            tex_ename.Text = "";
            tex_S.Enabled = true;
            tex_S.Text = "";
            tex_R.Enabled = true;
            tex_R.Text = "";
            tex_F.Enabled = true;
            tex_F.Text = "";
            rd_A_curr.Enabled = true;
            rd_M_curr.Enabled = true;
            but_save.Enabled = true;
            but_edit.Enabled = true;
            but_del.Enabled = true;
            data_grid.Enabled = true;

        }

        private void tex_aname_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-ye"));

        }

        private void tex_ename_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try { 
            int ty = 0;

            if (rd_M_curr.Checked == true)
            {
                ty = 1;
            }
            else
            {
                ty = 0;
            }

            curr.add_curr(tex_aname.Text, tex_ename.Text, tex_R.Text, Convert.ToDouble(tex_S.Text), tex_F.Text, ty);
            MessageBox.Show("تم الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            data_view();
            }
            catch (Exception ex)
            {
                MessageBox.Show("هناك خطأ يرجى التأكد من صحة البيانات" + ex);
            }

        }

        private void data_grid_DoubleClick(object sender, EventArgs e)
        {
            tex_aname.Text = data_grid.CurrentRow.Cells[1].Value.ToString();
            tex_ename.Text = data_grid.CurrentRow.Cells[2].Value.ToString();
            tex_R.Text = data_grid.CurrentRow.Cells[3].Value.ToString();
            Convert.ToDouble(tex_S.Text = data_grid.CurrentRow.Cells[4].Value.ToString());
            tex_F.Text = data_grid.CurrentRow.Cells[5].Value.ToString();
            if (Convert.ToInt32(data_grid.CurrentRow.Cells[6].Value) == 1)
            {
                rd_M_curr.Checked = true;
            }
            else
            {
                rd_A_curr.Checked = true;

            }
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            try {
            int ty = 0;

            if (rd_M_curr.Checked == true)
            {
                ty = 1;
            }
            else
            {
                ty = 0;
            }
            int curron = Convert.ToInt32(data_grid.CurrentRow.Cells[0].Value);
            curr.update_curr(curron, tex_aname.Text, tex_ename.Text, tex_R.Text, Convert.ToDouble(tex_S.Text), tex_F.Text, ty);
            MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            data_view();
            }
            catch (Exception ex)
            {
                MessageBox.Show("هناك خطأ يرجى التأكد من صحة البيانات" + ex);
            }
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            try { 
            if ((MessageBox.Show("هل أنت متأكد من حذف هذا السجل", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {
                curr.del_curr(Convert.ToInt32(data_grid.CurrentRow.Cells[0].Value));
                data_view();
                MessageBox.Show("تم الحذف بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (var c in groupBox2.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;

                    }
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هناك خطأ يرجى التأكد من صحة البيانات" + ex);
            }


        }
    }
}
