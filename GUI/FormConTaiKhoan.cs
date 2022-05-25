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
        public FormConTaiKhoan(DTONguoiDung a, string tendangnhap)
        {
            a.TenDangNhap = tendangnhap;
            InitializeComponent();
            BUSNguoiDung.GetThongTinCaNhan(a);
            txtHoTen.Text = a.HoTen;
            txtTuoi.Text = a.Tuoi + "";
            txtSDT.Text = a.SDT;
            txtSoCMND.Text = a.SoCMND;
            txtDiaChi.Text = a.DiaChi;
            txtUser.Text = a.TenDangNhap;
            txtPassword.Text = a.MatKhau;
        }
    }
}
