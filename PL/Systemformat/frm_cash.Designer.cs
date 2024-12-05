namespace AccountsSystem_AliAL_Ward_Development.PL.Systemformat
{
    partial class frm_cash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cash));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.but_dis = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.but_exit = new System.Windows.Forms.Button();
            this.but_new = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tex_fun = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tex_name_acc = new System.Windows.Forms.TextBox();
            this.tex_no_acc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_grid);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "النقدية";
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_grid.Location = new System.Drawing.Point(3, 22);
            this.data_grid.Name = "data_grid";
            this.data_grid.RowHeadersVisible = false;
            this.data_grid.Size = new System.Drawing.Size(457, 221);
            this.data_grid.TabIndex = 13;
            this.data_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellClick);
            this.data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellContentClick);
            // 
            // but_dis
            // 
            this.but_dis.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dis.ForeColor = System.Drawing.Color.SlateBlue;
            this.but_dis.Image = ((System.Drawing.Image)(resources.GetObject("but_dis.Image")));
            this.but_dis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_dis.Location = new System.Drawing.Point(221, 12);
            this.but_dis.Name = "but_dis";
            this.but_dis.Size = new System.Drawing.Size(73, 93);
            this.but_dis.TabIndex = 14;
            this.but_dis.Text = "عرض";
            this.but_dis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_dis.UseVisualStyleBackColor = true;
            this.but_dis.Click += new System.EventHandler(this.but_dis_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.but_dis);
            this.groupBox4.Controls.Add(this.but_exit);
            this.groupBox4.Controls.Add(this.but_new);
            this.groupBox4.Controls.Add(this.but_save);
            this.groupBox4.Controls.Add(this.but_del);
            this.groupBox4.Location = new System.Drawing.Point(9, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 114);
            this.groupBox4.TabIndex = 5;
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
            this.but_exit.TabIndex = 8;
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
            this.but_new.TabIndex = 5;
            this.but_new.Text = "جديد";
            this.but_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_new.UseVisualStyleBackColor = true;
            this.but_new.Click += new System.EventHandler(this.but_new_Click);
            // 
            // but_save
            // 
            this.but_save.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_save.ForeColor = System.Drawing.Color.SlateBlue;
            this.but_save.Image = ((System.Drawing.Image)(resources.GetObject("but_save.Image")));
            this.but_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_save.Location = new System.Drawing.Point(300, 12);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(73, 93);
            this.but_save.TabIndex = 4;
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
            this.but_del.Location = new System.Drawing.Point(142, 12);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(75, 93);
            this.but_del.TabIndex = 7;
            this.but_del.Text = "حذف";
            this.but_del.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tex_fun);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.tex_name_acc);
            this.groupBox2.Controls.Add(this.tex_no_acc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المدخلات";
            // 
            // tex_fun
            // 
            this.tex_fun.Location = new System.Drawing.Point(9, 18);
            this.tex_fun.Name = "tex_fun";
            this.tex_fun.Size = new System.Drawing.Size(42, 23);
            this.tex_fun.TabIndex = 39;
            this.tex_fun.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelControl2.Location = new System.Drawing.Point(245, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(210, 20);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "اضافة معلومات الحساب المالي";
            // 
            // tex_name_acc
            // 
            this.tex_name_acc.Enabled = false;
            this.tex_name_acc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_name_acc.Location = new System.Drawing.Point(9, 77);
            this.tex_name_acc.Name = "tex_name_acc";
            this.tex_name_acc.Size = new System.Drawing.Size(321, 26);
            this.tex_name_acc.TabIndex = 2;
            this.tex_name_acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tex_no_acc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_no_acc_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(348, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "اسم الحساب";
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
            // frm_cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 488);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Button but_new;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox tex_name_acc;
        private System.Windows.Forms.TextBox tex_no_acc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_grid;
        public System.Windows.Forms.TextBox tex_fun;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_dis;
    }
}