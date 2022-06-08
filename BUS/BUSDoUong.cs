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
    }
}
