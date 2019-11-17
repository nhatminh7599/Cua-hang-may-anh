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
        string connect = "";
        public KetNoi()
        {
            string t = Application.StartupPath;
            int i = t.LastIndexOf('\\') - 3;
            t = t.Substring(0, i) + "CuaHangMayAnh.mdb";
            string connect = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + t;
        }
        public void setConnect(string value)
        {
            this.connect = value;
        }
        /// <summary>
        /// Kết nối đến access
        /// </summary>
        /// <returns></returns>
        public bool Open_DataAccess()
        {
            try
            {
                
                con = new OleDbConnection(connect);
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
        public DataSet Load_Data(string Select, string TenBang)
        {
            string s = "Select * From " + TenBang;
            try
            {
                if (Open_DataAccess())
                {
                    com = new OleDbCommand(Select, con);
                    com.ExecuteNonQuery();
                    adaShowData = new OleDbDataAdapter(s, con);
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
                MessageBox.Show("Mã sản phẩm đã tồn tại hoặc sai kiểu dữ liệu", "Lỗi dữ liệu");
                adaShowData = new OleDbDataAdapter(s, con);
                adaShowData.Fill(dsHienThi);
                Close_Connect();
                return dsHienThi;
            }
        }
        public void Load_Data(string Select)
        {
            try
            {
                Open_DataAccess();
                adaShowData = new OleDbDataAdapter(Select, con);
                com = new OleDbCommand(Select, con);
                com.ExecuteNonQuery();
                Close_Connect();
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi");
            }
        }
    }
}
