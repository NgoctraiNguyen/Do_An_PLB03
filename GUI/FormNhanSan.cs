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
    public partial class FormNhanSan : Form
    {
        int MaDonHang;
        public FormNhanSan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaDonHang = int.Parse(textBox1.Text);
            BUSDanhSachDatSan.TimKiem(MaDonHang);
            txtHoTen.Text = BUSDanhSachDatSan.HoTen;
            txtSDT.Text = BUSDanhSachDatSan.SDTKhachHang;
            txtTenSan.Text = BUSDanhSachDatSan.TenSan;
            txtLoaiSan.Text = BUSDanhSachDatSan.LoaiSan;
            txtNgayNhan.Text = BUSDanhSachDatSan.NgayNhan;
            txtNgayTra.Text = BUSDanhSachDatSan.NgayTra;
            txtGia.Text = (BUSDanhSachDatSan.Gia).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BUSDanhSachDatSan.NhanSan(int.Parse(textBox1.Text));

        }
    }
}
