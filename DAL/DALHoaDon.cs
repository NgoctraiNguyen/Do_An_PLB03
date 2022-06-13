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
        public static void HoaDon(DTOHoaDon HoaDon)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = "INSERT INTO HoaDon(NgayGioTao,TongTien,MaNguoiDung,MaDonHang) " +
                            "VALUES (@NgayGioTao,@TongTien,@MaNguoiDung,@MaDonHang)  ";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;


            var ngaygiotao = command.Parameters.AddWithValue("@NgayGioTao", HoaDon.NgayGioTao);
            var makhachang = command.Parameters.AddWithValue("@TongTien", HoaDon.TongTien);
            var trangthai = command.Parameters.AddWithValue("@MaNguoiDung", HoaDon.MaNguoiDung);
            var tongtienthuesan = command.Parameters.AddWithValue("@MaDonHang", HoaDon.MaDonHang);

            command.ExecuteNonQuery();
        }

        public static void deleteHoaDon(int mahoadon)
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
        public static int LayMaTheoTen(string TenSan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select MaHoaDon
                             from HoaDon
                             join DonHang on HoaDon.MaDonHang = DonHang.MaDonHang
                             join TrangThaiSan on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                             where TenSan = '" + TenSan + "'";
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
        public static int GetTongTien(int MaHoaDon)
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
        public static void updateTongTien(int mahoadon,int tongtien)
        {
             SqlConnection conn= dbConnectionData.HamketNoi();
            conn.Open();
            String query = "update HoaDon  set TongTien='"+tongtien+"' where MaHoaDon='"+mahoadon+"'";
            SqlCommand command= new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static int LayMaKhachHang(String MaHoaDon)
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
    }

}
