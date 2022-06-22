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
        private FormChinh _formcha;
        public FormConTaiKhoan(DTONguoiDung user, FormChinh formcha)
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
            _formcha = formcha; 
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if(dl == DialogResult.Yes) {
                _formcha.Hide();
                FormDangNhap frm = new FormDangNhap();
                frm.ShowDialog();
                _formcha.Close();
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

        private void iptDisEye_MouseUp(object sender, MouseEventArgs e)
        {
            iptDisEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            txtMatKhau.PasswordChar = '*';
        }

        private void iptDisEye_MouseDown(object sender, MouseEventArgs e)
        {
            iptDisEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            txtMatKhau.PasswordChar = '\0';
        }
    }
}
