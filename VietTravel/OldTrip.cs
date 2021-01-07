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
    public partial class OldTrip : Form
    {
        string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";
        public OldTrip()
        {
            InitializeComponent();
        }

        private void OldTrip_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form odin = System.Windows.Forms.Application.OpenForms["SignIn"];
            SqlConnection con = new SqlConnection(conStr);
            string quere = "Select cd.Machuyen , cd.DichVuFree  , cd.Giaien , cd.LuotThich,cd.TenDiaDiem , cd.SoLuong , cd.TinhTrang , cd.TENSOHUU , cd.TenDaiLy , cd.NgayKhoiHanh , cd.MaHDV from ChuyenDi cd , HuongDanVien hd where cd.TinhTrang = 'Future Trip' and cd.MaHDV = hd.MaHDV and hd.Emails = @ten";
            SqlCommand jin = new SqlCommand(quere, con);
            jin.Parameters.AddWithValue("@ten", ((Signin)odin).TextBox.Text);
            SqlDataAdapter ada = new SqlDataAdapter(jin);
            DataTable asdi = new DataTable();
            ada.Fill(asdi);
            dataGridView1.DataSource = asdi;
            dataGridView1.Columns["MaHDV"].Visible = false;
            dataGridView1.Columns["MaChuyen"].Visible = false;
            dataGridView1.Columns["DichVuFree"].Visible = false;
            dataGridView1.Columns["GiaIen"].Visible = false;
            dataGridView1.Columns["LuoTThich"].Visible = false;
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

        private void OldTrip_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Form olis = System.Windows.Forms.Application.OpenForms["MainHDV"];
            olis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form olis = System.Windows.Forms.Application.OpenForms["MainHDV"];
            olis.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form olis = System.Windows.Forms.Application.OpenForms["MainHDV"];
            olis.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form odin = System.Windows.Forms.Application.OpenForms["SignIn"];
            SqlConnection con = new SqlConnection(conStr);
            string quere = "Select cd.TenDiaDiem , cd.SoLuong , cd.TinhTrang , cd.TENSOHUU , cd.TenDaiLy , cd.NgayKhoiHanh from ChuyenDi cd , HuongDanVien hd where cd.TinhTrang = 'Future Trip' and cd.MaHDV = hd.MaHDV and hd.Emails = @ten";
            SqlCommand jin = new SqlCommand(quere, con);
            jin.Parameters.AddWithValue("@ten", ((Signin)odin).TextBox.Text);
            SqlDataAdapter ada = new SqlDataAdapter(jin);
            DataTable asdi = new DataTable();
            ada.Fill(asdi);
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView1.Rows[i];
                        EditTrip jieun = new EditTrip(row);
                        jieun.Show();
                        this.Hide();
                        jieun.button.Visible = false;
                        jieun.tuoi.Visible = false;
                        jieun.a.Enabled = false;
                        jieun.b.Enabled = false;
                        jieun.c.Enabled = false;
                        jieun.d.Enabled = false;
                        jieun.e.Enabled = false;
                        jieun.f.Enabled = false;
                        jieun.g.Enabled = false;
                        jieun.h.Enabled = false;
                        jieun.i.Enabled = false;
                        jieun.j.Enabled = false;
                        jieun.Box.Visible = false;
                    }
                }
            }
        }
    }
}
//101