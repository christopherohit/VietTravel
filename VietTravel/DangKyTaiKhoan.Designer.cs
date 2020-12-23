
namespace VietTravel
{
    partial class DangKyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyTaiKhoan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MailsAcc = new System.Windows.Forms.TextBox();
            this.ConfPass = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PassHide = new System.Windows.Forms.TextBox();
            this.Major = new System.Windows.Forms.ComboBox();
            this.phongBanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDuLichDataSet1 = new VietTravel.QuanLyDuLichDataSet();
            this.quanLyDuLichDataSet = new VietTravel.QuanLyDuLichDataSet();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongBanTableAdapter = new VietTravel.QuanLyDuLichDataSetTableAdapters.PhongBanTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.ContinueBut = new System.Windows.Forms.Button();
            this.phongBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDuLichDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDuLichDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Member Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emails:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Majority:";
            // 
            // MailsAcc
            // 
            this.MailsAcc.Location = new System.Drawing.Point(502, 82);
            this.MailsAcc.Name = "MailsAcc";
            this.MailsAcc.Size = new System.Drawing.Size(162, 20);
            this.MailsAcc.TabIndex = 4;
            // 
            // ConfPass
            // 
            this.ConfPass.Location = new System.Drawing.Point(502, 152);
            this.ConfPass.Name = "ConfPass";
            this.ConfPass.PasswordChar = '*';
            this.ConfPass.Size = new System.Drawing.Size(162, 20);
            this.ConfPass.TabIndex = 4;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(502, 116);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(162, 20);
            this.PassBox.TabIndex = 4;
            // 
            // PassHide
            // 
            this.PassHide.Location = new System.Drawing.Point(501, 235);
            this.PassHide.Name = "PassHide";
            this.PassHide.PasswordChar = '*';
            this.PassHide.Size = new System.Drawing.Size(162, 20);
            this.PassHide.TabIndex = 4;
            // 
            // Major
            // 
            this.Major.FormattingEnabled = true;
            this.Major.Items.AddRange(new object[] {
            "Administration Institute",
            "Tourist Guide",
            "Staff Accountant",
            "Customer Care Staff"});
            this.Major.Location = new System.Drawing.Point(501, 190);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(162, 21);
            this.Major.TabIndex = 5;
            this.Major.SelectedIndexChanged += new System.EventHandler(this.Major_SelectedIndexChanged);
            this.Major.SelectedValueChanged += new System.EventHandler(this.Major_SelectedValueChanged);
            // 
            // phongBanBindingSource2
            // 
            this.phongBanBindingSource2.DataMember = "PhongBan";
            this.phongBanBindingSource2.DataSource = this.quanLyDuLichDataSet1;
            // 
            // quanLyDuLichDataSet1
            // 
            this.quanLyDuLichDataSet1.DataSetName = "QuanLyDuLichDataSet";
            this.quanLyDuLichDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyDuLichDataSet
            // 
            this.quanLyDuLichDataSet.DataSetName = "QuanLyDuLichDataSet";
            this.quanLyDuLichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this.quanLyDuLichDataSet;
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Department Code:";
            // 
            // ContinueBut
            // 
            this.ContinueBut.Location = new System.Drawing.Point(605, 288);
            this.ContinueBut.Name = "ContinueBut";
            this.ContinueBut.Size = new System.Drawing.Size(75, 23);
            this.ContinueBut.TabIndex = 7;
            this.ContinueBut.Text = "Next";
            this.ContinueBut.UseVisualStyleBackColor = true;
            this.ContinueBut.Click += new System.EventHandler(this.ContinueBut_Click);
            // 
            // phongBanBindingSource1
            // 
            this.phongBanBindingSource1.DataMember = "PhongBan";
            this.phongBanBindingSource1.DataSource = this.quanLyDuLichDataSet;
            // 
            // DangKyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 323);
            this.Controls.Add(this.ContinueBut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Major);
            this.Controls.Add(this.PassHide);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.ConfPass);
            this.Controls.Add(this.MailsAcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKyTaiKhoan";
            this.Text = "Đăng Ký Tài Khoản";
            this.Load += new System.EventHandler(this.DangKyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDuLichDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDuLichDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MailsAcc;
        private System.Windows.Forms.TextBox ConfPass;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox PassHide;
        private System.Windows.Forms.ComboBox Major;
        private QuanLyDuLichDataSet quanLyDuLichDataSet;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private QuanLyDuLichDataSetTableAdapters.PhongBanTableAdapter phongBanTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ContinueBut;
        private System.Windows.Forms.BindingSource phongBanBindingSource1;
        private QuanLyDuLichDataSet quanLyDuLichDataSet1;
        private System.Windows.Forms.BindingSource phongBanBindingSource2;
    }
}