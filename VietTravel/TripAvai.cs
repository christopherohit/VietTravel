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
    public partial class TripAvai : Form
    {
        string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public TripAvai()
        {
            InitializeComponent();
        }

        private void TripAvai_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            string select = "Select * from ChuyenDi where TinhTrang = 'On Sale' or TinhTrang = 'Hot Sale' or TinhTrang = 'Future Trip'";
            SqlCommand op = new SqlCommand(select, con);
            SqlDataAdapter iu = new SqlDataAdapter(op);
            DataTable ip = new DataTable();
            iu.Fill(ip);
            dataGridView1.DataSource = ip;
            dataGridView1.Columns["MaChuyen"].Visible = false;
            dataGridView1.Columns["MaHDV"].Visible = false;
            dataGridView1.Columns["LuotThich"].Visible = false;
            dataGridView1.Columns["Giaien"].Visible = false;
            dataGridView1.Columns["DichVuFree"].Visible = false;
            dataGridView1.Columns["TenDaiLy"].DisplayIndex = 0;
            dataGridView1.Columns["TenDiaDiem"].DisplayIndex = 1;
            dataGridView1.Columns["SoLuong"].DisplayIndex = 2;
            dataGridView1.Columns["TinhTrang"].DisplayIndex = 3;
            dataGridView1.Columns["TenSoHuu"].DisplayIndex = 4;
            dataGridView1.Columns["NgayKhoiHanh"].DisplayIndex = 5;
            dataGridView1.Columns["TenDaiLy"].HeaderText = "Agency Name";
            dataGridView1.Columns["TenDiaDiem"].HeaderText = "Location Trip";
            dataGridView1.Columns["SoLuong"].HeaderText = "Amount";
            dataGridView1.Columns["TinhTrang"].HeaderText = "Status Quo";
            dataGridView1.Columns["TenSoHuu"].HeaderText = "Accomodation";
            dataGridView1.Columns["NgayKhoiHanh"].HeaderText = "Department Day";
            dataGridView1.Columns["NgayKhoiHanh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["NgayKhoiHanh"].ValueType = typeof(DateTime);
            dataGridView1.ReadOnly = true;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            System.Windows.Forms.Form opas = System.Windows.Forms.Application.OpenForms["SignIn"];
            string kiemtra = "select * From HuongDanVien where Emails = @mails";
            string kiemtra2 = "select * from CSKH where Emails = @mails";
            string kiemtra3 = "select * from NhanVienKeToan where Emails = @mails";
            SqlCommand i1 = new SqlCommand(kiemtra, con);
            i1.Parameters.AddWithValue("@mails", ((Signin)opas).TextBox.Text);
            SqlDataAdapter ocv = new SqlDataAdapter(i1);
            DataTable mm = new DataTable();
            ocv.Fill(mm);
            SqlCommand i2 = new SqlCommand(kiemtra2, con);
            i2.Parameters.AddWithValue("@mails", ((Signin)opas).TextBox.Text);
            SqlDataAdapter sqlData = new SqlDataAdapter(i2);
            DataTable vc = new DataTable();
            sqlData.Fill(vc);
            SqlCommand i3 = new SqlCommand(kiemtra3, con);
            i3.Parameters.AddWithValue("@mails", ((Signin)opas).TextBox.Text);
            SqlDataAdapter opasr = new SqlDataAdapter(i3);
            DataTable ikmc = new DataTable();
            opasr.Fill(ikmc);
            if (mm.Rows.Count > 0)
            {
                MessageBox.Show("This feature is not available in your department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (vc.Rows.Count > 0)
            {
                MessageBox.Show("This feature is not available in your department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ikmc.Rows.Count > 0)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Selected == true)
                        {
                            DataGridViewRow row = this.dataGridView1.Rows[i];
                            EditTrip edit = new EditTrip(row);
                            edit.Show();
                            this.Hide();
                            edit.Box.Visible = false;
                            edit.button.Text = "Completely";
                        }
                    }
                }
            }
            
        }

        private void TripAvai_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Form sdi = System.Windows.Forms.Application.OpenForms["MainHDV"];
            sdi.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["NgayKhoiHanh"], ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["NgayKhoiHanh"], ListSortDirection.Descending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form sdi = System.Windows.Forms.Application.OpenForms["MainHDV"];
            sdi.Show();
            this.Hide();
        }
    }
}
//130