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
        private int mahoadon = -1;
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
                btn5A.BackColor = Color.LightGreen;
                btn5A.Enabled = true;
            }
            else
            {
                btn5A.BackColor = Color.Gray;
                btn5A.Enabled = false;
            }
            if (KiemTra("5B"))
            {
                btn5B.BackColor = Color.LightGreen;
                btn5B.Enabled = true;
            }
            else
            {
                btn5B.BackColor = Color.Gray;
                btn5B.Enabled = false;
            }
            if (KiemTra("5C"))
            {
                btn5C.BackColor = Color.LightGreen;
                btn5C.Enabled = true;
            }
            else
            {
                btn5C.BackColor = Color.Gray;
                btn5C.Enabled = false;
            }
            if (KiemTra("7A"))
            {
                btn7A.BackColor = Color.LightYellow;
                btn7A.Enabled = true;
            }
            else
            {
                btn7A.BackColor = Color.Gray;
                btn7A.Enabled = false;
            }
            if (KiemTra("7B"))
            {
                btn7B.BackColor = Color.LightYellow;
                btn7B.Enabled = true;
            }
            else
            {
                btn7B.BackColor = Color.Gray;
                btn7B.Enabled = false;
            }
            comboBox1.DataSource = DALDoUong.DoUong();
        }

        private void btn5A_Click(object sender, EventArgs e)
        {
            
        }
         
        public int ma;
        private void FormSudungdichvuvaThanhtoan_Click(object sender, EventArgs e)
        {

            float tiendichvu=0;

            string tensan = (((Button)sender).Text).Split(' ')[1];
             ma = DALHoaDon.LayMaTheoTen(tensan);
            mahoadon = ma;
            dtDichVu.DataSource = BUSDoUong.DsDoUong(ma);

            int sc = dtDichVu.Rows.Count;
            for (int i = 0; i < sc - 1; i++)
                tiendichvu += float.Parse(dtDichVu.Rows[i].Cells[3].Value.ToString());
            txtdv.Text=tiendichvu.ToString();
            txtTongTien.Text = (DALHoaDon.GetTongTien(mahoadon)).ToString();
            txtsan.Text = (int.Parse(txtTongTien.Text)-int.Parse(txtdv.Text)).ToString();
          
            
        }
        //them dich vu
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            if(txtSL.Text == "")
            {

            }
            else
            {
                int madouong = DALDoUong.MaDoUong(comboBox1.Text);
                BUSDoUong.ThemDichVu(mahoadon, madouong, int.Parse(txtSL.Text));
                dtDichVu.DataSource = BUSDoUong.DsDoUong(mahoadon);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGia.Text = BUSDoUong.GiaDoUongTheoMa(DALDoUong.MaDoUong(comboBox1.Text)).ToString();
        }

        DTOHoaDon HoaDon= new DTOHoaDon();
       
        private void button3_Click(object sender, EventArgs e)
        {
            BUSHoaDon.updateTongTien(ma, int.Parse(txtTongTien.Text));
        }

        private void dtDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtdv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
