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
        private DTOSan san;
     
   
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
           
            
            showsan5();
            showsan7();
            List<string> s5 = new List<string>();
            List<string> s7 = new List<string>();
            s5 = BUSSan.tensandat("5");
            s7 = BUSSan.tensandat("7");
            foreach(var i in s5)
            {
                if(KiemTra(i))
                {
                    this.fl1.Controls["btn" + i].BackColor = Color.LightGreen;
                    this.fl1.Controls["btn" + i].Enabled = true;
                }
                else
                {
                    this.fl1.Controls["btn" + i].BackColor = Color.Gray;
                    this.fl1.Controls["btn" + i].Enabled = false;
                }
            }
            foreach (var i in s7)
            {
                if (KiemTra(i))
                {
                    this.fl2.Controls["btn" + i].BackColor = Color.LightYellow;
                    this.fl2.Controls["btn" + i].Enabled = true;
                }
                else
                {
                    this.fl2.Controls["btn"+  i].BackColor = Color.Gray;
                    this.fl2.Controls["btn" + i].Enabled = false;
                }
            }
            comboBox1.DataSource = BUSDoUong.DoUong();
            dtThanhToan.DataSource = BUSHoaDon.DSThanhToan();
        }
        public int ma;
        private void FormSudungdichvuvaThanhtoan_Click(object sender, EventArgs e)
        {

            float tiendichvu=0;
            string tensan = (((Button)sender).Text);
            ma = BUSHoaDon.LayMaTheoTen(tensan);
            mahoadon = ma;
            dtDichVu.DataSource = BUSDoUong.DsDoUong(ma);

            int sc = dtDichVu.Rows.Count;
            for (int i = 0; i <= sc - 1; i++)
                tiendichvu += float.Parse(dtDichVu.Rows[i].Cells[3].Value.ToString());
            txtdv.Text=tiendichvu.ToString();
            txtTongTien.Text = (BUSHoaDon.GetTongTien(mahoadon)).ToString();
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
                    int madouong = BUSDoUong.MaDoUong(comboBox1.Text);
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
            txtGia.Text = BUSDoUong.GiaDoUongTheoMa(BUSDoUong.MaDoUong(comboBox1.Text)).ToString();
        }

        DTOHoaDon HoaDon= new DTOHoaDon();
       
        private void button3_Click(object sender, EventArgs e)
        {
            //BUSHoaDon.updateTongTien(ma, int.Parse(txtTongTien.Text));
            try
            {
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
            catch
            {

            }
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
            try
            {
                BUSDonHang.TraSan(BUSHoaDon.GetMaDonHang(ma));
                FormSudungdichvuvaThanhtoan_Load(sender, e);
            }
            catch
            {

            }
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
                int madouong = BUSDoUong.MaDoUong(comboBox1.Text);
                BUSDoUong.suadichvu(mahoadon, madouong, int.Parse(txtSL.Text));
                BUSDoUong.updatesoluong(int.Parse(txtSL.Text) - x, comboBox1.Text);
                dtDichVu.DataSource = BUSDoUong.DsDoUong(mahoadon);
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(dtDichVu.SelectedCells[1].Value);
                int madouong = BUSDoUong.MaDoUong(comboBox1.Text);
                BUSDoUong.xoadichvu(mahoadon, madouong);
                BUSDoUong.updatesoluong(-x, comboBox1.Text);
                dtDichVu.DataSource = BUSDoUong.DsDoUong(mahoadon);
            }
            catch
            {

            }
            
        }

        

     

        private void btnThemSan_Click(object sender, EventArgs e)
        {
            FormThemSan formThemSan = new FormThemSan();
            formThemSan.t += new FormThemSan.them(themsan);
            formThemSan.d += new FormThemSan.load(showsan5);
            formThemSan.d += new FormThemSan.load(showsan7);
            formThemSan.Show();

        }
        private void themsan(string loai,string txt)
        {

            BUSSan.them(loai, txt);
        }
        private void showsan5()
        {
            fl1.Controls.Clear();
            List<string> tensan5 = new List<string>();
            tensan5 = BUSSan.tensandat("5");
            foreach (var s5 in tensan5)
            {
                
                Button bt1 = new Button();
                bt1.Text = s5;
                bt1.Size = new System.Drawing.Size(100, 50);
                bt1.Name = "btn" + s5;
                fl1.Controls.Add(bt1);
                bt1.Click += new EventHandler(this.FormSudungdichvuvaThanhtoan_Click);
            }

            
          
        }
        private void showsan7()
        {
            fl2.Controls.Clear();
            List<string> tensan7 = new List<string>();
            tensan7 = BUSSan.tensandat("7");
            foreach (var s7 in tensan7)
            {
                Button bt2 = new Button();
                bt2.Text = s7;
                bt2.Size = new System.Drawing.Size(100, 50);
                bt2.Name = "btn" + s7;
                fl2.Controls.Add(bt2);
                bt2.Click += new EventHandler(this.FormSudungdichvuvaThanhtoan_Click);
            }
        }

        private void btnThemGio_Click(object sender, EventArgs e)
        {
            if(cbbThemGio.Text == "")
            {
                MessageBox.Show("Chưa nhập số giờ cần thêm!");
                return;
            }
            DateTime Thoigianthem = BUSTrangThaiSan.ThoiGianSauKhiCong(BUSTrangThaiSan.getMaTrangThaiSan(BUSHoaDon.GetMaDonHang(ma)),Convert.ToInt32(cbbThemGio.Text));
            if(Check(Thoigianthem) == false)
            {
                MessageBox.Show("Sân đã được đặt");
                return;
            }
            ThemGio(Convert.ToInt32(cbbThemGio.Text));
            List<TimeSpan> tgbd = new List<TimeSpan>();
            List<TimeSpan> tgkt = new List<TimeSpan>();
            List<int> giatheogio = new List<int>();
            tgbd = BUSGia.tgbatdau(BUSTrangThaiSan.getloaisan(ma));
            tgkt = BUSGia.tgketthuc(BUSTrangThaiSan.getloaisan(ma));
            giatheogio = BUSGia.gia(BUSTrangThaiSan.getloaisan(ma));


            int k = 0, p = 0, tien = 0, price = 0;

            for (int i = 0; i < tgbd.Count(); i++)
            {
                if (((int)tgbd[i].TotalHours) <= BUSTrangThaiSan.tgbd(ma) &&
                        ((int)tgkt[i].TotalHours) > BUSTrangThaiSan.tgbd(ma))
                {
                    k = i;
                }
                if (((int)tgbd[i].TotalHours) < BUSTrangThaiSan.tgkt(ma) &&
                    ((int)tgkt[i].TotalHours) >= BUSTrangThaiSan.tgkt(ma))
                {
                    p = i;
                }
            }

            if (k == p)
            {
                tien = (BUSTrangThaiSan.tgkt(ma) - BUSTrangThaiSan.tgbd(ma)) * giatheogio[k];
            }
            else
            {
                for (int i = k + 1; i < p; i++)
                {
                    price += ((((int)tgkt[i].TotalHours) - ((int)tgbd[i].TotalHours)) * giatheogio[i]);
                }

                tien = price + ((((int)tgkt[k].TotalHours)) - BUSTrangThaiSan.tgbd(ma)) * giatheogio[k]
                                    + (BUSTrangThaiSan.tgkt(ma) - ((int)tgbd[p].TotalHours)) * giatheogio[p];
            }
            BUSDonHang.UpdateTongTien(BUSHoaDon.GetMaDonHang(ma), tien);
            BUSHoaDon.updatetongtien(ma, tien);
        }
        private void ThemGio(int sogio)
        {
            BUSTrangThaiSan.themgio(ma, sogio);
        }
        private bool Check(DateTime thoigianthem)
        {
            List<DateTime> batdau = new List<DateTime>();
            batdau = BUSTrangThaiSan.BatDau(BUSDonHang.GetTenSan(BUSHoaDon.GetMaDonHang(ma)));
            foreach(var i in batdau)
            {
                if(DateTime.Compare(thoigianthem,i) > 0)
                {
                    return false;
                }
            }
            return true;
        }
       
    }
}
