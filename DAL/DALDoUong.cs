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
    }
}
