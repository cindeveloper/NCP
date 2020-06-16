using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
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
                nv.GioiTinh = reader.GetString(3);
                nv.Sdt = reader.GetString(4);
                nv.DiaChi = reader.GetString(5);
                //nv.TrangThai = reader.GetBoolean(6);
                lsNV.Add(nv);
            }
            // ...
            conn.Ngatketnoi();
            return lsNV;

        }

        public bool ThemNhanVien(NhanVienDTO TK)
        {
            try
            {
                conn.Ketnoi();
                string Query = "INSERT INTO [NCP].[dbo].[NhanVien] VALUES ('{0}',N'{1}','{2}',N'{3}',{4},'{5}',1)";
                string Sql = string.Format(Query, TK.MaNV, TK.HoTen, TK.NamSinh, TK.GioiTinh, TK.Sdt, TK.DiaChi);
                SqlCommand cmd = new SqlCommand(Sql, conn.cn);
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
        public bool CapNhatNhanVien(NhanVienDTO NV)
        {
            try
            {
                conn.Ketnoi();
                String Query = "UPDATE NhanVien SET HoTenNhanVien=N'{0}',NamSinh='{1}',GioiTinh=N'{2}',SDT={3},DiaChi=N'{4}' WHERE MaNhanVien='{5}'";
                string Sql = string.Format(Query, NV.HoTen, NV.NamSinh, NV.GioiTinh, NV.Sdt, NV.DiaChi, NV.MaNV);
                SqlCommand cmd = new SqlCommand(Sql, conn.cn);
                int count = cmd.ExecuteNonQuery();
                if(count>0)
                {
                    return true;
                }    
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Ngatketnoi();
            }
            return false;
        }
        public bool XoaNV(NhanVienDTO NV)
        {
            try
            {
                conn.Ketnoi();
                string Query ="DELETE FROM NhanVien Where MaNhanVien ='{0}'";
                string Sql = string.Format(Query, NV.MaNV);
                SqlCommand cmd = new SqlCommand(Sql, conn.cn);
                int count = cmd.ExecuteNonQuery();
                if(count>0)
                {
                    return true;

                }   
                
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Ngatketnoi();
            }
            return false;
        }
    }
}
