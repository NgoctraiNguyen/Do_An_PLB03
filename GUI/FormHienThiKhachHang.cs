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
    public partial class FormHienThiKhachHang : Form
    {
        public FormHienThiKhachHang()
        {
            InitializeComponent();
            LoadDuLieuBang();
        }
        private void LoadDuLieuBang()
        {
            dataGridView1.DataSource = BUSDangNhap.Getallkhachhang();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTenKhachHang.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
            }
            catch
            {
            }

        }
        private void FormHienThiKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtTenKhachHang.Text;
                string sdt = txtSDT.Text;
                DTOKhachHang kh = new DTOKhachHang( ten, sdt);
                BUSKhachHang.InsertKhachHang(kh);
                MessageBox.Show("Thêm thành công");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadDuLieuBang();
            txtClear();
        }
        private void txtClear()
        {
            txtID.Text = "";
            txtTenKhachHang.Text = "";
            txtSDT.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = Convert.ToInt32(txtID.Text);
                string ten = txtTenKhachHang.Text;
                string sdt = txtSDT.Text;
                DTOKhachHang kh = new DTOKhachHang(ma, ten, sdt);
                BUSKhachHang.UpdateKhachHang(kh);
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadDuLieuBang();
            txtClear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = Convert.ToInt32(txtID.Text);
                string ten = txtTenKhachHang.Text;
                string sdt = txtSDT.Text;
                DTOKhachHang kh = new DTOKhachHang(ma, ten, sdt);
                BUSKhachHang.DeleteKhachHang(kh);
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadDuLieuBang();
            txtClear();
        }

        private void txtID_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtTenKhachHang_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                label5.Text = "Vui lòng nhập lại họ tên";
                txtTenKhachHang.Focus();

            }
            else
            {
                label5.Text = "";
            }
        }

        private void txtSDT_MouseLeave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length != 10)
            {
                label6.Text = "Vui lòng nhập lại số điện thoại";
                txtSDT.Focus();
            }
            else
            {
                label6.Text = "";
            }
        }

        private void FormHienThiKhachHang_MouseMove(object sender, MouseEventArgs e)
        {
            if(label5.Text != "" || label6.Text != "")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 0)
            {
                string rowFilter = string.Format("{0} like '{1}'", "TenKhachHang", "*" + txtUser.Text + "*");
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            else if (cboTimKiem.SelectedIndex == 1)
            {
                string rowFilter = string.Format("{0} like '{1}'", "SDTKhachHang", "*" + txtUser.Text + "*");
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }
    }
}
