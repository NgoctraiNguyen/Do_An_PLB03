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
using Do_An_PLB03.DTO;

namespace Do_An_PLB03.GUI
{
    public partial class FormNhanSan : Form
    {
        private DTONguoiDung _user;
        int MaDonHang;
       DTOHoaDon HoaDon = new DTOHoaDon();
        private FormChinh _formcha;
        public FormNhanSan(DTONguoiDung user)
        {
            InitializeComponent();
            _user = user;
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
            int MaDonHang = int.Parse(textBox1.Text);
            BUSDanhSachDatSan.NhanSan(MaDonHang);
            HoaDon.NgayGioTao = DateTime.Now;
            HoaDon.MaDonHang = MaDonHang;
            HoaDon.MaNguoiDung = _user.MaNguoiDung;
            HoaDon.TongTien = BUSDonHang.GetTongTien(MaDonHang);
            HoaDon.TrangThai = 0;
            BUSHoaDon.HoaDon(HoaDon);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormNhanSan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSDanhSachDatSan.danhsachnhansan();
        }
    }
}
