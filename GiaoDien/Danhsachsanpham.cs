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
        public Danhsachsanpham()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            try
            {
                DataSet ds = ketnoi.Load_Data("SELECT * FROM DsSP");
                dtvsp.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi!!!!!", "Lỗi");
            }
        }

        private void Danhsachsanpham_Load(object sender, EventArgs e)
        {
            hienthi();
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
                    DataSet ds = ketnoi.Load_Data(accINSET);
                    ketnoi.Add_Data(accINSET);
                    ketnoi.Close_Connect();
                    hienthi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!!!! " + ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            //DialogResult dialodResult = MessageBox.Show("Bạn có chắc muốn xóa????", "Some title", MessageBoxButtons.YesNo);
            //if (dialodResult == DialogResult.Yes)
            //{
            //    try
            //    {
            //        cnn.Open();
            //        string accINSET = "DELETE FROM DsSP WHERE MaSP='" + txtMaSP.Text + "'";
            //        OleDbCommand cmd = new OleDbCommand(accINSET, cnn);
            //        cmd.ExecuteNonQuery();
            //        cnn.Close();
            //        hienthi();
            //        MessageBox.Show("Xóa hóa đơn " + txtMaSP.Text + "");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Xóa thất bại!!!!!" + ex.Message);
            //    }
            //}
        }

        private void dtvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int hang = e.RowIndex;
            //cnn.Open();
            //OleDbCommand cm = new OleDbCommand("SELECT * FROM DsSP", cnn);
            //OleDbDataAdapter ad = new OleDbDataAdapter(cm);
            //DataSet ds = new DataSet();
            //ad.Fill(ds, "DsSP");
            //cm.ExecuteNonQuery();
            //cnn.Close();
            //DataTable dt = new DataTable();
            //dt = ds.Tables[0];
            //if (hang > 0 && hang < dt.Rows.Count)
            //{
            //    txtMaSP.Text = dt.Rows[hang][0].ToString();
            //    txtTenSP.Text = dt.Rows[hang][1].ToString();
            //    txtSoLuong.Text = dt.Rows[hang][2].ToString();
            //    txtGia.Text = dt.Rows[hang][3].ToString();
            //    txtMoTa.Text = dt.Rows[hang][4].ToString();
            //}
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //cnn.Open();
            //string accINSET = "UPDATE DsSP SET tenSP= '" 
            //                   + txtTenSP.Text + "',soluong='" + txtSoLuong.Text + "',gia='" 
            //                   + txtGia.Text + "' WHERE maSP= '" + txtMaSP.Text + "'";
            //OleDbCommand cmd = new OleDbCommand(accINSET, cnn);
            //cmd.ExecuteNonQuery();
            //cnn.Close();
            //hienthi();
        }

    }
}
