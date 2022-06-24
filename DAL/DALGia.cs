using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;
using System.Data;
using System.Data.SqlClient;

namespace Do_An_PLB03.DAL
{
    internal class DALGia
    {
       public static List<TimeSpan> tgbd=new List<TimeSpan>();
        public static List<TimeSpan> tgkt=new List<TimeSpan>();
        public static List<int> giatheogio= new List<int>();
        public static List<TimeSpan> tgbatdau(DTOGia gia,int loaisan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = " select ThoiGianBatDau from Gia where LoaiSan='"+loaisan + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection=conn;

         SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tgbd.Add(reader.GetTimeSpan(0));
            }
            return tgbd;

        }

        public static List<TimeSpan> tgketthuc(DTOGia gia, int loaisan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = " select ThoiGianKetThuc from Gia where LoaiSan='" + loaisan + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tgkt.Add(reader.GetTimeSpan(0));
            }
            return tgkt;

        }

        public static List<int> gia(DTOGia gia, int loaisan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = " select GiaTheoGio from Gia where LoaiSan='" + loaisan + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                giatheogio.Add(reader.GetInt32(0));
            }
            return giatheogio;

        }
        public static DataTable BangGiaSan()
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("select MaGiaSan AS'Mã Giá Sân',LoaiSan AS'Loại Sân', ThoiGianBatDau AS'Thời gian bắt đầu', ThoiGianKetThuc AS'Thời gian kết thúc',GiaTheoGio AS'Giá theo giờ' from Gia", conn);
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void SuaGia(DTOGia a)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("update Gia set GiaTheoGio = @gia where MaGiaSan = @ma", conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@gia", a.GiaTheoGio);
            command.Parameters.AddWithValue("@ma", a.MaGiaSan);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
