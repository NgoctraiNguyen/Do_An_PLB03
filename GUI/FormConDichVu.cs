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
    public partial class FormConDichVu : Form
    {
        public FormConDichVu()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            dataGridView1.DataSource = BUSDoUong.GetAllDoUong();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                txtMaDoUong.Text = row.Cells[0].Value.ToString();
                txtTenDoUong.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
                txtGiaBan.Text = row.Cells[3].Value.ToString();
                txtGiaGoc.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
               
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtTenDoUong.Text;
                int sl = Convert.ToInt32(txtSoLuong.Text);
                int giaban = Convert.ToInt32(txtGiaBan.Text);
                int giagoc = Convert.ToInt32(txtGiaGoc.Text);
                DTODoUong douong = new DTODoUong(ten, sl, giaban, giagoc);
                BUSDoUong.InsertDoUong(douong);
                MessageBox.Show("Thêm thành công");
                dataGridView1.DataSource = BUSDoUong.GetAllDoUong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = Convert.ToInt32(txtMaDoUong.Text);
                string ten = txtTenDoUong.Text;
                int sl = Convert.ToInt32(txtSoLuong.Text);
                int giaban = Convert.ToInt32(txtGiaBan.Text);
                int giagoc = Convert.ToInt32(txtGiaGoc.Text);
                DTODoUong douong = new DTODoUong(ma, ten, sl, giaban, giagoc);
                BUSDoUong.UpdateDoUong(douong);
                MessageBox.Show("Sua thanh cong");
                dataGridView1.DataSource = BUSDoUong.GetAllDoUong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = Convert.ToInt32(txtMaDoUong.Text);
                BUSDoUong.DeleteDoUong(ma);
                MessageBox.Show("Xoa thanh cong");
                dataGridView1.DataSource = BUSDoUong.GetAllDoUong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Focus();
        }
        public void Focus()
        {
            txtMaDoUong.Text = "";
            txtTenDoUong.Text = "";
            txtSoLuong.Text = "";
            txtGiaBan.Text = "";
            txtGiaGoc.Text = "";
        }
    }
}
