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
    public class DALNguoiDung
    {
        public static DataTable GetAllNguoiDung()
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("sp_GetAllNguoiDung", conn);
            command.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void InsertNguoiDung(DTONguoiDung a)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("sp_InsertNguoiDung", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@hoten", a.HoTen);
            command.Parameters.AddWithValue("@tuoi", a.Tuoi);
            command.Parameters.AddWithValue("@diachi", a.DiaChi);
            command.Parameters.AddWithValue("@gioitinh", a.GioiTinh);
            command.Parameters.AddWithValue("@sdt", a.SDT);
            command.Parameters.AddWithValue("@socmnd", a.SoCMND);
            command.Parameters.AddWithValue("@vitri", a.Vitri);
            command.Parameters.AddWithValue("@quyen", a.Quyen);
            command.Parameters.AddWithValue("@tendangnhap", a.TenDangNhap);
            command.Parameters.AddWithValue("@matkhau", a.MatKhau);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static void UpdateNguoiDung(DTONguoiDung a)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("sp_UpdateNguoiDung", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ma", a.MaNguoiDung);
            command.Parameters.AddWithValue("@hoten", a.HoTen);
            command.Parameters.AddWithValue("@tuoi", a.Tuoi);
            command.Parameters.AddWithValue("@diachi", a.DiaChi);
            command.Parameters.AddWithValue("@gioitinh", a.GioiTinh);
            command.Parameters.AddWithValue("@sdt", a.SDT);
            command.Parameters.AddWithValue("@socmnd", a.SoCMND);
            command.Parameters.AddWithValue("@vitri", a.Vitri);
            command.Parameters.AddWithValue("@quyen", a.Quyen);
            command.Parameters.AddWithValue("@tendangnhap", a.TenDangNhap);
            command.Parameters.AddWithValue("@matkhau", a.MatKhau);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteNguoiDung(int a)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("sp_DeleteNguoiDung", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ma", a);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static void LuuThongTinCaNhan(DTONguoiDung a)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("update NguoiDung set HoTen=@hoten,Tuoi=@tuoi,SDT=@sdt,SoCMND=@socmnd,DiaChi=@diachi,TenDangNhap=@tendangnhap,MatKhau=@matkhau where TenDangNhap=@tendangnhap", conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@hoten", a.HoTen);
            command.Parameters.AddWithValue("@tuoi", a.Tuoi);
            command.Parameters.AddWithValue("@sdt", a.SDT);
            command.Parameters.AddWithValue("@socmnd", a.SoCMND);
            command.Parameters.AddWithValue("@diachi", a.DiaChi);
            command.Parameters.AddWithValue("@tendangnhap", a.TenDangNhap);
            command.Parameters.AddWithValue("@matkhau", a.MatKhau);
            command.ExecuteNonQuery();
            conn.Close();
        }

    }    
}
