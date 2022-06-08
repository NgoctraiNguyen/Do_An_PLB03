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
            string query= @"Select TrangThaiSan.TenSan,TenKhachHang,ThoiGianBatDau,ThoiGianKetThuc,SDTKhachHang,DonHang.MaDonHang,DonHang.MaTrangThaiSan,LoaiSan 
                            from San 
                            join TrangThaiSan on San.TenSan=TrangThaiSan.TenSan                
                            join DonHang on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                            join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang
                            where DonHang.TrangThai = 1";
          SqlDataAdapter da=new SqlDataAdapter(query,conn);
            DataTable tb= new DataTable();
            da.Fill(tb);
            da.Dispose();

            return tb;
        }
        public static string HoTen;
        public static string SDTKhachHang;
        public static string TenSan;
        public static string LoaiSan;
        public static string NgayTra;
        public static string NgayNhan;
        public static int Gia;
        public static int MaTrangThaiSan;
        public static bool GetDonHang(int MaDonHang)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select KhachHang.TenKhachHang,KhachHang.SDTKhachHang,San.TenSan,San.LoaiSan,TrangThaiSan.ThoiGianBatDau,TrangThaiSan.ThoiGianKetThuc,DonHang.TongTienThueSan,DonHang.MaTrangThaiSan
                            from San
                            join TrangThaiSan on San.TenSan = TrangThaiSan.TenSan
                            join DonHang on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                            join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    HoTen = reader.GetString(0);
                    SDTKhachHang = reader.GetString(1);
                    TenSan = reader.GetString(2);
                    LoaiSan = reader.GetString(3);
                    NgayNhan = reader["ThoiGianBatDau"].ToString();
                    NgayTra = reader["ThoiGianKetThuc"].ToString();
                    Gia = reader.GetInt32(6);
                    MaTrangThaiSan = reader.GetInt32(7);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable DanhSachNhanSan()
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select TrangThaiSan.TenSan,TenKhachHang,ThoiGianBatDau,ThoiGianKetThuc,SDTKhachHang,DonHang.MaDonHang,DonHang.MaTrangThaiSan,LoaiSan 
                            from San 
                            join TrangThaiSan on San.TenSan=TrangThaiSan.TenSan                
                            join DonHang on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                            join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang
                            where DonHang.TrangThai = 0";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            da.Dispose();
            return tb;
        }
    }
}
