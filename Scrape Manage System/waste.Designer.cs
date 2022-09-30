namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class waste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waste));
            this.summaryTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.ComboBox();
            this.genBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // summaryTxt
            // 
            this.summaryTxt.Location = new System.Drawing.Point(233, 206);
            this.summaryTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summaryTxt.Multiline = true;
            this.summaryTxt.Name = "summaryTxt";
            this.summaryTxt.Size = new System.Drawing.Size(431, 236);
            this.summaryTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Item:";
            // 
            // itemBox
            // 
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Location = new System.Drawing.Point(341, 166);
            this.itemBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(243, 21);
            this.itemBox.TabIndex = 3;
            this.itemBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // genBtn
            // 
            this.genBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.genBtn.Location = new System.Drawing.Point(347, 483);
            this.genBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(202, 57);
            this.genBtn.TabIndex = 4;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = false;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(385, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 45);
            this.label2.TabIndex = 23;
            this.label2.Text = "Waste";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(11, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 62);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // waste
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summaryTxt);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "waste";
            this.Text = "waste";
            this.Load += new System.EventHandler(this.Waste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox summaryTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemBox;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}