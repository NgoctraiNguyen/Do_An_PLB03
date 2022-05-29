using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_PLB03.DTO
{
    internal class DTOKhachHang
    {
        private int _MaKhachHang;
        private string _TenKhachHang;
        private string _SDTKhachHang;

        public DTOKhachHang() { }
        public DTOKhachHang(int MaKhachHang, string TenKhachHang, string SDTKhachHang)
        {
            this.MaKhachHang = MaKhachHang;
            this.TenKhachHang = TenKhachHang;
            this.SDTKhachHang = SDTKhachHang;

        }

        public int MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public string TenKhachHang { get => _TenKhachHang; set => _TenKhachHang = value; }
        public string SDTKhachHang { get => _SDTKhachHang; set => _SDTKhachHang = value; }
    }
}
