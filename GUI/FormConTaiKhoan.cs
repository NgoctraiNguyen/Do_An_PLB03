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
    public partial class FormConTaiKhoan : Form
    {
        private DTONguoiDung _user;
        public FormConTaiKhoan(DTONguoiDung user)
        {
            InitializeComponent();
            _user = user;
            txtHoTen.Text = _user.HoTen;
            txtTuoi.Text = Convert.ToString(_user.Tuoi);
            txtSDT.Text = Convert.ToString(_user.SDT);
            txtDiaChi.Text = _user.DiaChi;
            txtTenDangNhap.Text = _user.TenDangNhap;
            txtMatKhau.Text = _user.MatKhau;
            txtCCCD.Text = _user.SoCMND;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if(dl == DialogResult.Yes) { 
                
            }
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtHoTen.Text;
                int tuoi = Convert.ToInt32(txtTuoi.Text);
                string sdt = txtSDT.Text;
                string socmnd = txtCCCD.Text;
                string diachi = txtDiaChi.Text;
                string tendangnhap = txtTenDangNhap.Text;
                string matkhau = txtMatKhau.Text;
                DTONguoiDung luu = new DTONguoiDung(ten, tuoi, diachi, sdt, socmnd, tendangnhap, matkhau);
                BUSNguoiDung.LuuThongTinCaNhan(luu);
                MessageBox.Show("Lưu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
