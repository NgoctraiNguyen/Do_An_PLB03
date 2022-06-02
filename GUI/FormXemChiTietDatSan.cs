using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_PLB03.GUI
{
    public partial class FormXemChiTietDatSan : Form
    {
      
        public FormXemChiTietDatSan( string TenSan, string name, string NgayNhan,string NgayTra, string SDTKhachHang, string MaDonHang, string MaTrangThaiSan, string LoaiSan)
        {
            InitializeComponent();
            
            txtctTenKhachHang.Text = name;
            txtctTenSan.Text = TenSan;
            txtctNgayNhan.Text = NgayNhan.Substring(0, 5);
            txtctNgayTra.Text = NgayTra.Substring(0, 5);
            txtctSDT.Text = SDTKhachHang;
            txtctMaDonHang.Text= MaDonHang;
            txtctMaTrangThai.Text= MaTrangThaiSan;
            txtctTenLoaiSan.Text= LoaiSan;  
            //txtctSoGio.Text= (int.Parse(NgayTra.Substring(0,2))-int.Parse(NgayNhan.Substring(0,2))).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnctDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void FormXemChiTietDatSan_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
