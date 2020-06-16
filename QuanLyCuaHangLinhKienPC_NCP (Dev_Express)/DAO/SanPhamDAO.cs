using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
   public  class SanPhamDAO
    {
        
        DataProvider con = new DataProvider();
        public List<SanPhamDTO>LayDSSP()
        {
            List<SanPhamDTO> SanPhams = new List<SanPhamDTO>();// Tao List
            String Query = "SELECT sp.MaSanPham, sp.TenSanPham, sp.LoaiSanPham, sp.GiaGoc, sp.GiaBan, sp.SoLuongTon, sp.BaoHanh, sp.KhuyenMai,sp.MaNCC, sp.XuatXu, pn.NgayNhap FROM SanPham sp, PhieuNhap pn WHERE sp.MaNCC = pn.MaNCC";
            SqlDataReader reader = con.getdata(Query);
            while(reader.Read())
            {
                SanPhamDTO SP = new SanPhamDTO();
                SP.MaSP = reader.GetString(0);
                SP.TenSP = reader.GetString(1);
                SP.LoaiSP = reader.GetString(2);
                SP.GiaGoc = Math.Round(reader.GetDecimal(3));
                SP.GiaBan = Math.Round(reader.GetDecimal(4));
                SP.SLT = reader.GetInt32(5);
                SP.BaoHanh = reader.GetDateTime(6);
                SP.KM = reader.GetInt32(7);
                SP.MaNCC = reader.GetString(8);
                //SP.TrangThai = reader.GetInt32(9);
                SP.XuatXu = reader.GetString(9);
                SP.NgayNhap = reader.GetDateTime(10);
                SanPhams.Add(SP);

            }   
            return SanPhams;
        }

        // Thêm san Pham
        public bool ThemSanPham(SanPhamDTO sp)
        {
            try
            {
                con.Ketnoi();
                string sql = "INSERT INTO [NCP].[dbo].[SanPham] VALUES ('{0}',N'{1}',N'{2}',{3},{4},{5},'{6}',{7},'{8}',N'{9}',1)";
                string Query = string.Format(sql, sp.MaSP, sp.TenSP, sp.LoaiSP, sp.GiaGoc, sp.GiaBan, sp.SLT, sp.BaoHanh, sp.KM, sp.MaNCC, sp.XuatXu);
               SqlCommand cmd = new SqlCommand(Query, con.cn);
                int count = cmd.ExecuteNonQuery();
                if (count>0)
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
        public bool SuaSanPham(SanPhamDTO sp)
        {
            try
            {
                con.Ketnoi();
                string Query = string.Format("UPDATE SanPham SET TenSanPham=N'{0}',LoaiSanPham=N'{1}',GiaGoc={2}, GiaBan={3}, SoLuongTon={4},BaoHanh='{5}',KhuyenMai={6},MaNCC='{7}',XuatXu=N'{8}' WHERE MaSanPham='{9}'",sp.TenSP,sp.LoaiSP,sp.GiaGoc,sp.GiaBan,sp.SLT,sp.BaoHanh,sp.KM,sp.MaNCC,sp.XuatXu,sp.MaSP);
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
        public bool XoaSanPham(SanPhamDTO SP)
        {
            try
            {
                con.Ketnoi();
                string Query = string.Format("Delete From SanPham where MaSanPham='{0}'", SP.MaSP);
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
    }
}
