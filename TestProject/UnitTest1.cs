using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GiaoDien;
using System.Data.OleDb;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Xml;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private KetNoi ketnoi;
        private string connect;
        [TestInitialize]
        public void SetUp()
        {
            ketnoi = new KetNoi();
            connect = @"C:\Users\NhatMinh\Desktop\Cua-hang-may-anh\GiaoDien" + @"\CuaHangMayAnh.mdb";
            ketnoi.setConnect(connect);
        }
        [TestMethod]
        public void TestOpenAccess()
        {
            Assert.IsTrue(ketnoi.Open_DataAccess());
        }

        [TestMethod]
        public void TestDataSet_LoadData()
        {
            DataSet ds = new DataSet();
            DataSet testds = new DataSet();
            ketnoi.Open_DataAccess();
            ketnoi.adaShowData = new OleDbDataAdapter("Select MaKH from KhachHang", ketnoi.con);
            ketnoi.adaShowData.Fill(ds);
            ketnoi.Close_Connect();
            testds = ketnoi.Load_Data("Select MaKH from KhachHang", "KhachHang");
            string[] expect = new string[ds.Tables[0].Rows.Count];
            string[] actual = new string[testds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string s = ds.Tables[0].Rows[i][0].ToString();
                expect[i] = s;
                string r = testds.Tables[0].Rows[i][0].ToString();
                actual[i] = r;
            }
            Assert.Equals(expect, actual);
        }
    }
}
