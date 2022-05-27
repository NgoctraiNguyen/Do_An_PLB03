using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_PLB03.DTO
{
    internal class DTOTrangThaiSan
    {

        private int _MaTrangThaiSan;
        private string _TenSan;
        private DateTime _ThoiGianBatDau;
        private DateTime _ThoiGianKetThuc;
        private int _TrangThai;

        public DTOTrangThaiSan()
        {

        }
        public DTOTrangThaiSan(int MaTrangThaiSan, string TenSan, DateTime ThoiGianBatDau, DateTime ThoiGianKetThuc, int TrangThai)
        {
            this.MaTrangThaiSan = MaTrangThaiSan;
            this.TenSan = TenSan;
            this.ThoiGianBatDau = ThoiGianBatDau;
            this.ThoiGianKetThuc = ThoiGianKetThuc;
            this.TrangThai = TrangThai;

        }

        public int MaTrangThaiSan { get => _MaTrangThaiSan; set => _MaTrangThaiSan = value; }
        public string TenSan { get => _TenSan; set => _TenSan = value; }
        public DateTime ThoiGianBatDau { get => _ThoiGianBatDau; set => _ThoiGianBatDau = value; }
        public DateTime ThoiGianKetThuc { get => _ThoiGianKetThuc; set => _ThoiGianKetThuc = value; }
        public int TrangThai { get => _TrangThai; set => _TrangThai = value; }
    }
}
