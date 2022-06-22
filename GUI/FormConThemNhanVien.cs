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
    public partial class FormConThemNhanVien : Form
    {
        public FormConThemNhanVien()
        {
            InitializeComponent();
        }
        public delegate void MyDel();
        public MyDel d { get; set; }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string ten = txtHoTen.Text;
                int tuoi = Convert.ToInt32(txtTuoi.Text);
                string diachi = txtDiaChi.Text;
                string gioitinh = txtGioiTinh.Text;
                string sdt = txtSDT.Text;
                string socmnd = txtCMND.Text;
                string vitri = txtViTri.Text;
                int quyen = Convert.ToInt32(txtQuyen.Text);
                string tendangnhap = txtTenDangNhap.Text;
                string matkhau = txtMatKhau.Text;
                DTONguoiDung nguoidung = new DTONguoiDung(ten, tuoi, diachi, gioitinh, sdt, socmnd, vitri, quyen, tendangnhap, matkhau);
                BUSNguoiDung.InsertNguoiDung(nguoidung);
                MessageBox.Show("Thêm thành công");
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            d();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtHoTen_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                lblHoTen.Text = "Vui lòng nhập lại họ tên";
                txtHoTen.Focus();

            }
            else
            {
                lblHoTen.Text = "";
            }
        }

        private void txtTuoi_MouseLeave(object sender, EventArgs e)
        {
            int n = 0;
            if (txtTuoi.Text == "" || (int.TryParse(txtTuoi.Text, out n)) == false)

            {
                lblTuoi.Text = "Vui lòng nhập lại tuổi";
                txtTuoi.Focus();
            }
            else
            {
                lblTuoi.Text = "";
            }
        }

        private void txtViTri_MouseLeave(object sender, EventArgs e)
        {
            if (txtViTri.Text == "")
            {

                lblViTri.Text = "Vui lòng nhập lại vị trí";
                txtViTri.Focus();
            }
            else
            {
                lblViTri.Text = "";
            }
        }

        private void txtDiaChi_MouseLeave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                lblDiaChi.Text = "Vui lòng nhập lại địa chỉ";
                txtDiaChi.Focus();
            }
            else
            {
                lblDiaChi.Text = "";
            }
        }

        private void txtCMND_MouseLeave(object sender, EventArgs e)
        {
            if (txtCMND.Text.Length != 9)
            {
                lblCMND.Text = "Vui lòng nhập lại số CMND";
                txtCMND.Focus();
            }
            else
            {
                lblCMND.Text = "";
            }
        }

        private void txtGioiTinh_MouseLeave(object sender, EventArgs e)
        {
            if (txtGioiTinh.Text == "Nam" || txtGioiTinh.Text == "Nữ")
            {
                lblGT.Text = "";

            }
            else
            {
                lblGT.Text = "Vui lòng nhập lại giới tính";
                txtGioiTinh.Focus();
            }
        }

        private void txtQuyen_MouseLeave(object sender, EventArgs e)
        {
            if (txtQuyen.Text == "0" || txtQuyen.Text == "1")
            {

                lblQuyen.Text = "";
            }
            else
            {

                lblQuyen.Text = "Quyền không hợp lệ";
                txtQuyen.Focus();
            }
        }

        private void txtSDT_MouseLeave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length != 10)
            {
                lblSDT.Text = "Vui lòng nhập lại số điện thoại";
                txtSDT.Focus();
            }
            else
            {
                lblSDT.Text = "";
            }
        }

        private void txtTenDangNhap_MouseLeave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                lblTenDN.Text = "Vui lòng nhập lại tên đăng nhập";
                txtTenDangNhap.Focus();
            }
            else
            {
                lblTenDN.Text = "";
            }
        }

        private void txtMatKhau_MouseLeave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length < 8)
            {

                lblMK.Text = "Vui lòng nhập lại mật khẩu";
                txtMatKhau.Focus();
            }
            else
            {
                lblMK.Text = "";
            }
        }

        private void FormConThemNhanVien_MouseMove(object sender, MouseEventArgs e)
        {
            if (lblHoTen.Text != "" || lblGT.Text != "" || lblDiaChi.Text != "" || lblCMND.Text != "" || lblSDT.Text != "" || lblQuyen.Text != "" || lblTuoi.Text != "" || lblViTri.Text != "" || lblTenDN.Text != "" || lblMK.Text != "")
            {
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
