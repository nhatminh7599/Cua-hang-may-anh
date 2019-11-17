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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public static bool isQuanLy = false;
        private void btDK_Click(object sender, EventArgs e)
        {
            if (ThaoTac.KTTonTai("KhachHang", "TenDangNhap", txtTK.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại.", "Lỗi!", MessageBoxButtons.OK);
            }
            else
            {
                string sdt = txtSDT.Text;
                bool isSDT = true;
                if (sdt.Length == 10)
                {
                    for (int i = 0; i < 10; i++)
                        if (!char.IsDigit(sdt[i]))
                        {
                            isSDT = false;
                            break;
                        }
                }
                else
                    isSDT = false;
                if (isSDT)
                {
                    //bool isQuanLy = chbQuanLy.Checked;
                    KhachHang KH = new KhachHang(txtTK.Text, txtMK.Text, txtTen.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, isQuanLy);
                    if (!isQuanLy)
                        if (KH.ThemKhachHang())
                        {
                            MessageBox.Show("Đăng ký thành công", "Thông báo");
                            this.Close();
                        }
                        else MessageBox.Show("Đăng ký thất bại", "Thông báo");
                    else
                    {
                        if (KH.ThemQuanLy())
                        {
                            MessageBox.Show("Đăng ký thành công", "Thông báo");
                            this.Close();
                        }
                        else MessageBox.Show("Đăng ký thất bại", "Thông báo");
                    }
                }
                else
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMK.Text.Length > 5 && txtTK.Text.Length > 5)
                btDK.Enabled = true;
            else btDK.Enabled = false;
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            if (txtMK.Text.Length > 5 && txtTK.Text.Length > 5)
                btDK.Enabled = true;
            else btDK.Enabled = false;
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            if (isQuanLy)
            {
                chbQuanLy.Visible = true;
                chbQuanLy.Checked = true;
            }
            else
            {
                chbQuanLy.Visible = false;
                chbQuanLy.Checked = false;
            }
        }

        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            chbQuanLy.Visible = false;
            chbQuanLy.Checked = false;
        }
    }
}