using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_PLB03.DTO
{
    internal class DTOHoaDon
    {
        private int _MaHoaDon;
        private DateTime _NgayGioTao;
        private int _TongTien;
        private int _MaNguoiDung;
        private int _MaDonHang;
        private int _TrangThai;

        public DTOHoaDon() { }
        public DTOHoaDon(int MaHoaDon, DateTime NgayGioTao, int TongTien, int MaNguoiDung, int MaDonHang, int TrangThai )
        {
            this.MaHoaDon = MaHoaDon;
            this.NgayGioTao = NgayGioTao;
            this.TongTien = TongTien;
            this.MaNguoiDung = MaNguoiDung;
            this.MaDonHang = MaDonHang;
            this.TrangThai = TrangThai;
        }

        public int MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
        public DateTime NgayGioTao { get => _NgayGioTao; set => _NgayGioTao = value; }
        public int TongTien { get => _TongTien; set => _TongTien = value; }
        public int MaNguoiDung { get => _MaNguoiDung; set => _MaNguoiDung = value; }
        public int MaDonHang { get => _MaDonHang; set => _MaDonHang = value; }
        public int TrangThai { get => _TrangThai; set => _TrangThai = value; }  
    }
}
