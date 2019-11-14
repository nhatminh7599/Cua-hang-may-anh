using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiaoDien
{
    class KhachHang
    {
        protected int maKhachHang;
        protected string tenDangNhap;
        protected string matKhau;
        protected string ten;
        protected string diaChi;
        protected string sDT;
        protected string email;
        protected bool chucVu;

        public KhachHang()
        {
            this.tenDangNhap = this.matKhau = this.ten = this.diaChi = this.sDT = this.email = "";
            this.chucVu = false;
        }
        public KhachHang(int maKhachHang, string TenDangNhap, string MatKhau, string Ten, string DiaChi, string SDT, string Email, bool ChucVu)
        {
            this.maKhachHang = maKhachHang;
            this.tenDangNhap = TenDangNhap;
            this.matKhau = MatKhau;
            this.ten = Ten;
            this.diaChi = DiaChi;
            this.sDT = SDT;
            this.email = Email;
            this.chucVu = ChucVu;
        }

        public string TenDangNhap() { return this.tenDangNhap; }
        public void TenDangNhap(string value) { this.tenDangNhap = value; }
        public string MatKhau() { return this.matKhau; }
        public void MatKhau(string value) { this.matKhau = value; }
        public string Ten() { return this.ten; }
        public void Ten(string value) { this.ten = value; }
        public string DiaChi() { return this.diaChi; }
        public void DiaChi(string value) { this.diaChi = value; }
        public string SDT() { return this.sDT; }
        public void SDT(string value) { this.sDT = value; }
        public string Email() { return this.email; }
        public void Email(string value) { this.email = value; }
        public bool ChucVu() { return this.chucVu; }
        public void TenDangNhap(bool value) { this.chucVu = value; }
    }
}
