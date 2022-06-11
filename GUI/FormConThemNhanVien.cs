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
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập lại họ tên");
                    txtHoTen.Focus();
                }
                else
                {
                    if (txtTuoi.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập lại tuổi");
                        txtTuoi.Focus();
                    }
                    else
                    {
                        if (txtDiaChi.Text == "")
                        {
                            MessageBox.Show("Vui lòng nhập lại địa chỉ");
                            txtDiaChi.Focus();
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
                                if (txtSDT.Text == "" || txtSDT.Text.Length != 10)
                                {
                                    MessageBox.Show("Vui lòng nhập lại số điện thoại");
                                    txtSDT.Focus();
                                }
                                else
                                {
                                    if (txtCMND.Text == "" || txtCMND.Text.Length != 9)
                                    {
                                        MessageBox.Show("Vui lòng nhập lại số CMND");
                                        txtCMND.Focus();
                                    }
                                    else
                                    {
                                        if (txtViTri.Text == "")
                                        {
                                            MessageBox.Show("Vui lòng nhập lại vị trí");
                                            txtViTri.Focus();
                                        }
                                        else
                                        {
                                            if (txtQuyen.Text == "")
                                            {
                                                MessageBox.Show("Vui lòng nhập lại quyền");
                                                txtQuyen.Focus();
                                            }
                                            else
                                            {
                                                if (txtTenDangNhap.Text == "")
                                                {
                                                    MessageBox.Show("Vui lòng nhập lại tên đăng nhập");
                                                    txtTenDangNhap.Focus();
                                                }
                                                else
                                                {
                                                    if (txtMatKhau.Text == "")
                                                    {
                                                        MessageBox.Show("Vui lòng nhập lại mật khẩu");
                                                        txtMatKhau.Focus();
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
                                                        string tendangnhap = txtTenDangNhap.Text;
                                                        string matkhau = txtMatKhau.Text;
                                                        DTONguoiDung nguoidung = new DTONguoiDung(ten, tuoi, diachi, gioitinh, sdt, socmnd, vitri, quyen, tendangnhap, matkhau);
                                                        BUSNguoiDung.InsertNguoiDung(nguoidung);
                                                        MessageBox.Show("Thêm thành công");
                                                        this.Hide();
                                                    }
                                                }
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
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
