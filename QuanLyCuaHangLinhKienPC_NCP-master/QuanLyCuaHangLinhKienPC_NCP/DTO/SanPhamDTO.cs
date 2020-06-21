﻿using System;
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
        private bool trangThai;

        public SanPhamDTO()
        {

        }

        public SanPhamDTO(string maSP, string tenSP, string maLoai, decimal giaGoc, decimal giaBan, int soLuongTon, int khuyenMai, bool trangThai)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.MaLoai = maLoai;
            this.GiaGoc = giaGoc;
            this.GiaBan = giaBan;
            this.SoLuongTon = soLuongTon;
            this.KhuyenMai = khuyenMai;
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
    }
}
