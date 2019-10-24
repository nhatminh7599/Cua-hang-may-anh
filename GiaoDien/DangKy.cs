﻿using System;
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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        OleDbConnection strcon = new OleDbConnection();
        public void Open_DataAccess()
        {
            string s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "CuaHangMayAnh.mdb";
            strcon.ConnectionString = s;
            strcon.Open();
        }
        public void Close_Connect()
        {
            strcon.Close();
        }
        public DataSet Load_Data()
        {

            DataSet dsHienThi = new DataSet();
            string s = "select * from KhachHang";
            Open_DataAccess();
            OleDbDataAdapter daShowData = new OleDbDataAdapter(s, strcon);
            daShowData.Fill(dsHienThi, "DL_MatHang");
            Close_Connect();
            return dsHienThi;

        }
        private void DangKy_Load(object sender, EventArgs e)
        {
        }
    }
}