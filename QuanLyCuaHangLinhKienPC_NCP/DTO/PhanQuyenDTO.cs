using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyenDTO
    {
        private int maQuyen;
        private string tenQuyen;
        private string chiTietQuyen;

        public PhanQuyenDTO()
        {

        }

        public PhanQuyenDTO(int maQuyen, string tenQuyen, string chiTietQuyen)
        {
            this.MaQuyen = maQuyen;
            this.TenQuyen = tenQuyen;
            this.ChiTietQuyen = chiTietQuyen;
        }

        public int MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string TenQuyen { get => tenQuyen; set => tenQuyen = value; }
        public string ChiTietQuyen { get => chiTietQuyen; set => chiTietQuyen = value; }
    }
}
