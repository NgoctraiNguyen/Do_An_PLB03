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
    public class BUSDoUong
    {
        public static DataTable LaySLtuTenDoDuong(string ten)
        {
            return DALDoUong.LaySoLuongTuTenDoUong(ten);
        }
        public static void updatesoluong(int sluong,string tendouong)
        {
            DALDoUong.updatesoluong(sluong, tendouong);
        }
        public static DataTable GetAllDoUong()
        {
            return DALDoUong.GetAllDoUong();
        }
        public static void InsertDoUong(DTODoUong a)
        {
            DALDoUong.InsertDoUong(a);
        }
        public static void UpdateDoUong(DTODoUong a)
        {
            DALDoUong.UpdateDoUong(a);
        }
        public static void DeleteDoUong(int MaDoUong)
        {
            DALDoUong.DeleteDoUong(MaDoUong);
        }
        public static DataTable DsDoUong(int MaHoaDon)
        {
            return DALDoUong.DSDoUong(MaHoaDon);
        }
        public static List<string> DoUong()
        {
            return DALDoUong.DoUong();
        }
        public static int GiaDoUongTheoMa(int madouong)
        {
            return DALDoUong.GiaDoUongTheoMa(madouong);
        }
        public static void ThemDichVu(int mahoadon, int madouong, int soluong)
        {
            DALDoUong.ThemDichVu(mahoadon, madouong, soluong);  
        }
        public static void suadichvu(int mahoadon,int madouong,int soluong)
        {
            DALDoUong.SuaDichVu(mahoadon, madouong,soluong);
        }
        public static void xoadichvu(int mahoadon,int madouong)
        {
            DALDoUong.XoaDichVu(mahoadon, madouong);
        }
        public static void HienThiThongTinSua(int ma, DTODoUong d)
        {
            DALDoUong.HienthiThongTinSua(ma, d);
        }
        public static DataTable TimKiemTheoTen(string ma)
        {
            return DALDoUong.TimKiemTenDoUong(ma);
        }
        public static DataTable TimKiemTheoGiaBan(string gia)
        {
            return DALDoUong.TimKiemGiaBan(gia);
        }
    }
}
