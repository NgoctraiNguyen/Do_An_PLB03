using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_PLB03.DTO
{
    internal class DTOSan
    {
        private string _TenSan;
        private int _LoaiSan;

        public DTOSan()
        {

        }
        public DTOSan(string TenSan, int LoaiSan)
        {
            this.TenSan = TenSan;
            this.LoaiSan = LoaiSan;

        }

        public string TenSan { get => _TenSan; set => _TenSan = value; }
        public int LoaiSan { get => _LoaiSan; set => _LoaiSan = value; }
    }
}
