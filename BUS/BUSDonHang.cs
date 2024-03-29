﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;
using Do_An_PLB03.DAL;


namespace Do_An_PLB03.BUS
{
    internal class BUSDonHang
    {
        public static void donhang(DTODonHang donhang)
        {
            DALDonHang.donhang(donhang);
        }
        public static void deletedonhang(int madonhang)
        {
            DALDonHang.deletedonhang(madonhang);
        }
        public static int GetTongTien(int madonhang)
        {
            return DALDonHang.GetTongTien(madonhang);
        }
        public static string GetTenSan(int madonhang)
        {
            return DALDonHang.GetTenSan(madonhang);
        }
        public static void TraSan(int madonhang)
        {
            DALDonHang.TraSan(madonhang);
        }
        public static void UpdateTongTien(int madonhang, int tongtien)
        {
            DALDonHang.updateTongTien(madonhang,tongtien);
        }
    }
}
