namespace AccountsSystem_AliAL_Ward_Development.PL
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_user = new System.Windows.Forms.TextBox();
            this.tex_PWS = new System.Windows.Forms.TextBox();
            this.but_LOGIN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة المرور";
            // 
            // tex_user
            // 
            this.tex_user.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_user.Location = new System.Drawing.Point(126, 316);
            this.tex_user.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tex_user.Name = "tex_user";
            this.tex_user.Size = new System.Drawing.Size(233, 30);
            this.tex_user.TabIndex = 1;
            this.tex_user.Text = "ss";
            this.tex_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_user_KeyDown);
            // 
            // tex_PWS
            // 
            this.tex_PWS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_PWS.Location = new System.Drawing.Point(126, 355);
            this.tex_PWS.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tex_PWS.Name = "tex_PWS";
            this.tex_PWS.PasswordChar = '*';
            this.tex_PWS.Size = new System.Drawing.Size(233, 30);
            this.tex_PWS.TabIndex = 2;
            this.tex_PWS.Text = "ss";
            this.tex_PWS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_PWS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_PWS_KeyDown);
            // 
            // but_LOGIN
            // 
            this.but_LOGIN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_LOGIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_LOGIN.Image = ((System.Drawing.Image)(resources.GetObject("but_LOGIN.Image")));
            this.but_LOGIN.Location = new System.Drawing.Point(31, 403);
            this.but_LOGIN.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.but_LOGIN.Name = "but_LOGIN";
            this.but_LOGIN.Size = new System.Drawing.Size(328, 47);
            this.but_LOGIN.TabIndex = 3;
            this.but_LOGIN.Text = "دخــــــــــــــول";
            this.but_LOGIN.UseVisualStyleBackColor = true;
            this.but_LOGIN.Click += new System.EventHandler(this.but_LOGIN_Click);
            // 
            // frm_login
            // 
            this.AcceptButton = this.but_LOGIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 473);
            this.Controls.Add(this.but_LOGIN);
            this.Controls.Add(this.tex_PWS);
            this.Controls.Add(this.tex_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_user;
        private System.Windows.Forms.TextBox tex_PWS;
        private System.Windows.Forms.Button but_LOGIN;
    }
}