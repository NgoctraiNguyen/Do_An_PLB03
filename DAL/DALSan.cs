using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;
using System.Data.SqlClient;
using System.Data;

namespace Do_An_PLB03.DAL
{
    internal class DALSan
    {
        public static List<string> loaisan= new List<string>() ;
        public static List<string> tensan= new List<string>() ;
    
        public static List<string> san(DTOSan san)
        {

            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string queryss = "select  distinct LoaiSan from San ";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = queryss;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                loaisan.Add(reader.GetString(0));

            }
           return loaisan;  

        }

        public static List<string> tensandat(DTOSan san,string tenloaisan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            string query = "select TenSan from San where LoaiSan= '"+tenloaisan+"'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {

                tensan.Add(read.GetString(0));

            }
            return tensan;
        }
    }
}
