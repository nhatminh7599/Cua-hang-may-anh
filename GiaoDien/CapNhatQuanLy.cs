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
    public partial class CapNhatQuanLy : Form
    {
        public CapNhatQuanLy()
        {
            InitializeComponent();
        }

        KetNoi ketnoi = new KetNoi();
        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (KhachHang.ThemQuanLy(txtTK.Text, txtMK.Text))
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            else MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
        }
    }
}
