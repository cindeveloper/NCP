using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPhamDTO
    {
        private string maLoai;
        private string menLoai;
        private bool trangThai;

        public LoaiSanPhamDTO()
        {
        }

        public LoaiSanPhamDTO(string maLoai, string menLoai, bool trangThai)
        {
            this.MaLoai = maLoai;
            this.MenLoai = menLoai;
            this.TrangThai = trangThai;
        }

        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string MenLoai { get => menLoai; set => menLoai = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
