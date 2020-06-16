using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    
    public class SanPhamBUS
    {
        SanPhamDAO spDAO = new SanPhamDAO();
         public List<SanPhamDTO>LayDanhSachSanPham()
        {
            return spDAO.LayDSSP();
        }
        public bool ThenSanPham(SanPhamDTO SP)
        {
            return spDAO.ThemSanPham(SP);
        }
        public bool SuaSanPham(SanPhamDTO SP)
        {
            return spDAO.SuaSanPham(SP);
        }
        public bool XoaSanPham(SanPhamDTO SP)
        {
            return spDAO.XoaSanPham(SP);
        }
    }
}
