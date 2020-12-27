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
using System.IO;
using System.Globalization;
using System.Drawing.Imaging;


namespace VietTravel
{
    
    public partial class TrangChu : Form
    {
        string toannang = Path.GetFullPath("/VietTravel/Used/HuongDanVien/");
        string toanbo = Path.GetFullPath("/VietTravel/Used/KeToan/");
        string toanphan = Path.GetFullPath("/VietTravel/Used/CSKH/");
        string cStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";
        public bool IsDirty =true;
        public TextBox sdt { get { return this.PhonePretty; } set { PhonePretty = value; } }
        public TextBox sdt2 { get { return this.SDTCSKH; } }
        public TextBox sdt3 { get { return this.SDTKt; } }
        public DataGridView grid { get { return this.InforCusGridView; } }
        public TrangChu()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void Daily_Click(object sender, EventArgs e)
        {

        }

        public void TrangChu_Load(object sender, EventArgs e)
        {
            // Load Infor for Pretty
            SqlConnection con1 = new SqlConnection(cStr);
            string query1 = "Select * from HuongDanVien ";
            SqlCommand command1 = new SqlCommand(query1, con1);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable data1 = new DataTable();
            adapter1.Fill(data1);
            PrettyGribView.DataSource = data1;
            PrettyGribView.Columns["MaHDV"].Visible = false;
            PrettyGribView.Columns["AnhHuongDan"].Visible = false;
            PrettyGribView.Columns["MatKhau"].Visible = false;
            PrettyGribView.AutoGenerateColumns = false;
            PrettyGribView.ReadOnly = true;
            PrettyGribView.Columns["MaPhongBan"].Visible = false;
            PrettyGribView.Columns["HuongDanVien"].HeaderText = "Name Staff";
            PrettyGribView.Columns["NgaySinh"].HeaderText = "Date Of Birth";
            PrettyGribView.Columns["SoDienThoai"].HeaderText = "Mobile Phone";
            PrettyGribView.Columns["DiaChi"].HeaderText = "Address";
            PrettyGribView.Columns["Emails"].HeaderText = "Emails";
            PrettyGribView.AllowUserToAddRows = false;
            PrettyGribView.Rows.RemoveAt(PrettyGribView.Rows.Count - 1);

            // Load Infor for KT
            string query2 = "Select * from NhanVienKeToan";
            SqlCommand command2 = new SqlCommand(query2, con1);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            DataTable data2 = new DataTable();
            adapter2.Fill(data2);
            NhanVienKeToanGribView.DataSource = data2;
            NhanVienKeToanGribView.Columns["MaKeToan"].Visible = false;
            NhanVienKeToanGribView.Columns["MaPhongBan"].Visible = false;
            NhanVienKeToanGribView.Columns["MatKhau"].Visible = false;
            NhanVienKeToanGribView.Columns["AnhCaNhan"].Visible = false;
            NhanVienKeToanGribView.AutoGenerateColumns = false;
            NhanVienKeToanGribView.ReadOnly = true;
            NhanVienKeToanGribView.Columns["Hoten"].HeaderText = "Name Staff";
            NhanVienKeToanGribView.Columns["DOB"].HeaderText = "Day Of Birth";
            NhanVienKeToanGribView.Columns["Phone"].HeaderText = "Mobile Phone";
            NhanVienKeToanGribView.Columns["AddressNV"].HeaderText = "Address";
            NhanVienKeToanGribView.Columns["ChucVu"].HeaderText = "Regency";
            NhanVienKeToanGribView.AllowUserToAddRows = false;
            NhanVienKeToanGribView.Rows.RemoveAt(NhanVienKeToanGribView.Rows.Count - 1);

            // Load Infor For CSKH
            string query3 = "select * from CSKH";
            SqlCommand command3 = new SqlCommand(query3, con1);
            SqlDataAdapter adapter3 = new SqlDataAdapter(command3);
            DataTable data3 = new DataTable();
            adapter3.Fill(data3);
            CSKHGridView.DataSource = data3;
            CSKHGridView.ReadOnly = true;
            CSKHGridView.AutoGenerateColumns = false;
            CSKHGridView.Columns["MaHDV"].Visible = false;
            CSKHGridView.Columns["MaPhongBan"].Visible = false;
            CSKHGridView.Columns["MatKhau"].Visible = false;
            CSKHGridView.Columns["AnhThe"].Visible = false;
            CSKHGridView.Columns["Hoten"].HeaderText = "Name Staff";
            CSKHGridView.Columns["DateBirth"].HeaderText = "Date Of Birth";
            CSKHGridView.Columns["PhoneNum"].HeaderText = "Mobile Phone";
            CSKHGridView.Columns["DiachiCS"].HeaderText = "Address";
            CSKHGridView.Columns["ChucVuCD"].HeaderText = "Regency";
            CSKHGridView.AllowUserToAddRows = false;
            CSKHGridView.Rows.RemoveAt(CSKHGridView.Rows.Count - 1);

            // Load Infor For Client
            string query4 = "select * from KhachHang";
            SqlCommand command4 = new SqlCommand(query4, con1);
            SqlDataAdapter adapter4 = new SqlDataAdapter(command4);
            DataTable data4 = new DataTable();
            adapter4.Fill(data4);
            InforCusGridView.DataSource = data4;
            InforCusGridView.Columns["MaKH"].Visible = false;
            InforCusGridView.Columns["MaKH"].Width = 30;
            InforCusGridView.Columns["MatKhau"].Visible = false;
            InforCusGridView.AutoGenerateColumns = false;
            InforCusGridView.ReadOnly = true;
            InforCusGridView.Columns["MaKH"].HeaderText = "Ma";
            InforCusGridView.Columns["HovaTen"].HeaderText = "Customer Name";
            InforCusGridView.Columns["SoDienThoai"].HeaderText = "Phone Number";
            InforCusGridView.Columns["DiaChi"].HeaderText = "Address";
            InforCusGridView.AllowUserToAddRows = false;
            InforCusGridView.Rows.RemoveAt(InforCusGridView.Rows.Count - 1);

            //Load Agency
            string query5 = "select * from AGENCYFORAdmin";
            SqlCommand command5 = new SqlCommand(query5 , con1);
            SqlDataAdapter adapter5 = new SqlDataAdapter(command5);
            DataTable data5 = new DataTable();
            adapter5.Fill(data5);
            AgencyGribView.DataSource = data5;
            AgencyGribView.AutoGenerateColumns = false;
            AgencyGribView.ReadOnly = true;
            AgencyGribView.Columns["TenDaiLy"].HeaderText = "Agency Name";
            AgencyGribView.Columns["DiaDiem"].HeaderText = "Office Location";
            AgencyGribView.Columns["SoLuongChuyenDi"].HeaderText = "Number Trips";
            AgencyGribView.Columns["SoLuotThich"].HeaderText = "Number Likes";
            AgencyGribView.AllowUserToAddRows = false;
            AgencyGribView.Rows.RemoveAt(AgencyGribView.Rows.Count - 1);

            //Order Information
            SqlConnection con = new SqlConnection(cStr);
            string hienthi = "Select TenDiaDiem , SoLuong, NgayKhoiHanh from ChuyenDi";
            SqlCommand command = new SqlCommand(hienthi, con);
            SqlDataAdapter sql = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            sql.Fill(data);
            TripAvailableAgencyGridView.DataSource = data;
            TripAvailableAgencyGridView.ReadOnly = true;
            TripAvailableAgencyGridView.AutoGenerateColumns = false;
            TripAvailableAgencyGridView.Columns["TenDiaDiem"].HeaderText = "Tourist Attraction";
            TripAvailableAgencyGridView.Columns["SoLuong"].HeaderText = "Number Of Passengers";
            TripAvailableAgencyGridView.Columns["NgayKhoiHanh"].HeaderText = "Departure Day";
            TripAvailableAgencyGridView.Columns["NgayKhoiHanh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            TripAvailableAgencyGridView.Columns["NgayKhoiHanh"].ValueType = typeof(DateTime);
            TripAvailableAgencyGridView.AllowUserToAddRows = false;
            TripAvailableAgencyGridView.Rows.RemoveAt(TripAvailableAgencyGridView.Rows.Count - 1);
        }

        public void Display (string TenDaiLy)
        {
            SqlConnection con = new SqlConnection(cStr);
            string hienthi = "Select TenDiaDiem , SoLuong, NgayKhoiHanh from ChuyenDi where TenDaiLy in (select TenDaiLy from AgencyForAdmin where TenDaiLy = @tendaily)";
            SqlCommand command = new SqlCommand(hienthi , con);
            command.Parameters.AddWithValue("@tendaily", TenDaiLy);
            SqlDataAdapter sql = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            sql.Fill(data);
            TripAvailableAgencyGridView.DataSource = data;
            TripAvailableAgencyGridView.ReadOnly = true;
            TripAvailableAgencyGridView.AutoGenerateColumns = false;
            TripAvailableAgencyGridView.Columns["TenDiaDiem"].HeaderText = "Tourist Attraction";
            TripAvailableAgencyGridView.Columns["SoLuong"].HeaderText = "Number Of Passengers";
            TripAvailableAgencyGridView.Columns["NgayKhoiHanh"].HeaderText = "Departure Day";
            TripAvailableAgencyGridView.Columns["NgayKhoiHanh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            TripAvailableAgencyGridView.AllowUserToAddRows = false;
            TripAvailableAgencyGridView.Rows.RemoveAt(TripAvailableAgencyGridView.Rows.Count - 1);
        }
        /*public void ThongTin(string Thongtin)
        {
            SqlConnection connection = new SqlConnection(cStr);
            string query = "select MaHoaDon,MaChuyen , MaKH,  TenDiaDiem , HovaTen , Giaien , NgayKhoiHanh ,  From InforBookTrip  trip , ChuyenDi go , KhachHang cli where trip.MaChuyen = go.MaChuyen And cli.MaKH = trip.MaKH ";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable a = new DataTable();
            adapter.Fill(a);
        }*/
        public void PrettyGribView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.PrettyGribView.Rows[e.RowIndex];
                var data = (Byte[])(row.Cells["AnhHuongDan"].Value);
                var stream = new MemoryStream(data);
                NamePretty.Text = row.Cells["HuongDanVien"].Value.ToString();
                PhonePretty.Text = row.Cells["SoDienThoai"].Value.ToString();
                AddressPretty.Text = row.Cells["DiaChi"].Value.ToString();
                Mailspretty.Text = row.Cells["Emails"].Value.ToString();
                Pretty.Image = Image.FromStream(stream);
                this.DobPretty.Value = Convert.ToDateTime(row.Cells["Ngaysinh"].Value);
                if (Mailspretty.Text == "")
                {
                    var res = MessageBox.Show("You Still complete fill in information this staff \nDo you want complete registration it now ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (res)
                    {
                        case DialogResult.Yes:
                            DangKyTaiKhoan bosung = new DangKyTaiKhoan();
                            bosung.Show();
                            bosung.GetLabel.Hide();
                            bosung.GetLabel2.Hide();
                            bosung.GetComboBox.Text = "Tourist Guide";
                            bosung.GetTextBox.Text = "TRG29100512200X";
                            bosung.GetComboBox.Visible = false;
                            bosung.GetTextBox.Visible = false;
                            bosung.GetButton.Text = "OK";
                            this.Hide();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
           
          
        }

        public void NamePretty_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
            if (PrettyGribView.SelectedRows.Count >= 0)
            {
                for (int i = 0; i < PrettyGribView.Rows.Count; i++)
                {
                    if (PrettyGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.PrettyGribView.Rows[i];
                        if (NamePretty.Text != row.Cells["HuongDanVien"].Value.ToString())
                        {
                            IsDirty = false;
                        }
                        else
                        {
                            IsDirty = true;
                        }
                    }
                }
            } 
        }

        private void DobPretty_ValueChanged(object sender, EventArgs e)
        {
            if (PrettyGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < PrettyGribView.Rows.Count; i++)
                {
                    if (PrettyGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.PrettyGribView.Rows[i];
                        if (this.DobPretty.Value != Convert.ToDateTime(row.Cells["Ngaysinh"].Value.ToString()))
                        {
                            IsDirty = false;
                        }
                        else
                        {
                            IsDirty = true;
                        }
                    }
                }
            }
        }

        public void Pretty_Click(object sender, EventArgs e)
        {

            //Dinh Dang Hinh Anh
            /*            open.Filter = "Image Files(*.JPG ; *.jpeg ; *.gif ; *.bmp ; *.png) | *.jpg ; *.jpeg ; *.gif ; *.bmp ; *png";*/
            OpenFileDialog create = new OpenFileDialog();

            if (create.ShowDialog() == DialogResult.OK)
            {
                string pathImage = create.FileName.Replace(toannang, "");
                Pretty.Image = new Bitmap(toannang + pathImage);
                Pretty.Image.Tag = pathImage;
                MessageBox.Show(Pretty.Image.Tag.ToString());
            }
        }

        private void PhonePretty_TextChanged(object sender, EventArgs e)
        {
            if (PrettyGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < PrettyGribView.Rows.Count; i++)
                {
                    if (PrettyGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.PrettyGribView.Rows[i];
                        if (PhonePretty.Text != row.Cells["SoDienThoai"].Value.ToString())
                        {
                            IsDirty = false;
                        }
                        else
                        {
                            IsDirty = true;
                        }
                    }
                }
            }
        }

        private void AddressPretty_TextChanged(object sender, EventArgs e)
        {
            if (PrettyGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < PrettyGribView.Rows.Count; i++)
                {
                    if (PrettyGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.PrettyGribView.Rows[i];
                        if (AddressPretty.Text != row.Cells["DiaChi"].Value.ToString())
                        {
                            IsDirty = false;
                        }
                        else
                        {
                            IsDirty = true;
                        }
                    }
                }
            }
        }

        private void Mailspretty_TextChanged(object sender, EventArgs e)
        {
            if (PrettyGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < PrettyGribView.Rows.Count; i++)
                {
                    if (PrettyGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.PrettyGribView.Rows[i];
                        if (Mailspretty.Text != row.Cells["Emails"].Value.ToString())
                        {
                            IsDirty = false;
                        }
                        else
                        {
                            IsDirty = true;
                        }
                    }
                }
            }
        }

        private void Pretty_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (PrettyGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < PrettyGribView.Rows.Count; i++)
                {
                    if (PrettyGribView.Rows[i].Selected == true)
                    {
                        //MessageBox.Show(Pretty.Image.Tag.ToString());
                        DataGridViewRow row = this.PrettyGribView.Rows[i];
                        var data = (Byte[])(row.Cells["AnhHuongDan"].Value);
                        var stream = new MemoryStream(data);
                        MessageBox.Show(stream.ToString());
                        if (Pretty.Image.Tag != Image.FromStream(stream))
                        {
                            IsDirty = false;
                        }
                    }
                }
            }
        }

        public void AddPretty_Click(object sender, EventArgs e)
        {
            DangkyNhanVien them = new DangkyNhanVien();
            them.GetLabel.Visible = true;
            them.combo1.Visible = false;
            them.labelaaa.Visible = false;
            them.phongban.Text = "Tourist Guide";
            them.phongban.Visible = true;
            them.phongban.Enabled = false;
            them.Show();
            this.Hide();
        }

        public void DeletePretty_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            if (PrettyGribView.Rows.Count >= 0)
            {
               for (int i =0; i < PrettyGribView.Rows.Count; i++)
                {

                    if (PrettyGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.PrettyGribView.Rows[i];
                        var res = MessageBox.Show($"Do you want to remove Employee {row.Cells["HuongDanVien"].Value.ToString()} from the system", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (res)
                        {
                            case DialogResult.Yes:
                                MessageBox.Show(row.Cells["MaHDV"].Value.ToString());
                                string xoahuongdanvien = "Delete From HuongDanVien where Emails = @emails";
                                string xoachuyendi = "delete From ChuyenDi where MaHDV = @mahdv";
                                SqlCommand sqlCommand = new SqlCommand(xoahuongdanvien, con);
                                SqlCommand sql = new SqlCommand(xoachuyendi, con);
                                sql.Parameters.AddWithValue("@mahdv", row.Cells["MaHDV"].Value.ToString());
                                sqlCommand.Parameters.AddWithValue("@emails", row.Cells["Emails"].Value.ToString());
                                DataTable dataTable = new DataTable();
                                DataTable data = new DataTable();
                                SqlDataAdapter y = new SqlDataAdapter(sql);
                                SqlDataAdapter c = new SqlDataAdapter(sqlCommand);
                                y.Fill(data);
                                c.Fill(dataTable);
                                Form form = new TrangChu();
                                form.Show();
                                this.Hide();
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                }
                
            }
            
        }

        public void SavePretty_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toannang + Pretty.Image.Tag);
            if (IsDirty == false)
            {
                MessageBox.Show(toannang + Pretty.Image.Tag.ToString());
                string luu = toannang + Pretty.Image.Tag.ToString();
                SqlConnection con = new SqlConnection(cStr);
                con.Open();
                byte[] buffer = File.ReadAllBytes(luu);
                string save = "Update HuongDanVien Set HuongDanVien = @tenhuongdanvien , NgaySinh = @ngaysinh , SoDienThoai = @sodienthoai , DiaChi = @diachi , Emails = @emails , AnhHuongDan = @anhhuongdan where HuongDanVien = @tenhuongdanvien";
                SqlCommand command = new SqlCommand(save, con);
                command.Parameters.AddWithValue("@tenhuongdanvien", NamePretty.Text);
                command.Parameters.AddWithValue("@ngaysinh", DobPretty.Value);
                command.Parameters.AddWithValue("@sodienthoai", PhonePretty.Text);
                command.Parameters.AddWithValue("@diachi", AddressPretty.Text);
                command.Parameters.AddWithValue("@emails", Mailspretty.Text);
                var binary = command.Parameters.Add("@anhhuongdan", SqlDbType.VarBinary, -1);
                binary.Value = buffer;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable capnhap = new DataTable();
                adapter.Fill(capnhap);
            }
            else
            {
                MessageBox.Show("Nothing To Save");
            }
        }

        public void NhanVienKeToanGribView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.NhanVienKeToanGribView.Rows[e.RowIndex];
                var data = (Byte[])(row.Cells["AnhCaNhan"].Value);
                var stream = new MemoryStream(data);
                TenKT.Text = row.Cells["Hoten"].Value.ToString();
                EmailsKT.Text = row.Cells["Emails"].Value.ToString();
                SDTKt.Text = row.Cells["phone"].Value.ToString();
                Boss.Text = row.Cells["ChucVu"].Value.ToString();
                NhanVienKT.Image = Image.FromStream(stream);
                AddressKT.Text = row.Cells["AddressNV"].Value.ToString();
                this.DobKT.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                if (EmailsKT.Text == "")
                {
                    var res = MessageBox.Show("You Still complete fill in information this staff \nDo you want complete registration it now ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (res)
                    {
                        case DialogResult.Yes:
                            DangKyTaiKhoan bosung = new DangKyTaiKhoan();
                            bosung.Show();
                            bosung.GetLabel.Hide();
                            bosung.GetLabel2.Hide();
                            bosung.GetComboBox.Text = "Staff Accountant";
                            bosung.GetTextBox.Text = "STC2812200319992000";
                            bosung.GetComboBox.Visible = false;
                            bosung.GetTextBox.Visible = false;
                            bosung.GetButton.Text = "OK";
                            this.Hide();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
        }

        public void DeleteKT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            if (NhanVienKeToanGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < NhanVienKeToanGribView.Rows.Count; i++)
                {

                    if (NhanVienKeToanGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.NhanVienKeToanGribView.Rows[i];
                        var res = MessageBox.Show($"Do you want to remove Staff {row.Cells["Hoten"].Value.ToString()} from the system", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (res)
                        {
                            case DialogResult.Yes:
                                string xoahuongdanvien = "Delete From NhanVienKeToan where Emails = @emails";
                                SqlCommand sqlCommand = new SqlCommand(xoahuongdanvien, con);
                                sqlCommand.Parameters.AddWithValue("@emails", row.Cells["Emails"].Value.ToString());
                                DataTable dataTable = new DataTable();
                                SqlDataAdapter c = new SqlDataAdapter(sqlCommand);
                                c.Fill(dataTable);
                                Form form = new TrangChu();
                                form.Show();
                                this.Hide();
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                }

            }
        }

        public void DeleteCSKH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            if (CSKHGridView.Rows.Count >= 0)
            {
                for (int i = 0; i < CSKHGridView.Rows.Count; i++)
                {

                    if (CSKHGridView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.CSKHGridView.Rows[i];
                        var res = MessageBox.Show($"Do you want to remove Employee {row.Cells["HoTen"].Value.ToString()} from the system", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (res)
                        {
                            case DialogResult.Yes:
                                string xoahuongdanvien = "Delete From CSKH where PhoneNum = @phone";
                                SqlCommand sqlCommand = new SqlCommand(xoahuongdanvien, con);
                                sqlCommand.Parameters.AddWithValue("@phone", row.Cells["PhoneNum"].Value.ToString());
                                DataTable dataTable = new DataTable();
                                SqlDataAdapter c = new SqlDataAdapter(sqlCommand);
                                c.Fill(dataTable);
                                Form form = new TrangChu();
                                form.Show();
                                this.Hide();
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                }

            }
        }

        public void TenKT_TextChanged(object sender, EventArgs e)
        {
            if (NhanVienKeToanGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < NhanVienKeToanGribView.Rows.Count; i++)
                {
                    if(NhanVienKeToanGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.NhanVienKeToanGribView.Rows[i];
                        if (TenKT.Text != row.Cells["HoTen"].Value.ToString())
                        {
                            IsDirty = false;
                        }
                    }
                }
            }
        }

        public void DobKT_ValueChanged(object sender, EventArgs e)
        {
            if (NhanVienKeToanGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < NhanVienKeToanGribView.Rows.Count; i++)
                {
                    if (NhanVienKeToanGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.NhanVienKeToanGribView.Rows[i];
                        if (this.DobKT.Value != Convert.ToDateTime(row.Cells["DOB"].Value.ToString()))
                        {
                            IsDirty = false;
                        }
                    }
                }
            }
        }

        public void SDTKt_TextChanged(object sender, EventArgs e)
        {
            if (NhanVienKeToanGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < NhanVienKeToanGribView.Rows.Count; i++)
                {
                    if (NhanVienKeToanGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.NhanVienKeToanGribView.Rows[i];
                        if (SDTKt.Text != row.Cells["phone"].Value.ToString())
                        {
                            IsDirty = false;
                        }
                    }
                }
            }
        }

        public void AddressKT_TextChanged(object sender, EventArgs e)
        {
            if (NhanVienKeToanGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < NhanVienKeToanGribView.Rows.Count; i++)
                {
                    if (NhanVienKeToanGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.NhanVienKeToanGribView.Rows[i];
                        if (AddressKT.Text != row.Cells["AddressNV"].Value.ToString())
                        {
                            IsDirty = false;
                        }
                    }
                }
            }
        }

        public void EmailsKT_TextChanged(object sender, EventArgs e)
        {
            if (NhanVienKeToanGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < NhanVienKeToanGribView.Rows.Count; i++)
                {
                    if (NhanVienKeToanGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.NhanVienKeToanGribView.Rows[i];
                        if (EmailsKT.Text != row.Cells["Emails"].Value.ToString())
                        {
                            IsDirty = false;
                        }
                    }
                }
            }
        }

        public void Boss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NhanVienKeToanGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < NhanVienKeToanGribView.Rows.Count; i++)
                {
                    if (NhanVienKeToanGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.NhanVienKeToanGribView.Rows[i];
                        if (Boss.SelectedItem.ToString() != row.Cells["ChucVu"].Value.ToString())
                        {
                            IsDirty = false;
                        }
                    }
                }
            }
        }

        public void NhanVienKT_Click(object sender, EventArgs e)
        {
            OpenFileDialog createnew = new OpenFileDialog();
            if (createnew.ShowDialog() == DialogResult.OK)
                        {
                string pathImagemore = createnew.FileName.Replace(toanbo, "");
                NhanVienKT.Image = new Bitmap(toanbo+pathImagemore);
                NhanVienKT.Image.Tag = pathImagemore;
            }
        }

        public void SaveKT_Click(object sender, EventArgs e)
        {

            if (IsDirty == false)
            {
                string luu = toanbo + NhanVienKT.Image.Tag.ToString();
                SqlConnection con = new SqlConnection(cStr);
                con.Open();
                byte[] buffer = File.ReadAllBytes(luu);
                string capnhaketoan = "Update NhanVienKeToan set hoten = @hoten , dob = @dob , phone = @phone , AddressNV = @diachi , Chucvu = @chucvu , AnhCaNhan = @anhthe where Emails = @emails";
                SqlCommand command = new SqlCommand(capnhaketoan, con);
                command.Parameters.AddWithValue("@hoten", TenKT.Text);
                command.Parameters.AddWithValue("@dob", DobKT.Value);
                command.Parameters.AddWithValue("@phone", SDTKt.Text);
                command.Parameters.AddWithValue("@AddressNV", AddressKT.Text);
                command.Parameters.AddWithValue("@chucvu", Boss.SelectedItem);
                var binary = command.Parameters.Add("@anhthe", SqlDbType.VarBinary ,-1);
                binary.Value = buffer;
                command.Parameters.AddWithValue("@emails", EmailsKT.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable capnhap = new DataTable();
                adapter.Fill(capnhap);

            }
            else
            {
                MessageBox.Show("Nothing change To Saved");
            }
        }

        public void CSKHGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.CSKHGridView.Rows[e.RowIndex];
                var data = (Byte[])(row.Cells["AnhThe"].Value);
                var stream = new MemoryStream(data);
                NameCSKH.Text = row.Cells["Hoten"].Value.ToString();
                SDTCSKH.Text = row.Cells["PhoneNum"].Value.ToString();
                DCCSKH.Text = row.Cells["DiaChiCS"].Value.ToString();
                MailsCSKH.Text = row.Cells["Emais"].Value.ToString();
                ChamsocKH.Image = Image.FromStream(stream);
                this.DOBCSKH.Value = Convert.ToDateTime(row.Cells["DateBirth"].Value);
                Septong.Text = row.Cells["ChucVuCD"].Value.ToString();
                if (MailsCSKH.Text == "")
                {
                    var res = MessageBox.Show("You Still complete fill in information this staff \nDo you want complete registration it now ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (res)
                    {
                        case DialogResult.Yes:
                            DangKyTaiKhoan bosung = new DangKyTaiKhoan();
                            bosung.Show();
                            bosung.GetLabel.Hide();
                            bosung.GetLabel2.Hide();
                            bosung.GetComboBox.Text = "Customer Care Staff";
                            bosung.GetTextBox.Text = "CCS16102000X";
                            bosung.GetComboBox.Visible = false;
                            bosung.GetTextBox.Visible = false;
                            bosung.GetButton.Text = "OK";
                            bosung.GetComboBox.Enabled = false;
                            this.Hide();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
        }

        public void AddKT_Click(object sender, EventArgs e)
        {
            DangkyNhanVien form = new DangkyNhanVien();
            form.GetLabel.Visible = true;
            form.combo1.Visible = true;
            form.labelaaa.Visible = true;
            form.phongban.Text = "Staff Accountant";
            form.phongban.Enabled = false;
            form.phongban.Visible = true;
            form.Show();
            this.Hide();
        }

        public void AddCSKH_Click(object sender, EventArgs e)
        {
            DangkyNhanVien form = new DangkyNhanVien();
            form.GetLabel.Visible = true;
            form.combo1.Visible = true;
            form.labelaaa.Visible = true;
            form.phongban.Text = "Customer Care Staff";
            form.phongban.Enabled = false;
            form.phongban.Visible = true;
            form.Show();
            this.Hide();
        }

        public void NhanVienKT_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (NhanVienKeToanGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < NhanVienKeToanGribView.Rows.Count; i++)
                {
                    if (NhanVienKeToanGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.NhanVienKeToanGribView.Rows[i];
                        var data = (Byte[])(row.Cells["AnhCaNhan"].Value);
                        var stream = new MemoryStream(data);
                        if (NhanVienKT.Image != Image.FromStream(stream))
                        {
                            IsDirty = false;
                        }
                    }
                }
            }
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            ThemKhachHang them = new ThemKhachHang();
            them.Show();
            this.Hide();
        }

        private void AgencyGribView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.AgencyGribView.Rows[e.RowIndex];
                for (int i = 0; i < AgencyGribView.Rows.Count; i++)
                {
                    if (row.Selected == true)
                    {
                        string ten = row.Cells["TenDaiLy"].Value.ToString();
                        Display(ten);
                    }
                    else if (i + 1 == AgencyGribView.Rows.Count)
                    {
                        AgencyGribView.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form form = System.Windows.Forms.Application.OpenForms["ChinhSuaKhachHang"];
            if (InforCusGridView.Rows.Count >= 0)
            {
                for(int i = 0; i <InforCusGridView.Rows.Count; i++)
                {
                    if (InforCusGridView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.InforCusGridView.Rows[i];
                        ChinhSuaKhachHang a = new ChinhSuaKhachHang(row);
                        a.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cStr);
            if (InforCusGridView.Rows.Count >= 0)
            {
                for (int i = 0; i < InforCusGridView.Rows.Count; i++)
                {

                    if (InforCusGridView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.InforCusGridView.Rows[i];
                        var res = MessageBox.Show($"Do you want to remove Customers {row.Cells["HovaTen"].Value.ToString()} from the system", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (res)
                        {
                            case DialogResult.Yes:
                                string xoahuongHoadon = "exec XoaKhachHang @emails";
                            //    SqlCommand sql = new SqlCommand(xoahuongHoadon, con);
                                SqlCommand sqlCommand = new SqlCommand(xoahuongHoadon, con);
                                sqlCommand.Parameters.AddWithValue("@emails", Convert.ToInt32(row.Cells["MaKH"].Value.ToString()));
                                DataTable dataTable = new DataTable();
                                SqlDataAdapter c = new SqlDataAdapter(sqlCommand);
                                c.Fill(dataTable);
                                Form form = new TrangChu();
                                form.Show();
                                this.Hide();
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                }

            }
        }
        public void HienThiHoaDom(int makh)
        {
            SqlConnection con = new SqlConnection(cStr);
            string hienthi = "Select tendaily , tendiadiem, NgayKHoiHanh , giaien   from ChuyenDi cd, InforBookTrip ib , KhachHang kh where cd.MaChuyen = ib.MaChuyen And kh.MaKH = ib.MaKH and kh.MaKh = @makh";
            SqlCommand a = new SqlCommand(hienthi, con);
            a.Parameters.AddWithValue("@makh", makh);
            SqlDataAdapter adapter = new SqlDataAdapter(a);
            DataTable data = new DataTable();
            adapter.Fill(data);
            OrderOfCusGridView.DataSource = data;
            OrderOfCusGridView.ReadOnly = true;
            OrderOfCusGridView.Columns["tendiadiem"].HeaderText = "Location Name";
            OrderOfCusGridView.Columns["tendaily"].HeaderText = "Agency Name";
            OrderOfCusGridView.Columns["NgayKhoiHanh"].HeaderText = "Departure day";
            OrderOfCusGridView.Columns["giaien"].HeaderText = "Total Cost";
            OrderOfCusGridView.AllowUserToAddRows = false;
            OrderOfCusGridView.AutoGenerateColumns = false;
        }

        private void TripAvailableAgencyGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InforCusGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                int makh = Convert.ToInt32(InforCusGridView.Rows[index].Cells["MaKH"].Value.ToString());
                HienThiHoaDom(makh);
            }
            
        }
    }
}
