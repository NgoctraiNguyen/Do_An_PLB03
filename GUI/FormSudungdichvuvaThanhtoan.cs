using Do_An_PLB03.BUS;
using Do_An_PLB03.DTO;
using Do_An_PLB03.DAL;
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
    public partial class FormSudungdichvuvaThanhtoan : Form
    {
        private int mahoadon;
        public FormSudungdichvuvaThanhtoan()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool KiemTra(string TenSan)
        {
            foreach(DataRow data in BUSDanhSachDatSan.danhsachnhansan().Rows)
            {
                if(data["TenSan"].ToString() == TenSan)
                {
                    return true;
                }
            }
            return false;
        }
        private void FormSudungdichvuvaThanhtoan_Load(object sender, EventArgs e)
        {
            if(KiemTra("5A"))
            {
                btn5A.BackColor = Color.Green;
                btn5A.Enabled = true;
            }
            else
            {
                btn5A.BackColor = Color.Gray;
                btn5A.Enabled = false;
            }
            if (KiemTra("5B"))
            {
                btn5B.BackColor = Color.Green;
                btn5B.Enabled = true;
            }
            else
            {
                btn5B.BackColor = Color.Gray;
                btn5B.Enabled = false;
            }
            if (KiemTra("5C"))
            {
                btn5C.BackColor = Color.Green;
                btn5C.Enabled = true;
            }
            else
            {
                btn5C.BackColor = Color.Gray;
                btn5C.Enabled = false;
            }
            if (KiemTra("7A"))
            {
                btn7A.BackColor = Color.Green;
                btn7A.Enabled = true;
            }
            else
            {
                btn7A.BackColor = Color.Gray;
                btn7A.Enabled = false;
            }
            if (KiemTra("7B"))
            {
                btn7B.BackColor = Color.Green;
                btn7B.Enabled = true;
            }
            else
            {
                btn7B.BackColor = Color.Gray;
                btn7B.Enabled = false;
            }
        }

        private void btn5A_Click(object sender, EventArgs e)
        {
            
        }
        private void FormSudungdichvuvaThanhtoan_Click(object sender, EventArgs e)
        {
            dtDichVu.DataSource = BUSDoUong.DsDoUong(DALHoaDon.LayMaTheoTen(((Button)sender).Text));
        }
    }
}
