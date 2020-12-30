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
        public Button button { get { return this.Next; } }
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
            PhongBan.Text = "Staff Accountant";
            Chucvu.Text = row.Cells["ChucVu"].Value.ToString();
            privacy.Image = Image.FromStream(stream);
            PhongBan.Enabled = false;
            IsDirty = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TrangChu IU = new TrangChu();
            IU.Show();
            this.Hide();
        }

        private void ChinhSuaDaiLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChu Yoo = new TrangChu();
            Yoo.Show();
            this.Hide();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            System.Windows.Forms.Form Sam = System.Windows.Forms.Application.OpenForms["TrangChu"];
            if (Next.Text == "Done")
            {
                if (NameFull.Text == "" || address.Text == "" || phonenumber.Text == "")
                {
                    if (NameFull.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space");
                    }
                    else if (address.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space");
                    }
                    else if (phonenumber.Text == "")
                    {
                        MessageBox.Show("Fill in Blank Space");
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
        }
    }
}
