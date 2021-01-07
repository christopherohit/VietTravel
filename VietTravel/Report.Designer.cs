
namespace VietTravel
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.ChuyenDiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyDuLichDataSet5 = new VietTravel.QuanLyDuLichDataSet5();
            this.ChuyenDiTableAdapter = new VietTravel.QuanLyDuLichDataSet5TableAdapters.ChuyenDiTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aGENCYFORAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDuLichDataSet6 = new VietTravel.QuanLyDuLichDataSet6();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.aGENCYFORAdminTableAdapter = new VietTravel.QuanLyDuLichDataSet6TableAdapters.AGENCYFORAdminTableAdapter();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChuyenDiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyDuLichDataSet5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCYFORAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDuLichDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ChuyenDiBindingSource
            // 
            this.ChuyenDiBindingSource.DataMember = "ChuyenDi";
            this.ChuyenDiBindingSource.DataSource = this.QuanLyDuLichDataSet5;
            // 
            // QuanLyDuLichDataSet5
            // 
            this.QuanLyDuLichDataSet5.DataSetName = "QuanLyDuLichDataSet5";
            this.QuanLyDuLichDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChuyenDiTableAdapter
            // 
            this.ChuyenDiTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(13, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Report";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "BaoCaoDoanhSoChuyenDi";
            reportDataSource2.Value = this.ChuyenDiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VietTravel.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportPath = "Report1.rdlc";
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(984, 294);
            this.reportViewer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report Builder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Agency:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Amazing",
            "Arizo",
            "Raizent",
            "Xizonion",
            "LinQ",
            "Peninsula",
            "Georgia",
            "Florida",
            "Virginia",
            "Pennsylvania",
            "Alaska",
            "Nevada",
            "New Jersey",
            "Delaware",
            "Minnesota",
            "Wisconsin",
            "Missouri",
            "Vermont",
            "Suncheon",
            "Gwacheon",
            "Michigan"});
            this.comboBox1.Location = new System.Drawing.Point(104, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // aGENCYFORAdminBindingSource
            // 
            this.aGENCYFORAdminBindingSource.DataMember = "AGENCYFORAdmin";
            this.aGENCYFORAdminBindingSource.DataSource = this.quanLyDuLichDataSet6;
            // 
            // quanLyDuLichDataSet6
            // 
            this.quanLyDuLichDataSet6.DataSetName = "QuanLyDuLichDataSet6";
            this.quanLyDuLichDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(883, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Print All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aGENCYFORAdminTableAdapter
            // 
            this.aGENCYFORAdminTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 426);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Report_FormClosed);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChuyenDiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyDuLichDataSet5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aGENCYFORAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDuLichDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ChuyenDiBindingSource;
        private QuanLyDuLichDataSet5 QuanLyDuLichDataSet5;
        private QuanLyDuLichDataSet5TableAdapters.ChuyenDiTableAdapter ChuyenDiTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private QuanLyDuLichDataSet6 quanLyDuLichDataSet6;
        private System.Windows.Forms.BindingSource aGENCYFORAdminBindingSource;
        private QuanLyDuLichDataSet6TableAdapters.AGENCYFORAdminTableAdapter aGENCYFORAdminTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}