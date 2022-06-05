﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DAL;
using System.Data.SqlClient;
using System.Data;

namespace Do_An_PLB03.BUS
{
    internal class BUSDanhSachDatSan
    {   
        public static DataTable danhsach()
        {   
           DataTable dt = DALDanhSachDatSan.danhsach();
            return dt;
        }
        public static string HoTen;
        public static string SDTKhachHang;
        public static string TenSan;
        public static string LoaiSan;
        public static string NgayTra;
        public static string NgayNhan;
        public static int Gia;
        public static bool TimKiem(int MaHoaDon)
        {
            if (DALDanhSachDatSan.GetDonHang(MaHoaDon))
            {
                HoTen = DALDanhSachDatSan.HoTen;
                SDTKhachHang = DALDanhSachDatSan.SDTKhachHang;
                TenSan = DALDanhSachDatSan.TenSan;
                LoaiSan = DALDanhSachDatSan.LoaiSan;
                NgayNhan = DALDanhSachDatSan.NgayNhan;
                NgayTra = DALDanhSachDatSan.NgayTra;
                Gia = DALDanhSachDatSan.Gia;
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void NhanSan(int MaHoaDon)
        {
            int MaTrangThaiSan;
            DALDanhSachDatSan.GetDonHang(MaHoaDon);
            MaTrangThaiSan = DALDanhSachDatSan.MaTrangThaiSan;
            DALTrangThaiSan.deletetrangthai(MaTrangThaiSan);
            DALDonHang.deletedonhang(MaHoaDon);
        }
    }
}
