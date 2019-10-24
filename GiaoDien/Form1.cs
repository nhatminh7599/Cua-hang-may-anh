using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbdangnhap_Click(object sender, EventArgs e)
        {
            Form moi = new DangNhap();
            moi.ShowDialog();
        }

    }
}
