using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        DataProvider conn = new DataProvider();
        NhanVienDTO nv = new NhanVienDTO();

        public List<NhanVienDTO> loadDataDAO()
        {
            List<NhanVienDTO> lsNV = new List<NhanVienDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT * FROM NhanVien WHERE TrangThai = 'True'";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = reader.GetString(0);
                nv.HoTen = reader.GetString(1);
                nv.NamSinh = reader.GetDateTime(2);
                nv.GioiTinh = reader.GetBoolean(3);
                nv.Sdt = reader.GetString(4);
                nv.DiaChi = reader.GetString(5);
                nv.TrangThai = reader.GetBoolean(6);
                lsNV.Add(nv);
            }
            // ...
            conn.Ngatketnoi();
            return lsNV;
        }

        public NhanVienDTO TimKiemNVDAO(string tenTK)
        {
            string query = "SELECT nv.MaNhanVien, nv.HoTenNhanVien FROM NhanVien nv, TaiKhoan tk WHERE tk.TenTaiKhoan = '{0}' AND  nv.MaNhanVien = tk.MaNhanVien";
            string sql = string.Format(query, tenTK);
            SqlDataReader reader = conn.getdata(sql);
            NhanVienDTO nv = new NhanVienDTO();
            while (reader.Read())
            {
                nv.MaNV = reader.GetString(0);
                nv.HoTen = reader.GetString(1);
            }
            conn.Ngatketnoi();
            return nv;
        }
    }
}
