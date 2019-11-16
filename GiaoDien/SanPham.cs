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
    class SanPham
    {
        public int ma;
        public string ten;
        public int soluong;
        public double dongia;
        public string mota;
        KetNoi ketnoi = new KetNoi();
        public SanPham()
        {
            ten = mota = "";
            ma = soluong = 0;
            dongia = 0;
        }
        public SanPham(int ma, string ten, int soluong, double dongia, string mota)
        {
            this.ma = ma;
            this.ten = ten;
            this.soluong = soluong;
            this.dongia = dongia;
            this.mota = mota;
        }
        public void ThemSanPham()
        {
            try
            {
                if (ThaoTac.KTTonTai("DsSP", "MaSP", this.ma))
                    MessageBox.Show("Mã sản phẩm đã tồn tại!!!!");
                else
                {
                    string danhsachcot = "MaSP, TenSP, SoLuong, Gia, MoTa";
                    string danhsachthamso = (this.ma.ToString() + ", " +
                                        "\"" + this.ten + "\"" + ", "
                                        + this.soluong.ToString() + ", "
                                        + this.dongia.ToString() + ", " +
                                         "\"" + this.mota + "\"");
                    string accINSET = "INSERT INTO DsSP (" + danhsachcot + ") values (" + danhsachthamso + ")";
                    ketnoi.Load_Data(accINSET);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi dữ liệu", "Lỗi");
            }
        }
        public void SuaSanPham()
        {
            try
            {
                if(ThaoTac.KTTonTai("DsSP", "MaSP", this.ma))
                {
                    string accINSET = "UPDATE DsSP SET TenSP = \""
                                       + this.ten + "\", Soluong = " + this.soluong + ", Gia = "
                                       + this.dongia + ", MoTa = \"" + this.mota + "\" WHERE DsSP.MaSP = " + this.ma;
                    ketnoi.Load_Data(accINSET);
                }
                else MessageBox.Show("Mã sản phẩm không tồn tại", "Lỗi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi dữ liệu", "Lỗi");
            }
        }
        public void XoaSanPham()
        {
            try
            {
                
                string del = "DELETE FROM DsSP WHERE MaSP = " + this.ma;
                ketnoi.Load_Data(del);
                MessageBox.Show("Đã xóa sản phẩm " + this.ma);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!!!!!" + ex.Message);
            }
        }
    }
}
