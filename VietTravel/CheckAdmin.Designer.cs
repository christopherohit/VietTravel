
namespace VietTravel
{
    partial class CheckAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passcheck = new System.Windows.Forms.TextBox();
            this.CheckBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please type the passcode which the company was provider for you to continue. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "This action to detect unauthorized intruder and help secure information of compan" +
    "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "If you have any questions, Please contact the admin office for more details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thanks for your attention";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please enter your passcode:";
            // 
            // passcheck
            // 
            this.passcheck.Location = new System.Drawing.Point(159, 78);
            this.passcheck.Name = "passcheck";
            this.passcheck.PasswordChar = '*';
            this.passcheck.Size = new System.Drawing.Size(193, 20);
            this.passcheck.TabIndex = 5;
            this.passcheck.Text = "2812199920032000";
            // 
            // CheckBut
            // 
            this.CheckBut.Location = new System.Drawing.Point(354, 120);
            this.CheckBut.Name = "CheckBut";
            this.CheckBut.Size = new System.Drawing.Size(75, 23);
            this.CheckBut.TabIndex = 6;
            this.CheckBut.Text = "Check";
            this.CheckBut.UseVisualStyleBackColor = true;
            this.CheckBut.Click += new System.EventHandler(this.CheckBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Visit Website:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(78, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "https://travel.com.vn/dang-nhap.aspx";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CheckAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 155);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckBut);
            this.Controls.Add(this.passcheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckAdmin";
            this.Text = "Identity Verification ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckAdmin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passcheck;
        private System.Windows.Forms.Button CheckBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}