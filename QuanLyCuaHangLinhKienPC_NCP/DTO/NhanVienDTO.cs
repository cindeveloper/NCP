using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maNV;
        private string hoTen;
        private DateTime namSinh;
        private bool gioiTinh;
        private string sdt;
        private string diaChi;
        private bool trangThai;

        public NhanVienDTO()
        {
        }

        public NhanVienDTO(string maNV, string hoTen, DateTime namSinh, bool gioiTinh, string sdt, string diaChi, bool trangThai)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.GioiTinh = gioiTinh;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.trangThai = trangThai;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}