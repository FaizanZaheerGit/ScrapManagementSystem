namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class adminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            this.forgetpass = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.pinla = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.userla = new System.Windows.Forms.Label();
            this.pinTxt = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forgetpass
            // 
            this.forgetpass.FlatAppearance.BorderSize = 0;
            this.forgetpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgetpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.forgetpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.forgetpass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forgetpass.Location = new System.Drawing.Point(589, 390);
            this.forgetpass.Name = "forgetpass";
            this.forgetpass.Size = new System.Drawing.Size(130, 45);
            this.forgetpass.TabIndex = 17;
            this.forgetpass.Text = "Forgot Password?";
            this.forgetpass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forgetpass.UseVisualStyleBackColor = true;
            this.forgetpass.Click += new System.EventHandler(this.forgetpass_Click);
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(104, 27);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 58);
            this.back.TabIndex = 16;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(515, 332);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(204, 40);
            this.LoginBtn.TabIndex = 15;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.next_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(490, 97);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(229, 45);
            this.login.TabIndex = 13;
            this.login.Text = "Admin Login";
            // 
            // pinla
            // 
            this.pinla.AutoSize = true;
            this.pinla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.pinla.ForeColor = System.Drawing.Color.White;
            this.pinla.Location = new System.Drawing.Point(429, 267);
            this.pinla.Name = "pinla";
            this.pinla.Size = new System.Drawing.Size(33, 18);
            this.pinla.TabIndex = 12;
            this.pinla.Text = "Pin:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(515, 220);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(204, 20);
            this.usernameTxt.TabIndex = 10;
            this.usernameTxt.Text = "username";
            // 
            // userla
            // 
            this.userla.AutoSize = true;
            this.userla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.userla.ForeColor = System.Drawing.Color.White;
            this.userla.Location = new System.Drawing.Point(392, 221);
            this.userla.Name = "userla";
            this.userla.Size = new System.Drawing.Size(81, 18);
            this.userla.TabIndex = 9;
            this.userla.Text = "Username:";
            // 
            // pinTxt
            // 
            this.pinTxt.Location = new System.Drawing.Point(515, 266);
            this.pinTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinTxt.Mask = "0000";
            this.pinTxt.Name = "pinTxt";
            this.pinTxt.PasswordChar = 'X';
            this.pinTxt.Size = new System.Drawing.Size(204, 20);
            this.pinTxt.TabIndex = 18;
            this.pinTxt.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 561);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "ADMIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pinTxt);
            this.Controls.Add(this.forgetpass);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pinla);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.userla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "adminLogin";
            this.Text = "adminLogin";
            this.Load += new System.EventHandler(this.adminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forgetpass;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label pinla;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label userla;
        private System.Windows.Forms.MaskedTextBox pinTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}