using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AccountsSystem_AliAL_Ward_Development.PL.Account
{
    public partial class frm_Accont : Form
    {
        BL.Account.cls_acconts acc = new BL.Account.cls_acconts();
        public frm_Accont()
        {
            InitializeComponent();
            fill_acc();


        }

        void fill_acc()
        {
            cret_node();
            com_rep.DataSource = acc.get_all_fainlacc();
            com_rep.ValueMember = "Acc_Rep_No";
            com_rep.DisplayMember = "Acc_Rep_Aname";

            com_tyep_acc.DataSource = acc.get_all_acctyep();
            com_tyep_acc.ValueMember = "Acc_Type_No";
            com_tyep_acc.DisplayMember = "Acc_Type_Aname";
        }

        private void cret_node()
        {
            TreeNode tn ;
            tre_accont.Nodes.Clear();
            DataView dv = new DataView(acc.get_all_acconts());
            dv.RowFilter = "Acc_Parent_No=0";
            foreach (DataRowView drv in dv)
            {
                tn = new TreeNode(drv["Acc_No"].ToString() + "   " + drv["Acc_Aname"].ToString());
                tn.Tag = drv["Acc_No"].ToString();
                tre_accont.Nodes.Add(tn);
            }

            foreach(TreeNode tnode in tre_accont.Nodes)
            {
                node_child(tnode);
            }
        }
        void node_child(TreeNode nd)
        {
            TreeNode ctn ;
            DataView dv = new DataView(acc.get_all_acconts());
            dv.RowFilter = "Acc_Parent_No="+Convert.ToInt64( nd.Tag);
            foreach (DataRowView drv in dv)
            {
                ctn = new TreeNode(drv["Acc_No"].ToString() + "   " + drv["Acc_Aname"].ToString());
                ctn.Tag = drv["Acc_No"].ToString();
                nd.Nodes.Add(ctn);
                node_child(ctn);
            }
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
        private void but_new_Click(object sender, EventArgs e)
        {
            
            tex_no_acc.Enabled = true;
            tex_no_acc.Text = "";
            tex_no_acc.Focus();
            tex_fa_acc.Enabled = true;
            tex_fa_acc.Text = "";
            tex_name_acc.Enabled = true;
            tex_name_acc.Text = "";
            tex_lav_acc.Enabled = true;
            tex_lav_acc.Text = "";
            but_save.Enabled = true;
            com_rep.Enabled = true;
            com_tyep_acc.Enabled = true;
      

        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void com_rep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tre_accont_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tex_tag.Text = tre_accont.SelectedNode.Tag.ToString();
            but_save.Enabled = false;

        }

        private void tex_tag_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = acc.Get_accont_Alone(Convert.ToInt32(tex_tag.Text));
            if (dt.Rows.Count > 0)
            {
                tex_no_acc.Text = dt.Rows[0][0].ToString();
                tex_fa_acc.Text = dt.Rows[0][1].ToString();
                tex_name_acc.Text = dt.Rows[0][2].ToString();
                tex_lav_acc.Text = dt.Rows[0][3].ToString();
                tex_mad.Text = dt.Rows[0][4].ToString();
                tex_dan.Text = dt.Rows[0][5].ToString();
                tex_ras.Text = dt.Rows[0][6].ToString();
                com_rep.SelectedValue = dt.Rows[0][7].ToString();
                com_tyep_acc.SelectedValue = dt.Rows[0][8].ToString();

            }
        }

        private void tex_no_acc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar>=48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                acc.add_accoant(Convert.ToInt32(tex_no_acc.Text), Convert.ToInt32(tex_fa_acc.Text), tex_name_acc.Text, Convert.ToInt32(tex_lav_acc.Text), Convert.ToDouble(tex_mad.Text), Convert.ToDouble(tex_dan.Text), Convert.ToDouble(tex_ras.Text), Convert.ToInt32(com_rep.SelectedValue), Convert.ToInt32(com_tyep_acc.SelectedValue));
                cret_node();
                but_save.Enabled = false;

                MessageBox.Show("تم الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch
            {
                MessageBox.Show("هناك خطأ في ادخال البيانات يجب تصحيحة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            try {
          
                acc.update_accoant(Convert.ToInt32(tex_no_acc.Text), Convert.ToInt32(tex_fa_acc.Text), tex_name_acc.Text, Convert.ToInt32(tex_lav_acc.Text), Convert.ToDouble(tex_mad.Text), Convert.ToDouble(tex_dan.Text), Convert.ToDouble(tex_ras.Text), Convert.ToInt32(com_rep.SelectedValue), Convert.ToInt32(com_tyep_acc.SelectedValue));
                cret_node();
               

                MessageBox.Show("تم التعديل بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("هناك خطأ في ادخال البيانات يجب تصحيحة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





        }

        private void but_del_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = acc.jounr_test(Convert.ToInt32(tex_no_acc.Text));
            if (dt1.Rows.Count > 0)
            {
                MessageBox.Show("هذا الحساب قد أجريت علية عملية حسابية لايمكن حذفة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = new DataTable();
            dt = acc.Accoant_test(Convert.ToInt32(tex_no_acc.Text));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("هذا الحساب مرتبط بحسابات فرعية لايمكن حذفة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if ((MessageBox.Show("هل أنت متأكد من حذف هذا السجل", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {
                acc.del_acc(Convert.ToInt32(tex_no_acc.Text));
                cret_node();
                clarrdata();
                MessageBox.Show("تم الحذف بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                }



            }
        
    }
}
