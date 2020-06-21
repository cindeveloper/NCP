using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO tkDao = new TaiKhoanDAO();
        public TaiKhoanDTO checkQuyen(TaiKhoanDTO TK)
        {
            return tkDao.KiemTraQuyen(TK);
        }
        public bool ThemTaiKhoan(TaiKhoanDTO TK)
        {
            return tkDao.ThemTaiKhoan(TK);
        }
    }
}
