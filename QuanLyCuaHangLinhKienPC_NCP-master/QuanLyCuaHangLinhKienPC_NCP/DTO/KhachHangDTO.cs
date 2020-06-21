using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string sdt;
        private string hoTen;
        private string diaChi;
        private bool trangThai;

        public KhachHangDTO()
        {
        }
        public KhachHangDTO(string sdt, string hoTen, string diaChi)
        {
            this.sdt = sdt;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
        }
        public KhachHangDTO(string sdt)
        {
            this.sdt = sdt;
        }

        public string Sdt { get => sdt; set => sdt = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
