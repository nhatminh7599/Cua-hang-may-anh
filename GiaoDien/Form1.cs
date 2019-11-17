using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace GiaoDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection cnn = new OleDbConnection();
        KetNoi ketnoi = new KetNoi();
        DataSet ds = new DataSet();

        public static int maHoaDon = 1;
        public static string tenTaiKhoan;
        KhachHang KH;
        public static bool isQuanLy = false;
        public static bool isDangNhap = false;
        private void lbdangnhap_Click(object sender, EventArgs e)
        {
            Form moi = new DangNhap();
            if (moi.ShowDialog() == DialogResult.OK) // Đăng nhập thành công
            {
                //Xử lý sau khi đăng nhập thành công=
                DataSet ds = new DataSet();
                string Select = ("Select * From Khachhang Where KhachHang.TenDangNhap = \"" + tenTaiKhoan + "\"");
                KetNoi conn = new KetNoi();
                string[] s = new string[8];
                conn.Open_DataAccess();
                conn.adaShowData = new OleDbDataAdapter(Select, conn.con);
                conn.adaShowData.Fill(ds);
                for (int i = 0; i < 8; i++)
                    s[i] = ds.Tables[0].Rows[0].ItemArray[i].ToString();
                KH = new KhachHang(int.Parse(s[0]), s[1], s[2], s[3], s[4], s[5], s[6], bool.Parse(s[7]));
                lbDangNhap.Visible = false;
                lbDangNhap.Enabled = false;
                lbName.Text = KH.Ten();
                lbName.Visible = true;
                lbName.Enabled = true;
                btDangXuat.Enabled = true;
                btDangXuat.Visible = true;
                if (KH.ChucVu())
                {
                    isQuanLy = true;
                    btQuanLy.Enabled = true;
                    btQuanLy.Visible = true;
                }
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            while(ThaoTac.KTTonTai("HoaDon", "MaHD", maHoaDon)) maHoaDon++;
            ds = ketnoi.Load_Data("SELECT * FROM DsSP", "DsSP");
            dtvsp2.DataSource = ds.Tables[0];
            KH = new KhachHang();
            lbName.Visible = false;
            lbName.Enabled = false;
            btQuanLy.Visible = false;
            btQuanLy.Enabled = false;
            btThem.Enabled = false;
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            Form f = new ThongTin();
            f.ShowDialog();
        }

        private void btQuanLy_Click(object sender, EventArgs e)
        {
            Form f = new Danhsachsanpham();
            f.ShowDialog();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            tenTaiKhoan = "";
            KH = new KhachHang();
            lbName.Text = "";
            lbName.Enabled = false;
            lbName.Visible = false;
            lbDangNhap.Visible = true;
            lbDangNhap.Enabled = true;
            btDangXuat.Visible = false;
            btDangXuat.Enabled = false;
            btQuanLy.Visible = false;
            btQuanLy.Enabled = false;
            DangKy.isQuanLy = false;
            isDangNhap = false;
            isQuanLy = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (isDangNhap)
            {
                try
                {
                    string ma = dtvsp2.CurrentRow.Cells[0].Value.ToString();
                    string sl = txtSoLuong.Text;
                    string gia = dtvsp2.CurrentRow.Cells[3].Value.ToString();
                    if (!ThaoTac.KTTonTai("HoaDon", "MaHD", maHoaDon))
                    {

                        DateTime ngay = DateTime.UtcNow;
                        string s = "insert into HoaDon (MaHD, NgayTao) values (" + maHoaDon + ", #" + @ngay.ToString() + "#)";
                        ketnoi.Load_Data(s);

                    }
                    if (ThaoTac.KTHoaDon(maHoaDon, int.Parse(ma)))
                    {
                        DataSet ds = new DataSet();
                        ketnoi.Open_DataAccess();
                        ketnoi.adaShowData = new OleDbDataAdapter("Select SoLuong From CTHoaDon Where MaSP = " + ma + " and MaHD = " + maHoaDon, ketnoi.con);
                        ketnoi.adaShowData.Fill(ds);
                        ketnoi.Close_Connect();
                        int i = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                        string Update = "Update CTHoaDon SET SoLuong = " + (int.Parse(sl) + i) + " Where MaSP = " + ma + " and MaHD = " + maHoaDon;
                        ketnoi.Load_Data(Update);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        txtSoLuong.Text = "0";
                    }
                    else
                    {
                        string danhsachcot = "MaHD, MaSP, Gia, SoLuong";
                        string danhsachgiatri = maHoaDon + ", " + ma + ", " + gia + ", " + sl;
                        string accINSET = "INSERT INTO CTHoaDon (" + danhsachcot + ") values (" + danhsachgiatri + ")";
                        ketnoi.Load_Data(accINSET);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        txtSoLuong.Text = "0";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!!!!!" + ex);
                }
            }
            else
                MessageBox.Show("Vui lòng đăng nhập", "Lỗi");
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(dtvsp2.CurrentRow.Cells[2].Value.ToString());
            if (int.Parse(txtSoLuong.Text) < sl)
            {
                int s = int.Parse(txtSoLuong.Text);
                txtSoLuong.Text = (++s).ToString();
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(dtvsp2.CurrentRow.Cells[2].Value.ToString());
            if (int.Parse(txtSoLuong.Text) > 0)
            {
                int s = int.Parse(txtSoLuong.Text);
                txtSoLuong.Text = (--s).ToString();
            }
        }

        private void dtvsp2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoLuong.Text = 1.ToString();
        }

        private void btGioHang_Click(object sender, EventArgs e)
        {
            if (isDangNhap)
            {
                GioHang gh = new GioHang();
                gh.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng đăng nhập", "Lỗi");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!ThaoTac.KTThanhToan(maHoaDon))
            {
                string del = "DELETE FROM CTHoaDon WHERE MaHD = " + maHoaDon;
                ketnoi.Load_Data(del);
                del = "Delete from HoaDon Where MaHD = " + maHoaDon;
                ketnoi.Load_Data(del);
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            ketnoi.Open_DataAccess();
            string s = "SELECT * FROM DsSP WHERE (((DsSP.TenSP) = \"" + txtTim.Text + "\"));";
            ds.Clear();
            ketnoi.com = new OleDbCommand(s, ketnoi.con);
            ketnoi.com.ExecuteNonQuery();
            ketnoi.adaShowData = new OleDbDataAdapter(s, ketnoi.con);
            ketnoi.adaShowData.Fill(ds);
            ketnoi.Close_Connect();
            dtvsp2.DataSource = ds.Tables[0];
        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {
            ds.Clear();
            ds = ketnoi.Load_Data("SELECT * FROM DsSP", "DsSP");
            dtvsp2.DataSource = ds.Tables[0];
            txtTim.Text = "";
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "0")
                btThem.Enabled = false;
            else btThem.Enabled = true;
        }
    }
}
