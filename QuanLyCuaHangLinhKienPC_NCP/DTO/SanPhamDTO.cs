using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        private string maSP;
        private string tenSP;
        private string maLoai;
        private decimal giaGoc;
        private decimal giaBan;
        private int soLuongTon;
        private int khuyenMai;
        private string maNCC;
        private string tenNCC;
        private string xuatXu;
        private bool trangThai;
        private string TenLoai;
        private DateTime ngayNhap;

        public SanPhamDTO()
        {

        }

        public SanPhamDTO(string maSP, string tenSP, string maLoai, decimal giaGoc, decimal giaBan, int soLuongTon, int khuyenMai,string XuaXu)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.MaLoai = maLoai;
            this.GiaGoc = giaGoc;
            this.GiaBan = giaBan;
            this.SoLuongTon = soLuongTon;
            this.KhuyenMai = khuyenMai;
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.XuaXu = XuaXu;
            this.TrangThai = trangThai;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public decimal GiaGoc { get => giaGoc; set => giaGoc = value; }
        public decimal GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public int KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string XuaXu { get => xuatXu; set => xuatXu = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string TenLoai1 { get => TenLoai; set => TenLoai = value; }
    }
}
