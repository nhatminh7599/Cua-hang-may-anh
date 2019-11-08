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
    public class KetNoi
    {
        public OleDbConnection con = new OleDbConnection();
        public DataSet dsHienThi = new DataSet();
        public OleDbDataAdapter adaShowData;
        public OleDbCommand com;

        /// <summary>
        /// Kết nối đến access
        /// </summary>
        /// <returns></returns>
        public bool Open_DataAccess()
        {
            try
            {
                string s = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\NhatMinh\Desktop\Cua-hang-may-anh\GiaoDien\CuaHangMayAnh.mdb";
                con = new OleDbConnection(s);
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Đóng kết nối
        /// </summary>
        public void Close_Connect()
        {
            con.Close();
        }

        /// <summary>
        /// Truyền vào câu lệnh query và tên bảng
        /// </summary>
        /// <param name="Select"></param>
        /// <param name="TenBang"></param>
        /// <returns>Trả về bảng chứa dữ liệu sau khi thực thi câu lệnh query
        /// Trả về bảng rỗng nếu xảy ra lỗi</returns>
        public DataSet Load_Data(string Select)
        {
            try
            {
                string s = Select;
                if (Open_DataAccess())
                {
                    adaShowData = new OleDbDataAdapter(Select, con);
                    adaShowData.Fill(dsHienThi);
                    Close_Connect();
                    return dsHienThi;
                }
                else
                {
                    dsHienThi.Clear();
                    return dsHienThi;
                }
            }
            catch (Exception)
            {
                dsHienThi.Clear();
                return dsHienThi;
            }
        }

        /// <summary>
        /// Nhận vào câu lênh query, thao tác lên CSDL
        /// </summary>
        /// <param name="Select"></param>
        /// <returns></returns>
        public bool Add_Data(string Select)
        {
            try
            {
                string s = Select;
                if (Open_DataAccess())
                {
                    com = new OleDbCommand(Select, con);
                    com.ExecuteNonQuery();
                    Close_Connect();
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
