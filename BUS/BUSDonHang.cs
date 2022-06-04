using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;
using Do_An_PLB03.DAL;


namespace Do_An_PLB03.BUS
{
    internal class BUSDonHang
    {
        public static void donhang(DTODonHang donhang)
        {
            DALDonHang.donhang(donhang);
        }
        public static void deletedonhang(int madonhang)
        {
            DALDonHang.deletedonhang(madonhang);
        }

    }
}
