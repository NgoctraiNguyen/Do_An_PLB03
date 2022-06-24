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
        private DTONguoiDung _user;
        private List<string> list = new List<string>();
        public FormSudungdichvuvaThanhtoan(DTONguoiDung user)
        {
            InitializeComponent();
            _user = user;
        }

        private bool KiemTra(string TenSan)
        {
            foreach(DataRow data in BUSDanhSachDatSan.danhsachdangda().Rows)
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
            comboBox1.DataSource = BUSDoUong.DoUong();
            
            dtThanhToan.DataSource = BUSHoaDon.DSThanhToan();
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
            for (int i = 0; i <= sc - 1; i++)
                tiendichvu += float.Parse(dtDichVu.Rows[i].Cells[3].Value.ToString());
            txtdv.Text=tiendichvu.ToString();
            txtTongTien.Text = (DALHoaDon.GetTongTien(mahoadon)).ToString();
            txtsan.Text = (int.Parse(txtTongTien.Text)-int.Parse(txtdv.Text)).ToString();
            DienHoaDon(ma.ToString(), tensan);
          
            
        }
        private bool xuliSoLuong()// xử lí số lượng
        {
            DataTable dt = BUSDoUong.LaySLtuTenDoDuong(comboBox1.SelectedItem.ToString());
            if (dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) < Convert.ToInt32(txtSL.Text))
                {
                    return true;
                }
            }
            return false;
        }
        //them dich vu
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            if (txtSL.Text == "")
            {
            }
            else
            {
                if (xuliSoLuong() == true)
                {
                    MessageBox.Show("Vượt quá số lượng trong kho");
                    txtSL.Text = "";
                }
                else
                {
                    int madouong = DALDoUong.MaDoUong(comboBox1.Text);
                    BUSDoUong.ThemDichVu(mahoadon, madouong, int.Parse(txtSL.Text));
                    dtDichVu.DataSource = BUSDoUong.DsDoUong(mahoadon);
                }
                if (comboBox1.Text == "")
                {
                }
                else
                {

                    //BUSDoUong.updatesoluong(int.Parse(dtDichVu.Rows[i].Cells[1].Value.ToString()), dtDichVu.Rows[i].Cells[0].Value.ToString());
                    BUSDoUong.updatesoluong(int.Parse(txtSL.Text), comboBox1.Text);

                }
            }

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGia.Text = BUSDoUong.GiaDoUongTheoMa(DALDoUong.MaDoUong(comboBox1.Text)).ToString();
        }

        DTOHoaDon HoaDon= new DTOHoaDon();
       
        private void button3_Click(object sender, EventArgs e)
        {
            //BUSHoaDon.updateTongTien(ma, int.Parse(txtTongTien.Text));
            BUSHoaDon.ThanhToan(Convert.ToInt32(lblSoHoaDon.Text));
            if (comboBox1.Text == "")
            {

            }
            else
            {
                int sc = dtDichVu.Rows.Count;
                for (int i = 0; i < sc - 1; i++)
                {
                    BUSDoUong.updatesoluong(int.Parse(dtDichVu.Rows[i].Cells[1].Value.ToString()), dtDichVu.Rows[i].Cells[0].Value.ToString());
                }
            }
            FormSudungdichvuvaThanhtoan_Load(sender, e);
        }

        private void DienHoaDon(String SoHD, String San)
        {
            lblSoHoaDon.Text = SoHD;
            lblNgayin.Text = DateTime.Now.Day + " - " + DateTime.Now.Month + " - " + DateTime.Now.Year;
            lblGioIn.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            lblSan.Text = San;
            lblThuNgan.Text = _user.HoTen;
            int MaKhachHang = BUSHoaDon.laymakhachhang(lblSoHoaDon.Text);
            lblKhachHang.Text = BUSKhachHang.laytenkhachhang(MaKhachHang);
            lblThueSan.Text = txtsan.Text;
            lblDichVu.Text = txtdv.Text;
            lblTongTien.Text = txtTongTien.Text;
        }


        private void btnDatSan_Click(object sender, EventArgs e)
        {
            
            DALDonHang.TraSan(DALHoaDon.GetMaDonHang(ma));
            FormSudungdichvuvaThanhtoan_Load(sender, e);
        }

        private void dtThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                float tiendichvu = 0;
                DataGridViewRow row = new DataGridViewRow();
                row = dtThanhToan.Rows[e.RowIndex];
                ma = Convert.ToInt32(row.Cells[0].Value);
                dtDichVu.DataSource = BUSDoUong.DsDoUong(ma);
                int sc = dtDichVu.Rows.Count;
                for (int i = 0; i < sc - 1; i++)
                    tiendichvu += float.Parse(dtDichVu.Rows[i].Cells[3].Value.ToString());
                txtdv.Text = tiendichvu.ToString();
                txtTongTien.Text = row.Cells[3].Value.ToString();
                txtsan.Text = (int.Parse(txtTongTien.Text) - int.Parse(txtdv.Text)).ToString();
                DienHoaDon(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());

                mahoadon = ma;
            }
            catch
            {

            }
        }

        private void dtDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtDichVu.Rows[e.RowIndex];
                comboBox1.Text = row.Cells[0].Value.ToString();
                txtGia.Text = row.Cells[2].Value.ToString();
                txtSL.Text = row.Cells[1].Value.ToString();
            }
            catch
            {

            }
        }


        public static int x;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(dtDichVu.SelectedCells[1].Value);
                int madouong = DALDoUong.MaDoUong(comboBox1.Text);
                BUSDoUong.suadichvu(mahoadon, madouong, int.Parse(txtSL.Text));
                BUSDoUong.updatesoluong(int.Parse(txtSL.Text) - x, comboBox1.Text);
                dtDichVu.DataSource = BUSDoUong.DsDoUong(mahoadon);
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(dtDichVu.SelectedCells[1].Value);
            int madouong = DALDoUong.MaDoUong(comboBox1.Text);
            BUSDoUong.xoadichvu(mahoadon, madouong);
            BUSDoUong.updatesoluong(-x, comboBox1.Text);
            dtDichVu.DataSource = BUSDoUong.DsDoUong(mahoadon);
        }

        private void dtDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
