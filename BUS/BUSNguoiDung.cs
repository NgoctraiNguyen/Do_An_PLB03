using Do_An_PLB03.DAL;
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
    }
}
