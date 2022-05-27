using Do_An_PLB03.BUS;
using Do_An_PLB03.DTO;
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
    public partial class FormConTaiKhoan : Form
    {
<<<<<<< Updated upstream
        public FormConTaiKhoan(DTONguoiDung a, string tendangnhap)
=======
        private FormChinh _formcha;

        private DTONguoiDung _user;
        public FormConTaiKhoan(DTONguoiDung user, FormChinh formcha)
>>>>>>> Stashed changes
        {
            a.TenDangNhap = tendangnhap;
            InitializeComponent();
<<<<<<< Updated upstream
            BUSNguoiDung.GetThongTinCaNhan(a);
            txtHoTen.Text = a.HoTen;
            txtTuoi.Text = a.Tuoi + "";
            txtSDT.Text = a.SDT;
            txtSoCMND.Text = a.SoCMND;
            txtDiaChi.Text = a.DiaChi;
            txtUser.Text = a.TenDangNhap;
            txtPassword.Text = a.MatKhau;
=======
            _user = user;
            txtUser.Text = _user.HoTen;
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
>>>>>>> Stashed changes
        }
    }
}
