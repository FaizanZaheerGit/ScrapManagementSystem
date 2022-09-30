namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class userLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userLogin));
            this.userla = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.pinla = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.forgotPinBtn = new System.Windows.Forms.Button();
            this.pinTxt = new System.Windows.Forms.MaskedTextBox();
            this.deluserBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userla
            // 
            this.userla.AutoSize = true;
            this.userla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userla.ForeColor = System.Drawing.Color.White;
            this.userla.Location = new System.Drawing.Point(421, 223);
            this.userla.Name = "userla";
            this.userla.Size = new System.Drawing.Size(81, 18);
            this.userla.TabIndex = 0;
            this.userla.Text = "Username:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(522, 224);
            this.usernameTxt.MaximumSize = new System.Drawing.Size(231, 60);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(231, 20);
            this.usernameTxt.TabIndex = 1;
            this.usernameTxt.Text = "username";
            this.usernameTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameTxt_MouseClick);
            this.usernameTxt.MouseEnter += new System.EventHandler(this.usernameTxt_MouseEnter);
            // 
            // pinla
            // 
            this.pinla.AutoSize = true;
            this.pinla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinla.ForeColor = System.Drawing.Color.White;
            this.pinla.Location = new System.Drawing.Point(469, 265);
            this.pinla.Name = "pinla";
            this.pinla.Size = new System.Drawing.Size(33, 18);
            this.pinla.TabIndex = 3;
            this.pinla.Text = "Pin:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLbl.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(504, 101);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(239, 45);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "USER LOGIN";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(522, 311);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(231, 40);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(53, 22);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(183, 62);
            this.backBtn.TabIndex = 7;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // forgotPinBtn
            // 
            this.forgotPinBtn.FlatAppearance.BorderSize = 0;
            this.forgotPinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPinBtn.ForeColor = System.Drawing.Color.White;
            this.forgotPinBtn.Location = new System.Drawing.Point(611, 357);
            this.forgotPinBtn.Name = "forgotPinBtn";
            this.forgotPinBtn.Size = new System.Drawing.Size(142, 45);
            this.forgotPinBtn.TabIndex = 8;
            this.forgotPinBtn.Text = "Forgot Password?";
            this.forgotPinBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forgotPinBtn.UseVisualStyleBackColor = true;
            this.forgotPinBtn.Click += new System.EventHandler(this.Forgetpass_Click);
            // 
            // pinTxt
            // 
            this.pinTxt.Location = new System.Drawing.Point(522, 265);
            this.pinTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinTxt.Mask = "0000";
            this.pinTxt.Name = "pinTxt";
            this.pinTxt.PasswordChar = 'X';
            this.pinTxt.Size = new System.Drawing.Size(231, 20);
            this.pinTxt.TabIndex = 9;
            this.pinTxt.ValidatingType = typeof(int);
            // 
            // deluserBtn
            // 
            this.deluserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.deluserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deluserBtn.Location = new System.Drawing.Point(573, 512);
            this.deluserBtn.Name = "deluserBtn";
            this.deluserBtn.Size = new System.Drawing.Size(83, 34);
            this.deluserBtn.TabIndex = 10;
            this.deluserBtn.Text = "Delete User";
            this.deluserBtn.UseVisualStyleBackColor = false;
            this.deluserBtn.Click += new System.EventHandler(this.deluserBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 600);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "USER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deluserBtn);
            this.Controls.Add(this.pinTxt);
            this.Controls.Add(this.forgotPinBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.pinla);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.userla);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userLogin";
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.userLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userla;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label pinla;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button forgotPinBtn;
        private System.Windows.Forms.MaskedTextBox pinTxt;
        private System.Windows.Forms.Button deluserBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}