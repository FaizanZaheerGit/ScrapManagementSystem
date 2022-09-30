namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class wood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wood));
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.summaryTxt = new System.Windows.Forms.TextBox();
            this.genBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(504, 142);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(193, 20);
            this.datePicker.TabIndex = 7;
            // 
            // summaryTxt
            // 
            this.summaryTxt.Location = new System.Drawing.Point(170, 190);
            this.summaryTxt.Margin = new System.Windows.Forms.Padding(2);
            this.summaryTxt.Multiline = true;
            this.summaryTxt.Name = "summaryTxt";
            this.summaryTxt.Size = new System.Drawing.Size(527, 316);
            this.summaryTxt.TabIndex = 6;
            // 
            // genBtn
            // 
            this.genBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.genBtn.ForeColor = System.Drawing.Color.White;
            this.genBtn.Location = new System.Drawing.Point(170, 125);
            this.genBtn.Margin = new System.Windows.Forms.Padding(2);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(153, 55);
            this.genBtn.TabIndex = 4;
            this.genBtn.Text = "Generate Summary";
            this.genBtn.UseVisualStyleBackColor = false;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(11, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 62);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(372, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 45);
            this.label2.TabIndex = 24;
            this.label2.Text = "Wood";
            // 
            // wood
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.summaryTxt);
            this.Controls.Add(this.genBtn);
            this.Name = "wood";
            this.Text = "Wood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox summaryTxt;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}