﻿using System;
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
        public TrangChu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Daily_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            // Load Infor for Pretty
            SqlConnection con1 = new SqlConnection(cStr);
            string query1 = "Select * from HuongDanVien ";
            SqlCommand command1 = new SqlCommand(query1, con1);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable data1 = new DataTable();
            adapter1.Fill(data1);
            PrettyGribView.Columns["MaHDV"].Visible = false;
            PrettyGribView.DataSource = data1;
            PrettyGribView.Columns["MaHDV"].Visible = false;
            PrettyGribView.Columns["AnhHuongDan"].Visible = false;
            PrettyGribView.Columns["MatKhau"].Visible = false;
            PrettyGribView.AutoGenerateColumns = false;
            PrettyGribView.ReadOnly = true;
            PrettyGribView.Columns["MaPhongBan"].Visible = false;

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

            // Load Infor For Client
            string query4 = "select * from KhachHang";
            SqlCommand command4 = new SqlCommand(query4, con1);
            SqlDataAdapter adapter4 = new SqlDataAdapter(command4);
            DataTable data4 = new DataTable();
            adapter4.Fill(data4);
            InforCusGridView.DataSource = data4;
            InforCusGridView.Columns["MaKhachHang"].Visible = false;
            InforCusGridView.Columns["MatKhau"].Visible = false;
            InforCusGridView.AutoGenerateColumns = false;
            InforCusGridView.ReadOnly = true;

            //Load Agency
            string query5 = "select * from AGENCYFORAdmin";
            SqlCommand command5 = new SqlCommand(query5 , con1);
            SqlDataAdapter adapter5 = new SqlDataAdapter(command5);
            DataTable data5 = new DataTable();
            adapter5.Fill(data5);
            /*AgencyGribView.DataSource = data5;
            AgencyGribView.Columns["matkhau"].Visible = false;
            AgencyGribView.Columns["MaPhongBan"].Visible = false;
            AgencyGribView.Columns["AnhThe"].Visible = false;
            AgencyGribView.AutoGenerateColumns = false;
            AgencyGribView.ReadOnly = true;*/
        }

        private void PrettyGribView_CellClick(object sender, DataGridViewCellEventArgs e)
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
            }
           else if (Mailspretty.Text == "")
            {
                var res = MessageBox.Show("You Still complete fill in information this staff \nDo you want complete registration it now ?", "Warning" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
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
                        this.Hide();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
          
        }

        private void NamePretty_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
            if (PrettyGribView.SelectedRows.Count >= 0)
            {
                
            } 
        }

        private void AddPretty_Click(object sender, EventArgs e)
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

        private void DeletePretty_Click(object sender, EventArgs e)
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
                                string xoahuongdanvien = "Delete From HuongDanVien where Emails = @emails";
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
        private void SavePretty_Click(object sender, EventArgs e)
        {
            if (IsDirty == false)
            {
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

        private void Pretty_Click(object sender, EventArgs e)
        {

            //Dinh Dang Hinh Anh
/*            open.Filter = "Image Files(*.JPG ; *.jpeg ; *.gif ; *.bmp ; *.png) | *.jpg ; *.jpeg ; *.gif ; *.bmp ; *png";*/
            OpenFileDialog create = new OpenFileDialog();

            if (create.ShowDialog() == DialogResult.OK)
            {
                string pathImage = create.FileName.Replace(toannang, "");
                Pretty.Image = new Bitmap(toannang + pathImage);
                Pretty.Image.Tag = pathImage;
            }
        }

        private void NhanVienKeToanGribView_CellClick(object sender, DataGridViewCellEventArgs e)
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
            }
        }

        private void DeleteKT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            if (NhanVienKeToanGribView.Rows.Count >= 0)
            {
                for (int i = 0; i < NhanVienKeToanGribView.Rows.Count; i++)
                {

                    if (NhanVienKeToanGribView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.NhanVienKeToanGribView.Rows[i];
                        var res = MessageBox.Show($"Do you want to remove ${row.Cells["Hoten"].Value.ToString()} from the system", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void DeleteCSKH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            if (CSKHGridView.Rows.Count >= 0)
            {
                for (int i = 0; i < CSKHGridView.Rows.Count; i++)
                {

                    if (CSKHGridView.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.CSKHGridView.Rows[i];
                        var res = MessageBox.Show($"Do you want to remove ${row.Cells["HoTen"].Value.ToString()} from the system", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (res)
                        {
                            case DialogResult.Yes:
                                string xoahuongdanvien = "Delete From CSKH where Emails = @emails";
                                SqlCommand sqlCommand = new SqlCommand(xoahuongdanvien, con);
                                sqlCommand.Parameters.AddWithValue("@emails", row.Cells["Emais"].Value.ToString());
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

        private void TenKT_TextChanged(object sender, EventArgs e)
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

        private void DobKT_ValueChanged(object sender, EventArgs e)
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

        private void SDTKt_TextChanged(object sender, EventArgs e)
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

        private void AddressKT_TextChanged(object sender, EventArgs e)
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

        private void EmailsKT_TextChanged(object sender, EventArgs e)
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

        private void Boss_SelectedIndexChanged(object sender, EventArgs e)
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

        private void NhanVienKT_Click(object sender, EventArgs e)
        {
            OpenFileDialog createnew = new OpenFileDialog();
            if (createnew.ShowDialog() == DialogResult.OK)
                        {
                string pathImagemore = createnew.FileName.Replace(toanbo, "");
                NhanVienKT.Image = new Bitmap(toanbo+pathImagemore);
                NhanVienKT.Image.Tag = pathImagemore;
            }
        }

        private void SaveKT_Click(object sender, EventArgs e)
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
                command.ExecuteNonQuery();
                NhanVienKT.Image = Image.FromStream(new MemoryStream((byte[])rawdata));
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable capnhap = new DataTable();
                adapter.Fill(capnhap);

            }
            else
            {
                MessageBox.Show("Nothing change To Saved");
            }
        }

        private void CSKHGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.CSKHGridView.Rows[e.RowIndex];
                var data = (Byte[])(row.Cells["AnhThe"].Value);
                var stream = new MemoryStream(data);
                NameCSKH.Text = row.Cells["Hoten"].Value.ToString();
                SDTCSKH.Text = row.Cells["PhoneNum"].Value.ToString();
                DCCSKH.Text = row.Cells["DiaChiCS"].Value.ToString();
                MailsCSKH.Text = row.Cells[0].Value.ToString();
                ChamsocKH.Image = Image.FromStream(stream);
                this.DOBCSKH.Value = Convert.ToDateTime(row.Cells["DateBirth"].Value);
                Septong.Text = row.Cells["ChucVuCD"].Value.ToString();
            }
        }

        private void AddKT_Click(object sender, EventArgs e)
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

        private void AddCSKH_Click(object sender, EventArgs e)
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

        private void NhanVienKT_BackgroundImageChanged(object sender, EventArgs e)
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
    }
}
