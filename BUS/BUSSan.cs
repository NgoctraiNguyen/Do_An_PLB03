using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;
using Do_An_PLB03.DAL;

namespace Do_An_PLB03.BUS
{
    internal class BUSSan
    {
        public static List<string > loaisan= new List<string>();
        public static List<string> tensan= new List<string>();

        public static void them(string loai,string ten)
        {
            DALSan.them(loai,ten);
        }
        public static List<string > san (DTOSan san)
        {
            loaisan= DALSan.san(san);
            return loaisan;
        }
        public static List<string> tensandat(DTOSan san,string tenloaisan)
        {
            tensan.Clear();
            tensan= DALSan.tensandat(san,tenloaisan);
            return tensan;
        }
    }
}
