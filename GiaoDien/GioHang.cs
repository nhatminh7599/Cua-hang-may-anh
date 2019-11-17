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
        public void HienThi()
        {
            ds.Clear();
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
            if(dataGridView1.Rows.Count == 0)
                btXoa.Enabled = false;
        }
        private void GioHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialodResult = MessageBox.Show("Bạn có chắc muốn xóa????", "Some title", MessageBoxButtons.YesNo);
            if (dialodResult == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView1.RowCount > 0)
                    {
                        string MaSP = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        string del = "Delete From CTHoaDon Where MaSP = " + MaSP + " and MaHD = " + Form1.maHoaDon;
                        ketnoi.Load_Data(del);
                        HienThi();
                    }
                    if (dataGridView1.Rows.Count == 0)
                        btXoa.Enabled = false;
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
                int row = ds.Tables[0].Rows.Count;
                ds.Clear();
                ketnoi.adaShowData = new OleDbDataAdapter("select MaSP from CTHoaDon Where MaHD = " + Form1.maHoaDon, ketnoi.con);
                ketnoi.adaShowData.Fill(ds);
                ketnoi.Open_DataAccess();
                for (int i = 0; i < row; i++)
                {
                    string ma = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    ketnoi.adaShowData = new OleDbDataAdapter("SELECT SoLuong FROM DsSP WHERE DsSP.MaSP = " + ma, ketnoi.con);
                    DataSet tam = new DataSet();
                    ketnoi.adaShowData.Fill(tam);
                    string sl = tam.Tables[0].Rows[0].ItemArray[0].ToString();
                    int s = (int.Parse(sl) - int.Parse(ds.Tables[0].Rows[i].ItemArray[0].ToString()));
                    string UpdateDsSP = "UPDATE DsSP SET SoLuong = "  + s + " Where DsSP.MaSP = " + ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    ketnoi.Load_Data(UpdateDsSP);
                }
                string UpdateCTHoaDon = "UPDATE CTHoaDon SET ThanhToan = Yes Where MaHD = " + Form1.maHoaDon;
                ketnoi.Load_Data(UpdateCTHoaDon);
                ketnoi.Close_Connect();
                ds.Clear();
                string v = "Select MaKH From KhachHang Where TenDangNhap = \"" + Form1.tenTaiKhoan + "\"";
                ketnoi.Open_DataAccess();
                ketnoi.adaShowData = new OleDbDataAdapter(v, ketnoi.con);
                ds = new DataSet();
                ketnoi.adaShowData.Fill(ds);
                ketnoi.Close_Connect();
                string MaKH = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                string UpdateMaKH = "Update HoaDon set MaKH =  " + MaKH + " Where MaHD = " + Form1.maHoaDon;
                ketnoi.Load_Data(UpdateMaKH);
                Form1.maHoaDon++;
                txtTongTien.Text = "0" ;
                if(!Form1.isQuanLy)
                    MessageBox.Show("Thanh toán thành công, Nhân viên sẽ liên hệ đến bạn để lấy xác nhận đơn hàng");
                else
                    MessageBox.Show("Thanh toán thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            } 
        }

        
    }
}
