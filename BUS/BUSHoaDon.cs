using Do_An_PLB03.DAL;
using Do_An_PLB03.DTO;
using System;
using System.Collections.Generic;
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
    }
}
