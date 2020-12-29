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
    public partial class EditTrip : Form
    {
        string cStr = "Data Source=DESKTOP-7CBSM7T\\HENDRICHS;Initial Catalog=QuanLyDuLich;Integrated Security=True";
        string toannang = Path.GetFullPath("/VietTravel/Used/Place/");
        public Button button { get { return this.button1; } }
        public EditTrip(DataGridViewRow row)
        {
            InitializeComponent();
            HienThi();
            DiaDiem.Text = row.Cells["TenDiaDiem"].Value.ToString();
            SqlConnection a = new SqlConnection(cStr);
            string kiem = "select HuongDanVien from HuongDanVien where MaHDV = @ma";
            string chinhanh = "select phongcanh from TRIPAVAILABLE where TenDiaDiem = @ten";
            SqlCommand sql = new SqlCommand(chinhanh, a);
            sql.Parameters.AddWithValue("@ten", DiaDiem.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlCommand b = new SqlCommand(kiem, a);
            b.Parameters.AddWithValue("@ma", row.Cells["MaHDV"].Value.ToString());
            SqlDataAdapter r = new SqlDataAdapter(b);
            DataTable g = new DataTable();
            r.Fill(g);
            var data = (Byte[])(table.Rows[0].ItemArray[0]);
            var stream = new MemoryStream(data);
            MC.Text = row.Cells["MaChuyen"].Value.ToString();
            ChoO.Text = row.Cells["TENSOHUU"].Value.ToString();
            NgayXuatPhat.Value = Convert.ToDateTime(row.Cells["NgayKhoiHanh"].Value);
            soluong.Text = row.Cells["SoLuong"].Value.ToString();
            TinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
            DichVu.Text = row.Cells["DichVuFree"].Value.ToString();
            TongTien.Text = row.Cells["Giaien"].Value.ToString();
            HuongDanVien.Text = g.Rows[0].ItemArray[0].ToString();
            AnhChuyen.Image = Image.FromStream(stream);
            if (button1.Text == "Done")
            {
                MC.Enabled = true;

            }
            else
            {
                MC.Enabled = false;
                label12.Visible = false;
                textBox1.Visible = false;
            }
        }
        /*public EditTrip(DataGridViewRow rails)
        {
            InitializeComponent();
            HienThi();
            DiaDiem.Text = rails.Cells["TenDiaDiem"].Value.ToString();
            SqlConnection a = new SqlConnection(cStr);
            string kiem = "select HuongDanVien from HuongDanVien where MaHDV = @ma";
            string chinhanh = "select phongcanh from TRIPAVAILABLE where TenDiaDiem = @ten";
            SqlCommand sql = new SqlCommand(chinhanh, a);
            sql.Parameters.AddWithValue("@ten", DiaDiem.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlCommand b = new SqlCommand(kiem, a);
            b.Parameters.AddWithValue("@ma", rails.Cells["MaHDV"].Value.ToString());
            SqlDataAdapter r = new SqlDataAdapter(b);
            DataTable g = new DataTable();
            r.Fill(g);
            var data = (Byte[])(table.Rows[0].ItemArray[0]);
            var stream = new MemoryStream(data);
            MC.Text = rails.Cells["MaChuyen"].Value.ToString();
            ChoO.Text = rails.Cells["TENSOHUU"].Value.ToString();
            NgayXuatPhat.Value = Convert.ToDateTime(rails.Cells["NgayKhoiHanh"].Value);
            soluong.Text = rails.Cells["SoLuong"].Value.ToString();
            TinhTrang.Text = rails.Cells["TinhTrang"].Value.ToString();
            DichVu.Text = rails.Cells["DichVuFree"].Value.ToString();
            TongTien.Text = rails.Cells["Giaien"].Value.ToString();
            HuongDanVien.Text = g.Rows[0].ItemArray[0].ToString();
            AnhChuyen.Image = Image.FromStream(stream);
            if (button1.Text == "Done")
            {
                MC.Enabled = true;

            }
            else
            {
                MC.Enabled = false;
                label12.Visible = false;
                textBox1.Visible = false;
            }
        }*/

        public EditTrip()
        {
            InitializeComponent();
            HienThi();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void HienThi()
        {
            // TODO: This line of code loads data into the 'quanLyDuLichDataSet4.HuongDanvien' table. You can move, or remove it, as needed.
            this.huongDanvienTableAdapter.Fill(this.quanLyDuLichDataSet4.HuongDanvien);
            // TODO: This line of code loads data into the 'quanLyDuLichDataSet3.ACCOMODATION' table. You can move, or remove it, as needed.
            this.aCCOMODATIONTableAdapter.Fill(this.quanLyDuLichDataSet3.ACCOMODATION);
            // TODO: This line of code loads data into the 'quanLyDuLichDataSet1.TRIPAVAILABLE' table. You can move, or remove it, as needed.
            this.tRIPAVAILABLETableAdapter.Fill(this.quanLyDuLichDataSet1.TRIPAVAILABLE);
            SqlConnection aas = new SqlConnection(cStr);
            string liet = "select TenDiaDiem from TRIPAVAILABLE";
            SqlCommand sql = new SqlCommand(liet, aas);
            SqlDataAdapter we = new SqlDataAdapter(sql);
            DataTable data = new DataTable();
            we.Fill(data);
            DiaDiem.DataSource = data;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu aaa = new TrangChu();
            aaa.Show();
            this.Hide();
        }

        private void AnhChuyen_Click(object sender, EventArgs e)
        {
            OpenFileDialog AD = new OpenFileDialog();
            if (AD.ShowDialog() == DialogResult.OK)
            {
                string pathImage = AD.FileName.Replace(toannang, "");
                AnhChuyen.Image = new Bitmap(toannang + pathImage);
                AnhChuyen.Image.Tag = pathImage;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cStr);
            System.Windows.Forms.Form IU = System.Windows.Forms.Application.OpenForms["EditAgency"];
            if (button1.Text == "Done")
            {
                if (MC.Text == "" || soluong.Text == "" || TongTien.Text == "" || textBox1.Text == "" || AnhChuyen.Image == null )
                {
                    if (MC.Text == "")
                    {
                        MessageBox.Show("Please fill in blank space");
                    }
                    else if (AnhChuyen.Image == null)
                    {
                        MessageBox.Show("Please Choose Image for Trip");
                    }
                    else if (soluong.Text == "")
                    {
                        MessageBox.Show("Please fill in blank space");
                    }
                    else if (TongTien.Text == "")
                    {
                        MessageBox.Show("Please fill in blank space");
                    }
                    else if (textBox1.Text == "")
                    {
                        var res = MessageBox.Show("The default value set for the property will be 0", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            textBox1.Text = "0";
                        }
                        else
                        {
                            textBox1.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    string luachona = "Select * from ChuyenDi where MaChuyen = @ma";
                    SqlCommand command3 = new SqlCommand(luachona, con);
                    command3.Parameters.AddWithValue("@ma", MC.Text);
                    SqlDataAdapter sql1 = new SqlDataAdapter(command3);
                    DataTable data1 = new DataTable();
                    sql1.Fill(data1);
                    if (data1.Rows.Count > 0)
                    {
                        MessageBox.Show("Trip Code is belong another trip please recheck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string kiemtranv = "Select * from ChuyenDi tr , HuongDanVien TG where tr.MaHDV = TG.MaHDV And HuongDanVien = @nv And TinhTrang = 'On Sale' And TinhTrang = 'Hot Sale'";
                        SqlCommand ki = new SqlCommand(kiemtranv, con);
                        ki.Parameters.AddWithValue("@nv", HuongDanVien.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(ki);
                        DataTable ads = new DataTable();
                        adapter.Fill(ads);
                        if (ads.Rows.Count > 0)
                        {
                            MessageBox.Show("This Employ belong another trip ,Please choose another staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            string luu = toannang + AnhChuyen.Image.Tag.ToString();
                            Byte[] buffer = File.ReadAllBytes(luu);
                            string suaanh = "select cd.TenDiaDiem from ChuyenDi cd , TRIPAVAILABLE tp where cd.TenDiaDiem = tp.TenDiaDiem and tp.PhongCanh = @anh";
                            SqlCommand Samira = new SqlCommand(suaanh, con);
                            var nhiphan = Samira.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                            nhiphan.Value = buffer;
                            SqlDataAdapter anivi = new SqlDataAdapter(Samira);
                            DataTable via = new DataTable();
                            anivi.Fill(via);
                            string cap = "insert into ChuyenDi (MaChuyen,TenDiaDiem , SoLuong , TinhTrang , DichVuFree , TenSoHuu , Giaien , MgayKhoiHanh , LuotThich,MaHDV ) values (@ma , @tendiadiem , @soluong , @tinhtrang , @dichvu , @tensohuu , @gia , @ngaydi , @yeucau , @matg)";
                            string list = "select tr.MaHDV from ChuyenDi tr , HuongDanVien hdv where tr.MaHDV = hdv.MaHDV and hdv.HuongDanVien = @ten";
                            SqlCommand sql = new SqlCommand(list, con);
                            sql.Parameters.AddWithValue("@ten", HuongDanVien.Text);
                            SqlDataAdapter a = new SqlDataAdapter(sql);
                            DataTable o = new DataTable();
                            a.Fill(o);
                            MessageBox.Show(o.Rows[0].ItemArray[0].ToString());
                            SqlCommand Yoo = new SqlCommand(cap, con);
                            Yoo.Parameters.AddWithValue("@ma", MC.Text);
                            Yoo.Parameters.AddWithValue("@tendiadiem", Convert.ToString(via.Rows[0].ItemArray[0].ToString()));
                            Yoo.Parameters.AddWithValue("@soluong", soluong.Text);
                            Yoo.Parameters.AddWithValue("@tinhtrang", TinhTrang.Text);
                            Yoo.Parameters.AddWithValue("@dichvu", DichVu.Text);
                            Yoo.Parameters.AddWithValue("@tensohuu" , ChoO.Text);
                            Yoo.Parameters.AddWithValue("@gia", TongTien.Text);
                            Yoo.Parameters.AddWithValue("@ngay", Convert.ToDateTime(NgayXuatPhat.Value.ToString()));
                            Yoo.Parameters.AddWithValue("@yeucau", textBox1.Text);
                            Yoo.Parameters.AddWithValue("@matg", Convert.ToInt32(o.Rows[0].ItemArray[0].ToString()));
                            SqlDataAdapter ori = new SqlDataAdapter(Yoo);
                            DataTable azir = new DataTable();
                            ori.Fill(azir);
                            MessageBox.Show("Added Trip Success");
                            var res = MessageBox.Show("Do you want to return Main Form ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (res == DialogResult.Yes)
                            {
                                TrangChu chu = new TrangChu();
                                chu.Show();
                                this.Hide();
                            }
                            else
                            {
                                EditTrip eee = new EditTrip();
                                eee.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
            else if (button1.Text == "Next")
            {
                if (MC.Text == "" || soluong.Text == "" || TongTien.Text == "")
                {
                    if (MC.Text == "")
                    {
                        MessageBox.Show("Please fill in blank space");
                    }
                    else if (soluong.Text == "")
                    {
                        MessageBox.Show("Please fill in blank space");
                    }
                    else if (TongTien.Text == "")
                    {
                        MessageBox.Show("Please fill in blank space");
                    }
                }
                else
                {
                    string luachon = "Select * from ChuyenDi where MaChuyen = @ma";
                    SqlCommand command = new SqlCommand(luachon, con);
                    command.Parameters.AddWithValue("@ma", MC.Text);
                    SqlDataAdapter sql = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    sql.Fill(data);
                    if (data.Rows.Count > 1)
                    {
                        MessageBox.Show("Trip Code is belong another trip please recheck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string kiemtranv = "Select * from ChuyenDi tr , HuongDanVien TG where tr.MaHDV = TG.MaHDV And HuongDanVien = @nv And TinhTrang = 'On Sale' And TinhTrang = 'Hot Sale'";
                        SqlCommand ki = new SqlCommand(kiemtranv, con);
                        ki.Parameters.AddWithValue("@nv", HuongDanVien.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(ki);
                        DataTable ads = new DataTable();
                        adapter.Fill(ads);
                        if (ads.Rows.Count > 0)
                        {
                            MessageBox.Show("This Employ belong another trip ,Please choose another staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string luu = toannang + AnhChuyen.Image.Tag.ToString();
                            if (luu != null)
                            {
                                byte[] buffer = File.ReadAllBytes(luu);
                                string capnhap = "update ChuyenDi set  SoLuong = @soluong , TinhTrang = @tinhtrang , TenDiaDiem = @diadiem , MaHDV = @mhdv , DichVuFree = @service , TenSoHuu = @cho , giaien = @gia , ngaykhoihanh = @ngay , where MaChuyen = @ma ";
                                string list = "select tr.MaHDV from ChuyenDi tr , HuongDanVien hdv where tr.MaHDV = hdv.MaHDV and hdv.HuongDanVien = @ten";
                                string suaanh = "select cd.TenDiaDiem from ChuyenDi cd , TRIPAVAILABLE tp where cd.TenDiaDiem = tp.TenDiaDiem and tp.PhongCanh = @anh";
                                SqlCommand Samira = new SqlCommand(suaanh, con);
                                var nhiphan = Samira.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                                nhiphan.Value = buffer;
                                SqlDataAdapter anivi = new SqlDataAdapter(Samira);
                                DataTable via = new DataTable();
                                anivi.Fill(via);
                                SqlCommand saaa = new SqlCommand(list, con);
                                saaa.Parameters.AddWithValue("@ten", HuongDanVien.Text);
                                SqlDataAdapter alsi = new SqlDataAdapter(saaa);
                                DataTable ais = new DataTable();
                                alsi.Fill(ais);
                                MessageBox.Show(via.Rows[0].ItemArray[0].ToString());
                                SqlCommand als = new SqlCommand(capnhap, con);
                                als.Parameters.AddWithValue("@soluong", soluong.Text);
                                als.Parameters.AddWithValue("@tinhtrang", TinhTrang.Text);
                                als.Parameters.AddWithValue("@diadiem", Convert.ToString(via.Rows[0].ItemArray[0].ToString()));
                                als.Parameters.AddWithValue("@Mhdv", Convert.ToInt32(ais.Rows[0].ItemArray[0].ToString()));
                                als.Parameters.AddWithValue("@service", DichVu.Text);
                                als.Parameters.AddWithValue("@cho", ChoO.Text);
                                als.Parameters.AddWithValue("@gia", TongTien.Text);
                                als.Parameters.AddWithValue("@ngay", Convert.ToDateTime(NgayXuatPhat.Value.ToString()));
                                als.Parameters.AddWithValue("@ma", MC.Text);
                                SqlDataAdapter port = new SqlDataAdapter(als);
                                DataTable table = new DataTable();
                                port.Fill(table);
                                MessageBox.Show("Update Successfully");
                                var res = MessageBox.Show("Do you want to comback Main form?", "Warning", MessageBoxButtons.YesNo);
                                if (res == DialogResult.Yes)
                                {
                                    TrangChu a = new TrangChu();
                                    a.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    this.Show();
                                }
                            }
                            else
                            {
                                string capnhap = "update ChuyenDi set  SoLuong = @soluong , TinhTrang = @tinhtrang , MaHDV = @mhdv , DichVuFree = @service , TenSoHuu = @cho , giaien = @gia , ngaykhoihanh = @ngay , where MaChuyen = @ma ";
                                string list = "select tr.MaHDV from ChuyenDi tr , HuongDanVien hdv where tr.MaHDV = hdv.MaHDV and hdv.HuongDanVien = @ten";
                                SqlCommand saaa = new SqlCommand(list, con);
                                saaa.Parameters.AddWithValue("@ten", HuongDanVien.Text);
                                SqlDataAdapter alsi = new SqlDataAdapter(saaa);
                                DataTable ais = new DataTable();
                                SqlCommand als = new SqlCommand(capnhap, con);
                                als.Parameters.AddWithValue("@soluong", soluong.Text);
                                als.Parameters.AddWithValue("@tinhtrang", TinhTrang.Text);
                                als.Parameters.AddWithValue("@Mhdv", Convert.ToInt32(ais.Rows[0].ItemArray[0].ToString()));
                                als.Parameters.AddWithValue("@service", DichVu.Text);
                                als.Parameters.AddWithValue("@cho", ChoO.Text);
                                als.Parameters.AddWithValue("@gia", TongTien.Text);
                                als.Parameters.AddWithValue("@ngay", Convert.ToDateTime(NgayXuatPhat.Value.ToString()));
                                als.Parameters.AddWithValue("@ma", MC.Text);
                                SqlDataAdapter port = new SqlDataAdapter(als);
                                DataTable table = new DataTable();
                                port.Fill(table);
                                MessageBox.Show("Update Successfully");
                                var res = MessageBox.Show("Do you want to comback Main form?", "Warning", MessageBoxButtons.YesNo);
                                if (res == DialogResult.Yes)
                                {
                                    TrangChu a = new TrangChu();
                                    a.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    this.Show();
                                }
                            }
                        }

                    }
                }
            }
            else if (button1.Text == "Accept")
            {
                if (MC.Text == "" || soluong.Text == "" || TongTien.Text == "")
                {
                    if (MC.Text == "")
                    {
                        MessageBox.Show("Please fill in blank space");
                    }
                    else if (soluong.Text == "")
                    {
                        MessageBox.Show("Please fill in blank space");
                    }
                    else if (TongTien.Text == "")
                    {
                        MessageBox.Show("Please fill in blank space");
                    }
                }
                else
                {
                    string luachon = "Select * from ChuyenDi where MaChuyen = @ma";
                    SqlCommand command = new SqlCommand(luachon, con);
                    command.Parameters.AddWithValue("@ma", MC.Text);
                    SqlDataAdapter sql = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    sql.Fill(data);
                    if (data.Rows.Count > 1)
                    {
                        MessageBox.Show("Trip Code is belong another trip please recheck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string kiemtranv = "Select * from ChuyenDi tr , HuongDanVien TG where tr.MaHDV = TG.MaHDV And HuongDanVien = @nv And TinhTrang = 'On Sale' And TinhTrang = 'Hot Sale'";
                        SqlCommand ki = new SqlCommand(kiemtranv, con);
                        ki.Parameters.AddWithValue("@nv", HuongDanVien.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(ki);
                        DataTable ads = new DataTable();
                        adapter.Fill(ads);
                        if (ads.Rows.Count > 0)
                        {
                            MessageBox.Show("This Employ belong another trip ,Please choose another staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string luu = toannang + AnhChuyen.Image.Tag.ToString();
                            if (luu != null)
                            {
                                byte[] buffer = File.ReadAllBytes(luu);
                                string capnhap = "update ChuyenDi set  SoLuong = @soluong , TinhTrang = @tinhtrang , TenDiaDiem = @diadiem , MaHDV = @mhdv , DichVuFree = @service , TenSoHuu = @cho , giaien = @gia , ngaykhoihanh = @ngay , where MaChuyen = @ma ";
                                string list = "select tr.MaHDV from ChuyenDi tr , HuongDanVien hdv where tr.MaHDV = hdv.MaHDV and hdv.HuongDanVien = @ten";
                                string suaanh = "select cd.TenDiaDiem from ChuyenDi cd , TRIPAVAILABLE tp where cd.TenDiaDiem = tp.TenDiaDiem and tp.PhongCanh = @anh";
                                SqlCommand Samira = new SqlCommand(suaanh, con);
                                var nhiphan = Samira.Parameters.Add("@anh", SqlDbType.VarBinary, -1);
                                nhiphan.Value = buffer;
                                SqlDataAdapter anivi = new SqlDataAdapter(Samira);
                                DataTable via = new DataTable();
                                anivi.Fill(via);
                                SqlCommand saaa = new SqlCommand(list, con);
                                saaa.Parameters.AddWithValue("@ten", HuongDanVien.Text);
                                SqlDataAdapter alsi = new SqlDataAdapter(saaa);
                                DataTable ais = new DataTable();
                                alsi.Fill(ais);
                                MessageBox.Show(via.Rows[0].ItemArray[0].ToString());
                                SqlCommand als = new SqlCommand(capnhap, con);
                                als.Parameters.AddWithValue("@soluong", soluong.Text);
                                als.Parameters.AddWithValue("@tinhtrang", TinhTrang.Text);
                                als.Parameters.AddWithValue("@diadiem", Convert.ToString(via.Rows[0].ItemArray[0].ToString()));
                                als.Parameters.AddWithValue("@Mhdv", Convert.ToInt32(ais.Rows[0].ItemArray[0].ToString()));
                                als.Parameters.AddWithValue("@service", DichVu.Text);
                                als.Parameters.AddWithValue("@cho", ChoO.Text);
                                als.Parameters.AddWithValue("@gia", TongTien.Text);
                                als.Parameters.AddWithValue("@ngay", Convert.ToDateTime(NgayXuatPhat.Value.ToString()));
                                als.Parameters.AddWithValue("@ma", MC.Text);
                                SqlDataAdapter port = new SqlDataAdapter(als);
                                DataTable table = new DataTable();
                                port.Fill(table);
                                MessageBox.Show("Update Successfully");
                                var res = MessageBox.Show("Do you want to comback Main form?", "Warning", MessageBoxButtons.YesNo);
                                if (res == DialogResult.Yes)
                                {
                                    TrangChu a = new TrangChu();
                                    a.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    this.Show();
                                }
                            }
                            else
                            {
                                string capnhap = "update ChuyenDi set  SoLuong = @soluong , TinhTrang = @tinhtrang , MaHDV = @mhdv , DichVuFree = @service , TenSoHuu = @cho , giaien = @gia , ngaykhoihanh = @ngay , where MaChuyen = @ma ";
                                string list = "select tr.MaHDV from ChuyenDi tr , HuongDanVien hdv where tr.MaHDV = hdv.MaHDV and hdv.HuongDanVien = @ten";
                                SqlCommand saaa = new SqlCommand(list, con);
                                saaa.Parameters.AddWithValue("@ten", HuongDanVien.Text);
                                SqlDataAdapter alsi = new SqlDataAdapter(saaa);
                                DataTable ais = new DataTable();
                                SqlCommand als = new SqlCommand(capnhap, con);
                                als.Parameters.AddWithValue("@soluong", soluong.Text);
                                als.Parameters.AddWithValue("@tinhtrang", TinhTrang.Text);
                                als.Parameters.AddWithValue("@Mhdv", Convert.ToInt32(ais.Rows[0].ItemArray[0].ToString()));
                                als.Parameters.AddWithValue("@service", DichVu.Text);
                                als.Parameters.AddWithValue("@cho", ChoO.Text);
                                als.Parameters.AddWithValue("@gia", TongTien.Text);
                                als.Parameters.AddWithValue("@ngay", Convert.ToDateTime(NgayXuatPhat.Value.ToString()));
                                als.Parameters.AddWithValue("@ma", MC.Text);
                                SqlDataAdapter port = new SqlDataAdapter(als);
                                DataTable table = new DataTable();
                                port.Fill(table);
                                MessageBox.Show("Update Successfully");
                                var res = MessageBox.Show("Do you want to comback Main form?", "Warning", MessageBoxButtons.YesNo);
                                if (res == DialogResult.Yes)
                                {
                                    TrangChu a = new TrangChu();
                                    a.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    this.Show();
                                }
                            }
                        }

                    }
                }
            }
        }

        private void EditTrip_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChu aui = new TrangChu();
            aui.Show();
            this.Hide();
        }
    }
}

