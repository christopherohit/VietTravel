
namespace VietTravel
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.label1 = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.InBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HelpBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(232, 93);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(137, 20);
            this.UserBox.TabIndex = 1;
            this.UserBox.Text = "QuinnTran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(232, 127);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(137, 20);
            this.PassBox.TabIndex = 1;
            this.PassBox.Text = "20032000";
            // 
            // InBut
            // 
            this.InBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InBut.Location = new System.Drawing.Point(218, 178);
            this.InBut.Name = "InBut";
            this.InBut.Size = new System.Drawing.Size(75, 23);
            this.InBut.TabIndex = 2;
            this.InBut.Text = "Đăng Nhập";
            this.InBut.UseVisualStyleBackColor = true;
            this.InBut.Click += new System.EventHandler(this.InBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(359, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do you have account?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // HelpBut
            // 
            this.HelpBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpBut.BackColor = System.Drawing.Color.SlateGray;
            this.HelpBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpBut.ForeColor = System.Drawing.Color.Wheat;
            this.HelpBut.Location = new System.Drawing.Point(362, 51);
            this.HelpBut.Margin = new System.Windows.Forms.Padding(2);
            this.HelpBut.Name = "HelpBut";
            this.HelpBut.Size = new System.Drawing.Size(18, 23);
            this.HelpBut.TabIndex = 30;
            this.HelpBut.Text = "?";
            this.HelpBut.UseVisualStyleBackColor = false;
            this.HelpBut.Click += new System.EventHandler(this.HelpBut_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 247);
            this.Controls.Add(this.HelpBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InBut);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signin";
            this.Text = "Sign In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button InBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HelpBut;
    }
}

