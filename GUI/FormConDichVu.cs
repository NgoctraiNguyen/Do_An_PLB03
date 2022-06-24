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
                
            }
            catch 
            {
               
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            FormConThemDichVu f = new FormConThemDichVu();
            f.d += new FormConThemDichVu.MyDel(GetAllDoUong);
            f.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow row = dataGridView1.SelectedCells[0].OwningRow;

            string ma1 = row.Cells[0].Value.ToString();
            int ma = Convert.ToInt32(ma1);
            DTODoUong d = new DTODoUong();
            FormConSuaDichVu f = new FormConSuaDichVu(ma, d);
            f.d += new FormConSuaDichVu.MyDel(GetAllDoUong);
            f.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedCells[0].OwningRow;

            string ma1 = row.Cells[0].Value.ToString();
            try
            {
                int ma = Convert.ToInt32(ma1);
                BUSDoUong.DeleteDoUong(ma);
                MessageBox.Show("Xoa thanh cong");
                dataGridView1.DataSource = BUSDoUong.GetAllDoUong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void GetAllDoUong()
        {
            dataGridView1.DataSource = BUSDoUong.GetAllDoUong();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = BUSDoUong.TimKiemTheoTen(txtUser.Text);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = BUSDoUong.TimKiemTheoGiaBan(txtUser.Text);
            }
        }
    }
}
