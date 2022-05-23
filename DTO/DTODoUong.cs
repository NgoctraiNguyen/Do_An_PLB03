using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_PLB03.DTO
{
    public class DTODoUong
    {
        private int _MaDoUong;
        private string _TenDoUong;
        private int _SoLuong;
        private int _GiaBan;
        private int _GiaGoc;

        public DTODoUong()
        {

        }
        public DTODoUong(int maDoUong, string tenDoUong, int soLuong, int giaBan, int giaGoc)
        {
            _MaDoUong = maDoUong;
            _TenDoUong = tenDoUong;
            _SoLuong = soLuong;
            _GiaBan = giaBan;
            _GiaGoc = giaGoc;
        }

        public DTODoUong(string tenDoUong, int soLuong, int giaBan, int giaGoc)
        {
            _TenDoUong = tenDoUong;
            _SoLuong = soLuong;
            _GiaBan = giaBan;
            _GiaGoc = giaGoc;
        }

        public int MaDoUong { get => _MaDoUong; set => _MaDoUong = value; }
        public string TenDoUong { get => _TenDoUong; set => _TenDoUong = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public int GiaGoc { get => _GiaGoc; set => _GiaGoc = value; }
    }
}
