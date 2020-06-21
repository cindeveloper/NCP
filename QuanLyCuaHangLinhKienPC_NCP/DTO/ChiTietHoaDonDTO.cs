using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        private string maHD;
        private int soLuongMua;
        private string maSP;
        private string tenSP;
        private Decimal giaBan;
        private int khuyenMai;
        private Decimal thanhTien;
        private bool trangThai;

        public ChiTietHoaDonDTO()
        {
        }

        public ChiTietHoaDonDTO(string maHD, int soLuongMua, string maSP, string tenSP, Decimal giaBan, int khuyenMai, Decimal thanhTien, bool trangThai)
        {
            this.MaHD = maHD;
            this.SoLuongMua = soLuongMua;
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.GiaBan = giaBan;
            this.KhuyenMai = khuyenMai;
            this.ThanhTien = thanhTien;
            this.TrangThai = trangThai;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public int SoLuongMua { get => soLuongMua; set => soLuongMua = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public Decimal GiaBan { get => giaBan; set => giaBan = value; }
        public int KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
        public Decimal ThanhTien { get => thanhTien; set => thanhTien = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
