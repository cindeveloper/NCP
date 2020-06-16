using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        private string tenTK = null;
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        public void LoadDSTK()
        {
            dgvDanhSachTK.AutoGenerateColumns = false;
            dgvDanhSachTK.DataSource = tkBUS.LayDSTK();
           
        }
        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDSTK();
        }

        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {

            string value = txtTimKiemNhanh.Text;
            dgvDanhSachTK.DataSource = tkBUS.TimKiemNhanh(value);

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy fm = new frmDangKy();
            fm.ShowDialog();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {

            TaiKhoanDTO tk = new TaiKhoanDTO
            {
                TenTaiKhoan = tenTK
            };
            if (tkBUS.XoaTK(tk))
            {
                MessageBox.Show("Xóa Tài Khoản Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQuanLyTaiKhoan_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa Tài Khoản Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvDanhSachTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;

            }
            else if (dgvDanhSachTK.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                tenTK = dgvDanhSachTK.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
