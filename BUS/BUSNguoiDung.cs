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
    public class BUSNguoiDung
    {
        public static DataTable GetAllNguoiDung()
        {
            return DALNguoiDung.GetAllNguoiDung();
        }
        public static void InsertNguoiDung(DTONguoiDung a)
        {
            DALNguoiDung.InsertNguoiDung(a);
        }
        public static void UpdateNguoiDung(DTONguoiDung a)
        {
            DALNguoiDung.UpdateNguoiDung(a);
        }
        public static void DeleteNguoiDung(int a)
        {
            DALNguoiDung.DeleteNguoiDung(a);
        }
        public static void LuuThongTinCaNhan(DTONguoiDung a)
        {
            DALNguoiDung.LuuThongTinCaNhan(a);
        }
        public static void HienThiThongTinSua(int ma, DTONguoiDung user)
        {
            DALNguoiDung.HienThiThongTinSua(ma, user);
        }
        public static int GetMaNguoiDung(int a)
        {
            return DALNguoiDung.GetMaNguoiDung(a);
        }
        public static void ResetMatKhau(DTONguoiDung a)
        {
            DALNguoiDung.ResetMatKhau(a);
        }
        public static DataTable TimKiemTheoTen(string ten)
        {
            return DALNguoiDung.TimKiemTheoTen(ten);
        }
        public static DataTable TimKiemTheoSDT(string sdt)
        {
            return DALNguoiDung.TimKiemTheoSDT(sdt);
        }
        public static DataTable TimKiemTheoCMND(string cmnd)
        {
            return DALNguoiDung.TimKiemTheoCMND(cmnd);
        }
        public static DataTable TimKiemTheoViTri(string vt)
        {
            return DALNguoiDung.TimKiemTheoViTri(vt);
        }

        public static bool KiemTraTenDangNhap(String TenDangNhap)
        {
            return DALNguoiDung.KiemTraTenDangNhap(TenDangNhap);
        }
    }
}
