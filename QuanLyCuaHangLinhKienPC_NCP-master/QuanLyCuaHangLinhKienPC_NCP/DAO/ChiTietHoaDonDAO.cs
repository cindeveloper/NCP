using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        DataProvider conn = new DataProvider();

        public List<ChiTietHoaDonDTO> loadDataDAO(string maHD)
        {
            List<ChiTietHoaDonDTO> lsCTHD = new List<ChiTietHoaDonDTO>();
            conn.Ketnoi();
            //...
            string query = "SELECT ct.MaSP, sp.TenSanPham, sp.GiaBan, ct.SoLuongMua, sp.KhuyenMai, ((sp.GiaBan*ct.SoLuongMua)*(100-sp.KhuyenMai)/100) N'Thành tiền', ct.TrangThai FROM HoaDon hd, ChiTietHoaDon ct, SanPham sp WHERE ct.MaHoaDon = '{0}' AND ct.MaSP = sp.MaSanPham";
            string sql = string.Format(query, maHD);
            SqlDataReader reader = conn.getdata(sql);
            while (reader.Read())
            {
                ChiTietHoaDonDTO ct = new ChiTietHoaDonDTO();
                ct.MaHD = maHD;
                ct.MaSP = reader.GetString(0);
                ct.TenSP = reader.GetString(1);
                ct.GiaBan = reader.GetDecimal(2);
                ct.SoLuongMua = reader.GetInt32(3);
                ct.KhuyenMai = reader.GetInt32(4);
                ct.ThanhTien = reader.GetDecimal(5);
                ct.TrangThai = reader.GetBoolean(6);
                lsCTHD.Add(ct);
            }
            //...
            conn.Ngatketnoi();
            return lsCTHD;
        }
    }
}
