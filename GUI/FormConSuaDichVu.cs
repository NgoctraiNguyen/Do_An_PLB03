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
    public partial class FormConSuaDichVu : Form
    {
        private DTODoUong _d;
        private int Ma;
        public delegate void MyDel();
        public MyDel d { get; set; }
        public FormConSuaDichVu(int ma, DTODoUong d)
        {
            InitializeComponent();
            _d = d;
            Ma = ma;
            BUSDoUong.HienThiThongTinSua(ma, d);
            txtTenDoUong.Text = d.TenDoUong;
            txtSoLuong.Text = d.SoLuong.ToString();
            txtGiaBan.Text = d.GiaBan.ToString();
            txtGiaGoc.Text = d.GiaGoc.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                string ten = txtTenDoUong.Text;
                int sl = Convert.ToInt32(txtSoLuong.Text);
                int giaban = Convert.ToInt32(txtGiaBan.Text);
                int giagoc = Convert.ToInt32(txtGiaGoc.Text);
                DTODoUong douong = new DTODoUong(Ma, ten, sl, giaban, giagoc);
                BUSDoUong.UpdateDoUong(douong);
                MessageBox.Show("Sua thanh cong");
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
                btnSua.Enabled = true;
            }
            else
            {
                lblTen.Visible = true;
                txtTenDoUong.Focus();
                btnSua.Enabled = false;
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
