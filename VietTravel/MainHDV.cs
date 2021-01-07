using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietTravel
{
    public partial class MainHDV : Form
    {
        string conStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";

        public Label op { get { return this.label3; } }
        public GroupBox lju { get { return this.groupBox1; } }
        bool IsDirty { get; set; }
        public PictureBox asd { get { return this.picBox1; } }
        public MainHDV(DataTable data1)
        {
            SqlConnection con = new SqlConnection(conStr);
            InitializeComponent();
            var data = (Byte[])(data1.Rows[0].ItemArray[6]);
            var stream = new MemoryStream(data);
            picBox1.Image = Image.FromStream(stream);
            IsDirty = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.vietravel.com/vn/tag/huong-dan-vien-du-lich.aspx");
            IsDirty = false;
        }

        private void AllTrip_Click(object sender, EventArgs e)
        {
            TripAvai re = new TripAvai();
            re.Show();
            this.Hide();
            IsDirty = false;
        }

        private void MainHDV_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Do you want to exit system ?", "Warning", MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                if (IsDirty == true)
                {
                    Environment.Exit(1);
                }
                else if (IsDirty == false)
                {
                    Environment.Exit(1);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainHDV_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form loi = System.Windows.Forms.Application.OpenForms["SignIn"];
            SqlConnection con = new SqlConnection(conStr);
            string kiemtra = "select * From HuongDanVien where Emails = @mails";
            string kiemtra2 = "select * from CSKH where Emails = @mails";
            string kiemtra3 = "select * from NhanVienKeToan where Emails = @mails";
            SqlCommand i1 = new SqlCommand(kiemtra, con);
            i1.Parameters.AddWithValue("@mails", ((Signin)loi).TextBox.Text);
            SqlDataAdapter ocv = new SqlDataAdapter(i1);
            DataTable mm = new DataTable();
            ocv.Fill(mm);
            SqlCommand i2 = new SqlCommand(kiemtra2, con);
            i2.Parameters.AddWithValue("@mails", ((Signin)loi).TextBox.Text);
            SqlDataAdapter sqlData = new SqlDataAdapter(i2);
            DataTable vc = new DataTable();
            sqlData.Fill(vc);
            SqlCommand i3 = new SqlCommand(kiemtra3, con);
            i3.Parameters.AddWithValue("@mails", ((Signin)loi).TextBox.Text);
            SqlDataAdapter opasr = new SqlDataAdapter(i3);
            DataTable ikmc = new DataTable();
            opasr.Fill(ikmc);
            if (mm.Rows.Count > 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                Client.Enabled = false;
            }
            else if (vc.Rows.Count > 0)
            {
                OnTrip.Enabled = false;
                SoldOut.Enabled = false;
                button4.Enabled = false;
                button2.Enabled = false;
            }
            else if (ikmc.Rows.Count > 0)
            {
                OnTrip.Enabled = false;
                SoldOut.Enabled = false;
            }
        }

        private void OnTrip_Click(object sender, EventArgs e)
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
                Future bin = new Future();
                bin.Show();
                this.Hide();
            }
            else if (vc.Rows.Count > 0)
            {
                MessageBox.Show("This feature is not available in your department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ikmc.Rows.Count > 0)
            {
                MessageBox.Show("This feature is not available in your department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_Click(object sender, EventArgs e)
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
                AllClient ios = new AllClient();
                ios.Show();
                this.Hide();
            }
            else if (ikmc.Rows.Count > 0)
            {
                AllClient isx = new AllClient();
                isx.Show();
                this.Hide();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Form asd = System.Windows.Forms.Application.OpenForms["SignIn"];
            SqlConnection con = new SqlConnection(conStr);
            string kiemtra2 = "select * from CSKH where Emails = @mails";
            string kiemtra3 = "select * from NhanVienKeToan where Emails = @mails";
            SqlCommand i2 = new SqlCommand(kiemtra2, con);
            i2.Parameters.AddWithValue("@mails", ((Signin)asd).TextBox.Text);
            SqlDataAdapter sqlData = new SqlDataAdapter(i2);
            DataTable vc = new DataTable();
            sqlData.Fill(vc);
            SqlCommand i3 = new SqlCommand(kiemtra3, con);
            i3.Parameters.AddWithValue("@mails", ((Signin)asd).TextBox.Text);
            SqlDataAdapter opasr = new SqlDataAdapter(i3);
            DataTable ikmc = new DataTable();
            opasr.Fill(ikmc);
            string quey = "select * From HuongDanVien where Emails = @mails";
            SqlCommand jin = new SqlCommand(quey, con);
            jin.Parameters.AddWithValue("@mails", ((Signin)asd).TextBox.Text);
            SqlDataAdapter io = new SqlDataAdapter(jin);
            DataTable vn = new DataTable();
            io.Fill(vn);
            if (vn.Rows.Count > 0)
            {
                ChinhSuaNanVien op = new ChinhSuaNanVien(vn);
                op.Show();
                this.Hide();
                op.chucvu.Visible = false;
                op.label.Visible = false;
                op.pic.Visible = false;
                op.button.Text = "Completely";
            }
            else if (vc.Rows.Count > 0)
            {
                ChinhSuaNanVien op = new ChinhSuaNanVien(vc);
                op.Show();
                this.Hide();
                op.pic.Visible = false;
                op.button.Text = "Accept";
                op.chucvu.Enabled = true;

            }
            else if (ikmc.Rows.Count > 0)
            {
                ChinhSuaNanVien il = new ChinhSuaNanVien(ikmc);
                il.Show();
                this.Hide();
                il.pic.Visible = false;
                il.button.Text = "Accept";
                il.chucvu.Enabled = true;
            }

        }

        private void SoldOut_Click(object sender, EventArgs e)
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
                OldTrip bin = new OldTrip();
                bin.Show();
                this.Hide();
            }
            else if (vc.Rows.Count > 0)
            {
                MessageBox.Show("This feature is not available in your department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ikmc.Rows.Count > 0)
            {
                MessageBox.Show("This feature is not available in your department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                ListStaff tur = new ListStaff();
                tur.Show();
                this.Hide();
                groupBox1.Enabled = false;
            }
            else if (ikmc.Rows.Count > 0)
            {
                ListStaff tur = new ListStaff();
                tur.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Signin tis = new Signin();
            tis.TextBox.Text = string.Empty;
            tis.Pass.Text = string.Empty;
            tis.Show();
            this.Hide();
            tis.ciris.Text = "Login";
        }

        private void Exact_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form vnc = System.Windows.Forms.Application.OpenForms["SignIn"];
            SqlConnection con = new SqlConnection(conStr);
            string kiemtra = "select * From HuongDanVien where Emails = @mails";
            string kiemtra2 = "select * from CSKH where Emails = @mails";
            string kiemtra3 = "select * from NhanVienKeToan where Emails = @mails";
            SqlCommand i1 = new SqlCommand(kiemtra, con);
            i1.Parameters.AddWithValue("@mails", ((Signin)vnc).TextBox.Text);
            SqlDataAdapter ocv = new SqlDataAdapter(i1);
            DataTable mm = new DataTable();
            ocv.Fill(mm);
            SqlCommand i2 = new SqlCommand(kiemtra2, con);
            i2.Parameters.AddWithValue("@mails", ((Signin)vnc).TextBox.Text);
            SqlDataAdapter sqlData = new SqlDataAdapter(i2);
            DataTable vc = new DataTable();
            sqlData.Fill(vc);
            SqlCommand i3 = new SqlCommand(kiemtra3, con);
            i3.Parameters.AddWithValue("@mails", ((Signin)vnc).TextBox.Text);
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
                Report it = new Report();
                it.Show();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TRipAdmin hinj = new TRipAdmin();
            hinj.Show();
            this.Hide();
        }
    }
}
//284
