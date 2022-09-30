namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class CarParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarParts));
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.summaryTxt = new System.Windows.Forms.TextBox();
            this.genBtn = new System.Windows.Forms.Button();
            this.carpartsBox = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(540, 133);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(184, 20);
            this.datePicker.TabIndex = 7;
            // 
            // summaryTxt
            // 
            this.summaryTxt.Location = new System.Drawing.Point(181, 177);
            this.summaryTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summaryTxt.Multiline = true;
            this.summaryTxt.Name = "summaryTxt";
            this.summaryTxt.Size = new System.Drawing.Size(543, 343);
            this.summaryTxt.TabIndex = 6;
            // 
            // genBtn
            // 
            this.genBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.genBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.genBtn.ForeColor = System.Drawing.Color.White;
            this.genBtn.Location = new System.Drawing.Point(181, 98);
            this.genBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(203, 55);
            this.genBtn.TabIndex = 4;
            this.genBtn.Text = "Generate Summary";
            this.genBtn.UseVisualStyleBackColor = false;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // carpartsBox
            // 
            this.carpartsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carpartsBox.FormattingEnabled = true;
            this.carpartsBox.Location = new System.Drawing.Point(573, 98);
            this.carpartsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carpartsBox.Name = "carpartsBox";
            this.carpartsBox.Size = new System.Drawing.Size(151, 21);
            this.carpartsBox.TabIndex = 8;
            // 
            // Back
            // 
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(31, 14);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 62);
            this.Back.TabIndex = 15;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(367, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 45);
            this.label1.TabIndex = 23;
            this.label1.Text = "Car Parts";
            // 
            // CarParts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.carpartsBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.summaryTxt);
            this.Controls.Add(this.genBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarParts";
            this.Text = "Car Parts";
            this.Load += new System.EventHandler(this.CarParts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox summaryTxt;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.ComboBox carpartsBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}