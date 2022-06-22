using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_PLB03.BUS;

namespace Do_An_PLB03.GUI
{
    public partial class FormXemChiTietDatSan : Form
    {
      
        public FormXemChiTietDatSan( string TenSan, string name, string NgayNhan,string NgayTra, string SDTKhachHang, string MaDonHang, string MaTrangThaiSan, string LoaiSan)
        {
            InitializeComponent();
            
            txtctTenKhachHang.Text = name;
            txtctTenSan.Text = TenSan;
            txtctNgayNhan.Text = NgayNhan.ToString();
            txtctNgayTra.Text = NgayTra.ToString();
            txtctSDT.Text = SDTKhachHang;
            txtctMaDonHang.Text= MaDonHang;
            txtctMaTrangThai.Text= MaTrangThaiSan;
            txtctTenLoaiSan.Text= LoaiSan;  
           
        }


        private void btnctDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnHuySan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(" Bạn có chắc muốn xóa đơn hàng");
                BUSTrangThaiSan.deletetrangthai(int.Parse(txtctMaTrangThai.Text));
                BUSDonHang.deletedonhang(int.Parse(txtctMaDonHang.Text));
            }
            catch { };
        }
    }
}
