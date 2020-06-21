using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khDAO = new KhachHangDAO();

        public List<KhachHangDTO> layDSKHBus()
        {
            return khDAO.layDSKHDao();
        }

        public bool capNhatKHBus(KhachHangDTO kh)
        {
            return khDAO.capNhatKHDao(kh);
        }
        public bool themKHBus(KhachHangDTO kh)
        {
            return khDAO.themKHDao(kh);
        }
        public bool xoaKHBus(KhachHangDTO kh)
        {
            return khDAO.xoaKHDao(kh);
        }

        public List<KhachHangDTO> timKiemNhanhBus(string value)
        {
            return khDAO.timKiemNhanhDao(value);
        }
    }
}
