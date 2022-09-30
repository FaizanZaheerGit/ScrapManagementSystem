namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    partial class scrape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scrape));
            this.WorQUpDown = new System.Windows.Forms.NumericUpDown();
            this.WorQlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.makeorderBtn = new System.Windows.Forms.Button();
            this.priceLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rateTxt = new System.Windows.Forms.TextBox();
            this.rateLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.carpartsBox = new System.Windows.Forms.ComboBox();
            this.carnoTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dcontactTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.supplierBox = new System.Windows.Forms.ComboBox();
            this.updateorderBtn = new System.Windows.Forms.Button();
            this.driverBox = new System.Windows.Forms.ComboBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.checkrBtn = new System.Windows.Forms.Button();
            this.changerBtn = new System.Windows.Forms.Button();
            this.orderidTxt = new System.Windows.Forms.TextBox();
            this.changedBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WorQUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorQUpDown
            // 
            this.WorQUpDown.Location = new System.Drawing.Point(209, 219);
            this.WorQUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.WorQUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WorQUpDown.Name = "WorQUpDown";
            this.WorQUpDown.Size = new System.Drawing.Size(219, 20);
            this.WorQUpDown.TabIndex = 0;
            this.WorQUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WorQlbl
            // 
            this.WorQlbl.AutoSize = true;
            this.WorQlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.WorQlbl.Location = new System.Drawing.Point(101, 219);
            this.WorQlbl.Name = "WorQlbl";
            this.WorQlbl.Size = new System.Drawing.Size(86, 18);
            this.WorQlbl.TabIndex = 1;
            this.WorQlbl.Text = "Weight (Kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(18, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier\'s Name";
            // 
            // contactTxt
            // 
            this.contactTxt.Enabled = false;
            this.contactTxt.Location = new System.Drawing.Point(147, 121);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(165, 20);
            this.contactTxt.TabIndex = 5;
            // 
            // commentTxt
            // 
            this.commentTxt.Location = new System.Drawing.Point(206, 377);
            this.commentTxt.Multiline = true;
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(219, 81);
            this.commentTxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(101, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comment";
            // 
            // itemBox
            // 
            this.itemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Items.AddRange(new object[] {
            "Cardboard",
            "Plastic",
            "Wood",
            "Car Parts"});
            this.itemBox.Location = new System.Drawing.Point(209, 122);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(219, 21);
            this.itemBox.TabIndex = 10;
            this.itemBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(206, 340);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(219, 20);
            this.datePicker.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(101, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(18, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Order ID";
            // 
            // makeorderBtn
            // 
            this.makeorderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.makeorderBtn.Location = new System.Drawing.Point(50, 515);
            this.makeorderBtn.Name = "makeorderBtn";
            this.makeorderBtn.Size = new System.Drawing.Size(121, 53);
            this.makeorderBtn.TabIndex = 32;
            this.makeorderBtn.Text = "Make Order";
            this.makeorderBtn.UseVisualStyleBackColor = false;
            this.makeorderBtn.Click += new System.EventHandler(this.makeorderBtn_Click);
            // 
            // priceLbl
            // 
            this.priceLbl.BackColor = System.Drawing.Color.White;
            this.priceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLbl.Cursor = System.Windows.Forms.Cursors.No;
            this.priceLbl.Location = new System.Drawing.Point(206, 296);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(219, 21);
            this.priceLbl.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(101, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Price";
            // 
            // rateTxt
            // 
            this.rateTxt.Location = new System.Drawing.Point(209, 255);
            this.rateTxt.Name = "rateTxt";
            this.rateTxt.Size = new System.Drawing.Size(219, 20);
            this.rateTxt.TabIndex = 37;
            // 
            // rateLbl
            // 
            this.rateLbl.AutoSize = true;
            this.rateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rateLbl.Location = new System.Drawing.Point(101, 259);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(98, 18);
            this.rateLbl.TabIndex = 36;
            this.rateLbl.Text = "Rate (Per Kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(101, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label12.Location = new System.Drawing.Point(101, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 40;
            this.label12.Text = "Car Parts";
            // 
            // carpartsBox
            // 
            this.carpartsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carpartsBox.Enabled = false;
            this.carpartsBox.FormattingEnabled = true;
            this.carpartsBox.Location = new System.Drawing.Point(209, 174);
            this.carpartsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carpartsBox.Name = "carpartsBox";
            this.carpartsBox.Size = new System.Drawing.Size(219, 21);
            this.carpartsBox.TabIndex = 41;
            // 
            // carnoTxt
            // 
            this.carnoTxt.Enabled = false;
            this.carnoTxt.Location = new System.Drawing.Point(147, 77);
            this.carnoTxt.Name = "carnoTxt";
            this.carnoTxt.Size = new System.Drawing.Size(165, 20);
            this.carnoTxt.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label13.Location = new System.Drawing.Point(18, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 42;
            this.label13.Text = "Driver\'s Car #";
            // 
            // dcontactTxt
            // 
            this.dcontactTxt.Enabled = false;
            this.dcontactTxt.Location = new System.Drawing.Point(147, 116);
            this.dcontactTxt.Name = "dcontactTxt";
            this.dcontactTxt.Size = new System.Drawing.Size(165, 20);
            this.dcontactTxt.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label14.Location = new System.Drawing.Point(18, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 18);
            this.label14.TabIndex = 44;
            this.label14.Text = "Driver\'s Contact #";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label15.Location = new System.Drawing.Point(18, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 18);
            this.label15.TabIndex = 46;
            this.label15.Text = "Driver\'s Name";
            // 
            // supplierBox
            // 
            this.supplierBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierBox.FormattingEnabled = true;
            this.supplierBox.Location = new System.Drawing.Point(147, 79);
            this.supplierBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(165, 21);
            this.supplierBox.TabIndex = 48;
            this.supplierBox.SelectedIndexChanged += new System.EventHandler(this.supplierBox_SelectedIndexChanged);
            // 
            // updateorderBtn
            // 
            this.updateorderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.updateorderBtn.Location = new System.Drawing.Point(189, 515);
            this.updateorderBtn.Name = "updateorderBtn";
            this.updateorderBtn.Size = new System.Drawing.Size(121, 53);
            this.updateorderBtn.TabIndex = 49;
            this.updateorderBtn.Text = "Update Order";
            this.updateorderBtn.UseVisualStyleBackColor = false;
            this.updateorderBtn.Click += new System.EventHandler(this.updateorderBtn_Click);
            // 
            // driverBox
            // 
            this.driverBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverBox.FormattingEnabled = true;
            this.driverBox.Location = new System.Drawing.Point(147, 32);
            this.driverBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.driverBox.Name = "driverBox";
            this.driverBox.Size = new System.Drawing.Size(165, 21);
            this.driverBox.TabIndex = 50;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.delBtn.Location = new System.Drawing.Point(328, 515);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(121, 53);
            this.delBtn.TabIndex = 51;
            this.delBtn.Text = "Delete Order";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkrBtn
            // 
            this.checkrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.checkrBtn.Location = new System.Drawing.Point(467, 515);
            this.checkrBtn.Name = "checkrBtn";
            this.checkrBtn.Size = new System.Drawing.Size(121, 53);
            this.checkrBtn.TabIndex = 52;
            this.checkrBtn.Text = "Check Recieved Status";
            this.checkrBtn.UseVisualStyleBackColor = false;
            this.checkrBtn.Click += new System.EventHandler(this.checkrBtn_Click);
            // 
            // changerBtn
            // 
            this.changerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.changerBtn.Location = new System.Drawing.Point(606, 515);
            this.changerBtn.Name = "changerBtn";
            this.changerBtn.Size = new System.Drawing.Size(121, 53);
            this.changerBtn.TabIndex = 53;
            this.changerBtn.Text = "Change Received Status";
            this.changerBtn.UseVisualStyleBackColor = false;
            this.changerBtn.Click += new System.EventHandler(this.changerBtn_Click);
            // 
            // orderidTxt
            // 
            this.orderidTxt.Location = new System.Drawing.Point(147, 29);
            this.orderidTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderidTxt.Name = "orderidTxt";
            this.orderidTxt.Size = new System.Drawing.Size(165, 20);
            this.orderidTxt.TabIndex = 54;
            // 
            // changedBtn
            // 
            this.changedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.changedBtn.Location = new System.Drawing.Point(745, 515);
            this.changedBtn.Name = "changedBtn";
            this.changedBtn.Size = new System.Drawing.Size(121, 53);
            this.changedBtn.TabIndex = 55;
            this.changedBtn.Text = "Change Delivered Status";
            this.changedBtn.UseVisualStyleBackColor = false;
            this.changedBtn.Click += new System.EventHandler(this.changedBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.driverBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.carnoTxt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dcontactTxt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(493, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 162);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.contactTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.orderidTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.supplierBox);
            this.groupBox2.Location = new System.Drawing.Point(493, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 169);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supplier";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(11, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 62);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 45);
            this.label1.TabIndex = 91;
            this.label1.Text = "Scrape";
            // 
            // scrape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.changedBtn);
            this.Controls.Add(this.changerBtn);
            this.Controls.Add(this.checkrBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updateorderBtn);
            this.Controls.Add(this.carpartsBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rateTxt);
            this.Controls.Add(this.rateLbl);
            this.Controls.Add(this.makeorderBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.commentTxt);
            this.Controls.Add(this.WorQlbl);
            this.Controls.Add(this.WorQUpDown);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "scrape";
            this.Text = "Admin Order";
            this.Load += new System.EventHandler(this.scrape_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorQUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown WorQUpDown;
        private System.Windows.Forms.Label WorQlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.TextBox commentTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox itemBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button makeorderBtn;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rateTxt;
        private System.Windows.Forms.Label rateLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox carpartsBox;
        private System.Windows.Forms.TextBox carnoTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox dcontactTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox supplierBox;
        private System.Windows.Forms.Button updateorderBtn;
        private System.Windows.Forms.ComboBox driverBox;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button checkrBtn;
        private System.Windows.Forms.Button changerBtn;
        private System.Windows.Forms.TextBox orderidTxt;
        private System.Windows.Forms.Button changedBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}