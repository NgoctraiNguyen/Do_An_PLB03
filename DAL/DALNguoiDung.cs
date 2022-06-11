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
            SqlCommand command = new SqlCommand("select MaNguoiDung,HoTen, Tuoi, DiaChi, GioiTinh, SDT, SoCMND,ViTri, Quyen from NguoiDung", conn);
            command.CommandType = CommandType.Text;

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
            SqlCommand command = new SqlCommand("insert into NguoiDung(HoTen,Tuoi,DiaChi,GioiTinh,SDT,SoCMND,ViTri,Quyen,TenDangNhap,MatKhau)values(@hoten, @tuoi, @diachi, @gioitinh, @sdt, @socmnd, @vitri, @quyen, @tendangnhap, @matkhau)", conn);
            command.CommandType = CommandType.Text;

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
            SqlCommand command = new SqlCommand("update NguoiDung set HoTen=@hoten,Tuoi=@tuoi,DiaChi=@diachi,GioiTinh=@gioitinh,SDT=@sdt,SoCMND=@socmnd,ViTri=@vitri,Quyen=@quyen where MaNguoiDung=@ma", conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@ma", a.MaNguoiDung);
            command.Parameters.AddWithValue("@hoten", a.HoTen);
            command.Parameters.AddWithValue("@tuoi", a.Tuoi);
            command.Parameters.AddWithValue("@diachi", a.DiaChi);
            command.Parameters.AddWithValue("@gioitinh", a.GioiTinh);
            command.Parameters.AddWithValue("@sdt", a.SDT);
            command.Parameters.AddWithValue("@socmnd", a.SoCMND);
            command.Parameters.AddWithValue("@vitri", a.Vitri);
            command.Parameters.AddWithValue("@quyen", a.Quyen);
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
        public static void HienThiThongTinSua(int ma, DTONguoiDung user)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("select HoTen,Tuoi,DiaChi,GioiTinh,SDT,SoCMND,ViTri,Quyen from NguoiDung where MaNguoiDung=@ma", conn);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@ma", ma);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                user.HoTen = reader.GetString(0);
                user.Tuoi = reader.GetInt32(1);
                user.DiaChi = reader.GetString(2);
                user.GioiTinh = reader.GetString(3);
                user.SDT = reader.GetString(4);
                user.SoCMND = reader.GetString(5);
                user.Vitri = reader.GetString(6);
                user.Quyen = reader.GetInt32(7);
            }
            conn.Close();
        }

        public static int GetMaNguoiDung(int ma)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("select MaNguoiDung from NguoiDung where MaNguoiDung=" + ma, conn);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@ma", ma);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetInt32(0);
            }
            return ma;
        }
        public static void ResetMatKhau(DTONguoiDung a)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand("update NguoiDung set MatKhau=@matkhau where MaNguoiDung=@ma", conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@ma", a.MaNguoiDung);
            command.Parameters.AddWithValue("@matkhau", a.MatKhau);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable TimKiemTheoTen(string ten)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select MaNguoiDung,HoTen, Tuoi, DiaChi, GioiTinh, SDT, SoCMND,ViTri, Quyen from NguoiDung where HoTen like '%" + ten + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable TimKiemTheoSDT(string sdt)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select MaNguoiDung,HoTen, Tuoi, DiaChi, GioiTinh, SDT, SoCMND,ViTri, Quyen from NguoiDung where SDT like '%" + sdt + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable TimKiemTheoCMND(string cmnd)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select MaNguoiDung,HoTen, Tuoi, DiaChi, GioiTinh, SDT, SoCMND,ViTri, Quyen from NguoiDung where SoCMND like'%" + cmnd + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable TimKiemTheoViTri(string vt)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select MaNguoiDung,HoTen, Tuoi, DiaChi, GioiTinh, SDT, SoCMND,ViTri, Quyen from NguoiDung where ViTri like '%" + vt + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }    
}
