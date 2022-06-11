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
    internal class BUSThongke
    {
        
        public static DataTable sumthang= new DataTable();
        public static void thongkethang(int year)
            {
            DALThongKe.thongkethang(year);
            sumthang = DALThongKe.sumthang;
            }
        public static DataTable sumsan= new DataTable();
        public static void thongkesan(int month,int year) 
            {
                DALThongKe.thongkesan(month,year);
                sumsan = DALThongKe.sumsan;
            } 
    }
}
