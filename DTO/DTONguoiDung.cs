using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_PLB03.DTO
{
    public class DTONguoiDung
    {
        private int _MaNguoiDung;
        private string _HoTen;
        private int _Tuoi;
        private string _DiaChi;
        private int _GioiTinh;
        private string _SDT;
        private string _SoCMND;
        private string _TenDangNhap;
        private string _MatKhau;
        private string _Vitri;
        private int _Quyen;

        public DTONguoiDung()
        {

        }
        public DTONguoiDung(int maNguoiDung, string hoTen, int tuoi, string diaChi, int gioiTinh, string sDT, string soCMND, string tenDangNhap, string matKhau, string vitri, int quyen)
        {
            _MaNguoiDung = maNguoiDung;
            _HoTen = hoTen;
            _Tuoi = tuoi;
            _DiaChi = diaChi;
            _GioiTinh = gioiTinh;
            _SDT = sDT;
            _SoCMND = soCMND;
            _TenDangNhap = tenDangNhap;
            _MatKhau = matKhau;
            _Vitri = vitri;
            _Quyen = quyen;
        }


        public int MaNguoiDung { get => _MaNguoiDung; set => _MaNguoiDung = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public int Tuoi { get => _Tuoi; set => _Tuoi = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public int GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string SoCMND { get => _SoCMND; set => _SoCMND = value; }
        public string TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
        public string Vitri { get => _Vitri; set => _Vitri = value; }
        public int Quyen { get => _Quyen; set => _Quyen = value; }
    }
}
