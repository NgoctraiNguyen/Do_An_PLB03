using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_PLB03.BUS;
using Do_An_PLB03.DTO;

namespace Do_An_PLB03.GUI
{
    public partial class FormDatSan : Form
    {
        private FormChinh _formcha;
        DTOTrangThaiSan trangthaisan= new DTOTrangThaiSan();
        DTOSan san= new DTOSan();
        DTOGia gia = new DTOGia();
        DTOKhachHang khachhang = new DTOKhachHang();
        DTODonHang donhang= new DTODonHang();

        public static List<string> loaisan=new List<string>();
        public static List<string> tensan= new List<string>();

        public static List<TimeSpan> tgbd = new List<TimeSpan>();
        public static List<TimeSpan> tgkt = new List<TimeSpan>();
        public static List<int> giatheogio = new List<int>();

        public static TimeSpan[] Tgbd = new TimeSpan[50];
        public static TimeSpan[] Tgkt = new TimeSpan[50];
        public int[] Giatheogio = new int[50];

        string tenloaisan;
        public FormDatSan(FormChinh formcha)
        {
            InitializeComponent();
            _formcha = formcha;
            now.Enabled = true;
        }
        private void FormDatSan_Load(object sender, EventArgs e)
        {
            loaisan.Clear();
            loaisan = BUSSan.san(san);
            cbbLoaiSan.DataSource = loaisan;
            dtDanhSachDatSan.DataSource = BUSDanhSachDatSan.danhsach();
            lbloigio.Text = "";
        }

        private void cbbLoaiSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiSan.SelectedIndex != -1)
            {
                txtMaLoaiSan.Text = cbbLoaiSan.Text;
                tenloaisan = cbbLoaiSan.Text;
                tensan.Clear();
                tensan = BUSSan.tensandat(tenloaisan);
                cbbTenSan.DataSource = null;
                cbbTenSan.Items.Clear();
                cbbTenSan.DataSource = tensan;

            }
        }
        public TimeSpan[] tgbd_toarray(List<TimeSpan> tgbd)
        {
            return tgbd.ToArray();
        }
        public TimeSpan[] tgkt_toarray(List<TimeSpan> tgkt)
        {
            return tgkt.ToArray();
        }
        public int[] giatheogio_toarray(List<int> giatheogio)
        {
            return giatheogio.ToArray();
        }

        public static List<DateTime> batdau = new List<DateTime>();
        public static List<DateTime> ketthuc = new List<DateTime>();
        private void cbbTenSan_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            txtTenSan.Text = cbbTenSan.Text;
            BUSTrangThaiSan.kiemtrasan(trangthaisan, txtTenSan.Text);
            batdau = BUSTrangThaiSan.batdau;
            ketthuc = BUSTrangThaiSan.ketthuc;
        }
        private void txtSoGio_MouseLeave(object sender, EventArgs e)
        {
            if (txtSoGio.Text == "")
            {
                txtSoGio.Text = "0";
                btnDatSan.Enabled = false;

            }
            else if (Convert.ToDouble(txtSoGio.Text)%1!=0 || Convert.ToDouble(txtSoGio.Text)==0)
            {
                txtSoGio.Text = "0";
                lbloigio.Text = "Giờ nhập không hợp lệ";
                

            }
            else
            {
                lbloigio.Text = "";
                int hthem = Convert.ToInt32(txtSoGio.Text);
                dtpNgayGioTra.Value = dtpNgayGioNhan.Value.AddHours(hthem);

                tgbd = BUSGia.tgbatdau( int.Parse(tenloaisan));
                tgkt = BUSGia.tgketthuc( int.Parse(tenloaisan));
                giatheogio = BUSGia.gia( int.Parse(tenloaisan));

                Tgbd = tgbd_toarray(tgbd);
                Tgkt = tgkt_toarray(tgkt);
                Giatheogio = giatheogio_toarray(giatheogio);

                int k = 0, p = 0, tien = 0, price = 0;

                for (int i = 0; i < Tgbd.Count(); i++)
                {
                    if (((int)Tgbd[i].TotalHours) <= dtpNgayGioNhan.Value.Hour &&
                            ((int)Tgkt[i].TotalHours) > dtpNgayGioNhan.Value.Hour)
                    {
                        k = i;
                    }
                    if (((int)Tgbd[i].TotalHours) < dtpNgayGioTra.Value.Hour &&
                        ((int)Tgkt[i].TotalHours) >= dtpNgayGioTra.Value.Hour)
                    {
                        p = i;
                    }
                }

                if (k == p)
                {
                    tien = (dtpNgayGioTra.Value.Hour - dtpNgayGioNhan.Value.Hour) * Giatheogio[k];
                }
                else
                {
                    for (int i = k + 1; i < p; i++)
                    {
                        price += ((((int)Tgkt[i].TotalHours) - ((int)tgbd[i].TotalHours)) * Giatheogio[i]);
                    }

                    tien = price + ((((int)Tgkt[k].TotalHours)) - dtpNgayGioNhan.Value.Hour) * Giatheogio[k]
                                        + (dtpNgayGioTra.Value.Hour - ((int)Tgbd[p].TotalHours)) * Giatheogio[p];
                }


                txtGia.Text = tien.ToString();

            }
            for (int i = 0; i < batdau.Count; i++)
            {

                int s1 = DateTime.Compare(dtpNgayGioNhan.Value, batdau[i]);
                int s2 = DateTime.Compare(dtpNgayGioNhan.Value, ketthuc[i]);
                int ss1 = DateTime.Compare(dtpNgayGioTra.Value, batdau[i]);
                int ss2 = DateTime.Compare(dtpNgayGioTra.Value, ketthuc[i]);
                if ((s1 > 0 && s2 < 0) || (ss1 > 0 && ss2 < 0) || (s1 < 0 && ss2 > 0))
                {
                    lbnhan.Text = "thoi gian nay da duoc dat";
                }
                else
                {
                    lbnhan.Text = "";

                }
            }
        }

        private void txtSoGio_MouseClick(object sender, MouseEventArgs e)
        {
            txtSoGio.Text = "";

        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            if (dtpNgayGioTra.Value < DateTime.Now)
            {
                MessageBox.Show("Đã quá giờ đặt sân");
            }
            else
            {
                trangthaisan.TenSan = cbbTenSan.Text;
                trangthaisan.ThoiGianBatDau = dtpNgayGioNhan.Value;
                trangthaisan.ThoiGianKetThuc = dtpNgayGioTra.Value;
                BUSTrangThaiSan.TrangThaiSan(trangthaisan);

                khachhang.TenKhachHang = txtTenKhachHang.Text;
                khachhang.SDTKhachHang = txtSDTKhachHang.Text;
                if (!BUSKhachHang.kiemtrakhachhang(khachhang, txtSDTKhachHang.Text))
                {
                    BUSKhachHang.KhachHang(khachhang);
                }

                BUSKhachHang.laymakhachhang(khachhang, txtSDTKhachHang.Text);
                donhang.MaKhachHang = BUSKhachHang.makhachhang;

                BUSTrangThaiSan.matrangthaisan(trangthaisan, dtpNgayGioNhan.Value.Hour);
                donhang.MaTrangThaiSan = BUSTrangThaiSan.ma;
                donhang.NgayGioTao = DateTime.Now;
                donhang.TongTienSan = int.Parse(txtGia.Text);
                donhang.TrangThai = 1;

                BUSDonHang.donhang(donhang);

                dtDanhSachDatSan.DataSource = BUSDanhSachDatSan.danhsach();

                if (chkNhanSan.Checked)
                {
                    _formcha.Openchillform(new FormNhanSan(_formcha._user));
                }
            }
            txtTenKhachHang.Text = "";
            txtSDTKhachHang.Text = "";
            txtSDT.Text = "";
        }

        string ten, sdt;
        private void dtpNgayGioNhan_MouseLeave(object sender, EventArgs e)
        {
            
        }
        public static string ctTenSan, ctTen, ctNgayNhan, ctNgayTra, ctSDTKhachHang, ctMaDonHang, ctMaTrangThaiSan, ctLoaiSan;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (txtGia.Text == "" || txtSDTKhachHang.Text == "" || txtTenKhachHang.Text == "" || txtSoGio.Text == "0" || lbnhan.Text != "" || lbsdt.Text != "")
            {
                btnDatSan.Enabled = false;
            }
            else
            {
                btnDatSan.Enabled = true;
            }
        }
        private void txtSDTKhachHang_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^(09|03|07|08|05)+([0-9]{8})$");
            if (string.IsNullOrEmpty(txtSDTKhachHang.Text))
            {
                lbsdt.Text = "SDT không được để trống";
            }
            else
            {
                if (r.IsMatch(txtSDTKhachHang.Text) == false)
                    lbsdt.Text = "SDT khong hop le";
                else
                {
                    lbsdt.Text = "";
                }
            }
        }

        private void dtDanhSachDatSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dtDanhSachDatSan.Rows[e.RowIndex];
                ctTenSan = row.Cells[0].Value.ToString();
                ctTen = row.Cells[1].Value.ToString();
                ctNgayNhan = row.Cells[2].Value.ToString();
                ctNgayTra = row.Cells[3].Value.ToString();
                ctSDTKhachHang = row.Cells[4].Value.ToString();
                ctMaDonHang = row.Cells[5].Value.ToString();
                ctMaTrangThaiSan = row.Cells[6].Value.ToString();
                ctLoaiSan = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtDanhSachDatSan.SelectedRows.Count != 1) { return; }
                else
                {
                    FormXemChiTietDatSan formxct = new FormXemChiTietDatSan(ctTenSan, ctTen, ctNgayNhan, ctNgayTra, ctSDTKhachHang, ctMaDonHang, ctMaTrangThaiSan, ctLoaiSan);
                    formxct.ShowDialog();
                }
            }
            catch { }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUSKhachHang.getkhachhang(khachhang, txtSDT.Text);
            ten = BUSKhachHang.ten;
            sdt = BUSKhachHang.SDTkhachhang;

            txtTenKhachHang.Text = ten;
            txtSDTKhachHang.Text = sdt;
        }
        private void XuLiDonQuaHan(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            foreach (DataGridViewRow row in dtDanhSachDatSan.Rows)
            {
                if (Convert.ToDateTime(row.Cells[3].Value.ToString()) < dt)
                {
                    BUSDonHang.deletedonhang(Convert.ToInt32(row.Cells[5].Value));
                }
            }
        }
    }
}
