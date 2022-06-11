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
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Họ tên không được rỗng ");
                    txtHoTen.Focus();
                }
                else
                {
                    if (txtTuoi.Text == "")
                    {
                        MessageBox.Show("Tuổi không được rỗng");
                        txtTuoi.Focus();
                    }
                    else
                    {
                        if (txtViTri.Text == "")
                        {
                            MessageBox.Show("Vị trí không được rỗng");
                            txtTuoi.Focus();
                        }
                        else
                        {
                            if (txtDiaChi.Text == "")
                            {
                                MessageBox.Show("Địa chỉ không được rỗng");
                                txtDiaChi.Focus();
                            }
                            else
                            {
                                if (txtCMND.Text == "" || txtCMND.Text.Length != 9)
                                {
                                    MessageBox.Show("Vui lòng nhập lại CMND");
                                    txtCMND.Focus();
                                }
                                else
                                {
                                    if (txtGioiTinh.Text == "" && (txtGioiTinh.Text != "Nam" || txtGioiTinh.Text != "Nữ"))
                                    {
                                        MessageBox.Show("Vui lòng nhập lại giới tính");
                                        txtGioiTinh.Focus();
                                    }
                                    else
                                    {
                                        if (txtQuyen.Text == "")
                                        {
                                            MessageBox.Show("Vui lòng nhập lại quyền ");
                                            txtQuyen.Focus();
                                        }
                                        else
                                        {
                                            if (txtSDT.Text == "" || txtSDT.Text.Length != 10)
                                            {
                                                MessageBox.Show("Vui lòng nhập lại SDT");
                                                txtSDT.Focus();
                                            }
                                            else
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
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
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
    }
}
