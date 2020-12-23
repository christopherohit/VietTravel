using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Data.SqlClient;

namespace VietTravel
{
    public partial class CheckAdmin : Form
    {
        const string Pass_code = "2812199920032000";
        const string adminsignup = "0792361509";

        public CheckAdmin()
        {
            InitializeComponent();
        }

        private void CheckBut_Click(object sender, EventArgs e)
        {
            
            if ( passcheck.Text ==  Pass_code)
            {
                Form chapnhan = new DangKyTaiKhoan();
                chapnhan.Show();
                this.Close();
            }
            else if(passcheck.Text == adminsignup)
            {
                Form dangkyadmi = new DangKyAdmin();
                dangkyadmi.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"PassCode you have entered is incorrect, please check and re-enter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Form trolai = new Signin();
            trolai.Show();
            this.Hide();*/
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://travel.com.vn/dang-nhap.aspx");
            Thread.Sleep(3000);
        }
    }
}
