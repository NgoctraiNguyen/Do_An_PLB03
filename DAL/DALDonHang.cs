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
        public static void donhang(DTODonHang donhang)
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

        public static void danhsachdat()
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = "Select";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;
        }
        public static void deletedonhang(int madonhang)
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

    }
}
