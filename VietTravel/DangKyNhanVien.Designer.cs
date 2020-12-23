
namespace VietTravel
{
    partial class DangkyNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangkyNhanVien));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.reset = new System.Windows.Forms.Button();
            this.done_button = new System.Windows.Forms.Button();
            this.privacy = new System.Windows.Forms.PictureBox();
            this.dayofbirth = new System.Windows.Forms.DateTimePicker();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.NameFull = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Chucvu = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PhongBan = new System.Windows.Forms.ComboBox();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDuLichDataSet = new VietTravel.QuanLyDuLichDataSet();
            this.phongBanTableAdapter = new VietTravel.QuanLyDuLichDataSetTableAdapters.PhongBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.privacy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDuLichDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(555, 294);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 30;
            this.reset.Text = "Reload";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(433, 294);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(75, 23);
            this.done_button.TabIndex = 29;
            this.done_button.Text = "Next";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // privacy
            // 
            this.privacy.BackColor = System.Drawing.Color.Silver;
            this.privacy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.privacy.Location = new System.Drawing.Point(447, 55);
            this.privacy.Name = "privacy";
            this.privacy.Size = new System.Drawing.Size(183, 173);
            this.privacy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.privacy.TabIndex = 28;
            this.privacy.TabStop = false;
            this.privacy.Click += new System.EventHandler(this.privacy_Click);
            // 
            // dayofbirth
            // 
            this.dayofbirth.Location = new System.Drawing.Point(117, 101);
            this.dayofbirth.Name = "dayofbirth";
            this.dayofbirth.Size = new System.Drawing.Size(200, 20);
            this.dayofbirth.TabIndex = 27;
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(117, 145);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(200, 20);
            this.phonenumber.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Personal Photo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Permanent Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date of birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registration Information Staff";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(117, 190);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 20);
            this.address.TabIndex = 15;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // NameFull
            // 
            this.NameFull.Location = new System.Drawing.Point(117, 55);
            this.NameFull.Name = "NameFull";
            this.NameFull.Size = new System.Drawing.Size(200, 20);
            this.NameFull.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Competence:";
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
            this.Chucvu.Location = new System.Drawing.Point(118, 272);
            this.Chucvu.Name = "Chucvu";
            this.Chucvu.Size = new System.Drawing.Size(200, 21);
            this.Chucvu.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Department:";
            // 
            // PhongBan
            // 
            this.PhongBan.FormattingEnabled = true;
            this.PhongBan.Items.AddRange(new object[] {
            "Administration Institute",
            "Tourist Guide",
            "Staff Accountant",
            "Customer Care Staff"});
            this.PhongBan.Location = new System.Drawing.Point(117, 231);
            this.PhongBan.Name = "PhongBan";
            this.PhongBan.Size = new System.Drawing.Size(200, 21);
            this.PhongBan.TabIndex = 33;
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this.quanLyDuLichDataSet;
            // 
            // quanLyDuLichDataSet
            // 
            this.quanLyDuLichDataSet.DataSetName = "QuanLyDuLichDataSet";
            this.quanLyDuLichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // DangkyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 329);
            this.Controls.Add(this.PhongBan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Chucvu);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.privacy);
            this.Controls.Add(this.dayofbirth);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.NameFull);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangkyNhanVien";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.DangkyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privacy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDuLichDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.PictureBox privacy;
        private System.Windows.Forms.DateTimePicker dayofbirth;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox NameFull;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Chucvu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PhongBan;
        private QuanLyDuLichDataSet quanLyDuLichDataSet;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private QuanLyDuLichDataSetTableAdapters.PhongBanTableAdapter phongBanTableAdapter;
    }
}