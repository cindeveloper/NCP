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
            string Query = "select a.TenTaiKhoan,a.MatKhau,b.TenQuyen from TaiKhoan a, PhanQuyen b where a.MaQuyen = b.MaQuyen and a.TenTaiKhoan='" + TK.TenTaiKhoan + "' and a.MatKhau='" + TK.MatKhau + "'";
            SqlDataReader reader = con.getdata(Query);
            TaiKhoanDTO newTK = new TaiKhoanDTO();
            while (reader.Read())
            {
                newTK.TenTaiKhoan = reader.GetString(0);
                newTK.MatKhau = reader.GetString(1);
                newTK.TenQuyen = reader.GetString(2);
            }
            con.Ngatketnoi();
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
    }
}
