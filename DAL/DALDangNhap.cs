using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Do_An_PLB03.DTO;

namespace Do_An_PLB03.DAL
{
    public class DALDangNhap
    {
        public static bool KiemTraDangNhap(DTONguoiDung user)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from NguoiDung where TenDangNhap = '" + user.TenDangNhap + "' and MatKhau = '" + user.MatKhau + "'";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                user.MaNguoiDung = reader.GetInt32(0);
                user.HoTen = reader.GetString(1);
                user.Tuoi = reader.GetInt32(2);
                user.DiaChi = reader.GetString(3);
                user.GioiTinh = reader.GetInt32(4);
                user.SDT = reader.GetString(5);
                user.SoCMND = reader.GetString(6);
                user.Vitri = reader.GetString(7);
                user.Quyen = reader.GetInt32(8);
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public static DataTable GetAllKhachHang()
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("sp_GetAllKhachHang",conn);
            command.CommandType = CommandType.StoredProcedure;
            

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt =new DataTable(); 
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
