namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class DriverDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.carnoTxt = new System.Windows.Forms.TextBox();
            this.capacityUpDown = new System.Windows.Forms.NumericUpDown();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.driverGView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.supplierTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capacityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverGView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(165, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(165, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(165, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(417, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Car capacity (Kgs.)";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(259, 131);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(412, 20);
            this.nameTxt.TabIndex = 5;
            // 
            // contactTxt
            // 
            this.contactTxt.Location = new System.Drawing.Point(259, 177);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(121, 20);
            this.contactTxt.TabIndex = 6;
            // 
            // carnoTxt
            // 
            this.carnoTxt.Location = new System.Drawing.Point(259, 225);
            this.carnoTxt.Name = "carnoTxt";
            this.carnoTxt.Size = new System.Drawing.Size(121, 20);
            this.carnoTxt.TabIndex = 8;
            // 
            // capacityUpDown
            // 
            this.capacityUpDown.Location = new System.Drawing.Point(551, 225);
            this.capacityUpDown.Name = "capacityUpDown";
            this.capacityUpDown.Size = new System.Drawing.Size(120, 20);
            this.capacityUpDown.TabIndex = 9;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.addBtn.Location = new System.Drawing.Point(186, 290);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(153, 50);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Add Driver";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.updateBtn.Location = new System.Drawing.Point(369, 290);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(153, 50);
            this.updateBtn.TabIndex = 36;
            this.updateBtn.Text = "Update Driver";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.deleteBtn.Location = new System.Drawing.Point(551, 290);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(153, 50);
            this.deleteBtn.TabIndex = 37;
            this.deleteBtn.Text = "Delete Driver";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // driverGView
            // 
            this.driverGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverGView.Location = new System.Drawing.Point(102, 359);
            this.driverGView.Margin = new System.Windows.Forms.Padding(2);
            this.driverGView.Name = "driverGView";
            this.driverGView.RowTemplate.Height = 24;
            this.driverGView.Size = new System.Drawing.Size(674, 153);
            this.driverGView.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(417, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Supplier Name";
            // 
            // supplierTxt
            // 
            this.supplierTxt.Location = new System.Drawing.Point(551, 177);
            this.supplierTxt.Name = "supplierTxt";
            this.supplierTxt.Size = new System.Drawing.Size(121, 20);
            this.supplierTxt.TabIndex = 40;
            this.supplierTxt.Text = "AFH Solutions";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 56);
            this.button1.TabIndex = 94;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(320, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 45);
            this.label6.TabIndex = 95;
            this.label6.Text = "Driver Record";
            // 
            // DriverDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.supplierTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.driverGView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.capacityUpDown);
            this.Controls.Add(this.carnoTxt);
            this.Controls.Add(this.contactTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DriverDetails";
            this.Text = "driver_details";
            this.Load += new System.EventHandler(this.driver_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capacityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.TextBox carnoTxt;
        private System.Windows.Forms.NumericUpDown capacityUpDown;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView driverGView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supplierTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}