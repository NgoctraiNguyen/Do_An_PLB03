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
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=QLSB;User ID=sa;Password=12345678");
            return conn;
            //het noi localhost
        }
    }
}
