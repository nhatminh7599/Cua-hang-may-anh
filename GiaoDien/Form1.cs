using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GiaoDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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
        }

    }
}
