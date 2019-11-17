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
    public partial class Danhsachsanpham : Form
    {
        OleDbConnection cnn = new OleDbConnection();
        KetNoi ketnoi = new KetNoi();
        DataSet ds = new DataSet();
        public Danhsachsanpham()
        {
            InitializeComponent();
        }
        public void LayDuLieu()
        {
            string ma = dtvsp.CurrentRow.Cells[0].Value.ToString();
            string ten = dtvsp.CurrentRow.Cells[1].Value.ToString();
            string soluong = dtvsp.CurrentRow.Cells[2].Value.ToString();
            string gia = dtvsp.CurrentRow.Cells[3].Value.ToString();
            string mota = dtvsp.CurrentRow.Cells[4].Value.ToString();
            txtMaSP.Text = ma;
            txtTenSP.Text = ten;
            txtSoLuong.Text = soluong;
            txtGia.Text = gia;
            txtMoTa.Text = mota;
        }
        public void XoaDuLieu()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSoLuong.Clear();
            txtGia.Clear();
            txtMoTa.Clear();
        }
        public void HienThi()
        {
            try
            {
                ds = ketnoi.Load_Data("SELECT * FROM DsSP", "DsSP");
                dtvsp.DataSource = ds.Tables[0];
                LayDuLieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi dữ liệu", "Lỗi");
            }
        }
        private void Danhsachsanpham_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham(int.Parse(txtMaSP.Text), txtTenSP.Text, int.Parse(txtSoLuong.Text), double.Parse(txtGia.Text), txtMoTa.Text);
                sp.ThemSanPham();
                ds.Clear();
                ds = ketnoi.Load_Data("Select * From DsSP", "DsSP");
                dtvsp.DataSource = ds.Tables[0];
                XoaDuLieu();
                btThem.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi dữ liệu", "Lỗi");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialodResult = MessageBox.Show("Bạn có chắc muốn xóa????", "Some title", MessageBoxButtons.YesNo);
            if (dialodResult == DialogResult.Yes)
            {
                try
                {
                    SanPham sp = new SanPham(int.Parse(txtMaSP.Text), txtTenSP.Text, int.Parse(txtSoLuong.Text), double.Parse(txtGia.Text), txtMoTa.Text);
                    sp.XoaSanPham();
                    ds.Clear();
                    ds = ketnoi.Load_Data("Select * From DsSP", "DsSP");
                    dtvsp.DataSource = ds.Tables[0];
                    XoaDuLieu();
                    btThem.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi dữ liệu", "Lỗi");
                }
            }
        }

        private void dtvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LayDuLieu();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham(int.Parse(txtMaSP.Text), txtTenSP.Text, int.Parse(txtSoLuong.Text), double.Parse(txtGia.Text), txtMoTa.Text);
                sp.SuaSanPham();
                ds.Clear();
                ds = ketnoi.Load_Data("Select * From DsSP", "DsSP");
                dtvsp.DataSource = ds.Tables[0];
                XoaDuLieu();
                btThem.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi dữ liệu", "Lỗi");
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "")
            {
                btXoa.Enabled = true;
                if (txtTenSP.Text != "" && txtSoLuong.Text != "" && txtGia.Text != "")
                {
                    btThem.Enabled = true;
                    btSua.Enabled = true;
                }
                else
                {
                    btThem.Enabled = false;
                    btSua.Enabled = false;
                }
            }
            else
            {
                btXoa.Enabled = false;
                btThem.Enabled = false;
                btSua.Enabled = false;
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            ketnoi.Open_DataAccess();
            string s = "SELECT * FROM DsSP WHERE (((DsSP.TenSP) = \"" + txtTim.Text + "\"));";
            ds.Clear();
            ketnoi.com = new OleDbCommand(s, ketnoi.con);
            ketnoi.com.ExecuteNonQuery();
            ketnoi.adaShowData = new OleDbDataAdapter(s, ketnoi.con);
            ketnoi.adaShowData.Fill(ds);
            ketnoi.Close_Connect();
            dtvsp.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count > 0)
            {
                LayDuLieu();
            }
            else
            {
                XoaDuLieu();
            }
        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {
            ds.Clear();
            HienThi();
            txtTim.Text = "";
        }

        private void btThemQuanLy_Click(object sender, EventArgs e)
        {
            Form f = new DangKy();
            DangKy.isQuanLy = true;
            f.ShowDialog();
        }

        private void btCapNhatQuanLy_Click(object sender, EventArgs e)
        {
            Form f = new CapNhatQuanLy();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Danhsachdonhang();
            f.ShowDialog();
        }

    }
}
