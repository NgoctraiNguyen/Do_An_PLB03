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
        public static List<string> tensandat(string tenloaisan)
        {
            return DALSan.tensandat(tenloaisan);
        }
        public static List<char> chucai(string loaisan)
        {
            List<string> ten = new List<string>();
            List<char> result = new List<char>();
            ten = tensandat(loaisan);
            foreach(string i in ten)
            {
                result.Add(i[1]);
            }
            return result;
        }
    }
}
