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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void بياناتالاتصالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Systemformat.frm_conform cf = new PL.Systemformat.frm_conform();
            cf.ShowDialog();
        }

        private void بياناتالشركةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.frm_comp cf = new PL.frm_comp();
            cf.ShowDialog();
        }

        private void المستخدمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Users.frm_users cf = new PL.Users.frm_users();
            cf.ShowDialog();
        }

        private void دليلالحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Account.frm_Accont fa = new PL.Account.frm_Accont();
            fa.ShowDialog();
        }

        private void الصناديقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Systemformat.frm_cash fc = new PL.Systemformat.frm_cash();
            fc.Text = "الصناديق";
            fc.groupBox1.Text = "الصناديق";
            fc.tex_fun.Text = "1";
            fc.ShowDialog();
        }

        private void البنوكToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Systemformat.frm_cash fc = new PL.Systemformat.frm_cash();
            fc.Text = "البنوك";
            fc.groupBox1.Text = "البنوك";
            fc.tex_fun.Text = "2";
            fc.ShowDialog();
        }

        private void العملاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Systemformat.frm_curr curr = new PL.Systemformat.frm_curr();
            curr.ShowDialog();
        }

        private void قيداليوميةالعامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Jou.frm_Jou jou = new PL.Jou.frm_Jou();
            jou.ShowDialog();
        }
    }
}
