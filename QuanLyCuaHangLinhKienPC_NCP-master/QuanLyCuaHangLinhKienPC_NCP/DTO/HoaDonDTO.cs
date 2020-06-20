using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private string maHD;
        private DateTime ngayLap;
        private string maNhanVienLap;
        private string nhanVienLap;
        private string sdtKhachHang;
        private bool trangThai;

        public HoaDonDTO()
        {
        }

        public HoaDonDTO(string maHD, DateTime ngayLap, string nhanVienLap, string sdtKhachHang)
        {
            this.MaHD = maHD;
            this.NgayLap = ngayLap;
            this.NhanVienLap = nhanVienLap;
            this.SdtKhachHang = sdtKhachHang;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string NhanVienLap { get => nhanVienLap; set => nhanVienLap = value; }
        public string SdtKhachHang { get => sdtKhachHang; set => sdtKhachHang = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string MaNhanVienLap { get => maNhanVienLap; set => maNhanVienLap = value; }
    }
}
