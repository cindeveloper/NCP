using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        DataProvider conn = new DataProvider();
        //...
        public List<HoaDonDTO> LoadDataDAO()
        {
            List<HoaDonDTO> lsHD = new List<HoaDonDTO>();
            //...
            string query = "SELECT hd.MaHoaDon, hd.NgayLap, hd.NhanVienLap, nv.HoTenNhanVien ,hd.SDTKhach, hd.TrangThai FROM HoaDon hd, NhanVien nv WHERE hd.NhanVienLap = nv.MaNhanVien AND hd.TrangThai = 'true'";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHD = reader.GetString(0);
                hd.NgayLap = reader.GetDateTime(1);
                hd.MaNhanVienLap = reader.GetString(2);
                hd.NhanVienLap = reader.GetString(3);
                hd.SdtKhachHang = reader.GetString(4);
                hd.TrangThai = reader.GetBoolean(5);
                lsHD.Add(hd);
            }
            //...
            conn.Ngatketnoi();
            return lsHD;
        }

        public bool ThemHoaDonDAO(HoaDonDTO hd)
        {
            //...
            string query = "INSERT INTO HoaDon (MaHoaDon, NgayLap, NhanVienLap, SDTKhach) VALUES (MaHoaDon = '{0}', NgayLap = '{1}', NhanVienLap = '{2}', SDTKhach = '{3}')";
            string sql = string.Format(query, hd.MaHD, hd.NgayLap, hd.MaNhanVienLap, hd.SdtKhachHang);
            int count = conn.Insert(sql);
            if (count > 0)
            {
                return true;
            }
            //...
            return false;
        }

        public int DemTongHoaDonDAO()
        {
            //...
            string query = "SELECT COUNT(*) FROM HoaDon";
            int count = conn.GetDataScalar(query);
            //...
            return count;
        }
    }
}
