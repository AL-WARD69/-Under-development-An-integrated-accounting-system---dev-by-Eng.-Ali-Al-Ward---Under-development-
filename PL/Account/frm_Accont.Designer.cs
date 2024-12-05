namespace AccountsSystem_AliAL_Ward_Development.PL.Account
{
    partial class frm_Accont
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Accont));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tre_accont = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tex_ras = new System.Windows.Forms.TextBox();
            this.tex_dan = new System.Windows.Forms.TextBox();
            this.tex_mad = new System.Windows.Forms.TextBox();
            this.tex_lav_acc = new System.Windows.Forms.TextBox();
            this.tex_name_acc = new System.Windows.Forms.TextBox();
            this.tex_fa_acc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tex_no_acc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_tag = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.com_tyep_acc = new System.Windows.Forms.ComboBox();
            this.com_rep = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.but_exit = new System.Windows.Forms.Button();
            this.but_new = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.but_accoant = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tre_accont);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 550);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الدليل المحاسبي";
            // 
            // tre_accont
            // 
            this.tre_accont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tre_accont.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tre_accont.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tre_accont.Location = new System.Drawing.Point(3, 19);
            this.tre_accont.Name = "tre_accont";
            this.tre_accont.RightToLeftLayout = true;
            this.tre_accont.Size = new System.Drawing.Size(540, 528);
            this.tre_accont.TabIndex = 0;
            this.tre_accont.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_accont_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.tex_ras);
            this.groupBox2.Controls.Add(this.tex_dan);
            this.groupBox2.Controls.Add(this.tex_mad);
            this.groupBox2.Controls.Add(this.tex_lav_acc);
            this.groupBox2.Controls.Add(this.tex_name_acc);
            this.groupBox2.Controls.Add(this.tex_fa_acc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tex_no_acc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(560, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المدخلات";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelControl2.Location = new System.Drawing.Point(279, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(170, 20);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "معلومات الحساب المالي";
            // 
            // tex_ras
            // 
            this.tex_ras.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_ras.Location = new System.Drawing.Point(9, 227);
            this.tex_ras.Name = "tex_ras";
            this.tex_ras.Size = new System.Drawing.Size(321, 26);
            this.tex_ras.TabIndex = 7;
            this.tex_ras.Text = "0.00";
            this.tex_ras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_dan
            // 
            this.tex_dan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_dan.Location = new System.Drawing.Point(9, 198);
            this.tex_dan.Name = "tex_dan";
            this.tex_dan.Size = new System.Drawing.Size(321, 26);
            this.tex_dan.TabIndex = 6;
            this.tex_dan.Text = "0.00";
            this.tex_dan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_mad
            // 
            this.tex_mad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_mad.Location = new System.Drawing.Point(9, 169);
            this.tex_mad.Name = "tex_mad";
            this.tex_mad.Size = new System.Drawing.Size(321, 26);
            this.tex_mad.TabIndex = 5;
            this.tex_mad.Text = "0.00";
            this.tex_mad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_lav_acc
            // 
            this.tex_lav_acc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_lav_acc.Location = new System.Drawing.Point(9, 138);
            this.tex_lav_acc.Name = "tex_lav_acc";
            this.tex_lav_acc.Size = new System.Drawing.Size(321, 26);
            this.tex_lav_acc.TabIndex = 4;
            this.tex_lav_acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_name_acc
            // 
            this.tex_name_acc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_name_acc.Location = new System.Drawing.Point(9, 108);
            this.tex_name_acc.Name = "tex_name_acc";
            this.tex_name_acc.Size = new System.Drawing.Size(321, 26);
            this.tex_name_acc.TabIndex = 3;
            this.tex_name_acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_fa_acc
            // 
            this.tex_fa_acc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_fa_acc.Location = new System.Drawing.Point(9, 77);
            this.tex_fa_acc.Name = "tex_fa_acc";
            this.tex_fa_acc.Size = new System.Drawing.Size(321, 26);
            this.tex_fa_acc.TabIndex = 2;
            this.tex_fa_acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(380, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "دائن";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(371, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "الرصيد";
            // 
            // tex_no_acc
            // 
            this.tex_no_acc.Enabled = false;
            this.tex_no_acc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_no_acc.Location = new System.Drawing.Point(9, 47);
            this.tex_no_acc.Name = "tex_no_acc";
            this.tex_no_acc.Size = new System.Drawing.Size(321, 26);
            this.tex_no_acc.TabIndex = 1;
            this.tex_no_acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_no_acc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_no_acc_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(374, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "مدين";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(335, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "مستوى الحساب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(348, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "اسم الحساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(350, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "الحساب الأب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(351, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "رقم الحساب";
            // 
            // tex_tag
            // 
            this.tex_tag.Location = new System.Drawing.Point(315, 25);
            this.tex_tag.Name = "tex_tag";
            this.tex_tag.Size = new System.Drawing.Size(24, 20);
            this.tex_tag.TabIndex = 38;
            this.tex_tag.Visible = false;
            this.tex_tag.TextChanged += new System.EventHandler(this.tex_tag_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tex_tag);
            this.groupBox3.Controls.Add(this.com_tyep_acc);
            this.groupBox3.Controls.Add(this.com_rep);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(574, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // com_tyep_acc
            // 
            this.com_tyep_acc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_tyep_acc.FormattingEnabled = true;
            this.com_tyep_acc.Location = new System.Drawing.Point(9, 54);
            this.com_tyep_acc.Name = "com_tyep_acc";
            this.com_tyep_acc.Size = new System.Drawing.Size(297, 26);
            this.com_tyep_acc.TabIndex = 9;
            // 
            // com_rep
            // 
            this.com_rep.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_rep.FormattingEnabled = true;
            this.com_rep.Location = new System.Drawing.Point(9, 21);
            this.com_rep.Name = "com_rep";
            this.com_rep.Size = new System.Drawing.Size(297, 26);
            this.com_rep.TabIndex = 8;
            this.com_rep.SelectedIndexChanged += new System.EventHandler(this.com_rep_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(326, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "نوع الحساب";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(345, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "التقرير";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.but_exit);
            this.groupBox4.Controls.Add(this.but_new);
            this.groupBox4.Controls.Add(this.but_save);
            this.groupBox4.Controls.Add(this.but_del);
            this.groupBox4.Controls.Add(this.but_edit);
            this.groupBox4.Location = new System.Drawing.Point(574, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 114);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // but_exit
            // 
            this.but_exit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_exit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.but_exit.Image = ((System.Drawing.Image)(resources.GetObject("but_exit.Image")));
            this.but_exit.Location = new System.Drawing.Point(9, 12);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(72, 93);
            this.but_exit.TabIndex = 13;
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // but_new
            // 
            this.but_new.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_new.ForeColor = System.Drawing.Color.SlateBlue;
            this.but_new.Image = ((System.Drawing.Image)(resources.GetObject("but_new.Image")));
            this.but_new.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_new.Location = new System.Drawing.Point(358, 12);
            this.but_new.Name = "but_new";
            this.but_new.Size = new System.Drawing.Size(75, 93);
            this.but_new.TabIndex = 11;
            this.but_new.Text = "جديد";
            this.but_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_new.UseVisualStyleBackColor = true;
            this.but_new.Click += new System.EventHandler(this.but_new_Click);
            // 
            // but_save
            // 
            this.but_save.Enabled = false;
            this.but_save.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_save.ForeColor = System.Drawing.Color.SlateBlue;
            this.but_save.Image = ((System.Drawing.Image)(resources.GetObject("but_save.Image")));
            this.but_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_save.Location = new System.Drawing.Point(280, 12);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(73, 93);
            this.but_save.TabIndex = 10;
            this.but_save.Text = "حفظ";
            this.but_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_del
            // 
            this.but_del.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.ForeColor = System.Drawing.Color.SlateBlue;
            this.but_del.Image = ((System.Drawing.Image)(resources.GetObject("but_del.Image")));
            this.but_del.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_del.Location = new System.Drawing.Point(122, 12);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(75, 93);
            this.but_del.TabIndex = 12;
            this.but_del.Text = "حذف";
            this.but_del.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_edit
            // 
            this.but_edit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_edit.ForeColor = System.Drawing.Color.SlateBlue;
            this.but_edit.Image = ((System.Drawing.Image)(resources.GetObject("but_edit.Image")));
            this.but_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_edit.Location = new System.Drawing.Point(201, 12);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(74, 93);
            this.but_edit.TabIndex = 33;
            this.but_edit.Text = "تعديل";
            this.but_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(102, -22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(196, 20);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "اضافة معلومات المستخدمون";
            // 
            // but_accoant
            // 
            this.but_accoant.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_accoant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.but_accoant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_accoant.Location = new System.Drawing.Point(8, 566);
            this.but_accoant.Name = "but_accoant";
            this.but_accoant.Size = new System.Drawing.Size(410, 53);
            this.but_accoant.TabIndex = 43;
            this.but_accoant.Text = "الدليل المحاسبي";
            this.but_accoant.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 566);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(574, 505);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(440, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // frm_Accont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 631);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_accoant);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Accont";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الحسابات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tre_accont;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_no_acc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_ras;
        private System.Windows.Forms.TextBox tex_dan;
        private System.Windows.Forms.TextBox tex_mad;
        private System.Windows.Forms.TextBox tex_lav_acc;
        private System.Windows.Forms.TextBox tex_name_acc;
        private System.Windows.Forms.TextBox tex_fa_acc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox com_tyep_acc;
        private System.Windows.Forms.ComboBox com_rep;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_new;
        private System.Windows.Forms.Button but_del;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.TextBox tex_tag;
        private System.Windows.Forms.Button but_accoant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}