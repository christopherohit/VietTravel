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
    public partial class EditAgency : Form
    {
        string cStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public Button done { get { return this.button1; } }
        public TextBox vohieuhoa { get { return this.InAgency; } }
        public EditAgency(DataGridViewRow row)
        {
            InitializeComponent();
            AgencyName.Text = row.Cells["TenDaiLy"].Value.ToString();
            LocaTion.Text = row.Cells["DiaDiem"].Value.ToString();
            InAgency.Text = row.Cells["SoLuongChuyenDi"].Value.ToString();
            InAgency.Enabled = false;
            HienThi();
        }

        public EditAgency()
        {
            InitializeComponent();
        }
        public TextBox ten { get { return this.AgencyName; } }


        public void HienThi()
        {
            SqlConnection co = new SqlConnection(cStr);
            string hienthichuyen = "Select * from ChuyenDi where TenDaiLy in (select TenDaiLy from AgencyForAdmin where TenDaiLy = @tendaily)";
            SqlCommand cm = new SqlCommand(hienthichuyen, co);
            cm.Parameters.AddWithValue("@tendaily", AgencyName.Text);
            SqlDataAdapter sql2 = new SqlDataAdapter(cm);
            DataTable dat = new DataTable();
            sql2.Fill(dat);
            TripBelong.DataSource = dat;
            TripBelong.Columns["TenDaiLy"].Visible = false;
            TripBelong.Columns["MaChuyen"].Visible = false;
            TripBelong.Columns["TinhTrang"].Visible = true;
            TripBelong.Columns["DichVuFree"].Visible = true;
            TripBelong.Columns["TenSoHuu"].Visible = false;
            TripBelong.Columns["LuotThich"].Visible = false;
            TripBelong.Columns["MaHDV"].Visible = false;
            TripBelong.Columns["Giaien"].Visible = true;
            TripBelong.Columns["TenDiaDiem"].HeaderText = "Tourist Attraction";
            TripBelong.Columns["TenDiaDiem"].DisplayIndex = 0;
            TripBelong.Columns["SoLuong"].HeaderText = "Number Of Passengers";
            TripBelong.Columns["NgayKhoiHanh"].HeaderText = "Departure Day";
            TripBelong.Columns["NgayKhoiHanh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            TripBelong.Columns["NgayKhoiHanh"].ValueType = typeof(DateTime);
            TripBelong.ReadOnly = true;
            TripBelong.AutoGenerateColumns = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            if (button1.Text == "OK")
            {
                if (AgencyName.Text == "" || LocaTion.Text == "")
                {
                    if (AgencyName.Text == "")
                    {
                        MessageBox.Show("Please Fill in The Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (LocaTion.Text == "")
                    {
                        MessageBox.Show("Please Fill in The Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string kie = "Select * from AgencyForAdmin where TenDaiLy = @tendl";
                    SqlCommand ai = new SqlCommand(kie, con);
                    ai.Parameters.AddWithValue("tendl", AgencyName.Text);
                    SqlDataAdapter iu = new SqlDataAdapter(ai);
                    DataTable data = new DataTable();
                    iu.Fill(data);
                    if (data.Rows.Count > 1)
                    {
                        MessageBox.Show("Some Agency was used to this name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var res = MessageBox.Show("Changing the name of the dealer can pose a lot of risks\nDo you want to continue", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (res == DialogResult.OK)
                        {
                            string upd = "update AgencyForAdmin set TenDaiLy = @ten , DiaDiem = @diadiem where TenDaiLy = @ten";
                            SqlCommand sql = new SqlCommand(upd, con);
                            sql.Parameters.AddWithValue("@ten", AgencyName.Text);
                            sql.Parameters.AddWithValue("@diadiem", LocaTion.Text);
                            SqlDataAdapter et = new SqlDataAdapter(sql);
                            DataTable a = new DataTable();
                            et.Fill(a);
                            MessageBox.Show("Update Successfully");
                        }
                        else
                        {

                        }
                    }
                }
            }
            else if (button1.Text == "Done")
            {
                
                if(AgencyName.Text == "" || LocaTion.Text == "")
                {
                    if (AgencyName.Text == "")
                    {
                        MessageBox.Show("Please Fill in The Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (LocaTion.Text == "")
                    {
                        MessageBox.Show("Please Fill in The Blank Space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string kie = "Select * from AgencyForAdmin where TenDaiLy = @tendl";
                    SqlCommand ai = new SqlCommand(kie, con);
                    ai.Parameters.AddWithValue("tendl", AgencyName.Text);
                    SqlDataAdapter iu = new SqlDataAdapter(ai);
                    DataTable data = new DataTable();
                    iu.Fill(data);
                    if (data.Rows.Count > 0)
                    {
                        MessageBox.Show("Some Agency was used to this name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string nhapdaily = "insert into AgencyForAdmin (TenDaiLy , DiaDiem , SoLuongChuyenDi , SoLuotThich) values (@ten , @cho , @sl , 0)";
                        SqlCommand sql = new SqlCommand(nhapdaily, con);
                        sql.Parameters.AddWithValue("@ten", AgencyName.Text);
                        sql.Parameters.AddWithValue("@cho", LocaTion.Text);
                        sql.Parameters.AddWithValue("@sl", InAgency.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(sql);
                        DataTable ui = new DataTable();
                        adapter.Fill(ui);
                        MessageBox.Show("Add Agency Success");

                    }
                } 
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TrangChu abxu = new TrangChu();
            abxu.Show();
            this.Hide();
        }

        private void create_Click(object sender, EventArgs e)
        {
            EditTrip bbc = new EditTrip();
            bbc.button.Text = "Done"; 
            bbc.Show();
            this.Hide();
        }

        private void del_Click(object sender, EventArgs e)
        {
            SqlConnection ibus = new SqlConnection(cStr);
            if (TripBelong.Rows.Count > 0)
            {
                for (int i = 0; i < TripBelong.Rows.Count; i++)
                {
                    if (TripBelong.Rows[i].Selected == true)
                    {
                        var res =MessageBox.Show("Do you want to remove this trip out of this Agency", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            string thuco = "Delete from ChuyenDi where MaChuyen = @ma";
                            SqlCommand ios = new SqlCommand(thuco, ibus);
                            ios.Parameters.AddWithValue("@ma", TripBelong.Rows[i].Cells["MaChuyen"].Value.ToString());
                            SqlDataAdapter bay = new SqlDataAdapter(ios);
                            DataTable tio = new DataTable();
                            bay.Fill(tio);
                            MessageBox.Show("Delete Trip Completed");
                            
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (TripBelong.Rows.Count > 0)
            {
                for (int i = 0; i < TripBelong.Rows.Count; i++)
                {
                    if (TripBelong.Rows[i].Selected == true)
                    {
                        DataGridViewRow rails = this.TripBelong.Rows[i];
                        EditTrip rot = new EditTrip(rails);
                        rot.Show();
                        this.Hide();
                        rot.button.Text = "Accept";
                    }
                }
            }
        }

        private void EditAgency_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChu ewn = new TrangChu();
            ewn.Show();
            this.Hide();
        }
    }
}
//227