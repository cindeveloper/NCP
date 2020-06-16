using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class NhaCungCapDTO
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public bool TrangThai { get; set; }

        public NhaCungCapDTO(string maNCC, string tenNCC)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
        }

        public NhaCungCapDTO()
        {
        }
    }
   
}
 