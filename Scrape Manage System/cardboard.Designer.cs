﻿namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class cardboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardboard));
            this.genBtn = new System.Windows.Forms.Button();
            this.summaryTxt = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.Backbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genBtn
            // 
            this.genBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.genBtn.ForeColor = System.Drawing.Color.White;
            this.genBtn.Location = new System.Drawing.Point(176, 111);
            this.genBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(182, 55);
            this.genBtn.TabIndex = 0;
            this.genBtn.Text = "Generate Summary";
            this.genBtn.UseVisualStyleBackColor = false;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // summaryTxt
            // 
            this.summaryTxt.Location = new System.Drawing.Point(176, 192);
            this.summaryTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summaryTxt.Multiline = true;
            this.summaryTxt.Name = "summaryTxt";
            this.summaryTxt.Size = new System.Drawing.Size(527, 316);
            this.summaryTxt.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(468, 128);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(235, 20);
            this.datePicker.TabIndex = 3;
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Image = ((System.Drawing.Image)(resources.GetObject("Backbtn.Image")));
            this.Backbtn.Location = new System.Drawing.Point(27, 23);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(92, 62);
            this.Backbtn.TabIndex = 14;
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(27, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 62);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Backbtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 45);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cardboard";
            // 
            // cardboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.summaryTxt);
            this.Controls.Add(this.genBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cardboard";
            this.Text = "cardboard";
            this.Load += new System.EventHandler(this.Cardboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.TextBox summaryTxt;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}