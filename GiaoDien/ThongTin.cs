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
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        KetNoi conn = new KetNoi();
        DataSet ds = new DataSet();
        KhachHang KH = new KhachHang();
        private void ThongTin_Load(object sender, EventArgs e)
        {
            string Select = "Select * From KhachHang Where KhachHang.TenDangNhap = \"" + Form1.tenTaiKhoan + "\"";
            string[] s = new string[8];
            conn.Open_DataAccess();
            conn.adaShowData = new OleDbDataAdapter(Select, conn.con);
            conn.adaShowData.Fill(ds);
            for (int i = 0; i < 8; i++)
            {
                s[i] = ds.Tables[0].Rows[0].ItemArray[i].ToString();
            }
            KH = new KhachHang(int.Parse(s[0]), s[1], s[2], s[3], s[4], s[5], s[6], bool.Parse(s[7]));
            txtTen.Text = KH.Ten();
            txtMK.Text = KH.MatKhau();
            txtDiaChi.Text = KH.DiaChi();
            txtSDT.Text = KH.SDT();
            txtEmail.Text = KH.Email();
        }
    }
}
