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
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
        }

        OleDbConnection cnn = new OleDbConnection();
        KetNoi ketnoi = new KetNoi();
        DataSet ds = new DataSet();

        private void GioHang_Load(object sender, EventArgs e)
        {
            ds = ketnoi.Load_Data("SELECT * FROM CTHoaDon", "CTHoaDon");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialodResult = MessageBox.Show("Bạn có chắc muốn xóa????", "Some title", MessageBoxButtons.YesNo);
            if (dialodResult == DialogResult.Yes)
            {
                try
                {
                    string ma = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    ketnoi.Open_DataAccess();
                    string accINSET = "DELETE FROM CTHoaDon WHERE MaHD = " + ma + "";
                    ds.Clear();
                    ds = ketnoi.Load_Data(accINSET, "CTHoaDon");
                    dataGridView1.DataSource = ds.Tables[0];
                    MessageBox.Show("Đã xóa sản phẩm " + ma);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại!!!!!" + ex.Message);
                }
            }
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
           
            try
            {
                string ma = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ketnoi.Open_DataAccess();
                ketnoi.adaShowData = new OleDbDataAdapter("SELECT SoLuong FROM DsSP WHERE DsSP.MaSP = " + ma, ketnoi.con);
                DataSet tam = new DataSet();
                ketnoi.adaShowData.Fill(tam);
                string sl = tam.Tables[0].Rows[0].ItemArray[0].ToString();
                string accINSET = "UPDATE DsSP SET SoLuong = " + 
                    (int.Parse(sl) - int.Parse(ds.Tables[0].Rows[0].ItemArray[3].ToString()) + 
                    " Where DsSP.MaSP = " + ds.Tables[0].Rows[0].ItemArray[1].ToString());
                ketnoi.Close_Connect();
                ketnoi.Load_Data(accINSET);
                ds.Clear();
                MessageBox.Show("Thanh toán thành công!!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi dữ liệu", "Lỗi");
            } 
        }

        
    }
}
