﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            txtTen.Text = Form1.tenTaiKhoan;

        }
    }
}
