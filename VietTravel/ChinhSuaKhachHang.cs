using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietTravel
{
    public partial class ChinhSuaKhachHang : Form
    {
        System.Windows.Forms.Form Form = System.Windows.Forms.Application.OpenForms["TrangChu"];
        string cStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public ChinhSuaKhachHang(DataGridViewRow row)
        {
            
            InitializeComponent();
            
            NameClient.Text = row.Cells["HovaTen"].Value.ToString();
            EmailClien.Text = row.Cells["Emails"].Value.ToString();
            MobileNumBer.Text = row.Cells["SoDienThoai"].Value.ToString();
            Address.Text = row.Cells["DiaChi"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Isdirty = true;
            SqlConnection con = new SqlConnection(cStr);
            for (int i = 0; i < ((TrangChu)Form).grid.Rows.Count; i++)
            {
                if (((TrangChu)Form).grid.Rows[i].Selected == true)
                {
                    MessageBox.Show(((TrangChu)Form).grid.Rows[i].Cells["MaKH"].Value.ToString());
                    string kiem = "Select * from KhachHang where Emails = @mails";
                    SqlCommand ob = new SqlCommand(kiem, con);
                    ob.Parameters.AddWithValue("@mails", EmailClien.Text);
                    SqlDataAdapter a = new SqlDataAdapter(ob);
                    DataTable data = new DataTable();
                    a.Fill(data);
                    string sdt = "select * from KhachHang where SoDienThoai = @sdt";
                    SqlCommand sql = new SqlCommand(sdt, con);
                    sql.Parameters.AddWithValue("@sdt", MobileNumBer.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(sql);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (NameClient.Text != ((TrangChu)Form).grid.Rows[i].Cells["HovaTen"].Value.ToString())
                    {
                        Isdirty = false;
                    }
                    if (MobileNumBer.Text != ((TrangChu)Form).grid.Rows[i].Cells["SoDienThoai"].Value.ToString())
                    {
                        Isdirty = false;
                    }
                    if (Address.Text != ((TrangChu)Form).grid.Rows[i].Cells["DiaChi"].Value.ToString())
                    {
                        Isdirty = false;
                    }
                    if (EmailClien.Text != ((TrangChu)Form).grid.Rows[i].Cells"")
                    else if (data.Rows.Count > 0)
                    {
                        MessageBox.Show("Emails was used by another user \nPlease check again");
                    }
                    else if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("This Phone number has used by another user. \nPlease Check again");
                    }
                    else
                    {
                        string capnhat = "update KhachHang set HovaTen = @hoten , Emails = @mails , SoDienThoai = @sdt , DiaChi = @diachi where MaKH = makh";
                        SqlCommand command = new SqlCommand(capnhat, con);
                        command.Parameters.AddWithValue("@hoten", NameClient.Text);
                        command.Parameters.AddWithValue("@mails", EmailClien.Text);
                        command.Parameters.AddWithValue("@sdt", MobileNumBer.Text);
                        command.Parameters.AddWithValue("@diachi", Address.Text);
                        command.Parameters.AddWithValue("@MaKH", ((TrangChu)Form).grid.Rows[i].Cells["MaKH"].Value.ToString());
                    }
                }
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu b = new TrangChu();
            b.Show();
            this.Hide();
        }
    }
}
