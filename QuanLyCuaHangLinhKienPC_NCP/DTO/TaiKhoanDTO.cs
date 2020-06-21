using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaNhanVien { get; set; }
        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public bool TrangThai { get; set; }

        public TaiKhoanDTO(string tenTaiKhoan, string matKhau, string maNhanVien, int maQuyen)
        {
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
            MaNhanVien = maNhanVien;
            MaQuyen = maQuyen;
           // TenQuyen = tenQuyen;
        }

        public TaiKhoanDTO()
        {
        }

    }
}
