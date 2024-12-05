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
    public partial class frm_cash : Form
    {

        BL.Systemformat.cls_cash cf = new BL.Systemformat.cls_cash();
        public frm_cash()
        {
            InitializeComponent();
        }

        void showw()
        {
            data_grid.DataSource = cf.Get_all_cash(Convert.ToInt32(tex_fun.Text));
            data_grid.Columns[0].HeaderText = "رقم الحساب";
            data_grid.Columns[1].HeaderText = "اسم الحساب";
      
        }
        void clarrdata()
        {
            foreach (var c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }
        private void but_dis_Click(object sender, EventArgs e)
        {
            showw();

        }

        private void but_new_Click(object sender, EventArgs e)
        {
            tex_no_acc.Text = string.Empty;
            tex_name_acc.Text = string.Empty;
            tex_no_acc.Enabled = true;
            tex_no_acc.Focus();
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tex_no_acc_KeyDown(object sender, KeyEventArgs e)
        {
            PL.Account.frm_saersh fm = new PL.Account.frm_saersh();
            if (e.KeyCode == Keys.Enter)
            {
                fm.tex_shersh.Text = tex_no_acc.Text;
                fm.ShowDialog();
                if (fm.isok == true)
                {
                    tex_no_acc.Text = fm.data_grid.CurrentRow.Cells[0].Value.ToString();
                    tex_name_acc.Text = fm.data_grid.CurrentRow.Cells[2].Value.ToString();
                    but_save.Focus();

                }
            }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
         
                cf.add_cash(Convert.ToInt32(tex_no_acc.Text), tex_name_acc.Text, Convert.ToInt32(tex_fun.Text));
                showw();
                MessageBox.Show("تم الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("هل أنت متأكد من حذف هذا السجل", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {
                cf.del_cash(Convert.ToInt32(tex_no_acc.Text), Convert.ToInt32(tex_fun.Text));
                showw();
                clarrdata();
                MessageBox.Show("تم الحذف بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void data_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tex_no_acc.Text = data_grid.CurrentRow.Cells[0].Value.ToString();
            tex_name_acc.Text = data_grid.CurrentRow.Cells[1].Value.ToString();

        }

        private void data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
