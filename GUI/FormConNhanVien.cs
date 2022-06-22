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
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          
            FormConThemNhanVien f = new FormConThemNhanVien();
            f.d += new FormConThemNhanVien.MyDel(GetAllKH);
            f.Show();
        }
        public static int gioitinh = 0;
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedCells[0].OwningRow;

            string ma1 = row.Cells["MaNguoiDung"].Value.ToString();
            int ma = Convert.ToInt32(ma1);
            DTONguoiDung user = new DTONguoiDung();
            FormConSuaNhanVien f = new FormConSuaNhanVien(ma, user);
            f.d += new FormConSuaNhanVien.MyDel(GetAllKH);
            f.Show();
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

            }
            catch
            {

            }
        }
        private void GetAllKH()
        {
            dataGridView1.DataSource = BUSNguoiDung.GetAllNguoiDung();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 0)
            {
                dataGridView1.DataSource = BUSNguoiDung.TimKiemTheoTen(txtUser.Text);
            }

            else if (cboTimKiem.SelectedIndex == 1)
            {
                dataGridView1.DataSource = BUSNguoiDung.TimKiemTheoSDT(txtUser.Text);
            }
            else if (cboTimKiem.SelectedIndex == 2)
            {
                dataGridView1.DataSource = BUSNguoiDung.TimKiemTheoCMND(txtUser.Text);
            }
            else if (cboTimKiem.SelectedIndex == 3)
            {
                dataGridView1.DataSource = BUSNguoiDung.TimKiemTheoViTri(txtUser.Text);
            }
        }
    }
}
