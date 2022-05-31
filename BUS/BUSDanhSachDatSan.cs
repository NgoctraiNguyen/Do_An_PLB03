using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DAL;
using System.Data.SqlClient;
using System.Data;

namespace Do_An_PLB03.BUS
{
    internal class BUSDanhSachDatSan
    {   
        public static DataTable danhsach()
        {   
           DataTable dt = DALDanhSachDatSan.danhsach();
            return dt;
        }
    }
}
