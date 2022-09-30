namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class ChangePinU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePinU));
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.npinTxt = new System.Windows.Forms.MaskedTextBox();
            this.cpinTxt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(593, 254);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(167, 20);
            this.usernameTxt.TabIndex = 3;
            this.usernameTxt.Text = "username";
            this.usernameTxt.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(593, 372);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(167, 49);
            this.confirmBtn.TabIndex = 6;
            this.confirmBtn.Text = "confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // npinTxt
            // 
            this.npinTxt.Location = new System.Drawing.Point(593, 292);
            this.npinTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.npinTxt.Mask = "0000";
            this.npinTxt.Name = "npinTxt";
            this.npinTxt.PasswordChar = 'X';
            this.npinTxt.Size = new System.Drawing.Size(167, 20);
            this.npinTxt.TabIndex = 31;
            // 
            // cpinTxt
            // 
            this.cpinTxt.Location = new System.Drawing.Point(593, 326);
            this.cpinTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpinTxt.Mask = "0000";
            this.cpinTxt.Name = "cpinTxt";
            this.cpinTxt.PasswordChar = 'X';
            this.cpinTxt.Size = new System.Drawing.Size(167, 20);
            this.cpinTxt.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Change Pin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(116, 27);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 58);
            this.back.TabIndex = 16;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 600);
            this.panel1.TabIndex = 44;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(501, 128);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(259, 45);
            this.login.TabIndex = 43;
            this.login.Text = "Enter New Pin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(457, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Verify:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(457, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Enter new pin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Username:";
            // 
            // ChangePinU
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.cpinTxt);
            this.Controls.Add(this.npinTxt);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.usernameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePinU";
            this.Text = "Change Pin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.MaskedTextBox npinTxt;
        private System.Windows.Forms.MaskedTextBox cpinTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}