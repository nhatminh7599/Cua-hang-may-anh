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

        private void btDK_Click(object sender, EventArgs e)
        {
            if (ThaoTac.KTTenDangNhap(txtTK.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại.", "Lỗi!", MessageBoxButtons.OK);
            }
            else
            {
                if (ThaoTac.ThemKhachHang(txtTK.Text, txtMK.Text, txtTen.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text))
                    MessageBox.Show("true", "true");
                else MessageBox.Show("false", "false");
            }
        }

    }
}