
namespace VietTravel
{
    partial class Confirm_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm_Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.checkpass = new System.Windows.Forms.TextBox();
            this.complete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Re-type Password:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(286, 80);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(141, 20);
            this.pass.TabIndex = 2;
            // 
            // checkpass
            // 
            this.checkpass.Location = new System.Drawing.Point(286, 129);
            this.checkpass.Name = "checkpass";
            this.checkpass.PasswordChar = '*';
            this.checkpass.Size = new System.Drawing.Size(141, 20);
            this.checkpass.TabIndex = 2;
            // 
            // complete
            // 
            this.complete.Location = new System.Drawing.Point(273, 186);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(75, 23);
            this.complete.TabIndex = 3;
            this.complete.Text = "Done";
            this.complete.UseVisualStyleBackColor = true;
            this.complete.Click += new System.EventHandler(this.complete_Click);
            // 
            // Confirm_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 221);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.checkpass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirm_Registration";
            this.Text = "Confirm Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Confirm_Registration_FormClosing);
            this.Load += new System.EventHandler(this.Confirm_Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox checkpass;
        private System.Windows.Forms.Button complete;
    }
}