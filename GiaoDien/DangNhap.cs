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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (ThaoTac.KTTonTai("KhachHang", "TenDangNhap", txtTenTK.Text)) // KT tên tài khoản
            {
                if (ThaoTac.KTMatKhau(txtTenTK.Text, txtTenMK.Text)) // KT mật khẩu
                {
                    Form1.tenTaiKhoan = txtTenTK.Text;
                    Form1.isDangNhap = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK); // sai mật khẩu hoặc tài khoản
            }
            else MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK); // sai tài khoản
        }

        private void btdangki_Click(object sender, EventArgs e)
        {
            Form f = new DangKy();
            f.ShowDialog();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = false;
        }

        private void txtTenTK_TextChanged(object sender, EventArgs e)
        {
            if (txtTenTK.Text.Length > 5 && txtTenMK.Text.Length > 5)
                btnDangNhap.Enabled = true;
        }

        private void txtTenMK_TextChanged(object sender, EventArgs e)
        {
            if (txtTenTK.Text.Length > 5 && txtTenMK.Text.Length > 5)
                btnDangNhap.Enabled = true;
        }
    }
}
