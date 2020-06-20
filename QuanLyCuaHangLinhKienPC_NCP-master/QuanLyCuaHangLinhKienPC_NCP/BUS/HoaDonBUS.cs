using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hdDAO = new HoaDonDAO();
        //...
        public List<HoaDonDTO> LoadDataBUS()
        {
            return hdDAO.LoadDataDAO();
        }

        public bool ThemHoaDonBUS(HoaDonDTO hd)
        {
            return hdDAO.ThemHoaDonDAO(hd);
        }

        public int DemTongHDBUS()
        {
            return hdDAO.DemTongHoaDonDAO();
        }
    }
}
