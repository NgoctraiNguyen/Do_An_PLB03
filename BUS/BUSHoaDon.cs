using Do_An_PLB03.DAL;
using Do_An_PLB03.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_PLB03.BUS
{
    internal class BUSHoaDon
    {
        public static void HoaDon(DTOHoaDon HoaDon)
        {
            DALHoaDon.HoaDon(HoaDon);
        }

        public static void deleteHoaDon(int MaHoaDon)
        {
            DALHoaDon.deleteHoaDon(MaHoaDon);
        }
        public static void updateTongTien(int madonhang, int tongtien)
        {
            DALHoaDon.updateTongTien(madonhang, tongtien);
        }
        public static int laymakhachhang(string MaHoaDon)
        {
            return DALHoaDon.LayMaKhachHang(MaHoaDon);
        }
        public static void ThanhToan(int mahoadon)
        {
            DALHoaDon.ThanhToan(mahoadon);
        }
        public static DataTable DSHoaDon()
        {
            DataTable dt = DALHoaDon.DSHoaDon();
            return dt;
        }
        public static DataTable DSThanhToan()
        {
            DataTable dt = DALHoaDon.DSThanhToan();
            return dt;
        }
        public static int LayMaTheoTen(string ten)
        {
            return DALHoaDon.LayMaTheoTen(ten);
        }
        public static int GetTongTien(int MaHoaDon)
        {
            return DALHoaDon.GetTongTien(MaHoaDon);
        }
        public static int GetMaDonHang(int ma)
        {
            return DALHoaDon.GetMaDonHang(ma);
        }
        public static void updatetongtien(int mahoadon, int tien)
        {
            DALHoaDon.updatetongtien(mahoadon, tien);
        }
    }
}
