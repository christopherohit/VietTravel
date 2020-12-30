
namespace VietTravel
{
    partial class ChinhSuaKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSuaKhachHang));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailClien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MobileNumBer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NameClient
            // 
            this.NameClient.Location = new System.Drawing.Point(191, 74);
            this.NameClient.Name = "NameClient";
            this.NameClient.Size = new System.Drawing.Size(139, 20);
            this.NameClient.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Full Name:";
            // 
            // EmailClien
            // 
            this.EmailClien.Location = new System.Drawing.Point(191, 126);
            this.EmailClien.Name = "EmailClien";
            this.EmailClien.Size = new System.Drawing.Size(139, 20);
            this.EmailClien.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Emails Address:";
            // 
            // MobileNumBer
            // 
            this.MobileNumBer.Location = new System.Drawing.Point(191, 181);
            this.MobileNumBer.Name = "MobileNumBer";
            this.MobileNumBer.Size = new System.Drawing.Size(139, 20);
            this.MobileNumBer.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Phone Number:";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(191, 237);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(139, 20);
            this.Address.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(122, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Edit Information Customer";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(391, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChinhSuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.MobileNumBer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailClien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameClient);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChinhSuaKhachHang";
            this.Text = "Edit Customers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NameClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailClien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MobileNumBer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}