﻿using System;
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
            String Query = "SELECT SP.MaSP,SP.TenSP,L.TenLoai,SP.GiaGoc,SP.GiaBan,SP.SoLuongTon,SP.KhuyenMai,NCC.TenNCC,SP.XuatXu,Pn.NgayNhap FROM SanPham SP ,NhaCungCap NCC, PhieuNhap PN,ChiTietPhieuNhap CT, LoaiSanPham L where SP.MaSP = CT.MaSP  and NCC.MaNCC = CT.MaNCC and SP.MaLoai = L.MaLoai and SP.TrangThai='True' ";
            SqlDataReader reader = con.getdata(Query);
            while(reader.Read())
            {
                SanPhamDTO SP = new SanPhamDTO();
                SP.MaSP = reader.GetString(0);
                SP.TenSP = reader.GetString(1);
                SP.TenLoai1 = reader.GetString(2);
                SP.GiaGoc = Math.Round(reader.GetDecimal(3));
                SP.GiaBan = Math.Round(reader.GetDecimal(4));
                SP.SoLuongTon = reader.GetInt32(5);
                SP.KhuyenMai = reader.GetInt32(6);
                SP.TenNCC = reader.GetString(7);
                SP.XuaXu = reader.GetString(8);
                SP.NgayNhap = reader.GetDateTime(9);
                SanPhams.Add(SP);
            }   
            return SanPhams;
        }

        // Thêm san Pham
        public bool ThemSanPham(SanPhamDTO sp)
        {
            try
            {
                string sql = "INSERT INTO [NCP].[dbo].[SanPham] VALUES ('{0}',N'{1}',{2},{3},{4},{5},{6},'{7}',1)";
                string Query = string.Format(sql, sp.MaSP, sp.TenSP, sp.MaLoai, sp.GiaGoc, sp.GiaBan, sp.SoLuongTon, sp.KhuyenMai, sp.XuaXu);
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
           
            return false;

        }
        public bool SuaSanPham(SanPhamDTO sp)
        {
            try
            {
                string Query = string.Format("UPDATE SanPham SET TenSanPham=N'{0}',LoaiSanPham=N'{1}',GiaGoc={2}, GiaBan={3}, SoLuongTon={4},BaoHanh='{5}',KhuyenMai={6},MaNCC='{7}',XuatXu=N'{8}' WHERE MaSanPham='{9}'",sp.TenSP,sp.MaLoai,sp.GiaGoc,sp.GiaBan,sp.SoLuongTon,sp.KhuyenMai,sp.MaNCC,sp.XuaXu,sp.MaSP);
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
            }
            return false;
        }
        public bool XoaSanPham(SanPhamDTO SP)
        {
            try
            {
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
                
            }
            return false;
        }
    }
}
