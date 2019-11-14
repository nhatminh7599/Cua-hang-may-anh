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

        public void hienthi(DataGridView dg, string TenBang)
        {
            try
            {
                ds = ketnoi.Load_Data("SELECT * FROM " + TenBang, "DsSP");
                dg.DataSource = ds.Tables[0];
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
            catch (Exception)
            {
                MessageBox.Show("Lỗi dữ liệu", "Lỗi");
            }
        }
        private void Danhsachsanpham_Load(object sender, EventArgs e)
        {
            hienthi(dtvsp, "DsSp");
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ThaoTac.KTTonTai("DsSP", "MaSP", txtMaSP.Text))
                    MessageBox.Show("Mã hóa đơn đã tồn tại!!!!");
                else
                {
                    string danhsachcot = "MaSP, TenSP, SoLuong, Gia, MoTa";
                    string danhsachthamso = ("\"" + txtMaSP.Text + "\"" + ", " +
                                        "\"" + txtTenSP.Text + "\"" + ", " +
                                        "\"" + txtSoLuong.Text + "\"" + ", " +
                                         "\"" + txtGia.Text + "\"" + ", " +
                                         "\"" + txtMoTa.Text + "\"");
                    string accINSET = "INSERT INTO DsSP (" + danhsachcot + ") values (" + danhsachthamso + ")";
                    ds.Clear();
                    ds = ketnoi.Load_Data(accINSET, "DsSP");
                    dtvsp.DataSource = ds.Tables[0];
                    txtMaSP.Clear();
                    txtTenSP.Clear();
                    txtSoLuong.Clear();
                    txtGia.Clear();
                    txtMoTa.Clear();
                    btThem.Enabled = false;
                }
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
                    string ma = dtvsp.CurrentRow.Cells[0].Value.ToString();
                    if (ma == "")
                        ma = txtMaSP.Text;
                    ds.Clear();
                    ketnoi.Open_DataAccess();
                    string accINSET = "DELETE FROM DsSP WHERE MaSP = " + ma + "";
                    OleDbCommand cmd = new OleDbCommand(accINSET, ketnoi.con);
                    cmd.ExecuteNonQuery();
                    ketnoi.Close_Connect();
                    hienthi(dtvsp, "DsSP");
                    //ds.Clear();
                    //ds = ketnoi.Load_Data("SELECT * FROM DsSP", "DsSP");
                    //dtvsp.DataSource = ds.Tables[0];
                    MessageBox.Show("Đã xóa sản phẩm " + ma);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại!!!!!" + ex.Message);
                }
            }
        }

        private void dtvsp_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string accINSET = "UPDATE DsSP SET TenSP = \""
                                   + txtTenSP.Text + "\" ,Soluong = " + txtSoLuong.Text + ", Gia = "
                                   + txtGia.Text + ", MoTa = \"" + txtMoTa.Text + "\" WHERE DsSP.MaSP = " + txtMaSP.Text;
                ds.Clear();
                ds = ketnoi.Load_Data(accINSET, "DsSP");
                dtvsp.DataSource = ds.Tables[0];
                txtMaSP.Clear();
                txtTenSP.Clear();
                txtSoLuong.Clear();
                txtGia.Clear();
                txtMoTa.Clear();
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
            else
            {
                txtMaSP.Clear();
                txtTenSP.Clear();
                txtSoLuong.Clear();
                txtGia.Clear();
                txtMoTa.Clear();
            }
        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {
            ds.Clear();
            hienthi(dtvsp, "DsSp");
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

    }
}
