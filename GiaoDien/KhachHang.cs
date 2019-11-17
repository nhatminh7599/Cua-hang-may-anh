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
    public class KhachHang
    {
        protected int maKhachHang;
        protected string tenDangNhap;
        protected string matKhau;
        protected string ten;
        protected string diaChi;
        protected string sDT;
        protected string email;
        protected bool chucVu;

        public KhachHang()
        {
            this.tenDangNhap = this.matKhau = this.ten = this.diaChi = this.sDT = this.email = "";
            this.chucVu = false;
        }
        public KhachHang(int maKhachHang, string TenDangNhap, string MatKhau, string Ten, string DiaChi, string SDT, string Email, bool ChucVu)
        {
            this.maKhachHang = maKhachHang;
            this.tenDangNhap = TenDangNhap;
            this.matKhau = MatKhau;
            this.ten = Ten;
            this.diaChi = DiaChi;
            this.sDT = SDT;
            this.email = Email;
            this.chucVu = ChucVu;
        }
        public KhachHang(string TenDangNhap, string MatKhau, string Ten, string DiaChi, string SDT, string Email, bool ChucVu)
        {
            this.maKhachHang = 0;
            this.tenDangNhap = TenDangNhap;
            this.matKhau = MatKhau;
            this.ten = Ten;
            this.diaChi = DiaChi;
            this.sDT = SDT;
            this.email = Email;
            this.chucVu = ChucVu;
        }

        /// <summary>
        /// Thêm 1 khách hàng vào hệ thống
        /// Mặc định là khách hàng (Quản lý = false)
        /// </summary>
        /// <param name="TenDangNhap">Tên đăng nhập</param>
        /// <param name="MatKhau">Mật khẩu</param>
        /// <param name="HoTen">Họ tên</param>
        /// <param name="DiaChi">Địa chỉ</param>
        /// <param name="SDT">SDT</param>
        /// <param name="Email">Email</param>
        /// <returns></returns>
        public bool ThemKhachHang()
        {
            try
            {
                KetNoi ketnoi = new KetNoi();
                ketnoi.setConnect(@"C:\Users\NhatMinh\Desktop\Cua-hang-may-anh\GiaoDien" + @"\CuaHangMayAnh.mdb");
                if (this.tenDangNhap.Length < 6 || this.matKhau.Length < 6 || ThaoTac.KTSDT(this.sDT) == false)
                    return false;
                else
                {
                    if(ThaoTac.KTTonTai("KhachHang", "TenDangNhap", this.tenDangNhap))
                        return false;
                    else
                    {
                        
                        string danhsachcot = "TenDangNhap, MatKhau, DiaChi, HoTen, SDT, Email";
                        string danhsachthamso = ("\"" + this.TenDangNhap() + "\"" + ", " +
                                                 "\"" + this.MatKhau() + "\"" + ", " +
                                                 "\"" + this.Ten() + "\"" + ", " +
                                                 "\"" + this.DiaChi() + "\"" + ", " +
                                                 "\"" + this.SDT() + "\"" + ", " +
                                                 "\"" + this.Email() + "\"");
                        string Select = "insert into KhachHang " + "(" + danhsachcot + ") values(" + danhsachthamso + ")";
                        ketnoi.Load_Data(Select);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Thêm quản lý mới (tài khoản chưa tồn tại trên hệ thống)
        /// </summary>
        /// <param name="TenDangNhap">Tên đăng nhập</param>
        /// <param name="MatKhau">Mật khẩu</param>
        /// <param name="HoTen">Họ tên</param>
        /// <param name="DiaChi">Địa chỉ</param>
        /// <param name="SDT">SDT</param>
        /// <param name="Email">Email</param>
        /// <returns></returns>
        public bool ThemQuanLy()
        {
            try
            {
                if (this.tenDangNhap.Length < 6 || this.matKhau.Length < 6 || ThaoTac.KTSDT(this.sDT) == false)
                    return false;
                else
                {
                    if (ThaoTac.KTTonTai("KhachHang", "TenDangNhap", this.TenDangNhap()))
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                        return false;
                    }
                    else
                    {
                        KetNoi ketnoi = new KetNoi();
                        string danhsachcot = "TenDangNhap, MatKhau, DiaChi, HoTen, SDT, Email, QuanLy";
                        string danhsachthamso = ("\"" + this.TenDangNhap() + "\"" + ", " +
                                                 "\"" + this.MatKhau() + "\"" + ", " +
                                                 "\"" + this.Ten() + "\"" + ", " +
                                                 "\"" + this.DiaChi() + "\"" + ", " +
                                                 "\"" + this.SDT() + "\"" + ", " +
                                                 "\"" + this.Email() + "\"" + ", " + "True");
                        string Select = "insert into KhachHang " + "(" + danhsachcot + ") values(" + danhsachthamso + ")";
                        ketnoi.Load_Data(Select);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Cập nhật tài khoản thành quản lý
        /// </summary>
        /// <param name="TenDangNhap">Tên tài khoản</param>
        /// <returns></returns>
        public static bool ThemQuanLy(string TenDangNhap, string MatKhau)
        {
            if (ThaoTac.KTMatKhau(TenDangNhap, MatKhau))
            {
                KetNoi ketnoi = new KetNoi();
                ketnoi.setConnect(@"C:\Users\NhatMinh\Desktop\Cua-hang-may-anh\GiaoDien" + @"\CuaHangMayAnh.mdb");
                string Update = "Update KhachHang set QuanLy = True Where KhachHang.TenDangNhap = \"" + TenDangNhap + "\"";
                ketnoi.Load_Data(Update);
                return true;
            }
            else
                return false;
        }

        public string TenDangNhap() { return this.tenDangNhap; }
        public void TenDangNhap(string value) { this.tenDangNhap = value; }
        public string MatKhau() { return this.matKhau; }
        public void MatKhau(string value) { this.matKhau = value; }
        public string Ten() { return this.ten; }
        public void Ten(string value) { this.ten = value; }
        public string DiaChi() { return this.diaChi; }
        public void DiaChi(string value) { this.diaChi = value; }
        public string SDT() { return this.sDT; }
        public void SDT(string value) { this.sDT = value; }
        public string Email() { return this.email; }
        public void Email(string value) { this.email = value; }
        public bool ChucVu() { return this.chucVu; }
        public void ChucVu (bool value) { this.chucVu = value; }
    }
}
