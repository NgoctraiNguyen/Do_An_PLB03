using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Do_An_PLB03.DAL
{
    internal class DALDanhSachDatSan
    {
       public static DataTable danhsach()
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query= @"Select TenSan,TenKhachHang,ThoiGianBatDau,ThoiGianKetThuc 
                            from TrangThaiSan
                            join DonHang on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                            join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang";
          SqlDataAdapter da=new SqlDataAdapter(query,conn);
            DataTable tb= new DataTable();
            da.Fill(tb);
            da.Dispose();

            return tb;
        }
        
    }
}
