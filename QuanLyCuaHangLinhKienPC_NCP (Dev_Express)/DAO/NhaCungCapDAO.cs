using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    
   public  class NhaCungCapDAO
    {
        DataProvider con = new DataProvider();
        public List<NhaCungCapDTO>LoadDSNCC()
        {
            List<NhaCungCapDTO> NhaCungCaps = new List<NhaCungCapDTO>();
            string Query = "SELECT * FROM NhaCungCap WHERE TrangThai='True'";
            SqlDataReader reader = con.getdata(Query);
            while(reader.Read())
            {
                NhaCungCapDTO NCC = new NhaCungCapDTO();
                NCC.MaNCC = reader.GetString(0);
                NCC.TenNCC = reader.GetString(1);
                NhaCungCaps.Add(NCC);
            }
            return NhaCungCaps;
        }

        public bool ThemNCC(NhaCungCapDTO NCC)
        {

            try
            {
                con.Ketnoi();
                string Query = string.Format("INSERT INTO [NCP].[dbo].[NhaCungCap] VALUES('{0}',N'{1}',1)",NCC.MaNCC,NCC.TenNCC);
                SqlCommand cmd = new SqlCommand(Query, con.cn);
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
                con.Ngatketnoi();
            }
            return false;
        }
        public bool XoaNCC(NhaCungCapDTO NCC)
        {
            try
            {
                con.Ketnoi();
                string Query = string.Format("DELETE FROM NhaCungCap Where NhaCungCap='{0}'",NCC.MaNCC);
                SqlCommand cmd = new SqlCommand(Query, con.cn);
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
                con.Ngatketnoi();
            }
            return false;
        }

        public bool CapNhapNCC(NhaCungCapDTO NCC)
        {
            try
            {
                con.Ketnoi();
                string Query =string.Format( "UPDATE NhaCungCap SET TenNCC=N'{0}' WHERE NhaCungCap='{1}'",NCC.TenNCC,NCC.MaNCC);
                SqlCommand cmd = new SqlCommand(Query, con.cn);
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
                con.Ngatketnoi();
            }
            return false;
        }
        public List<NhaCungCapDTO>TimKiemNCC()
        {
            return null;
        }
    }
    
   
    
}
