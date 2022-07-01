using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;
using Do_An_PLB03.DAL;
using System.Data;

namespace Do_An_PLB03.BUS
{
    internal class BUSGia
    {
        public static List<TimeSpan> tgbd = new List<TimeSpan>();
        public static List<TimeSpan> tgkt = new List<TimeSpan>();
        public static List<int> giatheogio = new List<int>();
        public static List<TimeSpan> tgbatdau(int loaisan)
        {
           tgbd=DALGia.tgbatdau(loaisan);
            return tgbd;
        }
        public static List<TimeSpan> tgketthuc( int loaisan)
        {
            tgkt = DALGia.tgketthuc( loaisan);
            return tgkt;
        }
        public static List<int> gia(int loaisan)
        {
            giatheogio = DALGia.gia(loaisan);
            return giatheogio;
        }
        public static DataTable BangGiaSan()
        {
            return DALGia.BangGiaSan();
        }
        public static void SuaGia(DTOGia a)
        {
            DALGia.SuaGia(a);
        }
    }
}
