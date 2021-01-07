using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietTravel
{
    public partial class ChinhSuaNanVien : Form
    {
        string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";
        string toanbo = Path.GetFullPath("/VietTravel/Used/KeToan/");
        string toanphan = Path.GetFullPath("/VietTravel/Used/CSKH/");
        string Global = Path.GetFullPath("/VietTravel/Used/HuongDanVien/");
        public Button button { get { return this.Next; } }
        public ComboBox chucvu { get { return this.Chucvu; } }
        public Label label { get { return this.label6; } }
        public PictureBox pic { get { return this.pictureBox2; } }
        bool IsDirty { get; set; }
        public ChinhSuaNanVien(DataGridViewRow row)
        {
            InitializeComponent();
            var date = (Byte[])(row.Cells["AnhCaNhan"].Value);
            var stream = new MemoryStream(date);
            NameFull.Text = row.Cells["Hoten"].Value.ToString();
            dayofbirth.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
            phonenumber.Text = row.Cells["phone"].Value.ToString();
            address.Text = row.Cells["AddressNV"].Value.ToString();
            PhongBan.Text = "Can't Edit Here";
            Chucvu.Text = row.Cells["ChucVu"].Value.ToString();
            privacy.Image = Image.FromStream(stream);
            PhongBan.Enabled = false;
            IsDirty = true;
        }
        public ChinhSuaNanVien(DataTable vn)
        {
            InitializeComponent();
            var data = (Byte[])(vn.Rows[0].ItemArray[6]);
            var stream = new MemoryStream(data);
            NameFull.Text = vn.Rows[0].ItemArray[1].ToString();
            dayofbirth.Value = Convert.ToDateTime(vn.Rows[0].ItemArray[2].ToString());
            phonenumber.Text = vn.Rows[0].ItemArray[3].ToString();
            address.Text = vn.Rows[0].ItemArray[4].ToString();
            PhongBan.Text = "Can't Edit Here";
            Next.Text = "Success";
            PhongBan.Enabled = false;
            IsDirty = true;
            privacy.Image = Image.FromStream(stream);
            Chucvu.Enabled = false;
            Chucvu.Text = vn.Rows[0].ItemArray[7].ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TrangChu IU = new TrangChu();
            IU.Show();
            this.Hide();
        }

        private void ChinhSuaDaiLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Form QQ = System.Windows.Forms.Application.OpenForms["MainHDV"];
            System.Windows.Forms.Form Sam = System.Windows.Forms.Application.OpenForms["ListStaff"];
            if (Next.Text == "Completely")
            {
                QQ.Show();
                this.Hide();
            }
            else if (Next.Text == "Accept")
            {
                QQ.Show();
                this.Hide();
            }
            else if (Next.Text == "Finish")
            {
                Sam.Show();
                this.Hide();
            }
            else if (Next.Text == "Next")
            {
                Sam.Show();
                this.Hide();
            }
            else
            {
                TrangChu Yoo = new TrangChu();
                Yoo.Show();
                this.Hide();
            }
        }

        private void privacy_Click(object sender, EventArgs e)
        {
            if (PhongBan.Text.Equals("Staff Accountant"))
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string hinhanh = fileDialog.FileName.Replace(toanbo, "");
                    privacy.Image = new Bitmap(toanbo + hinhanh);
                    privacy.Image.Tag = hinhanh;
                    IsDirty = false;
                }
            }
            else if (PhongBan.Text == "Tourist Guide")
            {
                OpenFileDialog create = new OpenFileDialog();

                if (create.ShowDialog() == DialogResult.OK)
                {
                    string pathImage = create.FileName.Replace(Global, "");
                    privacy.Image = new Bitmap(Global + pathImage);
                    privacy.Image.Tag = pathImage;
                    IsDirty = false;
                }
            }
            else if (PhongBan.Text.Equals("Customer Care Staff"))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.FileName.Replace(toanphan, "");
                    privacy.Image = new Bitmap(toanphan + path);
                    privacy.Image.Tag = path;
                    IsDirty = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            System.Windows.Forms.Form Sam = System.Windows.Forms.Application.OpenForms["TrangChu"];
            System.Windows.Forms.Form Sam2 = System.Windows.Forms.Application.OpenForms["SignIn"];
            System.Windows.Forms.Form Sam3 = System.Windows.Forms.Application.OpenForms["MainHDV"];
            System.Windows.Forms.Form Sam4 = System.Windows.Forms.Application.OpenForms["ListStaff"];
            if (Next.Text == "OK")
            {
                if (NameFull.Text == "" || address.Text == "" || phonenumber.Text == "")
                {
                    if (NameFull.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (address.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (phonenumber.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (IsDirty == false)
                    {
                        string file = toanbo + privacy.Image.Tag.ToString();
                        byte[] buffer = File.ReadAllBytes(file);
                        string update = "update NhanVienKeToan set Hoten =@ten , AddressNV = @dc , phone = @sdt , DOB = @ngaysinh  , AnhCaNhan =@anh , ChucVu=@cv where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@cv", Chucvu.Text);
                        var binary = command.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                        binary.Value = buffer;
                        command.Parameters.AddWithValue("@mails", ((TrangChu)Sam).mailskt.Text);
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        TrangChu asd = new TrangChu();
                        asd.Show();
                        this.Hide();

                    }
                    else 
                    {
                        string update = "update NhanVienKeToan set Hoten =@ten , AddressNV = @dc , phone = @sdt , DOB = @ngaysinh  , ChucVu = @cv where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@cv", Chucvu.Text);
                        command.Parameters.AddWithValue("@mails", ((TrangChu)Sam).mailskt.Text);
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        TrangChu asd = new TrangChu();
                        asd.Show();
                        this.Hide();

                    }
                }
            }
            else if(Next.Text == "Completely")
            {
                if (NameFull.Text == "" || address.Text == "" || phonenumber.Text == "")
                {
                    if (NameFull.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (address.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (phonenumber.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (IsDirty == false)
                    {
                        string file = Global + privacy.Image.Tag.ToString();
                        byte[] buffer = File.ReadAllBytes(file);
                        string update = "update HuongDanVien set HuongDanVien =@ten , DiaChi = @dc , SoDienThoai = @sdt , Ngaysinh = @ngaysinh  , AnhHuongDan =@anh where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        var binary = command.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                        binary.Value = buffer;
                        command.Parameters.AddWithValue("@mails", ((Signin)Sam2).TextBox.Text);
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        Sam3.Show();
                        this.Hide();

                    }
                    else
                    {
                        string update = "update HuongDanVien set HuongDanVien =@ten , DiaChi = @dc , SoDienThoai = @sdt , Ngaysinh = @ngaysinh where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@mails", ((Signin)Sam2).TextBox.Text);
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        Sam3.Show();
                        this.Hide();

                    }
                }
            }
            else if (Next.Text == "Accept")
            {
                if (NameFull.Text == "" || address.Text == "" || phonenumber.Text == "")
                {
                    if (NameFull.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (address.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (phonenumber.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (IsDirty == false)
                    {
                        string file = toanbo + privacy.Image.Tag.ToString();
                        byte[] buffer = File.ReadAllBytes(file);
                        string update = "update NhanVienKeToan set Hoten =@ten , AddressNV = @dc , phone = @sdt , DOB = @ngaysinh  , AnhCaNhan =@anh , ChucVu=@cv where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@cv", Chucvu.Text);
                        var binary = command.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                        binary.Value = buffer;
                        command.Parameters.AddWithValue("@mails", ((Signin)Sam2).TextBox.Text);
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        Sam3.Show();
                        this.Hide();

                    }
                    else
                    {
                        string update = "update NhanVienKeToan set Hoten =@ten , AddressNV = @dc , phone = @sdt , DOB = @ngaysinh  , ChucVu = @cv where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@cv", Chucvu.Text);
                        command.Parameters.AddWithValue("@mails", ((Signin)Sam2).TextBox.Text);
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        Sam3.Show();
                        this.Hide();

                    }
                }
            }
            else if (Next.Text == "Next")
            {
                if (NameFull.Text == "" || address.Text == "" || phonenumber.Text == "")
                {
                    if (NameFull.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (address.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (phonenumber.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (IsDirty == false)
                    {
                        string file = toanbo + privacy.Image.Tag.ToString();
                        byte[] buffer = File.ReadAllBytes(file);
                        string update = "update NhanVienKeToan set Hoten =@ten , AddressNV = @dc , phone = @sdt , DOB = @ngaysinh  , AnhCaNhan =@anh , ChucVu=@cv where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@cv", Chucvu.Text);
                        var binary = command.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                        binary.Value = buffer;
                        command.Parameters.AddWithValue("@mails", ((ListStaff)Sam4).tio2.SelectedRows[0].Cells["Emails"].Value.ToString());
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        Sam4.Show();
                        this.Hide();

                    }
                    else
                    {
                        string update = "update NhanVienKeToan set Hoten =@ten , AddressNV = @dc , phone = @sdt , DOB = @ngaysinh  , ChucVu = @cv where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@cv", Chucvu.Text);
                        command.Parameters.AddWithValue("@mails", ((ListStaff)Sam4).tio2.SelectedRows[0].Cells["Emails"].Value.ToString());
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        Sam4.Show();
                        this.Hide();

                    }
                }
            }
            else if (Next.Text == "Done")
            {
                if (NameFull.Text == "" || address.Text == "" || phonenumber.Text == "")
                {
                    if (NameFull.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                    }
                    else if (address.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (phonenumber.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (IsDirty == false)
                    {
                        string file = toanphan + privacy.Image.Tag.ToString();
                        byte[] buffer = File.ReadAllBytes(file);
                        string update = "update CSKH set Hoten =@ten , AddressNV = @dc , phone = @sdt , DOB = @ngaysinh  , AnhCaNhan =@anh , ChucVu=@cv where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@cv", Chucvu.Text);
                        var binary = command.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                        binary.Value = buffer;
                        command.Parameters.AddWithValue("@mails", ((TrangChu)Sam).mailscs.Text);
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        TrangChu asd = new TrangChu();
                        asd.Show();
                        this.Hide();

                    }
                    else
                    {
                        string update = "update CSKH set Hoten =@ten , AddressNV = @dc , phone = @sdt , DOB = @ngaysinh  , ChucVu = @cv where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@cv", Chucvu.Text);
                        command.Parameters.AddWithValue("@mails", ((TrangChu)Sam).mailscs.Text);
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        TrangChu asd = new TrangChu();
                        asd.Show();
                        this.Hide();

                    }
                }
            }
            else if (Next.Text == "Finish")
            {
                if (NameFull.Text == "" || address.Text == "" || phonenumber.Text == "")
                {
                    if (NameFull.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (address.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (phonenumber.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (IsDirty == false)
                    {
                        string file = toanphan + privacy.Image.Tag.ToString();
                        byte[] buffer = File.ReadAllBytes(file);
                        string update = "update CSKH set Hoten =@ten , AddressNV = @dc , phone = @sdt , DOB = @ngaysinh  , AnhCaNhan =@anh , ChucVu=@cv where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@cv", Chucvu.Text);
                        var binary = command.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                        binary.Value = buffer;
                        command.Parameters.AddWithValue("@mails", ((ListStaff)Sam4).tio3.SelectedRows[0].Cells["Emails"].Value.ToString());
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        Sam4.Show();
                        this.Hide();

                    }
                    else
                    {
                        string update = "update CSKH set Hoten =@ten , AddressNV = @dc , phone = @sdt , DOB = @ngaysinh  , ChucVu = @cv where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@cv", Chucvu.Text);
                        command.Parameters.AddWithValue("@mails", ((ListStaff)Sam4).tio3.SelectedRows[0].Cells["Emails"].Value.ToString());
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        Sam4.Show();
                        this.Hide();

                    }
                }
            }
        }
    }
}
//443
