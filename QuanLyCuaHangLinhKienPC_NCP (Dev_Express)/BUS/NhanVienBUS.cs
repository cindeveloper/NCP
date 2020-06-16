using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nvDAO = new NhanVienDAO();

        public List<NhanVienDTO> loadDataBUS()
        {
            return nvDAO.loadDataDAO();
        }
        public bool ThemNhanVien(NhanVienDTO NV)
        {
            return nvDAO.ThemNhanVien(NV);
        }
        public bool CapNhapNhanVien(NhanVienDTO NV)
        {
            return nvDAO.CapNhatNhanVien(NV);
        }
        public bool XoaNhanVien(NhanVienDTO NV)
        {
            return nvDAO.XoaNV(NV);
        }
    }
}
