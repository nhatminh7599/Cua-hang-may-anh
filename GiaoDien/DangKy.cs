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

            }
        }

    }
}