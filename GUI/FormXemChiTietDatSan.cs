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
            try
            {
                txtctTenKhachHang.Text = name;
                txtctTenSan.Text = TenSan;
                txtctNgayNhan.Text = NgayNhan.ToString();
                txtctNgayTra.Text = NgayTra.ToString();
                txtctSDT.Text = SDTKhachHang;
                txtctMaDonHang.Text = MaDonHang;
                txtctMaTrangThai.Text = MaTrangThaiSan;
                txtctTenLoaiSan.Text = LoaiSan;
            }
            catch { }
  
           
        }


        private void btnctDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public delegate void load();
        public load l { get; set; }
        

        private void btnHuySan_Click(object sender, EventArgs e)
        {
            try
            {
               if( MessageBox.Show(" Bạn có chắc muốn xóa đơn hàng","Thong Bao" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    BUSTrangThaiSan.deletetrangthai(int.Parse(txtctMaTrangThai.Text));
                    BUSDonHang.deletedonhang(int.Parse(txtctMaDonHang.Text));
                    l();

                }
            }
            catch { };
        }
    }
}
