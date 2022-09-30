namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class userSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSignUp));
            this.backBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.pinla = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.userla = new System.Windows.Forms.Label();
            this.pinTxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(109, 25);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 66);
            this.backBtn.TabIndex = 16;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(518, 335);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(213, 44);
            this.signupBtn.TabIndex = 15;
            this.signupBtn.Text = "SignUp";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login.Location = new System.Drawing.Point(507, 105);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(224, 45);
            this.login.TabIndex = 13;
            this.login.Text = "User SignUp";
            // 
            // pinla
            // 
            this.pinla.AutoSize = true;
            this.pinla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.pinla.ForeColor = System.Drawing.Color.White;
            this.pinla.Location = new System.Drawing.Point(447, 294);
            this.pinla.Name = "pinla";
            this.pinla.Size = new System.Drawing.Size(33, 18);
            this.pinla.TabIndex = 12;
            this.pinla.Text = "Pin:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(518, 240);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(213, 20);
            this.usernameTxt.TabIndex = 10;
            this.usernameTxt.Text = "username";
            // 
            // userla
            // 
            this.userla.AutoSize = true;
            this.userla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.userla.ForeColor = System.Drawing.Color.White;
            this.userla.Location = new System.Drawing.Point(410, 241);
            this.userla.Name = "userla";
            this.userla.Size = new System.Drawing.Size(81, 18);
            this.userla.TabIndex = 9;
            this.userla.Text = "Username:";
            // 
            // pinTxt
            // 
            this.pinTxt.Location = new System.Drawing.Point(518, 293);
            this.pinTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinTxt.Mask = "0000";
            this.pinTxt.Name = "pinTxt";
            this.pinTxt.PasswordChar = 'X';
            this.pinTxt.Size = new System.Drawing.Size(213, 20);
            this.pinTxt.TabIndex = 17;
            this.pinTxt.ValidatingType = typeof(int);
            this.pinTxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.pinTxt_MaskInputRejected);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 224);
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
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 600);
            this.panel1.TabIndex = 18;
            // 
            // userSignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pinTxt);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pinla);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.userla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "userSignUp";
            this.Text = "userSignUp";
            this.Load += new System.EventHandler(this.userSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label pinla;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label userla;
        private System.Windows.Forms.MaskedTextBox pinTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}