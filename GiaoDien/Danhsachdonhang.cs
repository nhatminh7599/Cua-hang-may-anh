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
    public partial class Danhsachdonhang : Form
    {
        public Danhsachdonhang()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();

        private void Danhsachdonhang_Load(object sender, EventArgs e)
        {
            ketnoi.Open_DataAccess();
            string s = @"SELECT CTHoaDon.MaHD, DsSP.TenSP, KhachHang.HoTen, CTHoaDon.SoLuong, CTHoaDon.Gia, KhachHang.SDT, KhachHang.DiaChi FROM KhachHang INNER JOIN (HoaDon INNER JOIN (DsSP INNER JOIN CTHoaDon ON DsSP.MaSP = CTHoaDon.MaSP) ON HoaDon.MaHD = CTHoaDon.MaHD) ON KhachHang.MaKH = HoaDon.MaKH WHERE (((CTHoaDon.ThanhToan)=True));";
            ketnoi.adaShowData = new OleDbDataAdapter(s, ketnoi.con);
            DataSet ds = new DataSet();
            ds.Clear();
            ketnoi.adaShowData.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
