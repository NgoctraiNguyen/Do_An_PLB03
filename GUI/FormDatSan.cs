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
        }



        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        private void FormDatSan_Load(object sender, EventArgs e)
        {
            cbbLoaiSan.Items.Clear();
            loaisan = BUSSan.san(san);
            cbbLoaiSan.DataSource = loaisan;

            dtDanhSachDatSan.DataSource = BUSDanhSachDatSan.danhsach();



        }

        private void cbbLoaiSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiSan.SelectedIndex != null)
            {

                txtMaLoaiSan.Text = cbbLoaiSan.Text;
                tenloaisan = cbbLoaiSan.Text;

                tensan.Clear();
                tensan = BUSSan.tensandat(san, tenloaisan);
                cbbTenSan.DataSource = null;
                cbbTenSan.Items.Clear();
                cbbTenSan.DataSource = tensan;

            }

        }



        private void cbbLoaiSan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

       

        private void txtSoGio_Leave(object sender, EventArgs e)
        {

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

        private void txtSoGio_MouseLeave(object sender, EventArgs e)
        {
            if (txtSoGio.Text == "")
            {
                txtSoGio.Text = "0";
                
            }
            else
            {
                int hthem = Convert.ToInt32(txtSoGio.Text);
                dtpNgayGioTra.Value = dtpNgayGioNhan.Value.AddHours(hthem);

                tgbd = BUSGia.tgbatdau(gia, int.Parse(tenloaisan));
                tgkt = BUSGia.tgketthuc(gia, int.Parse(tenloaisan));
                giatheogio = BUSGia.gia(gia, int.Parse(tenloaisan));

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



        }

        private void txtSoGio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoGio_MouseClick(object sender, MouseEventArgs e)
        {
            txtSoGio.Text = "";

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void cbbTenSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenSan.Text=cbbTenSan.Text;

        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            trangthaisan.TenSan = cbbTenSan.Text;
            trangthaisan.ThoiGianBatDau = dtpNgayGioNhan.Value;
            trangthaisan.ThoiGianKetThuc = dtpNgayGioTra.Value;
            BUSTrangThaiSan.TrangThaiSan(trangthaisan);

            khachhang.TenKhachHang = txtTenKhachHang.Text;
            khachhang.SDTKhachHang = txtSDTKhachHang.Text;
            BUSKhachHang.KhachHang(khachhang);

            BUSKhachHang.laymakhachhang(khachhang,txtSDTKhachHang.Text);
            donhang.MaKhachHang = BUSKhachHang.makhachhang;

            BUSTrangThaiSan.matrangthaisan(trangthaisan,dtpNgayGioNhan.Value.Hour);
            donhang.MaTrangThaiSan =BUSTrangThaiSan.ma ;
            donhang.NgayGioTao=DateTime.Now;
            donhang.TongTienSan = int.Parse(txtGia.Text);
            donhang.TrangThai =1;

            BUSDonHang.donhang(donhang);

            if (chkNhanSan.Checked)
            {
                _formcha.Openchillform(new FormNhanSan());
            }

        }

        string ten, sdt;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUSKhachHang.getkhachhang(khachhang, txtSDT.Text);
            ten = BUSKhachHang.ten;
            sdt = BUSKhachHang.SDTkhachhang;

            txtTenKhachHang.Text = ten;
            txtSDTKhachHang.Text = sdt;
        }
    }
}
