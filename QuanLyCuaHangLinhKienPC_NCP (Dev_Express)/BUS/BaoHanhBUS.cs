using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class BaoHanhBUS
    {
        BaoHanhDAO bhDAO = new BaoHanhDAO();
        public List<BaoHanhDTO> layDSBHBus()
        {
            return bhDAO.layDSBHDao();
        }
        public List<BaoHanhDTO> timKiemNhanhBus(string value)
        {
            return bhDAO.timKiemNhanhDao(value);
        }
    }
}
