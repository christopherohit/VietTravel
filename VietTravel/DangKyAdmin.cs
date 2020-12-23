using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietTravel
{
    public partial class DangKyAdmin : Form
    {
        string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";
        public DangKyAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(AdmiName.Text) || string.IsNullOrWhiteSpace(PassAdmi.Text) || string.IsNullOrWhiteSpace(RePassAdmi.Text))
            {
                MessageBox.Show("Please fill in blankspace", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PassAdmi.Text != RePassAdmi.Text)
            {
                MessageBox.Show("Your Confirm Password not same your password. \nPlease re-check it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RePassAdmi.Text = string.Empty;
            }
            else if (AdmiName.Text.Length < 2 || PassAdmi.Text.Length < 6)
            {
                if (AdmiName.Text.Length < 2)
                {
                    MessageBox.Show("Your Name Just Fill In Too Short \n Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdmiName.BackColor = Color.White;
                    AdmiName.Text = string.Empty;
                }
                else if (PassAdmi.Text.Length < 6)
                {
                    MessageBox.Show("Your Password Which You Just Fill In Too Short \n We Required You Should Set The Password Which Have More And More Characters \n Thanks You.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PassAdmi.BackColor = Color.White;
                    PassAdmi.Text = string.Empty;
                }
            }
            else
            {
                    string fakename = AdmiName.Text;
                    string secure = PassAdmi.Text;
                    SqlConnection con = new SqlConnection(conStr);
                    string query = "select * from Account where AdminName = @tentaikhoan ";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@tentaikhoan", fakename);
                    DataTable data = new DataTable();
                    SqlDataAdapter a = new SqlDataAdapter(command);
                    a.Fill(data);
                    if (data.Rows.Count > 0)
                    {
                        MessageBox.Show("Bạn đã có sẵn trong hệ thống của tôi .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdmiName.Text = string.Empty;
                        PassAdmi.Text = string.Empty;
                    }
                else
                    {
                        SqlConnection conc = new SqlConnection(conStr);
                    string query2 = $"Insert into Account (AdminName , PassWordAdmin) values (@TaiKhoan , @MatKhau);";
                        SqlCommand sql = new SqlCommand(query2, conc);
                        sql.Parameters.AddWithValue("@TaiKhoan", AdmiName.Text);
                        sql.Parameters.AddWithValue("@MatKhau", PassAdmi.Text);
                        SqlDataAdapter c = new SqlDataAdapter(sql);
                        DataTable table = new DataTable();
                        c.Fill(table);
                        MessageBox.Show("SignUp Successfully, \nPlease Re-SignIn to System", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Form newadmin = new Signin();
                    newadmin.Show();
                    Thread.Sleep(3000);
                        this.Hide();
                    
                    }

                
            }
        }

        private void DangKyAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdmiName.Text = string.Empty;
            PassAdmi.Text = string.Empty;
            RePassAdmi.Text = string.Empty;
            MessageBox.Show("Re-Load Form Success");
        }
    }
}
