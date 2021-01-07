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

        public Button io { get { return this.button1; } }
        public PictureBox pro { get { return this.pictureBox1; } }

        public ThemKhachHang(DataGridViewRow row)
        {
            InitializeComponent();
            clientname.Text = row.Cells["HoVaTen"].Value.ToString();
            mailsclient.Text = row.Cells["Emails"].Value.ToString();
            phoneclient.Text = row.Cells["SoDienThoai"].Value.ToString();
            addressclient.Text = row.Cells["DiaChi"].Value.ToString();
            pictureBox1.Visible = false;
            button1.Text = "Continue";
        }

        public ThemKhachHang()
        {
            InitializeComponent();
            if (button1.Text == "Done")
            {
                pictureBox1.Visible = false;
            }
            else if (button1.Text == "Continue")
            {
                pictureBox1.Visible = false;

            }
            else
            {
                pictureBox1.Visible = true;
            }
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
            System.Windows.Forms.Form Is = System.Windows.Forms.Application.OpenForms["AllClient"];
            SqlConnection con = new SqlConnection(cStr);
            if (button1.Text == "Next")
            {
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
                    string query = "Select * from KhachHang where Emails = @mails";
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
            else if (button1.Text == "Done")
            {
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
                    string query = "Select * from KhachHang where Emails = @mails";
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
                        a.tio.Text = "Complete";
                    }
                }
            }
            else if (button1.Text == "Continue")
            {
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
                    string query = "Select * from KhachHang where Emails = @mails";
                    SqlCommand sql = new SqlCommand(query, con);
                    sql.Parameters.AddWithValue("@mails", mailsclient.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(sql);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    if (data.Rows.Count > 1)
                    {
                        MessageBox.Show("You are already a customer of the company", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string asdpx = "update KhachHang set HovaTen = @name , Emails = @mails , SodienThoai = @phone, DiaChi = @dc , MatKhau = null where Emails = @mails";
                        SqlCommand you = new SqlCommand(asdpx, con);
                        you.Parameters.AddWithValue("@name", clientname.Text);
                        you.Parameters.AddWithValue("@mails", mailsclient.Text);
                        you.Parameters.AddWithValue("@phone", phoneclient.Text);
                        you.Parameters.AddWithValue("@dc", addressclient.Text);
                        SqlDataAdapter asd = new SqlDataAdapter(you);
                        DataTable table = new DataTable();
                        asd.Fill(table);
                        con.Close();
                        dynamic res = MessageBox.Show("Information of This Customers has been updated. \nDo you want to update password for client ?" , "Warning" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            Confirm_Registration op = new Confirm_Registration();
                            op.Show();
                            this.Hide();
                            op.tio.Text = "Complete";
                        }
                        else
                        {
                            Is.Show();
                            this.Hide();
                        }
                    }
                }

            }
        }

        private void ThemKhachHang_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (button1.Text == "Done")
            {
                System.Windows.Forms.Form nim = System.Windows.Forms.Application.OpenForms["AllClient"];
                nim.Show();
                this.Hide();
            }
            else if (button1.Text == "Continue")
            {
                System.Windows.Forms.Form nimbus = System.Windows.Forms.Application.OpenForms["AllClient"];
                nimbus.Show();
                this.Hide();
            }
            else
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
}
//261