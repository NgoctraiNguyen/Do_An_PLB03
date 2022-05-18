using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Do_An_PLB03.DAL
{
    public class dbConnectionData
    {
        public static SqlConnection HamketNoi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L5DTBUM\SQLEXPRESS;Initial Catalog=QLSB;Integrated Security=True");
            return conn;
        }
    }
}
