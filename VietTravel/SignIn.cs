using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace VietTravel
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserBox.Text) || string.IsNullOrWhiteSpace(PassBox.Text))
            {
                if (string.IsNullOrWhiteSpace(UserBox.Text))
                {

                }
                if (string.IsNullOrWhiteSpace(PassBox.Text))
                {
                }

                MessageBox.Show("Please Fill in The Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserBox.Text = string.Empty;
                PassBox.Text = string.Empty;
                UserBox.BackColor = Color.White;
                PassBox.BackColor = Color.White;
            }
            else if (UserBox.Text.Length <= 3 || UserBox.Text.Length >= 20)
            {

                MessageBox.Show("Inconsistent account length, \nLength should be less than 20 and longer than 3 letters \nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserBox.Text = string.Empty;
                UserBox.BackColor = Color.White;
            }
            else if (PassBox.Text.Length < 6 || PassBox.Text.Length > 30)
            {

                MessageBox.Show("Inconsistent password length, \nLength should be less than 20 and longer than 3 letters \nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PassBox.Text = string.Empty;
                PassBox.BackColor = Color.White;
            }
            else
            {
                string nickname;
                string password;
                bool isInt = int.TryParse(PassBox.Text, out int number);
                bool isIntName = int.TryParse(UserBox.Text, out number);
               
                if (UserBox.Text != "")
                {
                    nickname = UserBox.Text;
                    password = PassBox.Text;
                    // Check User Exist.
                    string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conStr);
                    string kiemhuongdanvien = "Select * from HuongDanVien where Emails = @emails and MatKhau = @matkhau";
                    SqlCommand sql = new SqlCommand(kiemhuongdanvien, con);
                    sql.Parameters.AddWithValue("@emails", nickname);
                    sql.Parameters.AddWithValue("@matkhau", password);
                    SqlDataAdapter b = new SqlDataAdapter(sql);
                    DataTable table = new DataTable();
                    b.Fill(table);
                    string kiemKetoan = "Select * from NhanVienKeToan where Emails = @emails and MatKhau = @matkhau";
                    SqlCommand sql2 = new SqlCommand(kiemKetoan, con);
                    sql2.Parameters.AddWithValue("@emails", nickname);
                    sql2.Parameters.AddWithValue("@matkhau", password);
                    SqlDataAdapter o = new SqlDataAdapter(sql2);
                    DataTable tab = new DataTable();
                    o.Fill(tab);
                    string kiemCSKH = "Select * from CSKH where Emails = @emails and MatKhau = @matkhau";
                    SqlCommand sql3 = new SqlCommand(kiemCSKH, con);
                    sql3.Parameters.AddWithValue("@emails", nickname);
                    sql3.Parameters.AddWithValue("@matkhau", password);
                    SqlDataAdapter P = new SqlDataAdapter(sql3);
                    DataTable BAP = new DataTable();
                    P.Fill(BAP);
                    string query = "select * from Account where AdminName = @tentaikhoan and PassWordAdmin = @matkhau";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@tentaikhoan", nickname);
                    command.Parameters.AddWithValue("@matkhau", password);
                    SqlDataAdapter a = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    a.Fill(data);
                    if (data.Rows.Count > 0)
                    {
                        
                        MessageBox.Show($"Hello Administrators {nickname}! Hope you have a good day", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form aform = new TrangChu();
                        aform.Show();
                        this.Hide();
                    }
                    else if (table.Rows.Count > 0)
                    {
                        string layten = "select HuongDanVien from HuongDanVien Where Emails = @emails";
                        SqlCommand sql1 = new SqlCommand(layten, con);
                        sql1.Parameters.AddWithValue("@emails", nickname);
                        SqlDataAdapter da = new SqlDataAdapter(sql1);
                        DataTable i = new DataTable();
                        da.Fill(i);
                        MessageBox.Show($"Hello Tourist Guide {i.Rows[0].ItemArray[0].ToString()}! Hope you have a good day", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    else if(tab.Rows.Count > 0)
                    {
                        string layen = "select Hoten from NhanVienKeToan Where Emails = @emails";
                        SqlCommand sqll2 = new SqlCommand(layen, con);
                        sqll2.Parameters.AddWithValue("@emails", nickname);
                        SqlDataAdapter ada = new SqlDataAdapter(sqll2);
                        DataTable r = new DataTable();
                        ada.Fill(r);
                        MessageBox.Show($"Hello Accountant {r.Rows[0].ItemArray[0].ToString()}! Hope you have a good day", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                    }
                    else if (BAP.Rows.Count > 0)
                    {
                        string layen = "select HoTen from CSKH Where Emais = @emails";
                        SqlCommand sqll2 = new SqlCommand(layen, con);
                        sqll2.Parameters.AddWithValue("@emails", nickname);
                        SqlDataAdapter ada = new SqlDataAdapter(sqll2);
                        DataTable r = new DataTable();
                        ada.Fill(r);
                        MessageBox.Show($"Hello Customer Care Staff {r.Rows[0].ItemArray[0].ToString()}! Hope you have a good day", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Please account not available \nPlease Try Again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UserBox.Text = string.Empty;
                        PassBox.Text = string.Empty;
                    }


                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form checkadmin = new CheckAdmin();
            checkadmin.Show();

        }

        private void Signin_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void HelpBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Every Employ must be signin and signup by Emails . Just only Admin Can sign by Account Available");
        }
    }
}
