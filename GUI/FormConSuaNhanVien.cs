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
    public partial class FormConSuaNhanVien : Form
    {
        private DTONguoiDung _user;
        private int ma;
        public delegate void MyDel();
        public MyDel d { get; set; }
        public FormConSuaNhanVien(int Ma, DTONguoiDung user)
        {
            InitializeComponent();
            _user = user;
            ma = Ma;
            BUSNguoiDung.HienThiThongTinSua(Ma, user);
            txtHoTen.Text = user.HoTen;
            txtTuoi.Text = user.Tuoi.ToString();
            txtDiaChi.Text = user.DiaChi;
            txtGioiTinh.Text = user.GioiTinh;
            txtSDT.Text = user.SDT;
            txtCMND.Text = user.SoCMND;
            txtViTri.Text = user.Vitri;
            txtQuyen.Text = user.Quyen.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
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

                int ma1 = BUSNguoiDung.GetMaNguoiDung(ma);
                DTONguoiDung nguoidung = new DTONguoiDung(ma1, ten, tuoi, diachi, gioitinh, sdt, socmnd, vitri, quyen);
                BUSNguoiDung.UpdateNguoiDung(nguoidung);
                MessageBox.Show("Sửa thành công");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            d();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                int ma1 = BUSNguoiDung.GetMaNguoiDung(ma);
                DTONguoiDung nguoidung = new DTONguoiDung(ma1, "12345678");
                BUSNguoiDung.ResetMatKhau(nguoidung);
                MessageBox.Show("mật khẩu được reset lại: 12345678");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
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

        private void FormConSuaNhanVien_MouseMove(object sender, MouseEventArgs e)
        {
            if (lblHoTen.Text != "" || lblGT.Text != "" || lblDiaChi.Text != "" || lblCMND.Text != "" || lblSDT.Text != "" || lblQuyen.Text != "" || lblTuoi.Text != "" || lblViTri.Text != "")
            {
                btnSua.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
            }
        }
    }
}
