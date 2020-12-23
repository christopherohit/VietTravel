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
        string cStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public ComboBox combo1 { get { return this.Chucvu; } }
        public Label labelaaa { get { return this.label6; } }
        public PictureBox picture { get { return this.pictureBox1; } }
        public ComboBox phongban { get { return this.PhongBan; } }
        public Label GetLabel { get { return this.label7; } }

        public DangkyNhanVien()
        {
            
            InitializeComponent();
        }

        private void privacy_Click(object sender, EventArgs e)
        {
            OpenFileDialog create = new OpenFileDialog();
            
            if(create.ShowDialog() == DialogResult.OK)
            {
                string pathImage = create.FileName.Replace(Global,"");
                privacy.Image = new Bitmap(Global+pathImage);
                privacy.Image.Tag = pathImage;
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
            string file = Global + privacy.Image.Tag.ToString();
            SqlConnection con = new SqlConnection(cStr);
            con.Open();
            byte[] buffer = File.ReadAllBytes(file);
            if (PhongBan.Text.Equals("Tourist Guide"))
            {
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
                taiKhoan.GetTextBox.Text = "TRG29100512200X";
                taiKhoan.GetComboBox.Visible = false;
                taiKhoan.GetTextBox.Visible = false;
                this.Hide();

            }
            else if(PhongBan.Text.Equals("Customer care staff"))
            {

            }
            
            
        }

        private void DangkyNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDuLichDataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.quanLyDuLichDataSet.PhongBan);

        }
    }
}
