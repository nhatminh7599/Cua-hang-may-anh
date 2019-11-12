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
        DataSet ds;
        string temp = "";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void Danhsachsanpham_Load(object sender, EventArgs e)
        {
            hienthi(dtvsp, "DsSp");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi dữ liệu");
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
                    ketnoi.Open_DataAccess();
                    string accINSET = "DELETE FROM DsSP WHERE MaSP = " + ma + "";
                    OleDbCommand cmd = new OleDbCommand(accINSET, ketnoi.con);
                    cmd.ExecuteNonQuery();
                    ketnoi.Close_Connect();
                    ds.Clear();
                    ds = ketnoi.Load_Data("SELECT * FROM DsSP", "DsSP");
                    dtvsp.DataSource = ds.Tables[0];
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
            txtMaSP.Text = temp = ma;
            txtTenSP.Text = ten;
            txtSoLuong.Text = soluong;
            txtGia.Text = gia;
            txtMoTa.Text = mota;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (temp == "")
                    temp = txtMaSP.Text;
                string accINSET = "UPDATE DsSP SET TenSP = \""
                                   + txtTenSP.Text + "\" ,Soluong = " + txtSoLuong.Text + ", Gia = "
                                   + txtGia.Text + " WHERE MaSP = " + temp;
                ds = ketnoi.Load_Data(accINSET, "DsSP");
                accINSET = "UPDATE DsSP SET MaSP = "
                                   + txtMaSP.Text + " WHERE TenSP = \"" + txtTenSP.Text + "\"";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "")
            {
                btXoa.Enabled = true;
                if (txtTenSP.Text != "" && txtSoLuong.Text != "" && txtGia.Text != "")
                    btThem.Enabled = true;
                else btThem.Enabled = false;
            }
            else
            {
                btXoa.Enabled = false;
                btThem.Enabled = false;
            }
        }

    }
}
