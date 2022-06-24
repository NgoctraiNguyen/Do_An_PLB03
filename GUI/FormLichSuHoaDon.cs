using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_PLB03.BUS;
using Do_An_PLB03.DTO;

namespace Do_An_PLB03.GUI
{
    public partial class FormQuanLiHoaDon : Form
    {
        public FormQuanLiHoaDon()
        {
            InitializeComponent();
            dtHoaDon.DataSource = BUSHoaDon.DSHoaDon();
            dtpBatDau.Value = new DateTime(2022, 1, 1);
            dtpKetThuc.Value = new DateTime(2022, 12, 31);
            txtTongSoHoaDon.Text = dtHoaDon.RowCount.ToString();
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            string NgayGioTao = "Thời gian tạo";
            string TenKH = "Tên Khách Hàng";
            string SDTKH = "SDT Khách Hàng";
            string TenSan = "Tên Sân";
            string TenNV = "Tên Nhân Viên";
            DateTime BatDau = dtpBatDau.Value;
            DateTime KetThuc = dtpKetThuc.Value;
            string rowFilter = string.Format(@"[{0}] > '"+BatDau +"' and [{0}] < '"+KetThuc+"'"  ,NgayGioTao);
            if(txtTenKH.Text != "")
            {
                rowFilter += string.Format(@" and [{0}] like '%{1}%'", TenKH, txtTenKH.Text);
            }
            if(txtSDTKH.Text != "")
            {
                rowFilter += string.Format(@" and [{0}] like '%{1}%'", SDTKH, txtSDTKH.Text);
            }
            if(txtTenSan.Text != "")
            {
                rowFilter += string.Format(@" and [{0}] like '%{1}%'", TenSan, txtTenSan.Text);
            }
            if(txtTenNV.Text != "")
            {
                rowFilter += string.Format(@" and [{0}] like '%{1}%'", TenNV, txtTenNV.Text);
            }
            (dtHoaDon.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            txtTongSoHoaDon.Text = dtHoaDon.RowCount.ToString();
        }
        private void dtHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtHoaDon.Rows[e.RowIndex];
            dataGridView1.DataSource = BUSDoUong.DsDoUong(Convert.ToInt32(row.Cells[0].Value));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSDTKH.Text = txtTenKH.Text = txtTenNV.Text = txtTenSan.Text = "";
            dtpBatDau.Value = new DateTime(2022, 1, 1);
            dtpKetThuc.Value = new DateTime(2022, 12, 31);
        }
    }
}
