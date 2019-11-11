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
    public class ThaoTac
    {
        public static KetNoi con = new KetNoi();

        /// <summary>
        /// Kiểm tra 1 giá trị của 1 cột đã tồn tại trong hệ thống hay chưa
        /// </summary>
        /// <param name="TenBang">Tên bảng</param>
        /// <param name="TenCot">Tên cột</param>
        /// <param name="GiaTri">Giá trị kiểm tra</param>
        /// <returns></returns>
        public static bool KTTonTai(string TenBang, string TenCot, string GiaTri)
        {
            try
            {
                DataSet ds = new DataSet();
                string Select = "SELECT " + TenCot + " From " + TenBang + " k Where k." + TenCot + " = \"" + GiaTri + "\"";
                con.Open_DataAccess();
                con.adaShowData = new OleDbDataAdapter(Select, con.con);
                con.adaShowData.Fill(ds);
                con.Close_Connect();
                int s = ds.Tables[0].Rows.Count;
                if (s > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Ktra mật khẩu của tài khoản đăng nhập
        /// </summary>
        /// <param name="TenDangNhap">Tên đăng nhập</param>
        /// <param name="MatKhau">Mật khẩu</param>
        /// <returns></returns>
        public static bool KTMatKhau(string TenDangNhap, string MatKhau)
        {
            try
            {
                DataSet ds = new DataSet();
                string Select = "SELECT MatKhau From KhachHang Where KhachHang.TenDangNhap = \"" + TenDangNhap + "\"";
                ds = con.Load_Data(Select, "KhachHang");
                string s = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                if (MatKhau == s)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
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
        public static bool ThemKhachHang(string TenDangNhap, string MatKhau, string HoTen, string DiaChi, string SDT, string Email)
        {
            try
            {
                KetNoi ketnoi = new KetNoi();
                DataSet ds = new DataSet();
                string danhsachcot = "TenDangNhap, MatKhau, DiaChi, HoTen, SDT, Email";
                string danhsachthamso = ("\"" + TenDangNhap + "\"" + ", " +
                                         "\"" + MatKhau + "\"" + ", " +
                                         "\"" + HoTen + "\"" + ", " +
                                         "\"" + DiaChi + "\"" + ", " +
                                         "\"" + SDT + "\"" + ", " +
                                         "\"" + Email + "\"");
                string Select = "insert into KhachHang " + "(" + danhsachcot + ") values(" + danhsachthamso + ")";
                ketnoi.Load_Data(Select);
                return true;
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
        public static bool ThemQuanLy(string TenDangNhap, string MatKhau, string HoTen, string DiaChi, string SDT, string Email)
        {
            try
            {
                if (ThaoTac.KTTonTai("KhachHang", "TenDangNhap", TenDangNhap))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    KetNoi ketnoi = new KetNoi();
                    string danhsachcot = "TenDangNhap, MatKhau, DiaChi, HoTen, SDT, Email";
                    string danhsachthamso = ("\"" + TenDangNhap + "\"" + ", " +
                                             "\"" + MatKhau + "\"" + ", " +
                                             "\"" + HoTen + "\"" + ", " +
                                             "\"" + DiaChi + "\"" + ", " +
                                             "\"" + SDT + "\"" + ", " +
                                             "\"" + Email + "\"");
                    string Select = "insert into KhachHang " + "(" + danhsachcot + ") values(" + danhsachthamso + ")";
                    ketnoi.Load_Data(Select);
                    return true;
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
        public static bool ThemQuanLy(string TenDangNhap)
        {
            if (ThaoTac.KTTonTai("KhachHang", "TenDangNhap", TenDangNhap))
            {
                MessageBox.Show("Tài khoản không tồn tại", "Lỗi", MessageBoxButtons.OK);
                return false;
            }
            else
                try
                {
                    KetNoi ketnoi = new KetNoi();
                    string Update = "Update KhachHang set QuanLy = True Where KhachHang.TenDangNhap = \"" + TenDangNhap + "\"";
                    ketnoi.Load_Data(Update);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
        }
    }
}
