using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Do_An_PLB03.DTO;

namespace Do_An_PLB03.DAL
{
    internal class DALTrangThaiSan
    {
        public static void DatSan(DTOTrangThaiSan trangthaisan)
        {
            SqlConnection conn = dbConnectionData.HamketNoi();
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO TrangThaiSan (TenSan ,ThoiGianBatDau,ThoiGianKetThuc,TrangThai) VALUES (@TenSan,@ThoiGianBatDau,@ThoiGianKetThuc,@TrangThai)";

            // var matrangthaisan = command.Parameters.AddWithValue("@MaTrangThaiSan", "");
            var tensan = command.Parameters.AddWithValue("@TenSan", "");
            var thoigianbatdau = command.Parameters.AddWithValue("@ThoiGianBatDau", "");
            var thoigianketthuc = command.Parameters.AddWithValue("@ThoiGianKetThuc", "");
            var trangthai = command.Parameters.AddWithValue("@TrangThai", " ");

            //matrangthaisan.Value =trangthaisan.MaTrangThaiSan ;

            tensan.Value = trangthaisan.TenSan;
            thoigianbatdau.Value = trangthaisan.ThoiGianBatDau;
            thoigianketthuc.Value = trangthaisan.ThoiGianKetThuc;
            trangthai.Value = trangthaisan.TrangThai;

            command.ExecuteNonQuery();



        }
    }

}
