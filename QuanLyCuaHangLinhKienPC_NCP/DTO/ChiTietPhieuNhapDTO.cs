using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        public string MaPhieu { get; set; }
        public string MaNCC { get; set; }
        public string MaSP { get; set; }
        public int SoLuongNhap { get; set; }
    }
}
