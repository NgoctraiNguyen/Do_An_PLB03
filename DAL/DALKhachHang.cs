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
    internal class DALKhachHang
    {
        public static void KhachHang(DTOKhachHang khachhang)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO KhachHang (TenKhachHang,SDTKhachHang) VALUES(@TenKhachHang,@SDTKhachHang)";

            var tenkhachhang = command.Parameters.AddWithValue("@TenKhachHang", "");
            var sdtkhachhang = command.Parameters.AddWithValue("@SDTKhachHang", "");

            tenkhachhang.Value = khachhang.TenKhachHang;
            sdtkhachhang.Value = khachhang.SDTKhachHang;

            command.ExecuteNonQuery();

        }
       
        public static string ten;
        public static string SDTkhachhang;
        public static bool getkhachhang(DTOKhachHang khachhang,string SDT)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = " select TenKhachHang ,SDTKhachHang  from KhachHang where SDTKhachHang='"+SDT+"'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader(); 
            while (reader.Read())
            {
                ten=reader.GetString(0);
                SDTkhachhang=reader.GetString(1);
                return true;
            }
            return false;

        }
        public static int makhachhang;
        public static int laymakhachhang(DTOKhachHang khachhang, string SDT)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = " select MaKhachHang from KhachHang where SDTKhachHang='"+SDT+"'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                makhachhang = reader.GetInt32(0);
            }
            return makhachhang;

        }
        public static string LayTenKhachHang(int MaKhachHang)
        {
            String TenKhachHang = "";
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = " select TenKhachHang from KhachHang where MaKhachHang='" + MaKhachHang + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TenKhachHang = reader.GetString(0);
            }
            return TenKhachHang;
        }
    }
}
