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

            // SqlConnection conn = new SqlConnection(@"Data Source=HP-ThanhNhan\SQLEXPRESS;Initial Catalog=QLSB;User ID=sa;Password=12345678");
            //Data Source=HP-ThanhNhan\SQLEXPRESS;Initial Catalog=QLSB;User ID=sa;Password=12345678
            //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7RL4O9C2;Initial Catalog=QLSB;Integrated Security=True");
            // SqlConnection conn = new SqlConnection(@"Data Source=HP-ThanhNhan\SQLEXPRESS;Initial Catalog=QLSB;User ID=sa;Password=12345678");
            SqlConnection conn = new SqlConnection(@"Data Source =DESKTOP-L5DTBUM\SQLEXPRESS;Initial Catalog=QLSB;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4DIIGK3;Initial Catalog=QLSB;Integrated Security=True");
            return conn;
            /*khi đặt sân trạng thái đơn hàng là 1;
             * khi nhận sân trạng thái đơn hàng là 0; tao hóa đơn với trạng thái là 0
             * trả sân thì trạng thái đơn hàng là 2 ; hóa đơn trạng thái là 0(chưa thanh toán);
             * thanh toán thì đơn hàng là 2 ,hóa đơn trạng thái là 1;
             */
        }
    }
}
