using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoHanhDTO
    {
        private string sdt;
        private string maHoaDon;
        private DateTime ngayLapHD;
        private string maSanPham;
        private string tenSanPham;
        private int soLuong;
        private int khuyenMai;
        private decimal thanhTien;
        private DateTime thoihanBaoHanh;

        public BaoHanhDTO()
        {

        }

        public BaoHanhDTO(string sdt, string maHoaDon, DateTime ngayLapHD, string maSanPham, string tenSanPham, int soLuong, int khuyenMai, decimal thanhTien, DateTime thoihanBaoHanh)
        {
            this.sdt = sdt;
            this.maHoaDon = maHoaDon;
            this.ngayLapHD = ngayLapHD;
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.soLuong = soLuong;
            this.khuyenMai = khuyenMai;
            this.thanhTien = thanhTien;
            this.thoihanBaoHanh = thoihanBaoHanh;
        }


        public string Sdt { get => sdt; set => sdt = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public DateTime NgayLapHD { get => ngayLapHD; set => ngayLapHD = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
        public decimal ThanhTien { get => thanhTien; set => thanhTien = value; }
        public DateTime ThoiHanBaoHanh { get => thoihanBaoHanh; set => thoihanBaoHanh = value; }
    }
}
