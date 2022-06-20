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
        public static void updatesoluong(int sluong,string tendouong)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = " update DoUong set SoLuong=SoLuong-'" + sluong + "' where TenDoUong='"+tendouong+"'";
           SqlCommand command= new SqlCommand(query, conn);
            command.CommandType = CommandType.Text;   
            command.ExecuteNonQuery();
        }
        public static DataTable GetAllDoUong()
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("select * from DoUong", conn);
            command.CommandType = CommandType.Text;


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
            SqlCommand command = new SqlCommand("insert into DoUong(TenDoUong,SoLuong,GiaBan,GiaGoc)values( @tendouong, @soluong, @giagoc, @giaban)", conn);
            command.CommandType = CommandType.Text;

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
            SqlCommand command = new SqlCommand("update DoUong set TenDoUong = @tendouong, SoLuong = @soluong, GiaBan = @giaban, GiaGoc = @giagoc where MaDoUong = @MaDoUong", conn);
            command.CommandType = CommandType.Text;
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
            SqlCommand command = new SqlCommand("delete from DoUong where MaDoUong = @MaDoUong", conn);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@MaDoUong",MaDoUong);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable DSDoUong(int MaHoaDon)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = @"Select DoUong.TenDoUong, ChiTietHoaDon.SoLuong,  DoUong.GiaBan,ChiTietHoaDon.TongTien
                            from DoUong
                            join ChiTietHoaDon on DoUong.MaDoUong = ChiTietHoaDon.MaDoUong
                            where ChiTietHoaDon.MaHoaDon = '" + MaHoaDon + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            da.Dispose();

            return tb;
        }
        public static List<string> douong = new List<string>();
        public static List<string> DoUong()
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string queryss = "select  distinct TenDoUong from DoUong where SoLuong > 0";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = queryss;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            douong.Clear();
            while (reader.Read())
            {

                douong.Add(reader.GetString(0));

            }
            return douong;
        }
        public static int MaDoUong(string tendouong)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string queryss = string.Format("select MaDoUong from DoUong where TenDoUong = N'{0}'",tendouong);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = queryss;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                return reader.GetInt32(0);

            }
            return -1;
        }
        public static int GiaDoUongTheoMa(int madouong)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string queryss = string.Format("select GiaBan from DoUong where MaDoUong = {0}", madouong);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = queryss;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                return reader.GetInt32(0);

            }
            return -1;
        }
        public static void ThemDichVu(int mahoadon, int madouong, int soluong)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string querry = "INSERT INTO ChiTietHoaDon(MaDoUong,SoLuong,TongTien,MaHoaDon) " +
                            "VALUES (@MaDoUong,@SoLuong,@TongTien,@MaHoaDon)  ";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = querry;
            command.Connection = conn;

            int tongtien = GiaDoUongTheoMa(madouong)*soluong;
            var matrangthaisan = command.Parameters.AddWithValue("@MaDoUong", madouong);
            var ngaygiotao = command.Parameters.AddWithValue("@SoLuong", soluong);
            var makhachang = command.Parameters.AddWithValue("@TongTien", tongtien);
            var trangthai = command.Parameters.AddWithValue("@MaHoaDon", mahoadon);
            command.ExecuteNonQuery();
        }
        public static void HienthiThongTinSua(int ma, DTODoUong d)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("select TenDoUong, SoLuong, GiaBan, GiaGoc from DoUong where MaDoUong = @ma", conn);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@ma", ma);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                d.TenDoUong = reader.GetString(0);
                d.SoLuong = reader.GetInt32(1);
                d.GiaBan = reader.GetInt32(2);
                d.GiaGoc = reader.GetInt32(3);
            }
            conn.Close();
        }
        public static DataTable TimKiemTenDoUong(string ten)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select TenDoUong, SoLuong, GiaBan, GiaGoc from DoUong where TenDoUong like '%" + ten + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable TimKiemGiaBan(string gia)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select TenDoUong, SoLuong, GiaBan, GiaGoc from DoUong where GiaBan like '" + gia + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}