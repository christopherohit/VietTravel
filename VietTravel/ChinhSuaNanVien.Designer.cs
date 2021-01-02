
namespace VietTravel
{
    partial class ChinhSuaNanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSuaNanVien));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PhongBan = new System.Windows.Forms.ComboBox();
            this.Chucvu = new System.Windows.Forms.ComboBox();
            this.dayofbirth = new System.Windows.Forms.DateTimePicker();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.NameFull = new System.Windows.Forms.TextBox();
            this.privacy = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privacy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PhongBan
            // 
            this.PhongBan.FormattingEnabled = true;
            this.PhongBan.Items.AddRange(new object[] {
            "Administration Institute",
            "Tourist Guide",
            "Staff Accountant",
            "Customer Care Staff"});
            this.PhongBan.Location = new System.Drawing.Point(143, 304);
            this.PhongBan.Name = "PhongBan";
            this.PhongBan.Size = new System.Drawing.Size(200, 21);
            this.PhongBan.TabIndex = 45;
            // 
            // Chucvu
            // 
            this.Chucvu.FormattingEnabled = true;
            this.Chucvu.Items.AddRange(new object[] {
            "None",
            "CEO",
            "Deputy Head Of Accounting Department",
            "Accounting manager",
            "Deputy Accounting Director",
            "Secretary Deputy Accounting Director",
            "Secretary of Accounting Director",
            "Office workers",
            "Director of strantegy"});
            this.Chucvu.Location = new System.Drawing.Point(144, 345);
            this.Chucvu.Name = "Chucvu";
            this.Chucvu.Size = new System.Drawing.Size(200, 21);
            this.Chucvu.TabIndex = 44;
            // 
            // dayofbirth
            // 
            this.dayofbirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dayofbirth.Location = new System.Drawing.Point(143, 174);
            this.dayofbirth.Name = "dayofbirth";
            this.dayofbirth.Size = new System.Drawing.Size(200, 20);
            this.dayofbirth.TabIndex = 43;
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(143, 218);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(200, 20);
            this.phonenumber.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Competence:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Permanent Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Date of birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Full Name:";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(143, 263);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 20);
            this.address.TabIndex = 34;
            // 
            // NameFull
            // 
            this.NameFull.Location = new System.Drawing.Point(143, 128);
            this.NameFull.Name = "NameFull";
            this.NameFull.Size = new System.Drawing.Size(200, 20);
            this.NameFull.TabIndex = 35;
            // 
            // privacy
            // 
            this.privacy.BackColor = System.Drawing.Color.Silver;
            this.privacy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.privacy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.privacy.Location = new System.Drawing.Point(468, 134);
            this.privacy.Name = "privacy";
            this.privacy.Size = new System.Drawing.Size(183, 173);
            this.privacy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.privacy.TabIndex = 47;
            this.privacy.TabStop = false;
            this.privacy.Click += new System.EventHandler(this.privacy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Personal Photo:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(58, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(259, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // Next
            // 
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Location = new System.Drawing.Point(568, 368);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 49;
            this.Next.Text = "OK";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChinhSuaNanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 403);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.privacy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PhongBan);
            this.Controls.Add(this.Chucvu);
            this.Controls.Add(this.dayofbirth);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.address);
            this.Controls.Add(this.NameFull);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChinhSuaNanVien";
            this.Text = "Update Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChinhSuaDaiLy_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privacy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox PhongBan;
        private System.Windows.Forms.ComboBox Chucvu;
        private System.Windows.Forms.DateTimePicker dayofbirth;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox NameFull;
        private System.Windows.Forms.PictureBox privacy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Next;
    }
}