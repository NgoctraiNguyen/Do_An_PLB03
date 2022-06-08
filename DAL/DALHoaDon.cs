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
                return reader.GetInt32(0);
            }
            else
            {
                return -1;
            }
        }
    }
}
