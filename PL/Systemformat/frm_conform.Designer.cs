namespace AccountsSystem_AliAL_Ward_Development.PL.Systemformat
{
    partial class frm_conform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_conform));
            this.b_new = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.but_bwroser = new System.Windows.Forms.Button();
            this.tex_pwd = new System.Windows.Forms.TextBox();
            this.tex_user = new System.Windows.Forms.TextBox();
            this.tex_DB = new System.Windows.Forms.TextBox();
            this.tex_server = new System.Windows.Forms.TextBox();
            this.tex_mode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.but_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // b_new
            // 
            this.b_new.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_new.ForeColor = System.Drawing.Color.Navy;
            this.b_new.Location = new System.Drawing.Point(56, 255);
            this.b_new.Name = "b_new";
            this.b_new.Size = new System.Drawing.Size(70, 51);
            this.b_new.TabIndex = 1;
            this.b_new.Text = "جديد";
            this.b_new.UseVisualStyleBackColor = true;
            this.b_new.Click += new System.EventHandler(this.b_new_Click);
            // 
            // but_save
            // 
            this.but_save.Enabled = false;
            this.but_save.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_save.ForeColor = System.Drawing.Color.Navy;
            this.but_save.Location = new System.Drawing.Point(173, 255);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(80, 51);
            this.but_save.TabIndex = 7;
            this.but_save.Text = "حفظ";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_bwroser
            // 
            this.but_bwroser.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_bwroser.ForeColor = System.Drawing.Color.Navy;
            this.but_bwroser.Location = new System.Drawing.Point(293, 255);
            this.but_bwroser.Name = "but_bwroser";
            this.but_bwroser.Size = new System.Drawing.Size(99, 51);
            this.but_bwroser.TabIndex = 15;
            this.but_bwroser.Text = "عرض";
            this.but_bwroser.UseVisualStyleBackColor = true;
            this.but_bwroser.Click += new System.EventHandler(this.but_bwroser_Click);
            // 
            // tex_pwd
            // 
            this.tex_pwd.Enabled = false;
            this.tex_pwd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_pwd.ForeColor = System.Drawing.Color.Red;
            this.tex_pwd.Location = new System.Drawing.Point(136, 204);
            this.tex_pwd.Name = "tex_pwd";
            this.tex_pwd.Size = new System.Drawing.Size(365, 27);
            this.tex_pwd.TabIndex = 6;
            this.tex_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_user
            // 
            this.tex_user.Enabled = false;
            this.tex_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_user.ForeColor = System.Drawing.Color.Red;
            this.tex_user.Location = new System.Drawing.Point(136, 163);
            this.tex_user.Name = "tex_user";
            this.tex_user.Size = new System.Drawing.Size(365, 27);
            this.tex_user.TabIndex = 5;
            this.tex_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_user_KeyDown);
            // 
            // tex_DB
            // 
            this.tex_DB.Enabled = false;
            this.tex_DB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_DB.ForeColor = System.Drawing.Color.Red;
            this.tex_DB.Location = new System.Drawing.Point(136, 121);
            this.tex_DB.Name = "tex_DB";
            this.tex_DB.Size = new System.Drawing.Size(365, 27);
            this.tex_DB.TabIndex = 4;
            this.tex_DB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_DB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_DB_KeyDown);
            // 
            // tex_server
            // 
            this.tex_server.Enabled = false;
            this.tex_server.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_server.ForeColor = System.Drawing.Color.Red;
            this.tex_server.Location = new System.Drawing.Point(136, 73);
            this.tex_server.Name = "tex_server";
            this.tex_server.Size = new System.Drawing.Size(365, 27);
            this.tex_server.TabIndex = 3;
            this.tex_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_server.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_server_KeyDown);
            // 
            // tex_mode
            // 
            this.tex_mode.Enabled = false;
            this.tex_mode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_mode.ForeColor = System.Drawing.Color.Red;
            this.tex_mode.Location = new System.Drawing.Point(136, 23);
            this.tex_mode.Name = "tex_mode";
            this.tex_mode.Size = new System.Drawing.Size(365, 27);
            this.tex_mode.TabIndex = 2;
            this.tex_mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_mode.TextChanged += new System.EventHandler(this.tex_mode_TextChanged);
            this.tex_mode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_mode_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "قاعدة البيانات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "اسم السرفر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "نمط الاتصال";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(249, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(383, 256);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // but_del
            // 
            this.but_del.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.but_del.ForeColor = System.Drawing.Color.Navy;
            this.but_del.Location = new System.Drawing.Point(443, 255);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(75, 51);
            this.but_del.TabIndex = 17;
            this.but_del.Text = "حذف";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // frm_conform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 317);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_new);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.but_bwroser);
            this.Controls.Add(this.tex_pwd);
            this.Controls.Add(this.tex_user);
            this.Controls.Add(this.tex_DB);
            this.Controls.Add(this.tex_server);
            this.Controls.Add(this.tex_mode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_conform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تهيئة الاتصال بقاعدة البيانات";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_new;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_bwroser;
        private System.Windows.Forms.TextBox tex_pwd;
        private System.Windows.Forms.TextBox tex_user;
        private System.Windows.Forms.TextBox tex_DB;
        private System.Windows.Forms.TextBox tex_server;
        private System.Windows.Forms.TextBox tex_mode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button but_del;
    }
}