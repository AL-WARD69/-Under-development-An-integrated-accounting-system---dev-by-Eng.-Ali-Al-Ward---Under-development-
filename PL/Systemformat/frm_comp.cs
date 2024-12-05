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
namespace AccountsSystem_AliAL_Ward_Development.PL
{
    public partial class frm_comp : Form
    {
        BL.Systemformat.cls_copm Acomp = new BL.Systemformat.cls_copm();

        public frm_comp()
        {
            InitializeComponent();
            data_grid_all_comp();
        }
        void data_grid_all_comp()
        {
            data_grid.DataSource = Acomp.get_all_comp();
            data_grid.Columns[0].Visible = false;
            data_grid.Columns[1].HeaderText = "اسم الشركة";
            data_grid.Columns[2].Visible = false;
            data_grid.Columns[3].HeaderText = "عنوان الشركة";
            data_grid.Columns[4].Visible = false;
            data_grid.Columns[5].HeaderText = "التلفون";
            data_grid.Columns[6].HeaderText = "الفاكس";

            data_grid.Columns[7].HeaderText = "البريد الالكتروني";
            data_grid.Columns[8].HeaderText = "الموقع الالكتروني";
            data_grid.Columns[9].Visible = false;

        }
        private void but_new_Click(object sender, EventArgs e)
        {
            tex_name_ar.Enabled = true;
            tex_name_ar.Text = "";
            tex_name_ar.Focus();

            tex_name_en.Enabled = true;
            tex_name_en.Text = "";

            tex_add_ar.Enabled = true;
            tex_add_ar.Text = "";

            tex_add_en.Enabled = true;
            tex_add_en.Text = "";

            tex_email.Enabled = true;
            tex_email.Text = "";

            tex_web.Enabled = true;
            tex_web.Text = "";

            tex_phon.Enabled = true;
            tex_phon.Text = "";
            tex_fax.Enabled = true;
            tex_fax.Text = "";

            but_brwos.Enabled = true;
            tex_shersh.Enabled = true;

            but_char.Enabled = true;

            but_save.Enabled = true;
            but_edit.Enabled = true;
            but_del.Enabled = true;
            data_grid.Enabled = true;
            img_comp.Image = null;



        }

        private void tex_name_ar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_name_ar.Focus();
            }
        }

        private void tex_name_en_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_name_en.Focus();
            }
        }

        private void tex_add_ar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_add_ar.Focus();
            }
        }

    

        private void tex_add_en_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_add_en.Focus();
            }
        }

        private void tex_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_email.Focus();
            }
        }

        private void tex_web_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_web.Focus();
            }
        }

        private void tex_phon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_phon.Focus();
            }
        }

        private void tex_fax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tex_fax.Focus();
            }
        }

        private void tex_add_en_KeyPress(object sender, KeyPressEventArgs e)

        {
        }

        private void but_brwos_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.FileName = "All file|*.gif;*.jpg;*png;*bmp";
            if (of.ShowDialog() == DialogResult.OK)
            {
                img_comp.Image = Image.FromFile(of.FileName);
            }
        }

        private void but_char_Click(object sender, EventArgs e)
        {
            img_comp.Image = null;
        }
      //  private void but_exit_Click(object sender, EventArgs e)
        //{
        //}
        private void but_save_Click(object sender, EventArgs e)
        {


            if (img_comp.Image == null)
            {
                MessageBox.Show("يجب اضافة صورة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MemoryStream me = new MemoryStream();
                img_comp.Image.Save(me, img_comp.Image.RawFormat);
                byte[] bytee=me.ToArray();

                Acomp.add_copm(tex_name_ar.Text, tex_name_en.Text, tex_add_ar.Text, tex_add_en.Text, tex_phon.Text, tex_fax.Text, tex_email.Text, tex_web.Text, bytee);
                MessageBox.Show("تم الحفظ بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data_grid_all_comp();

            }


        }

        private void tex_name_ar_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-ye"));
        }

        private void tex_name_en_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void tex_add_ar_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-ye"));

        }

        private void tex_add_en_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void tex_email_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void tex_web_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void tex_phon_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void tex_fax_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void data_grid_DoubleClick(object sender, EventArgs e)
        {
            tex_name_ar.Text = data_grid.CurrentRow.Cells[1].Value.ToString();
            tex_name_en.Text = data_grid.CurrentRow.Cells[2].Value.ToString();
            tex_add_ar.Text = data_grid.CurrentRow.Cells[3].Value.ToString();
            tex_add_en.Text = data_grid.CurrentRow.Cells[4].Value.ToString();
            tex_phon.Text = data_grid.CurrentRow.Cells[5].Value.ToString();
            tex_fax.Text = data_grid.CurrentRow.Cells[6].Value.ToString();
            tex_email.Text = data_grid.CurrentRow.Cells[7].Value.ToString();
            tex_web.Text = data_grid.CurrentRow.Cells[8].Value.ToString();
            byte[] bb = (byte[])data_grid.CurrentRow.Cells[9].Value;
            MemoryStream me = new MemoryStream(bb);
            img_comp.Image = Image.FromStream(me);
        }

        private void but_edit_Click(object sender, EventArgs e)
        {

            if (img_comp.Image == null)
            {
                MessageBox.Show("يجب اضافة صورة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MemoryStream me = new MemoryStream();
                img_comp.Image.Save(me, img_comp.Image.RawFormat);
                byte[] bytee = me.ToArray();
                int con = Convert.ToInt32(data_grid.CurrentRow.Cells[0].Value);
                Acomp.update_copm(con,tex_name_ar.Text, tex_name_en.Text, tex_add_ar.Text, tex_add_en.Text, tex_phon.Text, tex_fax.Text, tex_email.Text, tex_web.Text, bytee);
                MessageBox.Show("تم التعديل بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data_grid_all_comp();

            }
        }

        private void data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_del_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("هل أنت متأكد من حذف هذا السجل", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {
                Acomp.del_copm(Convert.ToInt32(data_grid.CurrentRow.Cells[0].Value));
                data_grid_all_comp();
                MessageBox.Show("تم الحذف بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach(var c in this.Controls)
                {
                    if(c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;
                        ((TextBox)c).Enabled = false;
                    }
                }

                but_brwos.Enabled = false;
                img_comp.Image = null;


            }
        }

        private void tex_email_Validated(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+$");
            if (!re.IsMatch(tex_email.Text))
            {
                MessageBox.Show("تأكد من كتابة البريد الالكتروني بشكل صحيح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tex_email.Focus();
            }
        }

        private void tex_web_Validated(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^(\w+\.)*\w+([-.]\w+)*\.\w+$");
            if (!re.IsMatch(tex_web.Text))
            {
                MessageBox.Show("تأكد من كتابة الموقع الالكتروني بشكل صحيح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tex_web.Focus();
            }
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void tex_shersh_TextChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();

            dt1 = Acomp.get_copm_alian(tex_shersh.Text);

            this.data_grid.DataSource = dt1;
        }
    }
}
