using Do_An_PLB03.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_PLB03.DAL
{
    public class DALDoUong
    {
        public static DataTable GetAllDoUong()
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("sp_GetAllDoUong", conn);
            command.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void InsertDoUong(DTODoUong a)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("sp_InsertDoUong", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@tendouong", a.TenDoUong);
            command.Parameters.AddWithValue("@soluong", a.SoLuong);
            command.Parameters.AddWithValue("@giagoc", a.GiaGoc);
            command.Parameters.AddWithValue("@giaban", a.GiaBan);

            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateDoUong(DTODoUong a)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("sp_UpdateDoUong", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaDoUong", a.MaDoUong);
            command.Parameters.AddWithValue("@tendouong", a.TenDoUong);
            command.Parameters.AddWithValue("@soluong", a.SoLuong);
            command.Parameters.AddWithValue("@giagoc", a.GiaGoc);
            command.Parameters.AddWithValue("@giaban", a.GiaBan);

            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteDoUong(int MaDoUong)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("sp_DeleteDoUong", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MaDoUong",MaDoUong);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable DSDoUong(int MaHoaDon)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select DoUong.TenDoUong, ChiTietHoaDon.SoLuong,  DoUong.GiaBan
                            from DoUong
                            join ChiTietHoaDon on DoUong.MaDoUong = ChiTietHoaDon.MaDoUong
                            where ChiTietHoaDon.MaHoaDon = '" + MaHoaDon + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            da.Dispose();

            return tb;
        }
    }
}
