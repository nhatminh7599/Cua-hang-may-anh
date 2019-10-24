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
        OleDbConnection strcon = new OleDbConnection();
        public void Open_DataAccess()
        {
            string s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\CuaHangMayAnh.mdb";
            strcon.ConnectionString = s;
            strcon.Open();
        }
        public void Close_Connect()
        {
            strcon.Close();
        }
        public DataSet Load_Data(string Select, string TenBang)
        {
            DataSet dsHienThi = new DataSet();
            string s = Select;
            Open_DataAccess();
            OleDbDataAdapter daShowData = new OleDbDataAdapter(Select, strcon);
            daShowData.Fill(dsHienThi, TenBang);
            Close_Connect();
            return dsHienThi;
        }
    }
}
