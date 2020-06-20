using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO cthdDAO = new ChiTietHoaDonDAO();
        //...
        public List<ChiTietHoaDonDTO> loadDataBUS(string maHD)
        {
            return cthdDAO.loadDataDAO(maHD);
        }
    }
}
