using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_PLB03.DTO
{
    internal class DTODonHang
    {
        private int _MaDonHang;
        private int _MaTrangThaiSan;
        private DateTime _NgayGioTao;
        private int _MaKhachHang;
        private int _TrangThai;
        private int _TongTienSan;

        public DTODonHang() { }
        public DTODonHang(int MaDonHang, int MaTrangThaiSan, DateTime NgayGioTao ,int MakhachHang,int TrangThai, int TongTienSan)
        {
           this.MaDonHang = MaDonHang;
            this.MaTrangThaiSan= MaTrangThaiSan;
            this.NgayGioTao = NgayGioTao;
            MaKhachHang = MakhachHang;
            this.TrangThai = TrangThai;
            this.TongTienSan = TongTienSan;
        }

        public int MaDonHang { get => _MaDonHang; set => _MaDonHang = value; }

        public int MaTrangThaiSan { get => _MaTrangThaiSan; set => _MaTrangThaiSan = value; }
        public DateTime NgayGioTao { get => _NgayGioTao; set => _NgayGioTao = value; }
        public int MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public int TrangThai { get => _TrangThai; set => _TrangThai = value; }
        public int TongTienSan { get => _TongTienSan; set => _TongTienSan = value; }
    }
}
