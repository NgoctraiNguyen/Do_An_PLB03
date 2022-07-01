using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DAL;
using Do_An_PLB03.DTO;

namespace Do_An_PLB03.BUS
{
    internal class BUSTrangThaiSan
    {   

        public static void TrangThaiSan(DTOTrangThaiSan trangthaisan)
        {

            if (trangthaisan.TenSan != null)
               trangthaisan.TrangThai = 1;
            else trangthaisan.TrangThai = 0;
            DALTrangThaiSan.DatSan(trangthaisan);

        }
        public static int ma;
        public static void matrangthaisan(DTOTrangThaiSan trangthaisan,int tgbd)
        {
            ma=DALTrangThaiSan.matrangthai(trangthaisan, tgbd);
            
        }

        public static List<DateTime> batdau = new List<DateTime>();
        public static List<DateTime> ketthuc = new List<DateTime>();
        public static void  kiemtrasan(DTOTrangThaiSan trangthaisan,string tensan)
        {
            DALTrangThaiSan.kiemtrasan(trangthaisan , tensan);
            batdau = DALTrangThaiSan.batdau;
            ketthuc = DALTrangThaiSan.ketthuc;
        }
        public static void deletetrangthai(int matrangthaisan)
        {
            DALTrangThaiSan.deletetrangthai(matrangthaisan);
        }
        public static void themgio(int mahoadon, int sogio)
        {
            DALTrangThaiSan.themgio(DALTrangThaiSan.getmatrangthai(mahoadon), sogio);
        }
        public static int getloaisan(int mahoadon)
        {
            return DALTrangThaiSan.getloaisan(mahoadon);
        }
        public static int tgbd(int mahoadon)
        {
            DALTrangThaiSan.gettgbd(DALTrangThaiSan.getmatrangthai(mahoadon));
            return DALTrangThaiSan.tgbd;
        }
        public static int tgkt(int mahoadon)
        {
            DALTrangThaiSan.gettgbd(DALTrangThaiSan.getmatrangthai(mahoadon));
            return DALTrangThaiSan.tgkt;
        }
        public static List<DateTime> BatDau(string tensan)
        {
            return DALTrangThaiSan.BatDau(tensan);
        }
        public static DateTime ThoiGianSauKhiCong(int matrangthaisan,int sogio)
        {
            return DALTrangThaiSan.ThoiGianSauKhiCong(matrangthaisan,sogio);
        }
        public static int getMaTrangThaiSan(int madonhang)
        {
            return DALTrangThaiSan.getMaTrangThaiSan(madonhang);
        }
    }
}
