using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Do_An_PLB03.DAL
{
    internal class DALThongKe
    {
        
       public static DataTable sumthang= new DataTable();
        public static void thongkethang( int Year)
        {

            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query= @"select Month(NgayGioTao) AS Thang,Sum(TongTien) AS TongTien
                            from HoaDon 
                            where Year(NgayGioTao)='"+Year+"'  group by MONTH(NgayGioTao)";
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.Fill(sumthang);

        }
        public static DataTable sumsan= new DataTable();
        public static void thongkesan(int month,int year)
        {
            SqlConnection conn= dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"select LoaiSan ,Sum(TongTienThueSan) AS TongTien from HoaDon 
                                join DonHang on HoaDon.MaDonHang= DonHang.MaDonHang
                                join TrangThaiSan on DonHang.MaTrangThaiSan=TrangThaiSan.MaTrangThaiSan
                                join San on TrangThaiSan.TenSan=San.TenSan
                                where Month(HoaDon.NgayGioTao)='"+month+"'And Year(HoaDon.NgayGioTao)='"+year+"' Group by LoaiSan ";
            SqlDataAdapter d = new SqlDataAdapter(query, conn);
            d.Fill(sumsan);
        }
    }
}
