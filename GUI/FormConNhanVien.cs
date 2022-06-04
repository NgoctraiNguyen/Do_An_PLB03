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
    public partial class FormConNhanVien : Form
    {
        public FormConNhanVien()
        {
            InitializeComponent();
            GUI();
        }

        public void GUI()
        {
            dataGridView1.DataSource = BUSNguoiDung.GetAllNguoiDung();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtHoTen.Text;
                int tuoi = Convert.ToInt32(txtTuoi.Text);
                string diachi = txtDiaChi.Text;
                int gioitinh = Convert.ToInt32(txtGioiTinh.Text);
                string sdt = txtSDT.Text;
                string socmnd = txtCMND.Text;
                string vitri = txtViTri.Text;
                int quyen = Convert.ToInt32(txtQuyen.Text);
                string tendangnhap = txtTenDangNhap.Text;
                string matkhau = txtMatKhau.Text;
                DTONguoiDung nguoidung = new DTONguoiDung(ten, tuoi, diachi, gioitinh, sdt, socmnd, vitri, quyen, tendangnhap, matkhau);
                BUSNguoiDung.InsertNguoiDung(nguoidung);
                MessageBox.Show("Thêm thành công");
                dataGridView1.DataSource = BUSNguoiDung.GetAllNguoiDung();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static int gioitinh = 0;
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedCells[0].OwningRow;
            try
            {
                string ma1 = row.Cells["MaNguoiDung"].Value.ToString();
                int ma = Convert.ToInt32(ma1);
                string ten = txtHoTen.Text;
                int tuoi = Convert.ToInt32(txtTuoi.Text);
                string diachi = txtDiaChi.Text;
                
                if (txtGioiTinh.Text == "Nam")
                {
                    gioitinh = 1;
                }if(txtGioiTinh.Text == "Nữ")
                {
                    gioitinh = 0;
                }
                string sdt = txtSDT.Text;
                string socmnd = txtCMND.Text;
                string vitri = txtViTri.Text;
                int quyen = Convert.ToInt32(txtQuyen.Text);
                string tendangnhap = txtTenDangNhap.Text;
                string matkhau = txtMatKhau.Text;
                
                DTONguoiDung nguoidung = new DTONguoiDung(ma, ten, tuoi, diachi, gioitinh, sdt, socmnd, vitri, quyen, tendangnhap, matkhau);
                BUSNguoiDung.UpdateNguoiDung(nguoidung);
                MessageBox.Show("Sửa thành công");
                dataGridView1.DataSource = BUSNguoiDung.GetAllNguoiDung();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedCells[0].OwningRow;
            try
            {
                int ma = Convert.ToInt32(row.Cells["MaNguoiDung"].Value.ToString());
                BUSNguoiDung.DeleteNguoiDung(ma);
                MessageBox.Show("Xóa thành công");
                dataGridView1.DataSource = BUSNguoiDung.GetAllNguoiDung();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtTuoi.Text = row.Cells[2].Value.ToString();
                if (row.Cells[4].Value.ToString() == "1")
                {
                    txtGioiTinh.Text = "Nam";
                }
                else if(row.Cells[4].Value.ToString() == "0")
                {
                    txtGioiTinh.Text = "Nữ";
                }
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
                txtCMND.Text = row.Cells[6].Value.ToString();
                txtViTri.Text = row.Cells[7].Value.ToString();
                txtQuyen.Text = row.Cells[8].Value.ToString();
                txtTenDangNhap.Text = row.Cells[9].Value.ToString();
                txtMatKhau.Text = row.Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 0)
            {
                string rowFilter = string.Format("{0} like '{1}'", "HoTen", "*" + txtUser.Text + "*");
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            
            else if (cboTimKiem.SelectedIndex == 1)
            {
                string rowFilter = string.Format("{0} like '{1}'", "SDT", "*" + txtUser.Text + "*");
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            else if (cboTimKiem.SelectedIndex == 2)
            {
                string rowFilter = string.Format("{0} like '{1}'", "SoCMND", "*" + txtUser.Text + "*");
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            else if (cboTimKiem.SelectedIndex == 3)
            {
                string rowFilter = string.Format("{0} like '{1}'", "ViTri", "*" + txtUser.Text + "*");
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }
    }
}
