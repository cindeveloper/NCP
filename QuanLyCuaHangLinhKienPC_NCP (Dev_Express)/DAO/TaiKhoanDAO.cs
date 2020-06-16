using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.SqlServer.Server;

namespace DAO
{
    public class TaiKhoanDAO
    {
        DataProvider con = new DataProvider();
        public TaiKhoanDTO KiemTraQuyen(TaiKhoanDTO TK)
        {
            
            string Query = "select a.TenTaiKhoan,a.MatKhau,b.TenQuyen from TaiKhoan a, PhanQuyen b where a.MaQuyen = b.MaQuyen and a.TenTaiKhoan='"+TK.TenTaiKhoan+"' and a.MatKhau='"+TK.MatKhau+"'";
            SqlDataReader reader = con.getdata(Query);
            TaiKhoanDTO newTK = new TaiKhoanDTO();
            while(reader.HasRows)
            {
                while(reader.Read())
                {
                    newTK.TenTaiKhoan = reader.GetString(0);
                    newTK.MatKhau = reader.GetString(1);
                    newTK.TenQuyen = reader.GetString(2);   
                }
                reader.NextResult();
            }
            return newTK;
        }
        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {
                con.Ketnoi();
                string Query = "INSERT INTO [NCP].[dbo].[TaiKhoan] VALUES('{0}','{1}','{2}',{3},1 )";
                string Sql = string.Format(Query, tk.TenTaiKhoan, tk.MatKhau, tk.MaNhanVien, tk.MaQuyen);
                SqlCommand cmd = new SqlCommand(Sql, con.cn);
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
        public List<TaiKhoanDTO>LayDSTK()
        {
            List<TaiKhoanDTO> TaiKhoans = new List<TaiKhoanDTO>();
            con.Ketnoi(); 
            string Query = "select a.TenTaiKhoan,a.MatKhau,b.HoTenNhanVien,c.TenQuyen, a.TrangThai from TaiKhoan a, NhanVien b, PhanQuyen c where a.MaNhanVien = b.MaNhanVien and a.MaQuyen = c.MaQuyen and a.TrangThai = 'True'";
            SqlDataReader reader = con.getdata(Query);
            while(reader.Read())
            {
                TaiKhoanDTO TK = new TaiKhoanDTO();
                TK.TenTaiKhoan = reader.GetString(0);
                TK.MatKhau = reader.GetString(1);
                TK.TenNhanVien = reader.GetString(2);
                TK.TenQuyen = reader.GetString(3);
                TK.TrangThai = reader.GetBoolean(4);
                TaiKhoans.Add(TK);

            }
            con.Ngatketnoi();
            return TaiKhoans;
        }
        public List<TaiKhoanDTO>TimKiemTaiKhoan(string value)
        {
            List<TaiKhoanDTO> Taikhoans = new List<TaiKhoanDTO>();
            con.Ketnoi();
           string Query = "select a.TenTaiKhoan,a.MatKhau,b.HoTenNhanVien,c.TenQuyen from TaiKhoan a, NhanVien b, PhanQuyen c where (a.MaNhanVien = b.MaNhanVien and a.MaQuyen = c.MaQuyen) and(TenTaiKhoan Like '{0}%' OR HoTenNhanVien like N'{1}%' OR TenQuyen Like N'{2}%')";
            string Sql = string.Format(Query, value, value, value);
            SqlDataReader reader = con.getdata(Sql);
            while(reader.Read())
            {
                TaiKhoanDTO TK = new TaiKhoanDTO();
                TK.TenTaiKhoan = reader.GetString(0);
                TK.MatKhau = reader.GetString(1);
                TK.TenNhanVien = reader.GetString(2);
                TK.TenQuyen = reader.GetString(3);
                Taikhoans.Add(TK);
            }
            con.Ngatketnoi();
            return Taikhoans;
        }
        public bool XoaTK(TaiKhoanDTO TK)
        {
            try
            {
                con.Ketnoi();
                string Query = "UPDATE TaiKhoan SET TrangThai='False' Where TenTaiKhoan='{0}'";
                string sql = string.Format(Query, TK.TenTaiKhoan);
                SqlCommand cmd = new SqlCommand(sql,con.cn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
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
