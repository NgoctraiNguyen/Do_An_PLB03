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

            //if (trangthaisan.TenSan != null)
            //    trangthaisan.TrangThai = 1;
            //else trangthaisan.TrangThai = 0;
            DALTrangThaiSan.DatSan(trangthaisan);


        }
    }
}
