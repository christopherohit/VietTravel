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
                    UserBox.BackColor = Color.Red;
                }
                if (string.IsNullOrWhiteSpace(PassBox.Text))
                {
                    PassBox.BackColor = Color.Red;
                }

                MessageBox.Show("Hãy điền vào chỗ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserBox.Text = string.Empty;
                PassBox.Text = string.Empty;
                UserBox.BackColor = Color.White;
                PassBox.BackColor = Color.White;
            }
            else if (UserBox.Text.Length <= 3 || UserBox.Text.Length >= 20)
            {
                UserBox.BackColor = Color.Red;
                MessageBox.Show("Độ dài tài khoản không phù hợp, \n độ dài phải nhỏ hơn 20 và dài hơn 3 chữ cái \n Vui lòng thử lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserBox.Text = string.Empty;
                UserBox.BackColor = Color.White;
            }
            else if (PassBox.Text.Length < 6 || PassBox.Text.Length > 30)
            {
                PassBox.BackColor = Color.Red;
                MessageBox.Show("Độ dài mật khẩu không phù hợp, \n độ dài phải nhỏ hơn 20 và dài hơn 3 chữ cái \n Vui lòng thử lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PassBox.Text = string.Empty;
                PassBox.BackColor = Color.White;
            }
            else
            {
                string nickname;
                int password;
                bool isInt = int.TryParse(PassBox.Text, out int number);
                bool isIntName = int.TryParse(UserBox.Text, out number);
                if (isIntName == true || isInt == false)
                {
                    if (isIntName == true)
                    {
                        UserBox.BackColor = Color.Red;
                        MessageBox.Show("Tài Khoản vừa nhập chỉ có số không có ký tự khác \n Vui lòng thừ lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UserBox.Text = string.Empty;
                        UserBox.BackColor = Color.White;
                    }
                    else
                    {
                        nickname = UserBox.Text;
                    }
                    if (isInt == true)
                    {
                        /*PassBox.BackColor = Color.Red;
                        MessageBox.Show("Mật khẩu chỉ Bao gồm số \n Vui lòng thử lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PassBox.Text = string.Empty;
                        PassBox.BackColor = Color.White;*/
                        password = Convert.ToInt32(PassBox.Text);
                    }
                
                }
                else
                {
                    nickname = UserBox.Text;
                    password = Convert.ToInt32(PassBox.Text);
                    // Check User Exist.
                    string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conStr);

                    string query = "select * from Account where AdminName = @tentaikhoan and PassWordAdmin = @matkhau";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@tentaikhoan", nickname);
                    command.Parameters.AddWithValue("@matkhau", password);
                    SqlDataAdapter a = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    a.Fill(data);
                    if (data.Rows.Count > 0)
                    {
                        MessageBox.Show($"Hello {nickname}! Hy vọng bạn có một ngày tốt lành ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form aform = new TrangChu();
                        aform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Xin tài khoản không có sẵn \n Xin Vui Lòng Thử Lại ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Application.Exit();
        }

        private void HelpBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Every Employ must be signin and signup by Emails . Just only Admin Can sign by Account Available");
        }
    }
}
