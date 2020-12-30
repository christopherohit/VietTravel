using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VietTravel
{
    public partial class Confirm_Registration : Form
    {
        string cStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public Button tio { get { return this.complete; } }
        public Confirm_Registration()
        {
            InitializeComponent();
        }

        private void Confirm_Registration_Load(object sender, EventArgs e)
        {
            MessageBox.Show("To Complete Registration Account For Client Please Type password !");
        }

        private void complete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            System.Windows.Forms.Form a = System.Windows.Forms.Application.OpenForms["ThemKhachHang"];
            if (complete.Text == "Done")
            {
                if (pass.Text == "" || checkpass.Text == "")
                {
                    if (pass.Text == "")
                    {
                        MessageBox.Show("Please Fill In Blank");
                    }
                    if (checkpass.Text == "")
                    {
                        MessageBox.Show("Please Fill In Blank");

                    }
                }
                else if (pass.Text != checkpass.Text)
                {
                    MessageBox.Show("Your Confirm Password not same your password. \nPlease re-check it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass.Text.Length < 6)
                {
                    if (pass.Text.Length < 6)
                    {
                        MessageBox.Show("Inconsistent password length, \nLength should be less than 20 and longer than 3 letters \nPlease try again");
                    }
                }
                else
                {
                    string update = "update KhachHang set Matkhau = @matkhau where Emails = @emails";
                    SqlCommand command = new SqlCommand(update, con);
                    command.Parameters.AddWithValue("emails", ((ThemKhachHang)a).Emails.Text);
                    command.Parameters.AddWithValue("@matkhau", pass.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    MessageBox.Show("Completety Registration");
                    TrangChu trangChu = new TrangChu();
                    trangChu.Show();
                    this.Hide();
                }

            }
            else if (complete.Text == "OK")
            {
                if (pass.Text == "" || checkpass.Text == "")
                {
                    if (pass.Text == "")
                    {
                        MessageBox.Show("Please Fill In Blank");
                    }
                    if (checkpass.Text == "")
                    {
                        MessageBox.Show("Please Fill In Blank");

                    }
                }
                else if (pass.Text != checkpass.Text)
                {
                    MessageBox.Show("Your Confirm Password not same your password. \nPlease re-check it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass.Text.Length < 6)
                {
                    if (pass.Text.Length < 6)
                    {
                        MessageBox.Show("Inconsistent password length, \nLength should be less than 20 and longer than 3 letters \nPlease try again");
                    }
                }
                else
                {
                    string update = "update KhachHang set Matkhau = @matkhau where Emails = @emails";
                    SqlCommand command = new SqlCommand(update, con);
                    command.Parameters.AddWithValue("emails", ((ThemKhachHang)a).Emails.Text);
                    command.Parameters.AddWithValue("@matkhau", pass.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    MessageBox.Show("Completety Registration");
                    TrangChu trangChu = new TrangChu();
                    trangChu.Show();
                    this.Hide();
                }
            }
        }

        private void Confirm_Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            dynamic res = MessageBox.Show("Do you want to exit registration ?", "Exit Registration", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                TrangChu taolai = new TrangChu();
                taolai.Show();
                this.Hide();
            }
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
