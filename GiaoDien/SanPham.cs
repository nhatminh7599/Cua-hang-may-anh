using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiaoDien
{
    class SanPham
    {
        public int ma;
        public string ten;
        public int soluong;
        public double dongia;
        public string mota;

        public SanPham()
        {
            ten = mota = "";
            ma = soluong = 0;
            dongia = 0;
        }
        public SanPham(int ma, string ten, int soluong, double dongia, string mota)
        {
            this.ma = ma;
            this.ten = ten;
            this.soluong = soluong;
            this.dongia = dongia;
            this.mota = mota;
        }
    }
}
