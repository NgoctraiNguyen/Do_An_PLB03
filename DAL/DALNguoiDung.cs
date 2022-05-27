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

    }    
}
