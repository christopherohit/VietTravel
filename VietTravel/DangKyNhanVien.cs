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
   
    public partial class DangkyNhanVien : Form
    {
        string Global = Path.GetFullPath("/VietTravel/Used/HuongDanVien/");
        string toanbo = Path.GetFullPath("/VietTravel/Used/KeToan/");
        string toanphan = Path.GetFullPath("/VietTravel/Used/CSKH/");
        string cStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public ComboBox combo1 { get { return this.Chucvu; } }
        public Label labelaaa { get { return this.label6; } }
        public PictureBox picture { get { return this.pictureBox1; } }
        public ComboBox phongban { get { return this.PhongBan; } }
        public Label GetLabel { get { return this.label7; } }
        public TextBox sodt { get { return this.phonenumber; } }
        public TextBox tenst { get { return this.NameFull; } }
        public TextBox diast { get { return this.address; } }
        public DateTime bornst { get { return this.dayofbirth.Value;} }
        public Image pri { get { return this.privacy.Image; } }
        public Button pro { get { return this.done_button; } }

        bool IsDirty { get; set; }

        public DangkyNhanVien(DataGridViewRow row)
        {
            InitializeComponent();
            var date = (Byte[])(row.Cells["AnhHuongDan"].Value);
            var stream = new MemoryStream(date);
            NameFull.Text = row.Cells["HuongDanVien"].Value.ToString();
            dayofbirth.Value = Convert.ToDateTime(row.Cells["Ngaysinh"].Value);
            phonenumber.Text = row.Cells["SoDienThoai"].Value.ToString();
            address.Text = row.Cells["DiaChi"].Value.ToString();
            PhongBan.Text = "Tourist Guide";
            privacy.Image = Image.FromStream(stream);
            label6.Visible = false;
            Chucvu.Visible = false;
            IsDirty = true;
        }
        public DangkyNhanVien()
        {

            InitializeComponent();
            IsDirty = true;
        }



        private void privacy_Click(object sender, EventArgs e)
        {
            if (PhongBan.Text.Equals("Tourist Guide"))
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
            else if (PhongBan.Text.Equals("Staff Accountant"))
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog()== DialogResult.OK)
                {
                    string hinhanh = fileDialog.FileName.Replace(toanbo, "");
                    privacy.Image = new Bitmap(toanbo + hinhanh);
                    privacy.Image.Tag = hinhanh;
                    IsDirty = false;
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Refresh All Blank ? Are you sure about that ? ", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            switch (res)
            {
                case DialogResult.OK:
                    NameFull.Text = string.Empty;
                    dayofbirth.Value = DateTimePicker.MinimumDateTime;
                    phonenumber.Text = string.Empty;
                    address.Text = string.Empty;
                    Chucvu.SelectedText = "None";
                    privacy.Image = null;
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new TrangChu();
            form.Show();
            this.Hide();

        }

        private void done_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form Sam = System.Windows.Forms.Application.OpenForms["TrangChu"];
            System.Windows.Forms.Form wee = System.Windows.Forms.Application.OpenForms["ListStaff"];
            System.Windows.Forms.Form choi = System.Windows.Forms.Application.OpenForms["SignIn"];
            SqlConnection con = new SqlConnection(cStr);
            con.Open();
            if (done_button.Text == "Done")
            {
                if (NameFull.Text == "" || address.Text == "" || phonenumber.Text == "")
                {
                    if (NameFull.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ( address.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ( phonenumber.Text == "")
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
                        command.Parameters.AddWithValue("@mails", ((TrangChu)Sam).mailspr.Text);
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
                        string update = "update HuongDanVien set HuongDanVien =@ten , DiaChi = @dc , SoDienThoai = @sdt , Ngaysinh = @ngaysinh where Emails =@mails";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@ten", NameFull.Text);
                        command.Parameters.AddWithValue("@dc", address.Text);
                        command.Parameters.AddWithValue("@sdt", phonenumber.Text);
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dayofbirth.Value));
                        command.Parameters.AddWithValue("@mails", ((TrangChu)Sam).mailspr.Text);
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
            else if (done_button.Text == "Completely")
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
                        command.Parameters.AddWithValue("@mails", ((Signin)choi).TextBox.Text);
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        wee.Show();
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
                        command.Parameters.AddWithValue("@mails", ((Signin)choi).TextBox.Text);
                        SqlDataAdapter ae = new SqlDataAdapter(command);
                        DataTable ie = new DataTable();
                        ae.Fill(ie);
                        MessageBox.Show("Successful employee information update");
                        wee.Show();
                        this.Hide();

                    }
                }
            }
            else if (done_button.Text == "Finish")
            {
                if(NameFull.Text == "" || address.Text == "" || phonenumber.Text == "")
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
                    if (PhongBan.Text.Equals("Tourist Guide"))
                    {
                        if (IsDirty == true)
                        {
                            MessageBox.Show("You have not selected a personal photo for your staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string file = Global + privacy.Image.Tag.ToString();
                            Byte[] buffer = File.ReadAllBytes(file);
                            string query = "insert into HuongDanVien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau,MaPhongBan ,  AnhHuongDan) values (@hoten , @dob , @sdt , @diachi , null , null , 'TRG29100512200X' , @image)";
                            SqlCommand command1 = new SqlCommand(query, con);
                            command1.Parameters.AddWithValue("@hoten", NameFull.Text);
                            command1.Parameters.AddWithValue("@dob", dayofbirth.Value);
                            command1.Parameters.AddWithValue("@sdt", phonenumber.Text);
                            command1.Parameters.AddWithValue("@diachi", address.Text);
                            var binary = command1.Parameters.Add("@image", SqlDbType.VarBinary, -1);
                            binary.Value = buffer;
                            SqlDataAdapter adapter = new SqlDataAdapter(command1);
                            DataTable data = new DataTable();
                            adapter.Fill(data);
                            MessageBox.Show("In order to complete the employee information registration you need to complete creating an account for the employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DangKyTaiKhoan taiKhoan = new DangKyTaiKhoan();
                            taiKhoan.Show();
                            taiKhoan.GetLabel.Hide();
                            taiKhoan.GetLabel2.Hide();
                            taiKhoan.GetComboBox.Text = "Tourist Guide";
                            taiKhoan.GetComboBox.Enabled = false;
                            taiKhoan.GetTextBox.Text = "TRG29100512200X";
                            taiKhoan.GetComboBox.Visible = false;
                            taiKhoan.GetTextBox.Visible = false;
                            taiKhoan.GetButton.Text = "Finish";
                            this.Hide();
                        }

                    }
                    else if (PhongBan.Text.Equals("Customer Care Staff"))
                    {
                        if (IsDirty == true)
                        {
                            MessageBox.Show("You have not selected a personal photo for your staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string path = toanphan + privacy.Image.Tag.ToString();
                            Byte[] buffer = File.ReadAllBytes(path);
                            string query4 = "Insert into CSKH (Emails ,Hoten , DOB , phone ,AddressNV , ChucVu, MaPhongBan,matkhau , AnhCaNhan) values (null , @hoten , @datebirth , @phonenum , @Diachi , @chucvu , 'CCS16102000X' , null , @anh)";
                            SqlCommand command = new SqlCommand(query4, con);
                            command.Parameters.AddWithValue("@hoten", NameFull.Text);
                            command.Parameters.AddWithValue("@datebirth", dayofbirth.Value);
                            command.Parameters.AddWithValue("@phonenum", phonenumber.Text);
                            command.Parameters.AddWithValue("@Diachi", address.Text);
                            command.Parameters.AddWithValue("@Chucvu", Chucvu.Text);
                            var res = command.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                            res.Value = buffer;
                            SqlDataAdapter sql = new SqlDataAdapter(command);
                            DataTable data = new DataTable();
                            sql.Fill(data);
                            MessageBox.Show("In order to complete the employee information registration you need to complete creating an account for the employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DangKyTaiKhoan taiKhoan = new DangKyTaiKhoan();
                            taiKhoan.Show();
                            taiKhoan.GetLabel.Hide();
                            taiKhoan.GetLabel2.Hide();
                            taiKhoan.GetComboBox.Text = "Staff Accountant";
                            taiKhoan.GetComboBox.Enabled = false;
                            taiKhoan.GetTextBox.Text = "STC2812200319992000";
                            taiKhoan.GetComboBox.Visible = false;
                            taiKhoan.GetTextBox.Visible = false;
                            taiKhoan.GetButton.Text = "Finish";
                            this.Hide();
                        }
                    }
                    else if (PhongBan.Text.Equals("Staff Accountant"))
                    {
                        if (IsDirty == true)
                        {
                            MessageBox.Show("You have not selected a personal photo for your staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string hinhanh = toanbo + privacy.Image.Tag.ToString();
                            byte[] buffer = File.ReadAllBytes(hinhanh);
                            string query = "Insert into NhanVienKeToan (hoten , dob , emails , phone, Addressnv, chucvu , MaPhongBan, matkhau ,anhcanhan) values  (@hoten ,  @dob , null , @phone ,  @addressnv ,  @chucvu , 'STC2812200319992000' , null ,  @anhthe)";
                            SqlCommand command3 = new SqlCommand(query, con);
                            command3.Parameters.AddWithValue("@hoten", NameFull.Text);
                            command3.Parameters.AddWithValue("@dob", dayofbirth.Value);
                            command3.Parameters.AddWithValue("@phone", phonenumber.Text);
                            command3.Parameters.AddWithValue("@addressnv", address.Text);
                            command3.Parameters.AddWithValue("@chucvu", Chucvu.Text);
                            var nhiphan = command3.Parameters.Add("@anhthe", SqlDbType.VarBinary, -1);
                            nhiphan.Value = buffer;
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(command3);
                            DataTable data = new DataTable();
                            dataAdapter.Fill(data);
                            MessageBox.Show("In order to complete the employee information registration you need to complete creating an account for the employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DangKyTaiKhoan taiKhoan = new DangKyTaiKhoan();
                            taiKhoan.Show();
                            taiKhoan.GetLabel.Hide();
                            taiKhoan.GetLabel2.Hide();
                            taiKhoan.GetComboBox.Text = "Staff Accountant";
                            taiKhoan.GetComboBox.Enabled = false;
                            taiKhoan.GetTextBox.Text = "STC2812200319992000";
                            taiKhoan.GetComboBox.Visible = false;
                            taiKhoan.GetTextBox.Visible = false;
                            taiKhoan.GetButton.Text = "Finish";
                            this.Hide();
                        }
                    }
                    
                }
                
            }
            else if (done_button.Text == "Next")
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
                    if (PhongBan.Text.Equals("Tourist Guide"))
                    {
                        if (IsDirty == true)
                        {
                            MessageBox.Show("You have not selected a personal photo for your staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string file = Global + privacy.Image.Tag.ToString();
                            Byte[] buffer = File.ReadAllBytes(file);
                            string query = "insert into HuongDanVien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau,MaPhongBan ,  AnhHuongDan) values (@hoten , @dob , @sdt , @diachi , null , null , 'TRG29100512200X' , @image)";
                            SqlCommand command1 = new SqlCommand(query, con);
                            command1.Parameters.AddWithValue("@hoten", NameFull.Text);
                            command1.Parameters.AddWithValue("@dob", dayofbirth.Value);
                            command1.Parameters.AddWithValue("@sdt", phonenumber.Text);
                            command1.Parameters.AddWithValue("@diachi", address.Text);
                            var binary = command1.Parameters.Add("@image", SqlDbType.VarBinary, -1);
                            binary.Value = buffer;
                            SqlDataAdapter adapter = new SqlDataAdapter(command1);
                            DataTable data = new DataTable();
                            adapter.Fill(data);
                            MessageBox.Show("In order to complete the employee information registration you need to complete creating an account for the employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DangKyTaiKhoan taiKhoan = new DangKyTaiKhoan();
                            taiKhoan.Show();
                            taiKhoan.GetLabel.Hide();
                            taiKhoan.GetLabel2.Hide();
                            taiKhoan.GetComboBox.Text = "Tourist Guide";
                            taiKhoan.GetComboBox.Enabled = false;
                            taiKhoan.GetTextBox.Text = "TRG29100512200X";
                            taiKhoan.GetComboBox.Visible = false;
                            taiKhoan.GetTextBox.Visible = false;
                            taiKhoan.GetButton.Text = "Done";
                            this.Hide();
                        }

                    }
                    else if (PhongBan.Text.Equals("Customer Care Staff"))
                    {
                        if (IsDirty == true)
                        {
                            MessageBox.Show("You have not selected a personal photo for your staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string path = toanphan + privacy.Image.Tag.ToString();
                            Byte[] buffer = File.ReadAllBytes(path);
                            string query4 = "Insert into CSKH (Emails ,Hoten , DOB , phone ,AddressNV , ChucVu, MaPhongBan,matkhau , AnhCaNhan) values (null , @hoten , @datebirth , @phonenum , @Diachi , @chucvu , 'CCS16102000X' , null , @anh)";
                            SqlCommand command = new SqlCommand(query4, con);
                            command.Parameters.AddWithValue("@hoten", NameFull.Text);
                            command.Parameters.AddWithValue("@datebirth", dayofbirth.Value);
                            command.Parameters.AddWithValue("@phonenum", phonenumber.Text);
                            command.Parameters.AddWithValue("@Diachi", address.Text);
                            command.Parameters.AddWithValue("@Chucvu", Chucvu.Text);
                            var res = command.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                            res.Value = buffer;
                            SqlDataAdapter sql = new SqlDataAdapter(command);
                            DataTable data = new DataTable();
                            sql.Fill(data);
                            MessageBox.Show("In order to complete the employee information registration you need to complete creating an account for the employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DangKyTaiKhoan taiKhoan = new DangKyTaiKhoan();
                            taiKhoan.Show();
                            taiKhoan.GetLabel.Hide();
                            taiKhoan.GetLabel2.Hide();
                            taiKhoan.GetComboBox.Text = "Staff Accountant";
                            taiKhoan.GetComboBox.Enabled = false;
                            taiKhoan.GetTextBox.Text = "STC2812200319992000";
                            taiKhoan.GetComboBox.Visible = false;
                            taiKhoan.GetTextBox.Visible = false;
                            taiKhoan.GetButton.Text = "Done";
                            this.Hide();
                        }
                    }
                    else if (PhongBan.Text.Equals("Staff Accountant"))
                    {
                        if(IsDirty == true)
                        {
                            MessageBox.Show("You have not selected a personal photo for your staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string hinhanh = toanbo + privacy.Image.Tag.ToString();
                            byte[] buffer = File.ReadAllBytes(hinhanh);
                            string query = "Insert into NhanVienKeToan (hoten , dob , emails , phone, Addressnv, chucvu , MaPhongBan, matkhau ,anhcanhan) values  (@hoten ,  @dob , null , @phone ,  @addressnv ,  @chucvu , 'STC2812200319992000' , null ,  @anhthe)";
                            SqlCommand command3 = new SqlCommand(query, con);
                            command3.Parameters.AddWithValue("@hoten", NameFull.Text);
                            command3.Parameters.AddWithValue("@dob", dayofbirth.Value);
                            command3.Parameters.AddWithValue("@phone", phonenumber.Text);
                            command3.Parameters.AddWithValue("@addressnv", address.Text);
                            command3.Parameters.AddWithValue("@chucvu", Chucvu.Text);
                            var nhiphan = command3.Parameters.Add("@anhthe", SqlDbType.VarBinary, -1);
                            nhiphan.Value = buffer;
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(command3);
                            DataTable data = new DataTable();
                            dataAdapter.Fill(data);
                            MessageBox.Show("In order to complete the employee information registration you need to complete creating an account for the employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DangKyTaiKhoan taiKhoan = new DangKyTaiKhoan();
                            taiKhoan.Show();
                            taiKhoan.GetLabel.Hide();
                            taiKhoan.GetLabel2.Hide();
                            taiKhoan.GetComboBox.Text = "Staff Accountant";
                            taiKhoan.GetComboBox.Enabled = false;
                            taiKhoan.GetTextBox.Text = "STC2812200319992000";
                            taiKhoan.GetComboBox.Visible = false;
                            taiKhoan.GetTextBox.Visible = false;
                            taiKhoan.GetButton.Text = "Done";
                            this.Hide();
                        }
                    }
                }
            }


        }

        private void DangkyNhanVien_Load(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Form oris = System.Windows.Forms.Application.OpenForms["TrangChu"];
            // TODO: This line of code loads data into the 'quanLyDuLichDataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.quanLyDuLichDataSet.PhongBan);
            if (done_button.Text == "Done")
            {
                NameFull.Text = ((TrangChu)oris).prname.Text;
                dayofbirth.Value = Convert.ToDateTime(((TrangChu)oris).datepr.ToString());
            }

        }

        private void DangkyNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Form lp = System.Windows.Forms.Application.OpenForms["ListStaff"];
            if (done_button.Text == "Finish" || done_button.Text == "Completely")
            {
                lp.Show();
                this.Hide();
            }
            else
            {
                TrangChu olris = new TrangChu();
                olris.Show();
                this.Hide();
            }
        }
    }
}
//554