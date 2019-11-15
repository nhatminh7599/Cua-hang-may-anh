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

        KetNoi ketnoi = new KetNoi();
        DataSet ds = new DataSet();

        private void GioHang_Load(object sender, EventArgs e)
        {
            string select = "SELECT DsSP.MaSP, DsSP.TenSP, CTHoaDon.SoLuong, CTHoaDon.Gia FROM DsSP INNER JOIN CTHoaDon ON DsSP.MaSP = CTHoaDon.MaSP Where CTHoaDon.MaHD = " + Form1.maHoaDon + " and ThanhToan = No";
            ketnoi.Open_DataAccess();
            ketnoi.adaShowData = new OleDbDataAdapter(select, ketnoi.con);
            ketnoi.adaShowData.Fill(ds);
            ketnoi.Close_Connect();
            dataGridView1.DataSource = ds.Tables[0];
            int tam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                tam += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            txtTongTien.Text = tam.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialodResult = MessageBox.Show("Bạn có chắc muốn xóa????", "Some title", MessageBoxButtons.YesNo);
            if (dialodResult == DialogResult.Yes)
            {
                try
                {
                    //ketnoi.Open_DataAccess();
                    //ketnoi.adaShowData = new OleDbDataAdapter("Select MaSP From CTHoaDon WHERE MaHD = " + Form1.maHoaDon, ketnoi.con);
                    
                    //string accINSET = "DELETE FROM CTHoaDon WHERE MaSP = " + ma + "";
                    //ds.Clear();
                    //ds = ketnoi.Load_Data(accINSET, "CTHoaDon");
                    //dataGridView1.DataSource = ds.Tables[0];
                    //MessageBox.Show("Đã xóa sản phẩm " + ma);
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
                ds.Clear();
                ds = ketnoi.Load_Data("select * from CTHoaDon", "CTHoaDon");
                ketnoi.Open_DataAccess();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string ma = ds.Tables[0].Rows[1].ItemArray[i].ToString();
                    ketnoi.adaShowData = new OleDbDataAdapter("SELECT SoLuong FROM DsSP WHERE DsSP.MaSP = " + ma, ketnoi.con);
                    DataSet tam = new DataSet();
                    ketnoi.adaShowData.Fill(tam);
                    string sl = tam.Tables[0].Rows[0].ItemArray[0].ToString();
                    int s = (int.Parse(sl) - int.Parse(ds.Tables[0].Rows[i].ItemArray[1].ToString()));
                    string UpdateDsSP = "UPDATE DsSP SET SoLuong = "  + s + " Where DsSP.MaSP = " + ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    ketnoi.Load_Data(UpdateDsSP);
                }
                string UpdateCTHoaDon = "UPDATE CTHoaDon SET ThanhToan = Yes Where MaHD = " + Form1.maHoaDon;
                ketnoi.Load_Data(UpdateCTHoaDon);
                ketnoi.Close_Connect();
                ds.Clear();
                Form1.maHoaDon++;
                MessageBox.Show("Thanh toán thành công!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            } 
        }

        
    }
}
