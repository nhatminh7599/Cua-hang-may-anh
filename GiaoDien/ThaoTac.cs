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
                con.setConnect(@"C:\Users\NhatMinh\Desktop\Cua-hang-may-anh\GiaoDien" + @"\CuaHangMayAnh.mdb");
                DataSet ds = new DataSet();
                ds.Clear();
                string Select = "SELECT " + TenCot + " From " + TenBang + " k Where k." + TenCot + " = \"" + GiaTri + "\"";
                con.Open_DataAccess();
                con.adaShowData = new OleDbDataAdapter(Select, con.con);
                con.Close_Connect();
                con.adaShowData.Fill(ds);
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
        /// Kiểm tra 1 giá trị của 1 cột đã tồn tại trong hệ thống hay chưa
        /// </summary>
        /// <param name="TenBang">Tên bảng</param>
        /// <param name="TenCot">Tên cột</param>
        /// <param name="GiaTri">Giá trị kiểm tra ( int ) </param>
        /// <returns></returns>
        public static bool KTTonTai(string TenBang, string TenCot, int GiaTri)
        {
            try
            {
                con.setConnect(@"C:\Users\NhatMinh\Desktop\Cua-hang-may-anh\GiaoDien" + @"\CuaHangMayAnh.mdb");
                DataSet ds = new DataSet();
                string Select = "SELECT " + TenCot + " From " + TenBang + " k Where k." + TenCot + " = " + GiaTri;
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
                
                if (TenDangNhap.Length < 6 || MatKhau.Length < 6)
                    return false;
                else
                {
                    DataSet ds = new DataSet();
                    string Select = "SELECT MatKhau From KhachHang Where KhachHang.TenDangNhap = \"" + TenDangNhap + "\"";
                    con.Open_DataAccess();
                    con.adaShowData = new OleDbDataAdapter(Select, con.con);
                    con.adaShowData.Fill(ds);
                    string s = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    if (MatKhau == s)
                        return true;
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool KTSDT(string SDT)
        {
            if (SDT.Length == 10)
            {
                for (int i = 0; i < 10; i++)
                    if (!char.IsDigit(SDT[i]))
                    {
                        return false;
                    }
            }
            else
                return false;
            return true;
        }

        public static bool KTHoaDon(int MaHD, int MaSP)
        {
            try
            {
                DataSet ds = new DataSet();
                string Select = "SELECT MaHD From CTHoaDon k Where k.MaSP = " + MaSP + " and k.ThanhToan = No";
                con.Open_DataAccess();
                con.adaShowData = new OleDbDataAdapter(Select, con.con);
                con.adaShowData.Fill(ds);
                con.Close_Connect();
                int s = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                if (s == MaHD)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool KTThanhToan(int MaHD)
        {

            try
            {
                con.setConnect(@"C:\Users\NhatMinh\Desktop\Cua-hang-may-anh\GiaoDien" + @"\CuaHangMayAnh.mdb");
                DataSet ds = new DataSet();
                string Select = "SELECT MaKH From HoaDon Where MaHD = " + MaHD;
                con.Open_DataAccess();
                con.adaShowData = new OleDbDataAdapter(Select, con.con);
                con.adaShowData.Fill(ds);
                con.Close_Connect();
                string s = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                if (s != "")
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
