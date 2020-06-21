using System;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public decimal GiaGoc { get; set; }
        public decimal GiaBan { get; set; }
        public int SLT { get; set; }
        public DateTime BaoHanh { get; set; }
        public int KM { get; set; }
        public string MaNCC { get; set; }
        public int TrangThai { get; set; }
        public string XuatXu { get; set; }
        public DateTime NgayNhap { get; set; }
        public SanPhamDTO()
        {

        }
        public SanPhamDTO(string MaSanPham, string TenSanPham, string Loai, decimal Giagoc, decimal Giaban, int SL, DateTime BH, int KMai, string NCC, string XXu)
        {
            MaSP = MaSanPham;
            TenSP = TenSanPham;
            LoaiSP = Loai;
            GiaGoc = Giagoc;
            GiaBan = Giaban;
            SLT = SL;
            BaoHanh = BH;
            KM = KMai;
            MaNCC = NCC;
            XuatXu = XXu;

        }
    }
}
