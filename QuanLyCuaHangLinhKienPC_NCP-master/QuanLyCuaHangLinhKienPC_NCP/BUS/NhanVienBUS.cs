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
        public NhanVienDTO TimKiemNVBUS(string tenTK)
        {
            return nvDAO.TimKiemNVDAO(tenTK);
        }
    }
}
