using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
        public List<TaiKhoanDTO>LayDSTK()
        {
            return tkDao.LayDSTK();
        }
        public List<TaiKhoanDTO>TimKiemNhanh(string value)
        {
            return tkDao.TimKiemTaiKhoan(value);
        }
        public bool XoaTK(TaiKhoanDTO tk)
        {
            return tkDao.XoaTK(tk);
        }
    }
}
