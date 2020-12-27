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
        public Button GetButton { get { return this.ContinueBut; } }

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
            System.Windows.Forms.Form dknhanvien = System.Windows.Forms.Application.OpenForms["DangKyNhanVien"];
            SqlConnection con = new SqlConnection(cStr);
            System.Windows.Forms.Form trangchu = System.Windows.Forms.Application.OpenForms["TrangChu"];
            if (ContinueBut.Text.Equals("OK"))
            {

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
                else if (MailsAcc.Text != "")
                {
                    if (Major.Text == "Tourist Guide")
                    {
                        string kiem = "select * from HuongDanVien where Emails = @emails";
                        SqlCommand command = new SqlCommand(kiem, con);
                        command.Parameters.AddWithValue("@emails", MailsAcc.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        if (data.Rows.Count > 0)
                        {
                            MessageBox.Show("Someone was used this emails, Please check it again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(((TrangChu)trangchu).sdt.Text);
                            string capnhap = "update HuongDanVien set Emails = @emails , MatKhau = @matkhau where SoDienThoai = @sdt";
                            SqlCommand command1 = new SqlCommand(capnhap, con);
                            command1.Parameters.AddWithValue("@emails", MailsAcc.Text);
                            command1.Parameters.AddWithValue("@matkhau", PassBox.Text);
                            command1.Parameters.AddWithValue("@sdt", ((TrangChu)trangchu).sdt.Text);
                            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                            DataTable data1 = new DataTable();
                            adapter1.Fill(data1);
                            MessageBox.Show("Registration Completely !");
                            TrangChu abc = new TrangChu();
                            abc.Show();
                            this.Hide();

                        }
                    }
                    else if (Major.Text == "Staff Accountant")
                    {
                        string kiem2 = "select * from NhanVienKeToan where Emails = @emails";
                        SqlCommand command = new SqlCommand(kiem2, con);
                        command.Parameters.AddWithValue("@emails", MailsAcc.Text);
                        SqlDataAdapter sqlData = new SqlDataAdapter(command);
                        DataTable data = new DataTable();
                        sqlData.Fill(data);
                        if (data.Rows.Count > 0)
                        {
                            MessageBox.Show("Someone was used this emails, Please check it again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string capnhat2 = "update NhanVienKeToan set Emails = @emails , matkhau = @matkhau where phone = @sdt";
                            SqlCommand sql = new SqlCommand(capnhat2, con);
                            sql.Parameters.AddWithValue("@emails", MailsAcc.Text);
                            sql.Parameters.AddWithValue("@matkhau", PassBox.Text);
                            sql.Parameters.AddWithValue("@sdt", ((TrangChu)trangchu).sdt3.Text);
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
                            DataTable table = new DataTable();
                            dataAdapter.Fill(table);
                            MessageBox.Show("Registration Completely !");
                            TrangChu abc = new TrangChu();
                            abc.Show();
                            this.Hide();
                        }
                    }
                    else if (Major.Text == "Customer Care Staff")
                    {
                        string kiemthu3 = "select * from CSKH where emais = @emails";
                        SqlCommand command = new SqlCommand(kiemthu3, con);
                        command.Parameters.AddWithValue("@emails", MailsAcc.Text);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            MessageBox.Show("Someone was used this emails, Please check it again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string capnhat3 = "Update CSKH set Emais = @emails , Matkhau = @pass  where PhoneNum = @sdt";
                            SqlCommand sqlCommand = new SqlCommand(capnhat3, con);
                            sqlCommand.Parameters.AddWithValue("@emails", MailsAcc.Text);
                            sqlCommand.Parameters.AddWithValue("@pass", PassBox.Text);
                            sqlCommand.Parameters.AddWithValue("@sdt", ((TrangChu)trangchu).sdt2.Text);
                            SqlDataAdapter sql = new SqlDataAdapter(sqlCommand);
                            DataTable data = new DataTable();
                            sql.Fill(data);
                            MessageBox.Show("Registration Completely !");
                            TrangChu abc = new TrangChu();
                            abc.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else if (ContinueBut.Text == "Done")
            {
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
                else if (MailsAcc.Text != "")
                {
                    if (Major.Text == "Tourist Guide")
                    {
                        string kiem ="select * from HuongDanVien where Emails = @emails";
                        SqlCommand command = new SqlCommand(kiem, con);
                        command.Parameters.AddWithValue("@emails", MailsAcc.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        if (data.Rows.Count > 0)
                        {
                            MessageBox.Show("Someone was used this emails, Please check it again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                                MessageBox.Show(((DangkyNhanVien)dknhanvien).sodt.Text);
                                string capnhap = "update HuongDanVien set Emails = @emails , MatKhau = @matkhau where SoDienThoai = @sdt";
                                SqlCommand command1 = new SqlCommand(capnhap, con);
                                command1.Parameters.AddWithValue("@emails", MailsAcc.Text);
                                command1.Parameters.AddWithValue("@matkhau", PassBox.Text);
                                command1.Parameters.AddWithValue("sdt", ((DangkyNhanVien)dknhanvien).sodt.Text);
                                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                                DataTable data1 = new DataTable();
                                adapter1.Fill(data1);
                                MessageBox.Show("Registration new Employ completely. \nYou need to re-signin into the system");
                                MessageBox.Show("Registration Completely !");
                                TrangChu abc = new TrangChu();
                                abc.Show();
                                this.Hide();

                        }
                    }
                    else if(Major.Text == "Staff Accountant")
                    {
                        MessageBox.Show(((DangkyNhanVien)dknhanvien).sodt.Text);
                        string kiem2 = "select * from NhanVienKeToan where Emails = @emails";
                        SqlCommand command = new SqlCommand(kiem2, con);
                        command.Parameters.AddWithValue("@emails", MailsAcc.Text);
                        SqlDataAdapter sqlData = new SqlDataAdapter(command);
                        DataTable data = new DataTable();
                        sqlData.Fill(data);
                        if (data.Rows.Count >0)
                        {
                            MessageBox.Show("Someone was used this emails, Please check it again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string capnhat2 = "update NhanVienKeToan set Emails = @emails , matkhau = @matkhau where phone = @sdt";
                            SqlCommand sql = new SqlCommand(capnhat2, con);
                            sql.Parameters.AddWithValue("@emails", MailsAcc.Text);
                            sql.Parameters.AddWithValue("@matkhau", PassBox.Text);
                            sql.Parameters.AddWithValue("@sdt", ((DangkyNhanVien)dknhanvien).sodt.Text);
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
                            DataTable table = new DataTable();
                            dataAdapter.Fill(table);
                            MessageBox.Show("Registration Completely !");
                            TrangChu abc = new TrangChu();
                            abc.Show();
                            this.Hide();
                        }
                    }
                    else if (Major.Text == "Customer Care Staff")
                    {
                        MessageBox.Show("s");
                        string kiemthu3 = "select * from CSKH where emais = @emails";
                        SqlCommand command = new SqlCommand(kiemthu3, con);
                        command.Parameters.AddWithValue("@emails", MailsAcc.Text);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            MessageBox.Show("Someone was used this emails, Please check it again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("s");
                            string capnhat3 = "Update CSKH set Emais = @emails , Matkhau = @pass  where PhoneNum = @sdt";
                            SqlCommand sqlCommand = new SqlCommand(capnhat3);
                            sqlCommand.Parameters.AddWithValue("@emails", MailsAcc.Text);
                            sqlCommand.Parameters.AddWithValue("@pass", PassBox.Text);
                            sqlCommand.Parameters.AddWithValue("@sdt", ((DangkyNhanVien)dknhanvien).sodt.Text);
                            SqlDataAdapter sql = new SqlDataAdapter(sqlCommand);
                            DataTable data = new DataTable();
                            sql.Fill(data);
                            MessageBox.Show("Registration Completely !");
                            TrangChu abc = new TrangChu();
                            abc.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
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
                        if (data.Rows.Count > 0)
                        {
                            if (PassHide.Text != "TRG29100512200X")
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
                                    themnhanvien.Parameters.AddWithValue("@emails", MailsAcc.Text);
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
            else if (Major.Text.Equals("Tourist Guide"))
            {
                if (ContinueBut.Text.Equals("OK") || ContinueBut.Text.Equals("Done"))
                {
                    PassHide.Visible = false;
                    label6.Visible = false;
                }
            }
            else if (Major.Text.Equals("Staff Accountant"))
            {
                if(ContinueBut.Text.Equals("OK") || ContinueBut.Text.Equals("Done"))
                {
                    PassHide.Visible = false;
                    label6.Visible = false;
                }
            }
            else if (Major.Text.Equals("Customer Care Staff"))
            {
                if(ContinueBut.Text.Equals("OK") || ContinueBut.Text.Equals("Done"))
                {
                    PassHide.Visible = false;
                    label6.Visible = false;
                }
            }
        }

        private void DangKyTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            dynamic res = MessageBox.Show("Do you want to exit this form ?", "VieTravel", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Signin to = new Signin();
                to.Show();
                this.Hide();
            }
            if(res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}



