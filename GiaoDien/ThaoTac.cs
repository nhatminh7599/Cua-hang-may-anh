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
        public static bool KTTenDangNhap(string TenDangNhap)
        {
            try
            {
                DataSet ds = new DataSet();
                string Select = "SELECT TenDangNhap From KhachHang Where KhachHang.TenDangNhap = \"" + TenDangNhap + "\"";
                ds = con.Load_Data(Select, "KhachHang");
                string s = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                if (TenDangNhap == s)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
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
        //public static bool ThemKhachHang(string TenDangNhap, string MatKhau)
        //{ 
            
        //}
    }
}
