using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        private string maPhieu;
        private  string nhanVienLap;
        private int soLuongNhap;

        public PhieuNhapDTO()
        {

        }

        public PhieuNhapDTO(string maPhieu, string nhanVienLap, int soLuongNhap)
        {
            this.MaPhieu = maPhieu;
            this.NhanVienLap = nhanVienLap;
            this.SoLuongNhap = soLuongNhap;
        }

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string NhanVienLap { get => nhanVienLap; set => nhanVienLap = value; }
        public int SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
    } 
}
