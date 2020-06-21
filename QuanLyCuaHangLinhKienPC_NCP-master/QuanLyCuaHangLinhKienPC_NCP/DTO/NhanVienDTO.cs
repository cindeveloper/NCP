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
        private string maChucVu;
        private string hoTenNV;
        private bool gioiTinh;
        private DateTime ngaySinh;
        private string sdtNV;
        private string diaChi;
        private bool trangThai;

        public NhanVienDTO()
        {

        }

        public NhanVienDTO(string maNV, string maChucVu, string hoTenNV, bool gioiTinh, DateTime ngaySinh, string sdtNV, string diaChi, bool trangThai)
        {
            this.MaNV = maNV;
            this.MaChucVu = maChucVu;
            this.HoTenNV = hoTenNV;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.SdtNV = sdtNV;
            this.DiaChi = diaChi;
            this.TrangThai = trangThai;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SdtNV { get => sdtNV; set => sdtNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}