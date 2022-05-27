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
    }
}
