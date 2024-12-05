using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsSystem_AliAL_Ward_Development.PL.Account
{
    public partial class frm_saersh : Form
    {
        public bool isok = false;
        public frm_saersh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tex_shersh_TextChanged(object sender, EventArgs e)
        {
            BL.Account.cls_acconts acc = new BL.Account.cls_acconts();
            data_grid.DataSource = acc.sarsh_accont(tex_shersh.Text);
            data_grid.Columns[0].HeaderText = "رقم الحساب";
            data_grid.Columns[1].Visible = false;
            data_grid.Columns[2].HeaderText = "اسم الحساب";
            data_grid.Columns[3].Visible = false;
            data_grid.Columns[4].Visible = false;
            data_grid.Columns[5].Visible = false;
            data_grid.Columns[6].Visible = false;
            data_grid.Columns[7].Visible = false;
            data_grid.Columns[8].Visible = false;

        }

        private void data_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isok = true;
            Close();
        }
    }
}
