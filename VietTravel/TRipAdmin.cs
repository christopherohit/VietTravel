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

    public partial class TRipAdmin : Form
    {
        string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public TRipAdmin()
        {
            InitializeComponent();
        }

        private void TRipAdmin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            string Sql = "Select * from AgencyForAdmin ";
            SqlCommand op = new SqlCommand(Sql, con);
            SqlDataAdapter io = new SqlDataAdapter(op);
            DataTable nn = new DataTable();
            io.Fill(nn);
            dataGridView1.DataSource = nn;
            dataGridView1.Columns["SoLuotThich"].Visible = true;
            dataGridView1.ReadOnly = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form jin = System.Windows.Forms.Application.OpenForms["MainHDV"];
            jin.Show();
            this.Hide();
        }

        private void TRipAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Form jin = System.Windows.Forms.Application.OpenForms["MainHDV"];
            jin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        DataGridViewRow row = this.dataGridView1.Rows[i];
                        EditAgency aaaa = new EditAgency(row);
                        aaaa.Show();
                        this.Hide();
                        aaaa.done.Text = "Completely";
                        aaaa.vhh.Visible = false;
                    }
                }
            }
        }
    }
}
