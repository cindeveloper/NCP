using DTO;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
     public class BaoHanhDAO
    {
        DataProvider conn = new DataProvider();
        BaoHanhDTO bh = new BaoHanhDTO();

        public List<BaoHanhDTO> layDSBHDao()
        {
            List<BaoHanhDTO> dsBH = new List<BaoHanhDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT SDTKhach,ct.MaHoaDon,hd.NgayLap,MaSanPham,TenSanPham,SoLuongMua,KhuyenMai,ThanhTien=ct.SoLuongMua*sp.GiaBan,BaoHanh FROM HoaDon hd, SanPham sp, ChiTietHoaDon ct WHERE hd.MaHoaDon = ct.MaHoaDon and ct.MaSP = sp.MaSanPham and sp.MaSanPham = ct.MaSP";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                BaoHanhDTO bh = new BaoHanhDTO();
                bh.Sdt= reader.GetString(0);
                bh.MaHoaDon = reader.GetString(1);
                bh.NgayLapHD = reader.GetDateTime(2);
                bh.MaSanPham = reader.GetString(3);
                bh.TenSanPham = reader.GetString(4);
                bh.SoLuong = reader.GetInt32(5);
                bh.KhuyenMai = reader.GetInt32(6);
                bh.ThanhTien = reader.GetDecimal(7);
                bh.ThoiHanBaoHanh = reader.GetDateTime(8);
                dsBH.Add(bh);
            }
            conn.Ngatketnoi();
            return dsBH;
        }

        public List<BaoHanhDTO> timKiemNhanhDao(string value)
        {
            List<BaoHanhDTO> dsBH = new List<BaoHanhDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT SDTKhach,ct.MaHoaDon,hd.NgayLap,MaSanPham,TenSanPham,SoLuongMua,KhuyenMai,ThanhTien=ct.SoLuongMua*sp.GiaBan,BaoHanh FROM HoaDon hd, SanPham sp, ChiTietHoaDon ct WHERE(SDTKhach like '{0}%' OR ct.MaHoaDon like N'{1}%' OR hd.NgayLap like '{2}%' OR MaSanPham like N'{3}%' OR TenSanPham like N'{4}%' OR SoLuongMua like '{5}%' OR KhuyenMai like '{6}%' OR BaoHanh like '{7}%')";
            string sql = string.Format(query, value, value,value,value,value, value,value,value);
            SqlDataReader reader = conn.getdata(sql);
            while (reader.Read())
            {
                BaoHanhDTO bh = new BaoHanhDTO();
                bh.Sdt = reader.GetString(0);
                bh.MaHoaDon = reader.GetString(1);
                bh.NgayLapHD = reader.GetDateTime(2);
                bh.MaSanPham = reader.GetString(3);
                bh.TenSanPham = reader.GetString(4);
                bh.SoLuong = reader.GetInt32(5);
                bh.KhuyenMai = reader.GetInt32(6);
                bh.ThanhTien = reader.GetDecimal(7);
                bh.ThoiHanBaoHanh = reader.GetDateTime(8);
                dsBH.Add(bh);
            }
            conn.Ngatketnoi();
            return dsBH;
        }
    }

}
