using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            txtUser.Text = _user.HoTen;
            txtTuoi.Text = Convert.ToString(_user.Tuoi);
            txtSDT.Text = Convert.ToString(_user.SDT);
            txtDiaChi.Text = _user.DiaChi;
            txtTenDangNhap.Text = _user.TenDangNhap;
            txtMatKhau.Text = _user.MatKhau;
            txtCCCD.Text = _user.SoCMND;
        }
    }
}
