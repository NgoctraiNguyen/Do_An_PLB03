using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DAL;
using System.Data.SqlClient;
using System.Data;

namespace Do_An_PLB03.BUS
{
    internal class BUSDanhSachDatSan
    {   
        public static DataTable danhsach()
        {   
           DataTable dt = DALDanhSachDatSan.danhsach();
            return dt;
        }
        public static string HoTen;
        public static string SDTKhachHang;
        public static string TenSan;
        public static string LoaiSan;
        public static string NgayTra;
        public static string NgayNhan;
        public static int Gia;
        public static bool TimKiem(int MaHoaDon)// tìm kiếm sân đã đặt và chưa nhận
        {
            if (DALDanhSachDatSan.GetDonHang(MaHoaDon))
            {
                HoTen = DALDanhSachDatSan.HoTen;
                SDTKhachHang = DALDanhSachDatSan.SDTKhachHang;
                TenSan = DALDanhSachDatSan.TenSan;
                LoaiSan = DALDanhSachDatSan.LoaiSan;
                NgayNhan = DALDanhSachDatSan.NgayNhan;
                NgayTra = DALDanhSachDatSan.NgayTra;
                Gia = DALDanhSachDatSan.Gia;
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void NhanSan(int MaDonHang)
        {
            DALDonHang.DoiTrangThai(MaDonHang);
        }
        
        public static DataTable danhsachnhansan()
        {
            DataTable dt = DALDanhSachDatSan.DanhSachNhanSan();
            return dt;
        }
        public static DataTable danhsachdangda()
        {
            DataTable dt = DALDanhSachDatSan.DanhSachDangDa();
            return dt;
        }
    }
}
