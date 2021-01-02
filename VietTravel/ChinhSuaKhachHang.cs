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
            SqlConnection con = new SqlConnection(cStr);
            con.Open();
            for (int i = 0; i < ((TrangChu)Form).grid.Rows.Count; i++)
            {
                if (((TrangChu)Form).grid.Rows[i].Selected == true)
                {
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
                    if (NameClient.Text == "" || MobileNumBer.Text == "" || Address.Text == "" || EmailClien.Text == "")
                    {
                        if (NameClient.Text == "")
                        {
                            MessageBox.Show("You can't set this properties is empty. You can choose Delete This Customers to replace for this action");
                        }
                        else if (MobileNumBer.Text == "")
                        {
                            MessageBox.Show("You can't set this properties is empty. You can choose Delete This Customers to replace for this action");
                        }
                        else if (EmailClien.Text == "")
                        {
                            MessageBox.Show("You can't set this properties is empty. You can choose Delete This Customers to replace for this action");
                        }
                        else if (Address.Text == "")
                        {
                            MessageBox.Show("You can't set this properties is empty. You can choose Delete This Customers to replace for this action");

                        }
                    }
                    else
                    {
                        if (data.Rows.Count > 1)
                        {
                            MessageBox.Show("Emails was used by another user \nPlease check again");
                        }
                        else if (table.Rows.Count > 1)
                        {
                            MessageBox.Show("This Phone number has used by another user. \nPlease Check again");
                        }
                        else
                        {
                            string capnhat = "update KhachHang set HovaTen = @hoten , Emails = @mails , SoDienThoai = @sdt , DiaChi = @diachi where MaKH = @makh";
                            SqlCommand command = new SqlCommand(capnhat, con);
                            
                            command.Parameters.AddWithValue("@hoten", NameClient.Text);
                            command.Parameters.AddWithValue("@mails", EmailClien.Text); // khong cap nhap dc
                            command.Parameters.AddWithValue("@sdt", Convert.ToInt32(MobileNumBer.Text));
                            command.Parameters.AddWithValue("@diachi", Address.Text);
                            command.Parameters.AddWithValue("@makh", ((TrangChu)Form).grid.Rows[i].Cells["MaKH"].Value.ToString());
                            command.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Information of This Customers has been updated");
                            var res = MessageBox.Show("Do you want return Main Page ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (res == DialogResult.Yes)
                            {
                                TrangChu abc = new TrangChu();
                                abc.Show();
                                this.Hide();
                            }
                            else if (res == DialogResult.No)
                            {
                                break;
                            }
                        }
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
//120
