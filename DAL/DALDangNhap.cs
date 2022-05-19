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
        public static int KiemTraDangNhap(DTONguoiDung user)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DangNhap";
            command.Connection = conn;

            command.Parameters.AddWithValue("@user", user.TenDangNhap);
            command.Parameters.AddWithValue("@pass", user.MatKhau);

            object o = command.ExecuteScalar();
            int code = Convert.ToInt32(o);
            return code;
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
