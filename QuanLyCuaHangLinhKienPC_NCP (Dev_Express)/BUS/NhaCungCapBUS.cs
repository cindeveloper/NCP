using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    
    public class NhaCungCapBUS
    {
        NhaCungCapDAO NCCDAO = new NhaCungCapDAO();
        public List<NhaCungCapDTO>LoadDSNCC()
        {
            return NCCDAO.LoadDSNCC();
        }
        public bool ThemNCC (NhaCungCapDTO NCC)
        {
            return NCCDAO.ThemNCC(NCC);
        }
        public bool XoaNCC (NhaCungCapDTO NCC)
        {
            return NCCDAO.XoaNCC(NCC);
        }
        public bool CapNhatNCC(NhaCungCapDTO NCC)
        {
            return NCCDAO.CapNhapNCC(NCC);
        }
    }
}
