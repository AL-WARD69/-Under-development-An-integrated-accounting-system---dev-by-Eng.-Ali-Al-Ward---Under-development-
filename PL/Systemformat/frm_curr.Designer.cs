namespace AccountsSystem_AliAL_Ward_Development.PL.Systemformat
{
    partial class frm_curr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_curr));
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.but_new = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rd_M_curr = new System.Windows.Forms.RadioButton();
            this.rd_A_curr = new System.Windows.Forms.RadioButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tex_F = new System.Windows.Forms.TextBox();
            this.tex_S = new System.Windows.Forms.TextBox();
            this.tex_R = new System.Windows.Forms.TextBox();
            this.tex_ename = new System.Windows.Forms.TextBox();
            this.tex_aname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_grid.Enabled = false;
            this.data_grid.Location = new System.Drawing.Point(3, 22);
            this.data_grid.Name = "data_grid";
            this.data_grid.RowHeadersVisible = false;
            this.data_grid.Size = new System.Drawing.Size(457, 179);
            this.data_grid.TabIndex = 13;
            this.data_grid.DoubleClick += new System.EventHandler(this.data_grid_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_grid);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 204);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العملات";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.but_edit);
            this.groupBox4.Controls.Add(this.but_exit);
            this.groupBox4.Controls.Add(this.but_new);
            this.groupBox4.Controls.Add(this.but_save);
            this.groupBox4.Controls.Add(this.but_del);
            this.groupBox4.Location = new System.Drawing.Point(11, 474);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 114);
            this.groupBox4.TabIndex = 99;
            this.groupBox4.TabStop = false;
            // 
            // but_edit
            // 
            this.but_edit.Enabled = false;
            this.but_edit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_edit.ForeColor = System.Drawing.Color.SlateBlue;
            this.but_edit.Image = ((System.Drawing.Image)(resources.GetObject("but_edit.Image")));
            this.but_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_edit.Location = new System.Drawing.Point(222, 12);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(74, 93);
            this.but_edit.TabIndex = 10;
            this.but_edit.Text = "تعديل";
            this.but_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // but_exit
            // 
            this.but_exit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_exit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.but_exit.Image = ((System.Drawing.Image)(resources.GetObject("but_exit.Image")));
            this.but_exit.Location = new System.Drawing.Point(9, 12);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(72, 93);
            this.but_exit.TabIndex = 12;
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // but_new
            // 
            this.but_new.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_new.ForeColor = System.Drawing.Color.SlateBlue;
            this.but_new.Image = ((System.Drawing.Image)(resources.GetObject("but_new.Image")));
            this.but_new.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_new.Location = new System.Drawing.Point(378, 12);
            this.but_new.Name = "but_new";
            this.but_new.Size = new System.Drawing.Size(75, 93);
            this.but_new.TabIndex = 9;
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
            this.but_save.Location = new System.Drawing.Point(300, 12);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(73, 93);
            this.but_save.TabIndex = 8;
            this.but_save.Text = "حفظ";
            this.but_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_del
            // 
            this.but_del.Enabled = false;
            this.but_del.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.ForeColor = System.Drawing.Color.SlateBlue;
            this.but_del.Image = ((System.Drawing.Image)(resources.GetObject("but_del.Image")));
            this.but_del.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_del.Location = new System.Drawing.Point(142, 12);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(75, 93);
            this.but_del.TabIndex = 11;
            this.but_del.Text = "حذف";
            this.but_del.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.rd_M_curr);
            this.groupBox2.Controls.Add(this.rd_A_curr);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.tex_F);
            this.groupBox2.Controls.Add(this.tex_S);
            this.groupBox2.Controls.Add(this.tex_R);
            this.groupBox2.Controls.Add(this.tex_ename);
            this.groupBox2.Controls.Add(this.tex_aname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 255);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المدخلات";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // rd_M_curr
            // 
            this.rd_M_curr.AutoSize = true;
            this.rd_M_curr.Enabled = false;
            this.rd_M_curr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_M_curr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rd_M_curr.Location = new System.Drawing.Point(175, 221);
            this.rd_M_curr.Name = "rd_M_curr";
            this.rd_M_curr.Size = new System.Drawing.Size(116, 23);
            this.rd_M_curr.TabIndex = 6;
            this.rd_M_curr.TabStop = true;
            this.rd_M_curr.Text = "عملة محلية";
            this.rd_M_curr.UseVisualStyleBackColor = true;
            // 
            // rd_A_curr
            // 
            this.rd_A_curr.AutoSize = true;
            this.rd_A_curr.Enabled = false;
            this.rd_A_curr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_A_curr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rd_A_curr.Location = new System.Drawing.Point(40, 221);
            this.rd_A_curr.Name = "rd_A_curr";
            this.rd_A_curr.Size = new System.Drawing.Size(116, 23);
            this.rd_A_curr.TabIndex = 7;
            this.rd_A_curr.TabStop = true;
            this.rd_A_curr.Text = "عملة أجنبية";
            this.rd_A_curr.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelControl2.Location = new System.Drawing.Point(298, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(156, 20);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "اضافة معلومات العملة";
            // 
            // tex_F
            // 
            this.tex_F.Enabled = false;
            this.tex_F.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_F.Location = new System.Drawing.Point(9, 173);
            this.tex_F.Name = "tex_F";
            this.tex_F.Size = new System.Drawing.Size(333, 26);
            this.tex_F.TabIndex = 5;
            this.tex_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_S
            // 
            this.tex_S.Enabled = false;
            this.tex_S.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_S.Location = new System.Drawing.Point(9, 141);
            this.tex_S.Name = "tex_S";
            this.tex_S.Size = new System.Drawing.Size(333, 26);
            this.tex_S.TabIndex = 4;
            this.tex_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_R
            // 
            this.tex_R.Enabled = false;
            this.tex_R.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_R.Location = new System.Drawing.Point(9, 109);
            this.tex_R.Name = "tex_R";
            this.tex_R.Size = new System.Drawing.Size(333, 26);
            this.tex_R.TabIndex = 3;
            this.tex_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_ename
            // 
            this.tex_ename.Enabled = false;
            this.tex_ename.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_ename.Location = new System.Drawing.Point(9, 77);
            this.tex_ename.Name = "tex_ename";
            this.tex_ename.Size = new System.Drawing.Size(333, 26);
            this.tex_ename.TabIndex = 2;
            this.tex_ename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_ename.Enter += new System.EventHandler(this.tex_ename_Enter);
            // 
            // tex_aname
            // 
            this.tex_aname.Enabled = false;
            this.tex_aname.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_aname.Location = new System.Drawing.Point(9, 47);
            this.tex_aname.Name = "tex_aname";
            this.tex_aname.Size = new System.Drawing.Size(333, 26);
            this.tex_aname.TabIndex = 1;
            this.tex_aname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_aname.Enter += new System.EventHandler(this.tex_aname_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(381, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "الصرف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(365, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "نوع العملة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(388, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "الفكة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(364, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "رمز العملة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(352, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "الاسم لاتيني";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(358, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "اسم العملة";
            // 
            // frm_curr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_curr";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "العملات";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Button but_new;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox tex_F;
        private System.Windows.Forms.TextBox tex_S;
        private System.Windows.Forms.TextBox tex_R;
        private System.Windows.Forms.TextBox tex_ename;
        private System.Windows.Forms.TextBox tex_aname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rd_M_curr;
        private System.Windows.Forms.RadioButton rd_A_curr;
        private System.Windows.Forms.Button but_edit;
    }
}