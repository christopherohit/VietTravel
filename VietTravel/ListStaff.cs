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
    public partial class ListStaff : Form
    {
        string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public DataGridView tio { get { return this.dataGridView1; } }
        public DataGridView tio2 { get { return this.dataGridView2; } }
        public DataGridView tio3 { get { return this.dataGridView3; } }
        public ListStaff()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DangkyNhanVien eoi = new DangkyNhanVien();
            eoi.pro.Text = "Finish";
            eoi.combo1.Visible = false;
            eoi.labelaaa.Visible = false;
            eoi.phongban.Text = "Tourist Guide";
            eoi.phongban.Enabled = false;
            eoi.picture.Visible = false;
            eoi.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form ios = System.Windows.Forms.Application.OpenForms["MainHDV"];
            ios.Show();
            this.Hide();
            ((MainHDV)ios).lju.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ListStaff_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            string query = "Select *  from HuongDanVien";
            SqlCommand ior = new SqlCommand(query, con);
            SqlDataAdapter a = new SqlDataAdapter(ior);
            DataTable jin = new DataTable();
            a.Fill(jin);
            dataGridView1.DataSource = jin;
            dataGridView1.Columns["MaHDV"].Visible = false;
            dataGridView1.Columns["AnhHuongDan"].Visible = false;
            dataGridView1.Columns["MatKhau"].Visible = false;
            dataGridView1.Columns["MaPhongBan"].Visible = false;
            dataGridView1.Columns["ChucVu"].Visible = false;
            //dataGridView1.Columns["HuongDanVien"].HeaderText = "Name Staff";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Date Of Birth";
            dataGridView1.Columns["SoDienThoai"].HeaderText = "Mobile Phone";
            dataGridView1.Columns["DiaChi"].HeaderText = "Address";
            dataGridView1.Columns["ChucVu"].HeaderText = "Regency";
            dataGridView1.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["NgaySinh"].ValueType = typeof(DateTime);
            string que = "Select * from NhanVienKeToan";
            SqlCommand yo = new SqlCommand(que, con);
            SqlDataAdapter ki = new SqlDataAdapter(yo);
            DataTable ol = new DataTable();
            ki.Fill(ol);
            dataGridView2.DataSource = ol;
            dataGridView2.Columns["MaKeToan"].Visible = false;
            dataGridView2.Columns["AnhCaNhan"].Visible = false;
            dataGridView2.Columns["MaPhongBan"].Visible = false;
            dataGridView2.Columns["MatKhau"].Visible = false;
            //dataGridView2.Columns["Hoten"].HeaderText = "Name Staff";
            dataGridView2.Columns["DOB"].HeaderText = "Day Of Birth";
            dataGridView2.Columns["Phone"].HeaderText = "Mobile Phone";
            dataGridView2.Columns["AddressNV"].HeaderText = "Address";
            dataGridView2.Columns["ChucVu"].HeaderText = "Regency";
            dataGridView2.Columns["DOB"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView2.Columns["DOB"].ValueType = typeof(DateTime);
            string ry = "Select * from CSKH";
            SqlCommand sql = new SqlCommand(ry, con);
            SqlDataAdapter pic = new SqlDataAdapter(sql);
            DataTable lit = new DataTable();
            pic.Fill(lit);
            dataGridView3.DataSource = lit;
            dataGridView3.Columns["AnhCaNhan"].Visible = false;
            dataGridView3.Columns["MaHDV"].Visible = false;
            dataGridView3.Columns["MaPhongBan"].Visible = false;
            dataGridView3.Columns["MatKhau"].Visible = false;
            //dataGridView3.Columns["Hoten"].HeaderText = "Name Staff";
            dataGridView3.Columns["DOB"].HeaderText = "Date Of Birth";
            dataGridView3.Columns["phone"].HeaderText = "Mobile Phone";
            dataGridView3.Columns["AddressNV"].HeaderText = "Address";
            dataGridView3.Columns["ChucVu"].HeaderText = "Regency";
            dataGridView3.Columns["DOB"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView3.Columns["DOB"].ValueType = typeof(DateTime);

            System.Windows.Forms.Form ios = System.Windows.Forms.Application.OpenForms["ListStaff"];
            System.Windows.Forms.Form iso = System.Windows.Forms.Application.OpenForms["SignIn"];
            string set = "Select * from CSKH where Emails = @mails";
            SqlCommand yiu = new SqlCommand(set, con);
            yiu.Parameters.AddWithValue("@mails", ((Signin)iso).TextBox.Text);
            SqlDataAdapter op = new SqlDataAdapter(yiu);
            DataTable loi = new DataTable();
            op.Fill(loi);
            if(loi.Rows.Count > 0)
            {
                groupBox2.Enabled = false;

            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("HuongDanVien LIKE '{0}%'", textBox1.Text);
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("Hoten  LIKE '{0}%'", textBox1.Text);
            (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = string.Format("Hoten  LIKE '{0}%'", textBox1.Text);
        }

        private void ListStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Form asd = System.Windows.Forms.Application.OpenForms["MainHDV"];
            asd.Show();
            this.Hide();
            ((MainHDV)asd).lju.Enabled = true;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            
        }

        private void aded_Click(object sender, EventArgs e)
        {
            DangkyNhanVien eoi = new DangkyNhanVien();
            eoi.pro.Text = "Finish";
            eoi.combo1.Visible = true;
            eoi.labelaaa.Visible = true;
            eoi.phongban.Text = "Staff Accountant";
            eoi.phongban.Enabled = false;
            eoi.picture.Visible = false;
            eoi.Show();
            this.Hide();
        }

        private void eded_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView2.Rows[i];
                        ChinhSuaNanVien a = new ChinhSuaNanVien(row);
                        a.Show();
                        this.Hide();
                        a.pic.Visible = false;
                        a.button.Text = "Next";
                        a.chucvu.Enabled = true;
                    }
                }
            }
        }

        private void edtg_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView1.Rows[i];
                        DangkyNhanVien kill = new DangkyNhanVien(row);
                        kill.Show();
                        this.Hide();
                        kill.picture.Visible = false;
                        kill.phongban.Enabled = false;
                        kill.pro.Text = "Completely";
                    }
                }
            }
        }

        private void deltg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView1.Rows[i];
                        var res = MessageBox.Show($"Do you want to remove Employee {row.Cells["HuongDanVien"].Value.ToString()} from the system", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (res)
                        {
                            case DialogResult.Yes:
                                string xoaHuongDanVien = "Exec XoaNhanVien @ma";
                                SqlCommand sqlCommand = new SqlCommand(xoaHuongDanVien, con);
                                sqlCommand.Parameters.AddWithValue("@ma", row.Cells["MaHDV"].Value.ToString());
                                DataTable data = new DataTable();
                                SqlDataAdapter c = new SqlDataAdapter(sqlCommand);
                                c.Fill(data);
                                ListStaff pl = new ListStaff();
                                pl.Show();
                                this.Hide();
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                }
            }
        }

        private void deled_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView2.Rows[i];
                        var res = MessageBox.Show($"Do you want to remove Employee {row.Cells["Hoten"].Value.ToString()} from the system", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (res)
                        {
                            case DialogResult.Yes:
                                string xoa = "Delete from NhanVienKeToan where phone =@mails";
                                SqlCommand sql = new SqlCommand(xoa, con);
                                sql.Parameters.AddWithValue("@mails", row.Cells["Phone"].Value.ToString());
                                SqlDataAdapter ui = new SqlDataAdapter(sql);
                                DataTable iu = new DataTable();
                                ui.Fill(iu);
                                ListStaff pit = new ListStaff();
                                pit.Show();
                                this.Hide();
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                }
            }
        }

        private void edhr_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    if (dataGridView3.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView3.Rows[i];
                        ChinhSuaNanVien a = new ChinhSuaNanVien(row);
                        a.Show();
                        this.Hide();
                        a.pic.Visible = false;
                        a.button.Text = "Finish";
                        a.chucvu.Enabled = true;
                    }
                }
            }
        }

        private void delhr_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            if (dataGridView3.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    if (dataGridView3.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView3.Rows[i];
                        var res = MessageBox.Show($"Do you want to remove Employee {row.Cells["Hoten"].Value.ToString()} from the system", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (res)
                        {
                            case DialogResult.Yes:
                                string xoa = "Delete from CSKH where phone =@mails";
                                SqlCommand sql = new SqlCommand(xoa, con);
                                sql.Parameters.AddWithValue("@mails", row.Cells["phone"].Value.ToString());
                                SqlDataAdapter ui = new SqlDataAdapter(sql);
                                DataTable iu = new DataTable();
                                ui.Fill(iu);
                                ListStaff pit = new ListStaff();
                                pit.Show();
                                this.Hide();
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                }
            }
        }

        private void adhr_Click(object sender, EventArgs e)
        {
            DangkyNhanVien eoi = new DangkyNhanVien();
            eoi.pro.Text = "Finish";
            eoi.combo1.Visible = true;
            eoi.labelaaa.Visible = true;
            eoi.phongban.Text = "Customer Care Staff";
            eoi.phongban.Enabled = false;
            eoi.picture.Visible = false;
            eoi.Show();
            this.Hide();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    if (dataGridView3.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView3.Rows[i];
                        if (row.Cells["Emails"].Value.ToString() == "")
                        {
                            dynamic re = MessageBox.Show("This information of this staff not completely, Do you want to completely set up it?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            switch (re)
                            {
                                case DialogResult.Yes:
                                    DangKyTaiKhoan tu = new DangKyTaiKhoan();
                                    tu.Show();
                                    this.Hide();
                                    tu.GetButton.Text = "Great";
                                    tu.GetComboBox.Text = "Customer Care Staff";
                                    tu.GetTextBox.Text = "CCS16102000X";
                                    tu.GetTextBox.Enabled = false;
                                    tu.GetComboBox.Enabled = false;
                                    break;
                                case DialogResult.No:
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView2.Rows[i];
                        if (row.Cells["Emails"].Value.ToString() == null)
                        {
                            dynamic re = MessageBox.Show("This information of this staff not completely, Do you want to completely set up it?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            switch (re)
                            {
                                case DialogResult.Yes:
                                    DangKyTaiKhoan tu = new DangKyTaiKhoan();
                                    tu.Show();
                                    this.Hide();
                                    tu.GetButton.Text = "Great";
                                    tu.GetComboBox.Text = "Staff Accountant";
                                    tu.GetTextBox.Text = "STC2812200319992000";
                                    tu.GetTextBox.Enabled = false;
                                    tu.GetComboBox.Enabled = false;
                                    break;
                                case DialogResult.No:
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            if( groupBox2.Enabled == false)
            {
                MessageBox.Show("This feature is not available in your department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
//391