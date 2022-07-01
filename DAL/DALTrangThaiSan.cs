using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Do_An_PLB03.DTO;
using System.Data;

namespace Do_An_PLB03.DAL
{
    internal class DALTrangThaiSan
    {
        public static void DatSan(DTOTrangThaiSan trangthaisan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO TrangThaiSan (TenSan ,ThoiGianBatDau,ThoiGianKetThuc,TrangThai) " +
                                    "VALUES (@TenSan,@ThoiGianBatDau,@ThoiGianKetThuc,@TrangThai)";

            // var matrangthaisan = command.Parameters.AddWithValue("@MaTrangThaiSan", "");
            var tensan = command.Parameters.AddWithValue("@TenSan", "");
            var thoigianbatdau = command.Parameters.AddWithValue("@ThoiGianBatDau", "");
            var thoigianketthuc = command.Parameters.AddWithValue("@ThoiGianKetThuc", "");
            var trangthai = command.Parameters.AddWithValue("@TrangThai", " ");

            //matrangthaisan.Value =trangthaisan.MaTrangThaiSan ;

            tensan.Value = trangthaisan.TenSan;
            thoigianbatdau.Value = trangthaisan.ThoiGianBatDau;
            thoigianketthuc.Value = trangthaisan.ThoiGianKetThuc;
            trangthai.Value = trangthaisan.TrangThai;

            command.ExecuteNonQuery();



        }
        public static int ma;
        public static int matrangthai(DTOTrangThaiSan trangthaisan,int tgbd)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
          string querry = "select MaTrangThaiSan from TrangThaiSan where DATEPART(hh,ThoiGianBatDau)='" + tgbd+"'";
            command.CommandType=CommandType.Text;
            command.CommandText=querry;

            SqlDataReader read= command.ExecuteReader();

            while (read.Read())
            {
                ma = read.GetInt32(0);
            }

            return ma;
        }
        public static List<DateTime> batdau = new List<DateTime>();
        public static List<DateTime> ketthuc = new List<DateTime>();
        public static void kiemtrasan(DTOTrangThaiSan trangthaisan, string tensan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            string que = "select ThoiGianBatDau,ThoiGianKetThuc from trangthaisan where TenSan='" + tensan + "'and TrangThai=1";
            command.CommandType = CommandType.Text;
            command.CommandText = que;
            SqlDataReader read = command.ExecuteReader();

            DateTime bt = new DateTime(1, 1, 1, 0, 0, 0);
            DateTime kt = new DateTime(1, 1, 1, 0, 0, 0);

            if (read.HasRows)
            {

                while (read.Read())
                {
                    batdau.Add(read.GetDateTime(0));
                    ketthuc.Add(read.GetDateTime(1));

                }
            }
            else
            {
                batdau.Add(bt);
                ketthuc.Add(kt);
            }


        }
        public static void deletetrangthai(int matrangthaisan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            string query = "delete from TrangThaiSan where MaTrangThaiSan='" + matrangthaisan + "'";
            command.CommandType=CommandType.Text;
            command.CommandText=query;
            command.ExecuteNonQuery();

        }
        public static void themgio(int matrangthaisan,int sogio)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            string query = "update TrangThaiSan set ThoiGianKetThuc = Dateadd(hour, "+sogio+", ThoiGianKetThuc) where MaTrangThaiSan = '"+matrangthaisan+"'";
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();

        }
        public static int getmatrangthai(int mahoadon)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select TrangThaiSan.MaTrangThaiSan
                             from HoaDon
                             join DonHang on HoaDon.MaDonHang = DonHang.MaDonHang
                             join TrangThaiSan on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                             where MaHoaDon = '"+mahoadon+"'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
            return -1;
        }

        public static int getloaisan(int mahoadon)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select LoaiSan
                             from HoaDon
                             join DonHang on HoaDon.MaDonHang = DonHang.MaDonHang
                             join TrangThaiSan on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan
                             join San on TrangThaiSan.TenSan = San.TenSan
                             where MaHoaDon = '" + mahoadon + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return Convert.ToInt32(reader.GetString(0));
                }
            }
            return -1;
        }
        public static int tgbd = 0;
        public static int tgkt = 0;
        public static void gettgbd(int matrangthaisan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"select datepart(hour,ThoiGianBatDau),datepart(hour,ThoiGianKetThuc) from TrangThaiSan where MaTrangThaiSan = '" + matrangthaisan+"'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tgbd = reader.GetInt32(0);
                    tgkt = reader.GetInt32(1);
                }
            }
        }
        public static List<DateTime> BatDau(string tensan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            string querry = "select ThoiGianBatDau " +
                "from TrangThaiSan join DonHang on TrangThaiSan.MaTrangThaiSan = DonHang.MaTrangThaiSan" +
                " where DonHang.TrangThai = 1 and TenSan = '"+tensan+"'";
            command.CommandType = CommandType.Text;
            command.CommandText = querry;

            SqlDataReader read = command.ExecuteReader();
            List<DateTime> list = new List<DateTime>();
            while (read.Read())
            {
                list.Add(read.GetDateTime(0));
            }

            return list;
        }
        public static DateTime ThoiGianSauKhiCong(int matrangthaisan,int sogio)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"select ThoiGianKetThuc from TrangThaiSan where MaTrangThaiSan = '" + matrangthaisan + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            DateTime saukhicong = new DateTime();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    saukhicong = reader.GetDateTime(0); 
                }
            }
            saukhicong.AddHours(sogio);
            return saukhicong;
        }
        public static int getMaTrangThaiSan(int madonhang)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"select MaTrangThaiSan from DonHang where MaDonHang = '" + madonhang + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return  reader.GetInt32(0);
                }
            }
            return -1;
        }
    }

}
