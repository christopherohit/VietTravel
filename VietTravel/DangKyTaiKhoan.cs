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
    public partial class DangKyTaiKhoan : Form
    {
        string cStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";
        public DangKyTaiKhoan()
        {
            InitializeComponent();
            

        }
        public Label GetLabel { get { return this.label5; } }
        public Label GetLabel2 { get { return this.label6; } }
        public ComboBox GetComboBox { get { return this.Major; } }
        public TextBox GetTextBox { get { return this.PassHide; } }

        private void DangKyTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDuLichDataSet1.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.quanLyDuLichDataSet1.PhongBan);
            // TODO: This line of code loads data into the 'quanLyDuLichDataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.quanLyDuLichDataSet.PhongBan);
            Major.SelectedItem = null;
            Major.SelectedText = "--Select--";

        }

        private void ContinueBut_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            if (MailsAcc.Text == "" || PassBox.Text == "")
            {
                MessageBox.Show("Please fill in blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MailsAcc.Text.Length < 10 || PassBox.Text.Length < 10)
            {
                if (MailsAcc.Text.Length < 10)
                {
                    MessageBox.Show("Your Name Just Fill In Too Short \n Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MailsAcc.Text = string.Empty;
                }
                else if (PassBox.Text.Length < 10)
                {
                    MessageBox.Show("Your Password Which You Just Fill In Too Short \nWe Required You Should Set The Password Which Have More And More Characters \nThanks You.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PassBox.BackColor = Color.White;
                    PassBox.Text = string.Empty;
                }
            }
            else if (PassBox.Text != ConfPass.Text)
            {
                MessageBox.Show("Your Confirm Password not same your password. \nPlease re-check it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConfPass.Text = string.Empty;
            }
            else if (Major.Text == "--Select--")
            {
                MessageBox.Show("You have not chosen a major", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (Major.SelectedText == "Tourist Guide")
            {
                if (PassHide.Text != "")
                {
                    string bannganh = "select * from PhongBan Where MaPhongBan = @maphongban";
                    SqlCommand sql = new SqlCommand(bannganh, con);
                    sql.Parameters.AddWithValue("@maphongban", PassHide.Text);
                    DataTable data = new DataTable();
                    SqlDataAdapter first = new SqlDataAdapter(sql);
                    first.Fill(data);
                    if(data.Rows.Count > 0)
                    {
                        if( PassHide.Text != "TRG29100512200X")
                        {
                            MessageBox.Show("Incorrect department code, Please re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string kiemtra1 = "select * from HuongDanVien where Emails = @emails";
                            SqlCommand command = new SqlCommand(kiemtra1, con);
                            command.Parameters.AddWithValue("@emails", MailsAcc.Text);
                            DataTable data1 = new DataTable();
                            SqlDataAdapter a = new SqlDataAdapter(command);
                            a.Fill(data1);
                            if (data1.Rows.Count > 0)
                            {
                                MessageBox.Show("You Have Appeared In The Company System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MailsAcc.Text = string.Empty;
                                PassBox.Text = string.Empty;
                                ConfPass.Text = string.Empty;
                            }
                            else
                            {
                                string nhap = "Insert into HuongDanVien (HuongDanVien , NgaySinh , SoDienThoai , DiaChi , Emails , AnhHuongDan, MatKhau , MaPhongBan) values (null , null , null , null , @emails , null , @matkhau , 'TRG29100512200X')";
                                SqlCommand themnhanvien = new SqlCommand(nhap, con);
                                themnhanvien.Parameters.AddWithValue("@emails" , MailsAcc.Text);
                                themnhanvien.Parameters.AddWithValue("@matkhau", PassBox.Text);
                                DataTable data2 = new DataTable();
                                SqlDataAdapter b = new SqlDataAdapter(themnhanvien);
                                b.Fill(data2);
                                MessageBox.Show("VieTravel Company  \nWelcome to your new home");
                                MessageBox.Show("You must fill personal information to complete SignUp");
                                DangkyNhanVien reset = new DangkyNhanVien();
                                reset.picture.Visible = false;
                                reset.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                
            }
            else if (Major.SelectedText == "Staff Accountant")
            {
                if (PassHide.Text != "")
                {
                    string bannganh = "select * from PhongBan Where MaPhongBan = @maphongban";
                    SqlCommand sql = new SqlCommand(bannganh, con);
                    sql.Parameters.AddWithValue("@maphongban", PassHide.Text);
                    DataTable data = new DataTable();
                    SqlDataAdapter first = new SqlDataAdapter(sql);
                    first.Fill(data);
                    if (data.Rows.Count > 0)
                    {
                        if (PassHide.Text != "STC2812200319992000")
                        {
                            MessageBox.Show("Incorrect department code, Please re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string kiemtraketoan = "select * from NhanVienKeToan where Emails = @Emails";
                            SqlCommand sql1 = new SqlCommand(kiemtraketoan, con);
                            sql1.Parameters.AddWithValue("@Emails", MailsAcc.Text);
                            DataTable table = new DataTable();
                            SqlDataAdapter sqlData = new SqlDataAdapter(sql1);
                            sqlData.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("You Have Appeared In The Company System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MailsAcc.Text = string.Empty;
                                PassBox.Text = string.Empty;
                                ConfPass.Text = string.Empty;
                            }
                            else
                            {
                                string nhapketoan = "Insert Into NhanVienKeToan (Hoten , DOB , Emails , phone , AddressNV , ChucVu , MaPhongBan , MatKhau , AnhCaNhan) values (null , null , @emails , null , null , null , 'STC2812200319992000' , @matkhau , null)";
                                SqlCommand command = new SqlCommand(nhapketoan, con);
                                command.Parameters.AddWithValue("@emails", MailsAcc.Text);
                                command.Parameters.AddWithValue("@matkhau", PassBox.Text);
                                DataTable dataTable = new DataTable();
                                SqlDataAdapter adapter = new SqlDataAdapter(command);
                                adapter.Fill(dataTable);
                                MessageBox.Show("VieTravel Company  \nWelcome to your new home");
                                MessageBox.Show("You must fill personal information to complete SignUp");
                                DangkyNhanVien reset = new DangkyNhanVien();
                                reset.picture.Visible = false;
                                reset.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
            else if (Major.Text.Equals("Customer care staff"))
            {
                if (PassHide.Text != "")
                {
                    string kiemtrabannganh = "select * from CSKH where MaPhongBan = @maphongban ";
                    SqlCommand command = new SqlCommand(kiemtrabannganh, con);
                    command.Parameters.AddWithValue("@maphongban", PassHide.Text);
                    DataTable data = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    if (data.Rows.Count > 0)
                    {
                        if (PassHide.Text != "CCS16102000X")
                        {
                            MessageBox.Show("Incorrect department code, Please re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string kiemtracskh = "select * from CSKH where Emais = @emails";
                            SqlCommand sqlCommand = new SqlCommand(kiemtracskh, con);
                            sqlCommand.Parameters.AddWithValue("@emails", MailsAcc.Text);
                            DataTable table = new DataTable();
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                            dataAdapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("You Have Appeared In The Company System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MailsAcc.Text = string.Empty;
                                PassBox.Text = string.Empty;
                                ConfPass.Text = string.Empty;
                            }
                            else
                            {
                                string nhapCSKH = "Insert into CSKH (Emais , HoTen , DateBirth , PhoneNum , DiaChiCS , ChucVuCD , AnhThe , MaPhongBan , MatKhau) select @emails , null , null , null , null , null , null , 'CCS16102000X' , @matkhau ";
                                SqlCommand sql = new SqlCommand(nhapCSKH, con);
                                sql.Parameters.AddWithValue("@emails", MailsAcc.Text);
                                sql.Parameters.AddWithValue("@matkhau", PassBox.Text);
                                DataTable dataTable = new DataTable();
                                SqlDataAdapter sqlData = new SqlDataAdapter(sql);
                                sqlData.Fill(dataTable);
                                MessageBox.Show("VieTravel Company  \nWelcome to your new home");
                                MessageBox.Show("You must fill personal information to complete SignUp");
                                DangkyNhanVien reset = new DangkyNhanVien();
                                reset.picture.Visible = false;
                                reset.Show();
                                this.Hide();
                            }
                        }
                    }
                    

                }

            }
           else if (Major.Text.Equals("Administration Institute"))
            {
                Thread.Sleep(2000);
                MessageBox.Show("You Can't Registration Administration Institute in This Form \nPlease Contact to Administrators", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PassHide.Text == "")
            {
                MessageBox.Show("Your industry code is currently empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Major_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void Major_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Major.Text.Equals("Administration Institute"))
            {
                PassHide.Visible = false;
                label6.Visible = false;
                
            }
        }
    }
}



