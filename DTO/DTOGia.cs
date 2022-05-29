using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_PLB03.DTO
{
    internal class DTOGia
    {
        private int _MaGiaSan;
        private int _LoaiSan;
        private DateTime _ThoiGianBatDau;
        private DateTime _ThoiGianKetThuc;
        private int _GiaTheoGio;

        public DTOGia() { }
        public DTOGia(int MaGiaSan, int LoaiSan, DateTime ThoiGianBatDau, DateTime ThoiGianKetThuc, int GiaTheoGio)
        {
            this.MaGiaSan = MaGiaSan;
            this.LoaiSan = LoaiSan;
            this.ThoiGianBatDau = ThoiGianBatDau;
            this.ThoiGianKetThuc = ThoiGianKetThuc;
            this.GiaTheoGio = GiaTheoGio;
        }


        public int MaGiaSan { get => _MaGiaSan; set => _MaGiaSan = value; }
        public int LoaiSan { get => _LoaiSan; set => _LoaiSan = value; }
        public DateTime ThoiGianBatDau { get => _ThoiGianBatDau; set => _ThoiGianBatDau = value; }
        public DateTime ThoiGianKetThuc { get => _ThoiGianKetThuc; set => _ThoiGianKetThuc = value; }
        public int GiaTheoGio { get => _GiaTheoGio; set => _GiaTheoGio = value; }
    }
}
