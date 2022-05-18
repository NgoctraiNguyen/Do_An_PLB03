using Do_An_PLB03.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;


namespace Do_An_PLB03.BUS
{
    public class BUSDangNhap
    {
        public static int DangNhap(DTONguoiDung user)
        {

            return DALDangNhap.KiemTraDangNhap(user);
        }
    }
}
