using Do_An_PLB03.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_PLB03
{
    public partial class Formkhohang : Form
    {
        public Formkhohang()
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
                txtTenDoUong.Text = row.Cells[0].Value.ToString();
                txtSoLuong.Text = row.Cells[1].Value.ToString();
                txtGiaBan.Text = row.Cells[2].Value.ToString();
                txtGiaGoc.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
