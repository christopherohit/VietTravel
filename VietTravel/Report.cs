using Microsoft.Reporting.WinForms;
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
    public partial class Report : Form
    {
        string cStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDuLichDataSet6.AGENCYFORAdmin' table. You can move, or remove it, as needed.
            this.aGENCYFORAdminTableAdapter.Fill(this.quanLyDuLichDataSet6.AGENCYFORAdmin);
            // TODO: This line of code loads data into the 'QuanLyDuLichDataSet5.ChuyenDi' table. You can move, or remove it, as needed.
            this.ChuyenDiTableAdapter.Fill(this.QuanLyDuLichDataSet5.ChuyenDi);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            string query = "Select * from AgencyForAdmin where TenDaiLy = @daily";
            SqlCommand il = new SqlCommand(query, con);
            il.Parameters.AddWithValue("@daily", comboBox1.Text);
            SqlDataAdapter ios = new SqlDataAdapter(il);
            DataSet vn = new DataSet();
            ios.Fill(vn);

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            if (vn.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "BaoCaoDoanhSoChuyenDi";
                rds.Value = vn.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form nv = System.Windows.Forms.Application.OpenForms["MainHDV"];
            nv.Show();
            this.Hide();
        }

        private void Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Form nv = System.Windows.Forms.Application.OpenForms["MainHDV"];
            nv.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            string query = "Select * from AgencyForAdmin";
            SqlCommand il = new SqlCommand(query, con);
            SqlDataAdapter ios = new SqlDataAdapter(il);
            DataSet vn = new DataSet();
            ios.Fill(vn);

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            if (vn.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "BaoCaoDoanhSoChuyenDi";
                rds.Value = vn.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}
