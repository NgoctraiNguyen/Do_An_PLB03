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
    public partial class FormConGiaSan : Form
    {
        public int Ma;

        public FormConGiaSan()
        {
            InitializeComponent();
            LoadDuLieubangGia();
        }
        private void LoadDuLieubangGia()
        {
            dtGiaSan.DataSource = BUSGia.BangGiaSan();
            dtGiaSan.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtGiaSan.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dtGiaSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtGiaSan.Rows[e.RowIndex];
                Ma = Convert.ToInt32(row.Cells[0].Value);
                txtLoaiSan.Text = row.Cells[1].Value.ToString();
                txtTGBD.Text = row.Cells[2].Value.ToString();
                txtTGKT.Text = row.Cells[3].Value.ToString();
                txtGia.Text = row.Cells[4].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int loaisan = Convert.ToInt32(txtLoaiSan.Text);
                DateTime ThoiGianBatDau = Convert.ToDateTime(txtTGBD.Text);
                DateTime ThoiGianKetThuc = Convert.ToDateTime(txtTGKT.Text);
                int GiaTheoGio = Convert.ToInt32(txtGia.Text);
                int ma = Ma;
                DTOGia dtogia = new DTOGia(ma, loaisan, ThoiGianBatDau, ThoiGianKetThuc, GiaTheoGio);
                BUSGia.SuaGia(dtogia);
                MessageBox.Show("Sửa thành công");
                LoadDuLieubangGia();
            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi. Vui lòng nhập lại");
            }
        }

        private void txtGia_MouseLeave(object sender, EventArgs e)
        {
            int n = 0;
            if (txtGia.Text == "" || (int.TryParse(txtGia.Text, out n)) == false)
            {
                lblGia.Text = "Vui lòng nhập lại";
                txtGia.Focus();
            }
            else
            {
                lblGia.Text = "";
            }
        }

        private void FormConGiaSan_MouseMove(object sender, MouseEventArgs e)
        {
            if(lblGia.Text != "")
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
