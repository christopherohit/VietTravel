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
    public partial class Future : Form
    {
        string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public Future()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form lio = System.Windows.Forms.Application.OpenForms["MainHDV"];
            lio.Show();
            this.Hide();
        }

        private void Future_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Form lio = System.Windows.Forms.Application.OpenForms["MainHDV"];
            lio.Show();
            this.Hide();
        }

        private void Future_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form ascx = System.Windows.Forms.Application.OpenForms["SignIn"];
            SqlConnection con = new SqlConnection(conStr);
            string quere = "Select cd.TenDiaDiem , cd.SoLuong , cd.TinhTrang , cd.TENSOHUU , cd.TenDaiLy , cd.NgayKhoiHanh from ChuyenDi cd , HuongDanVien hd where cd.TinhTrang = 'Future Trip' and cd.MaHDV = hd.MaHDV and hd.Emails = @ten";
            SqlCommand jin = new SqlCommand(quere, con);
            jin.Parameters.AddWithValue("@ten", ((Signin)ascx).TextBox.Text);
            SqlDataAdapter ada = new SqlDataAdapter(jin);
            DataTable asdi = new DataTable();
            ada.Fill(asdi);
            dataGridView1.DataSource = asdi;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["TenDaiLy"].HeaderText = "Agency Name";
            dataGridView1.Columns["TenDiaDiem"].HeaderText = "Location Trip";
            dataGridView1.Columns["SoLuong"].HeaderText = "Amount";
            dataGridView1.Columns["TinhTrang"].HeaderText = "Status Quo";
            dataGridView1.Columns["TenSoHuu"].HeaderText = "Accomodation";
            dataGridView1.Columns["NgayKhoiHanh"].HeaderText = "Department Day";
            dataGridView1.Columns["NgayKhoiHanh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["NgayKhoiHanh"].ValueType = typeof(DateTime);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["NgayKhoiHanh"], ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["NgayKhoiHanh"], ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView1.Rows[i];
                        Request abi = new Request();
                        abi.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("You are not on a future trip now you can click on the transfer request button to have a future trip.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Request abi = new Request();
            abi.Show();
            this.Hide();
        }
    }
}
//90