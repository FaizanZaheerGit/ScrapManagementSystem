namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class userselection1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userselection1));
            this.userBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.topheading = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBtn.Image")));
            this.userBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userBtn.Location = new System.Drawing.Point(460, 244);
            this.userBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(309, 145);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "USER";
            this.userBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.user_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.adminBtn.FlatAppearance.BorderSize = 0;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.White;
            this.adminBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminBtn.Image")));
            this.adminBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adminBtn.Location = new System.Drawing.Point(109, 244);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(309, 145);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Text = "ADMIN";
            this.adminBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.admin_Click);
            // 
            // topheading
            // 
            this.topheading.AutoSize = true;
            this.topheading.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topheading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.topheading.Location = new System.Drawing.Point(390, 37);
            this.topheading.Name = "topheading";
            this.topheading.Size = new System.Drawing.Size(458, 70);
            this.topheading.TabIndex = 2;
            this.topheading.Text = "Welcome to Scrape Managemanet System\r\nby AFH Solutions";
            this.topheading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpBtn
            // 
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.ForeColor = System.Drawing.Color.White;
            this.signUpBtn.Location = new System.Drawing.Point(329, 507);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(238, 37);
            this.signUpBtn.TabIndex = 3;
            this.signUpBtn.Text = "Register New User";
            this.signUpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(825, 501);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 50);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.topheading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 130);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userselection1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.userBtn);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "userselection1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Label topheading;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

