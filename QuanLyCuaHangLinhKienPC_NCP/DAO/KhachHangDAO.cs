using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        DataProvider conn = new DataProvider();
        KhachHangDTO kh = new KhachHangDTO();
        // ...
        public List<KhachHangDTO> layDSKHDao()
        {
            List<KhachHangDTO> dsKH = new List<KhachHangDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT * FROM KhachHang WHERE TrangThai='True'";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.SDT = reader.GetString(0);
                kh.HoTenKH = reader.GetString(1);
                kh.DiaChi = reader.GetString(2);
                kh.TrangThai = reader.GetBoolean(3);
                dsKH.Add(kh);
            }
            conn.Ngatketnoi();
            return dsKH;
        }
        public bool themKHDao(KhachHangDTO kh)
        {
            try
            {
                conn.Ketnoi();
                string query = "INSERT INTO KhachHang (SDT, HoTenKhachHang, DiaChi) VALUES ('{0}',N'{1}',N'{2}')";
                string sql = string.Format(query, kh.SDT, kh.HoTenKH, kh.DiaChi);
                SqlCommand cmd = new SqlCommand(sql, conn.cn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                conn.Ngatketnoi();
            }
            return false;
        }

        public bool capNhatKHDao(KhachHangDTO kh)
        {
            try
            {
                conn.Ketnoi();
                string query = "UPDATE KhachHang SET HotenKhachHang=N'{0}',DiaChi=N'{1}' WHERE SDT='{2}'";
                string sql = string.Format(query, kh.HoTenKH, kh.DiaChi, kh.SDT);
                SqlCommand cmd = new SqlCommand(sql, conn.cn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Ngatketnoi();
            }
            return false;
        }

        public bool xoaKHDao(KhachHangDTO kh)
        {
            try
            {
                conn.Ketnoi();
                string query = "UPDATE KhachHang SET TrangThai='False' WHERE SDT='{0}'";
                string sql = string.Format(query, kh.SDT);
                SqlCommand cmd = new SqlCommand(sql, conn.cn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Ngatketnoi();
            }
            return false;
        }
        public List<KhachHangDTO> timKiemNhanhDao(string value)
        {
            List<KhachHangDTO> dsKH = new List<KhachHangDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT * FROM KhachHang WHERE (SDT like '{0}%' OR HoTenKhachHang like N'{1}%' OR DiaChi like N'{2}%') AND TrangThai='True'";
            string sql = string.Format(query, value, value, value);
            SqlDataReader reader = conn.getdata(sql);
            while (reader.Read())
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.SDT = reader.GetString(0);
                kh.HoTenKH = reader.GetString(1);
                kh.DiaChi = reader.GetString(2);
                kh.TrangThai = reader.GetBoolean(3);
                dsKH.Add(kh);
            }
            conn.Ngatketnoi();
            return dsKH;
        }
    }
}
