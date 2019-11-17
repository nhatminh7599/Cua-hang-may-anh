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
        private string connect= @"C:\Users\NhatMinh\Desktop\Cua-hang-may-anh\GiaoDien" + @"\CuaHangMayAnh.mdb";
        [TestInitialize]
        public void SetUp()
        {
            ketnoi = new KetNoi();
            ketnoi.setConnect(connect);
        }

        //Test class KetNoi
        //[TestMethod]
        //public void TestOpenAccess()
        //{
        //    Assert.IsTrue(ketnoi.Open_DataAccess());
        //}

        //[TestMethod]
        //public void TestDataSet_LoadData()
        //{
        //    DataSet ds = new DataSet();
        //    DataSet testds = new DataSet();
        //    ketnoi.Open_DataAccess();
        //    ketnoi.adaShowData = new OleDbDataAdapter("Select MaKH from KhachHang", ketnoi.con);
        //    ketnoi.adaShowData.Fill(ds);
        //    ketnoi.Close_Connect();
        //    testds = ketnoi.Load_Data("Select MaKH from KhachHang", "KhachHang");
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        string s = ds.Tables[0].Rows[i][0].ToString();
        //        string r = testds.Tables[0].Rows[i][0].ToString();
        //        Assert.AreEqual(s, r);
        //    }
        //}

        ////Test class KhachHang
        //[TestMethod]
        //public void TestThemKhachHangRong()
        //{
        //    KhachHang KH = new KhachHang();
        //    Assert.IsFalse(KH.ThemKhachHang());
        //}

        //[TestMethod]
        //public void TestThemKhachHangDaTonTai()
        //{
        //    KhachHang KH = new KhachHang("minh123", "minh123", "", "", "1231231231", "", true);
        //    Assert.IsFalse(KH.ThemKhachHang());
        //}

        //[TestMethod]
        //public void TestThemKhachHang()
        //{
        //    KhachHang KH = new KhachHang("minh1234", "minh1234", "", "", "1231231231", "", true);
        //    Assert.IsTrue(KH.ThemKhachHang());
        //}

        //[TestMethod]
        //public void TestThemQuanLyDaTonTai()
        //{
        //    KhachHang KH = new KhachHang("minh123", "minh123", "", "", "1231231231", "", true);
        //    Assert.IsFalse(KH.ThemQuanLy());
        //}

        //[TestMethod]
        //public void TestThemQuanLy()
        //{
        //    KhachHang KH = new KhachHang("minh12345", "minh12345", "", "", "1231231231", "", true);
        //    Assert.IsTrue(KH.ThemQuanLy());
        //}

        //[TestMethod]
        //public void TestCapNhatQuanLy()
        //{
        //    Assert.IsTrue(KhachHang.ThemQuanLy("admin1", "admin1"));
        //}

        //[TestMethod]
        //public void TestCapNhatQuanLyKhongTonTai()
        //{
        //    Assert.IsFalse(KhachHang.ThemQuanLy("minh1234567", "minh1234567"));
        //}

        //Test class san pham
        //[TestMethod]
        //public void TestThemSanPhamThieuThongTin()
        //{
        //    SanPham sp = new SanPham();
        //    Assert.IsFalse(sp.ThemSanPham());
        //}

        //[TestMethod]
        //public void TestThemSanPhamDaTonTai()
        //{
        //    SanPham sp = new SanPham(1, "e", 11, 11, "");
        //    Assert.IsFalse(sp.ThemSanPham());
        //}

        //[TestMethod]
        //public void TestThemSanPham()
        //{
        //    SanPham sp = new SanPham(7, "e", 11, 11, "");
        //    Assert.IsTrue(sp.ThemSanPham());
        //}

        //[TestMethod]
        //public void TestSuaSanPhamKhongTonTai()
        //{
        //    SanPham sp = new SanPham(100, "dd", 11, 11, "");
        //    Assert.IsFalse(sp.SuaSanPham());
        //}

        //[TestMethod]
        //public void TestSuaSanPham()
        //{
        //    SanPham sp = new SanPham(1, "asd", 123, 200, "");
        //    Assert.IsTrue(sp.SuaSanPham());
        //}

        //[TestMethod]
        //public void TestXoaSanPhamKhongTonTai()
        //{
        //    SanPham sp = new SanPham(100, "dd", 11, 11, "");
        //    Assert.IsFalse(sp.XoaSanPham());
        //}

        //[TestMethod]
        //public void TestXoaSanPham()
        //{
        //    SanPham sp = new SanPham();
        //    sp.ma = 20;
        //    Assert.IsTrue(sp.XoaSanPham());
        //}

        //Test class thao tac

    }
}
