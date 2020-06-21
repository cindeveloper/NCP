using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO()
        {
        }

        public KhachHangDTO(string sdt)
        {
            this.SDT = sdt;
        }

        public KhachHangDTO(string maKH, string sDT, string hoTenKH, string diaChi, bool trangThai)
        {
            MaKH = maKH;
            SDT = sDT;
            HoTenKH = hoTenKH;
            DiaChi = diaChi;
            TrangThai = trangThai;
        }

        public string MaKH { get; set; }
        public string SDT { get; set; }
        public string HoTenKH { get; set; }
        public string DiaChi { get; set; }
        public bool TrangThai { get; set; }
    }
}
