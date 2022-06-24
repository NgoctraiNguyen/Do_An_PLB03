using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;

namespace Do_An_PLB03.DAL
{
    internal class DALHoaDon
    {
        public static void HoaDon(DTOHoaDon HoaDon) // tạo hóa đơn
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = "INSERT INTO HoaDon(NgayGioTao,TongTien,MaNguoiDung,MaDonHang,TrangThai) " +
                            "VALUES (@NgayGioTao,@TongTien,@MaNguoiDung,@MaDonHang,@TrangThai)  ";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;


            var ngaygiotao = command.Parameters.AddWithValue("@NgayGioTao", HoaDon.NgayGioTao);
            var makhachang = command.Parameters.AddWithValue("@TongTien", HoaDon.TongTien);
            var mangnguoidung = command.Parameters.AddWithValue("@MaNguoiDung", HoaDon.MaNguoiDung);
            var tongtienthuesan = command.Parameters.AddWithValue("@MaDonHang", HoaDon.MaDonHang);
            var trangthai = command.Parameters.AddWithValue("@TrangThai", HoaDon.TrangThai);

            command.ExecuteNonQuery();
        }

        public static void deleteHoaDon(int mahoadon) //xóa hóa đơn
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            string query = "delete from HoaDon where MaHoaDon='" + mahoadon + "'";
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        public static int LayMaTheoTen(string TenSan) // Trả về mã hóa đơn theo tên sân
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select MaHoaDon
                             from HoaDon
                             join DonHang on HoaDon.MaDonHang = DonHang.MaDonHang
                             join TrangThaiSan on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                             where TenSan = '" + TenSan + "' and DonHang.TrangThai = 0 and HoaDon.TrangThai = 0";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                return 4;
            }
            else
            {
                return -1;
            }
        }
        public static int tongtienthuesan = 0;
        public static int GetTongTien(int MaHoaDon) // Trả về tổng tiền của 1 hóa đơn
        {
            if (MaHoaDon == -1) return -1;
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"select TongTien from HoaDon where MaHoaDon = '"+ MaHoaDon +"'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader1 = command.ExecuteReader();
            while(reader1.Read())
            {
                tongtienthuesan = reader1.GetInt32(0);
            }


            SqlConnection Conn = dbConnectionData.HamketNoi();
            Conn.Open();
            string Query = @"select TongTien from ChiTietHoaDon where MaHoaDon = '" + MaHoaDon + "'";
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = Query;
            Command.Connection = Conn;
            SqlDataReader reader2 = Command.ExecuteReader();
            while( reader2.Read())
            {
                tongtienthuesan += reader2.GetInt32(0);
            }
            return tongtienthuesan;

        }
        public static void updateTongTien(int mahoadon,int tongtien) // cộng tổng tiền khi ấn thanh toán
        {
             SqlConnection conn= dbConnectionData.HamketNoi();
            conn.Open();
            String query = "update HoaDon  set TongTien='"+tongtien+"', TrangThai = 1 where MaHoaDon='"+mahoadon+"'";
            SqlCommand command= new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static int LayMaKhachHang(String MaHoaDon) // Trả về mã khách hàng từ mã hóa đơn
        {
            int MaKhachHang = 0;
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"select MaNguoiDung from HoaDon where MaHoaDon = '" + MaHoaDon + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                MaKhachHang = reader1.GetInt32(0);

            }
            return MaKhachHang;
        }
        public static DataTable DSThanhToan() //  Trả về danh sách hóa đơn chưa thanh toán
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("Select MaHoaDon AS'Mã Hóa Đơn',TenSan AS' Tên Sân', TenKhachHang AS' Tên Khách Hàng', HoaDon.TongTien AS'Tổng Tiền' " +
                "from KhachHang join DonHang on KhachHang.MaKhachHang = DonHang.MaKhachHang " +
                "join TrangThaiSan on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan " +
                "join HoaDon on DonHang.MaDonHang = HoaDon.MaDonHang " +
                "where HoaDon.TrangThai = 0 and DonHang.TrangThai = 2", conn);
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int GetMaDonHang(int MaHoaDon) // Trả về mã đơn hàng của hóa đơn
        {
            int MaDonHang = 0;
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"select MaDonHang from HoaDon where MaHoaDon = '" + MaHoaDon + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                MaDonHang = reader1.GetInt32(0);
            }
            return MaDonHang;
        }

        public static void ThanhToan(int mahoadon) // Chuyển trạng thái khi thanh toán 
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            string query = "Update HoaDon SET HoaDon.TrangThai = 1 where HoaDon.MaHoaDon = '" + mahoadon + "'";
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        public static DataTable DSHoaDon()
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("Select MaHoaDon AS'Mã Hóa Đơn', TenKhachHang AS 'Tên Khách Hàng', SDTKhachHang as 'SDT Khách Hàng', TenSan AS 'Tên Sân', HoaDon.TongTien AS 'Tổng Tiền',NguoiDung.HoTen as 'Tên Nhân Viên', HoaDon.NgayGioTao as 'Thời gian tạo' " +
                " from KhachHang join DonHang on KhachHang.MaKhachHang = DonHang.MaKhachHang " +
                " join TrangThaiSan on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan " +
                " join HoaDon on DonHang.MaDonHang = HoaDon.MaDonHang " +
                " join NguoiDung on NguoiDung.MaNguoiDung = HoaDon.MaNguoiDung" +
                " where HoaDon.TrangThai = 1", conn);
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }

}
