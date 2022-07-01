using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;
using System.Data.SqlClient;
using System.Data;

namespace Do_An_PLB03.DAL
{
    internal class DALDonHang
    {
        public static void donhang(DTODonHang donhang) // tạo đơn hàng
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = "INSERT INTO DonHang(MaTrangThaiSan,NgayGioTao,MaKhachHang,TrangThai,TongTienThueSan) " +
                            "VALUES (@MaTrangThaiSan,@NgayGioTao,@MaKhachHang,@TrangThai,@TongTienThueSan)  ";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;

            
            var matrangthaisan = command.Parameters.AddWithValue("@MaTrangThaiSan", donhang.MaTrangThaiSan);
            var ngaygiotao = command.Parameters.AddWithValue("@NgayGioTao",donhang.NgayGioTao);
            var makhachang = command.Parameters.AddWithValue("@MaKhachHang", donhang.MaKhachHang);
            var trangthai = command.Parameters.AddWithValue("@TrangThai", donhang.TrangThai);
            var tongtienthuesan = command.Parameters.AddWithValue("@TongTienThueSan",donhang.TongTienSan);

            command.ExecuteNonQuery();
        }

        public static void deletedonhang(int madonhang) // xóa đơn hàng
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            string query = "delete from DonHang where MaDonHang='" + madonhang+ "'";
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();

        }
        public static void DoiTrangThai(int madonhang) // Chuyển trạng thái khi nhận sân 
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            string query = "Update DonHang SET TrangThai = 0 where DonHang.MaDonHang = '" + madonhang + "'";
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        public static int GetTongTien(int MaDonHang) // trả về tổng tiền từ đơn hàng
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = " select TongTienThueSan from DonHang where MaDonHang = '" + MaDonHang + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            int rt = 0 ;
            while(reader.Read())
            {
                return reader.GetInt32(0);
            }
            return rt;
        }
        public static void ThanhToan(int mahoadon) // Chuyển trạng thái hóa đơn từ 0->1 khi thanh toán
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            String query = "update HoaDon  set TrangThai = 1 where MaHoaDon='" + mahoadon + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void TraSan(int madonhang) // chuyển trạng thái đơn hàng từ 0 -> 2 khi trả sân

        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            String query = "update DonHang set DonHang.TrangThai = 2 where MaDonHang='" + madonhang + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static string GetTenSan(int madonhang) //trả về tên sân của đơn hàng
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = " select TenSan " +
                            "from TrangThaiSan join DonHang on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan" +
                            " where MaDonHang = '" + madonhang + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            string rt = "0";
            while (reader.Read())
            {
                return reader.GetString(0);
            }
            return rt;
        }
        public static void updateTongTien(int madonhang,int tongtien)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            String query = "update DonHang set DonHang.TongTienThueSan = "+tongtien+" where MaDonHang='" + madonhang + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
