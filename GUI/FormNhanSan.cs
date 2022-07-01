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
        public FormNhanSan(DTONguoiDung user)
        {
            InitializeComponent();
            _user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMaDatSan.Text != "")
            {
                MaDonHang = int.Parse(txtMaDatSan.Text);
                if (BUSDanhSachDatSan.TimKiem(MaDonHang) == true)
                {
                    txtHoTen.Text = BUSDanhSachDatSan.HoTen;
                    txtSDT.Text = BUSDanhSachDatSan.SDTKhachHang;
                    txtTenSan.Text = BUSDanhSachDatSan.TenSan;
                    txtLoaiSan.Text = BUSDanhSachDatSan.LoaiSan;
                    txtNgayNhan.Text = BUSDanhSachDatSan.NgayNhan;
                    txtNgayTra.Text = BUSDanhSachDatSan.NgayTra;
                    txtGia.Text = (BUSDanhSachDatSan.Gia).ToString();
                    button3.Enabled = true;
                }
                else
                {
                    MessageBox.Show("không tìm thấy sân");
                    button3.Enabled = false;
                }
            }
        }

        public bool KiemTra(string TenSan)
        {
            foreach (DataRow data in BUSDanhSachDatSan.danhsachdangda().Rows)
            {
                if (data["TenSan"].ToString() == TenSan)
                {
                    return true;
                }
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtMaDatSan.Text != "")
            {
                int MaDonHang = int.Parse(txtMaDatSan.Text);
                if (Convert.ToDateTime(txtNgayNhan.Text) > DateTime.Now.AddMinutes(15))
                {
                    MessageBox.Show("Chưa tới giờ nhận sân");
                }
                else if (KiemTra(BUSDonHang.GetTenSan(MaDonHang)))
                {
                    MessageBox.Show("Sân đang được sử dụng");
                }
                else
                {
                    if (MessageBox.Show(" Bạn có chắc muốn nhận sân này", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BUSDanhSachDatSan.NhanSan(MaDonHang);
                        HoaDon.NgayGioTao = DateTime.Now;
                        HoaDon.MaDonHang = MaDonHang;
                        HoaDon.MaNguoiDung = _user.MaNguoiDung;
                        HoaDon.TongTien = BUSDonHang.GetTongTien(MaDonHang);
                        HoaDon.TrangThai = 0;
                        BUSHoaDon.HoaDon(HoaDon);
                        dataGridView1.DataSource = BUSDanhSachDatSan.danhsachnhansan();
                    }
                }
            }
        }
        private void FormNhanSan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSDanhSachDatSan.danhsachnhansan();
        }
    }
}
