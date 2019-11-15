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

        public static string tenTaiKhoan;
        KhachHang KH;
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
                    btQuanLy.Enabled = true;
                    btQuanLy.Visible = true;
                }
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ds = ketnoi.Load_Data("SELECT * FROM DsSP", "DsSP");
            dtvsp2.DataSource = ds.Tables[0];
            KH = new KhachHang();
            lbName.Visible = false;
            lbName.Enabled = false;
            btQuanLy.Visible = false;
            btQuanLy.Enabled = false;
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
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = dtvsp2.CurrentRow.Cells[0].Value.ToString();
                string sl = txtSoLuong.Text;
                string gia = dtvsp2.CurrentRow.Cells[3].Value.ToString();

                string danhsachcot = "MaSP, Gia, SoLuong";
                string danhsachgiatri = ma + ", " + gia + ", " + sl;
                string accINSET = "INSERT INTO CTHoaDon (" + danhsachcot + ") values (" + danhsachgiatri + ")";
                ketnoi.Load_Data(accINSET);
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!!!" + ex);
            }
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
            GioHang gh = new GioHang();
            gh.Show();
        }

    }
}
