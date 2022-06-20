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
    public partial class FormConThemDichVu : Form
    {
        public FormConThemDichVu()
        {
            InitializeComponent();
        }
        public delegate void MyDel();
        public MyDel d { get; set; }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDoUong.Text == "")
                {
                    MessageBox.Show("vui lòng nhập lại tên đồ uống");
                    txtTenDoUong.Focus();
                }
                else
                {
                    if (txtSoLuong.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập lại số lượng");
                        txtSoLuong.Focus();
                    }
                    else
                    {
                        if (txtGiaBan.Text == "")
                        {
                            MessageBox.Show("Vui lòng nhập lại giá bán");
                            txtGiaBan.Focus();
                        }
                        else
                        {
                            if (txtGiaGoc.Text == "")
                            {
                                MessageBox.Show("Vui lòng nhập lại giá gốc");
                                txtGiaGoc.Focus();
                            }
                            else
                            {
                                string ten = txtTenDoUong.Text;
                                int sl = Convert.ToInt32(txtSoLuong.Text);
                                int giaban = Convert.ToInt32(txtGiaBan.Text);
                                int giagoc = Convert.ToInt32(txtGiaGoc.Text);
                                DTODoUong douong = new DTODoUong(ten, sl, giaban, giagoc);
                                BUSDoUong.InsertDoUong(douong);
                                MessageBox.Show("Them thanh cong");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            d();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtTenDoUong_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenDoUong.Text))
            {
                lblTen.Visible = false;
                btnThem.Enabled = true;
            }
            else
            {
                lblTen.Visible = true;
                txtTenDoUong.Focus();
                btnThem.Enabled = false;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaGoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
