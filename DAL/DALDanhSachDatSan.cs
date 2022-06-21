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
       public static DataTable danhsach() // trả về danh sách đặt sân
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query= @"Select TrangThaiSan.TenSan AS 'Tên Sân',TenKhachHang AS' Tên Khách Hàng',
                           ThoiGianBatDau AS 'Thời Gian Nhận',ThoiGianKetThuc AS 'Thời Gian Trả',SDTKhachHang AS 'Số Điện Thoại',
                            DonHang.MaDonHang AS ' Mã Đơn Hàng',DonHang.MaTrangThaiSan AS 'Mã Trạng Thái' ,LoaiSan AS ' Loại Sân'
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
        public static bool GetDonHang(int MaDonHang) //Trả về đơn hàng theo mã đon hàng
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select KhachHang.TenKhachHang,KhachHang.SDTKhachHang,San.TenSan,San.LoaiSan,TrangThaiSan.ThoiGianBatDau,TrangThaiSan.ThoiGianKetThuc,DonHang.TongTienThueSan,DonHang.MaTrangThaiSan
                            from San
                            join TrangThaiSan on San.TenSan = TrangThaiSan.TenSan
                            join DonHang on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                            join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang
                            where DonHang.MaDonHang='" + MaDonHang + "'AND DonHang.TrangThai=1";
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

        public static DataTable DanhSachNhanSan() // Trả về danh sách nhận sân 
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select TrangThaiSan.TenSan AS'Tên Sân',TenKhachHang AS'Tên Khách Hàng',
                            ThoiGianBatDau AS'Thời Gian Nhận',ThoiGianKetThuc AS'Thời Gian Trả',SDTKhachHang'Số Điện Thoại',DonHang.MaDonHang AS ' Mã Đơn Hàng',
                            DonHang.MaTrangThaiSan AS 'Mã Trạng Thái',LoaiSan AS'Loại Sân' 
                            from San 
                            join TrangThaiSan on San.TenSan=TrangThaiSan.TenSan                
                            join DonHang on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                            join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang
                            join HoaDon on DonHang.MaDonHang = HoaDon.MaDonHang
                            where (DonHang.TrangThai = 0 or DonHang.TrangThai = 2) And Day(HoaDon.NgayGioTao)=Day(GETDATE()) ";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            da.Dispose();
            return tb;
        }

        public static DataTable DanhSachDangDa() // Trả về danh sách đang đá
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select TrangThaiSan.TenSan,TenKhachHang,ThoiGianBatDau,ThoiGianKetThuc,SDTKhachHang,DonHang.MaDonHang,DonHang.MaTrangThaiSan,HoaDon.TrangThai
                            from San 
                            join TrangThaiSan on San.TenSan=TrangThaiSan.TenSan                
                            join DonHang on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                            join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang
                            join HoaDon on DonHang.MaDonHang = HoaDon.MaDonHang
                            where DonHang.TrangThai = 0 and HoaDon.TrangThai = 0";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            da.Dispose();
            return tb;
        }
    }
}
