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
        public static DateTime batdau, ketthuc;
        public static void kiemtrasan(DTOTrangThaiSan trangthaisan, string tensan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            string que = "select ThoiGianBatDau,ThoiGianKetThuc from trangthaisan where TenSan='"+tensan+"'and TrangThai=1";
            command.CommandType = CommandType.Text;
            command.CommandText = que;
            SqlDataReader read= command.ExecuteReader();
            while (read.Read())
            {
                batdau=read.GetDateTime(0);
                ketthuc=read.GetDateTime(1);
            }
        }


    }

}
