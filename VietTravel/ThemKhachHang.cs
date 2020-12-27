using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VietTravel
{
    public partial class ThemKhachHang : Form
    {
        string cStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public ThemKhachHang()
        {
            InitializeComponent();
        }
        public TextBox Emails { get { return this.mailsclient; } }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu trang = new TrangChu();
            trang.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            if (clientname.Text == "" || phoneclient.Text == "" || addressclient.Text == "" || mailsclient.Text == "")
            {
                if (clientname.Text == "")
                {
                    MessageBox.Show("Please Fill In Blank");
                }
                else if (phoneclient.Text == "")
                {
                    MessageBox.Show("Please Fill In Blank");
                }
                else if (addressclient.Text == "")
                {
                    MessageBox.Show("Please Fill In Blank");
                }
                else if (mailsclient.Text == "")
                {
                    MessageBox.Show("Please Fill In Blank");
                }
            }
            else
            {
                string query =  "Select * from KhachHang where Emails = @mails";
                SqlCommand sql = new SqlCommand(query, con);
                sql.Parameters.AddWithValue("@mails", mailsclient.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(sql);
                DataTable data = new DataTable();
                adapter.Fill(data);
                if (data.Rows.Count > 0)
                {
                    MessageBox.Show("You are already a customer of the company", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string them = "insert into KhachHang (HovaTen , Emails , SodienThoai, DiaChi , MatKhau) values (@hoten , @emails , @sdt , @diachi , null)";
                    SqlCommand command = new SqlCommand(them, con);
                    command.Parameters.AddWithValue("@hoten", clientname.Text);
                    command.Parameters.AddWithValue("@emails", mailsclient.Text);
                    command.Parameters.AddWithValue("@sdt", phoneclient.Text);
                    command.Parameters.AddWithValue("@diachi", addressclient.Text);
                    SqlDataAdapter sqlData = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    sqlData.Fill(table);
                    MessageBox.Show("To Add Successfully you need to create the password for client");
                    Confirm_Registration a = new Confirm_Registration();
                    a.Show();
                    this.Hide();
                }
            }
            
        }

        private void ThemKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            dynamic res = MessageBox.Show("Do you want to exit registration ?", "Exit Registration", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                TrangChu taolai = new TrangChu();
                taolai.Show();
                this.Hide();
            }
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
