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
    public partial class AllClient : Form
    {
        string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public DataGridView io { get { return this.dataGridView1; } }
        public AllClient()
        {
            InitializeComponent();
        }

        private void AllClient_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            string pot = "select * From KhachHang";
            SqlCommand op = new SqlCommand(pot, con);
            SqlDataAdapter it = new SqlDataAdapter(op);
            DataTable data = new DataTable();
            it.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["MaKH"].Visible = false;
            dataGridView1.Columns["MatKhau"].Visible = false;
            dataGridView1.Columns["HovaTen"].HeaderText = "Customer Name";
            dataGridView1.Columns["SoDienThoai"].HeaderText = "Phone Number";
            dataGridView1.Columns["DiaChi"].HeaderText = "Address";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form pli = System.Windows.Forms.Application.OpenForms["MainHDV"];
            pli.Show();
            this.Hide();
        }

        private void AllClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Form pli = System.Windows.Forms.Application.OpenForms["MainHDV"];
            pli.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("HovaTen LIKE '{0}%'", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemKhachHang jio = new ThemKhachHang();
            jio.Show();
            this.Hide();
            jio.io.Text = "Done";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView1.Rows[i];
                        ThemKhachHang auri = new ThemKhachHang(row);
                        auri.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView1.Rows[i];
                        var res = MessageBox.Show($"Do you want to remove Customers {row.Cells["HovaTen"].Value.ToString()} from the system", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (res)
                        {
                            case DialogResult.Yes:
                                string xoahuongHoadon = "exec XoaKhachHang @emails";
                                //    SqlCommand sql = new SqlCommand(xoahuongHoadon, con);
                                SqlCommand sqlCommand = new SqlCommand(xoahuongHoadon, con);
                                sqlCommand.Parameters.AddWithValue("@emails", Convert.ToInt32(row.Cells["MaKH"].Value.ToString()));
                                DataTable dataTable = new DataTable();
                                SqlDataAdapter c = new SqlDataAdapter(sqlCommand);
                                c.Fill(dataTable);
                                MessageBox.Show("Delete Success");
                                AllClient sd = new AllClient();
                                sd.Show();
                                this.Hide();
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                }
            }
        }
    }
}
//120