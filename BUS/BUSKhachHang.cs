using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;
using Do_An_PLB03.DAL;

namespace Do_An_PLB03.BUS
{
    internal class BUSKhachHang
    {
      
        public static string ten;
        public static string SDTkhachhang;
        public static void KhachHang(DTOKhachHang khachhang)
        {
            DALKhachHang.KhachHang(khachhang);
        }
        public static void getkhachhang(DTOKhachHang khachhang,string SDT)
        {
            DALKhachHang.getkhachhang(khachhang,SDT);
            ten = DALKhachHang.ten;
            SDTkhachhang = DALKhachHang.SDTkhachhang;
        
        }
        public static int makhachhang;
        public static void laymakhachhang(DTOKhachHang khachhang,string SDT)
        {
            makhachhang = DALKhachHang.laymakhachhang(khachhang,SDT);
            
        }
    }
}
