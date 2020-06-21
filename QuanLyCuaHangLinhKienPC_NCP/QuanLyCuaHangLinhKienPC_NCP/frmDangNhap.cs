using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmDangNhap : Form
    {
        string tenTK = null;
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        #region Xử lý thao tác chuyển qua lại giữa 2 slide
        //private void btnDangNhapHeader_Click(object sender, EventArgs e)
        //{
        //    slideDangNhap.Visible = true;
        //    slideDangKy.Visible = false;
        //    slideDangNhap.Left = 40;

        //    separator.Left = btnDangNhapHeader.Left;
        //    separator.Width = btnDangNhapHeader.Width;
        //}

        //private void btnDangKyHeader_Click(object sender, EventArgs e)
        //{
        //    slideDangKy.Visible = true;
        //    slideDangNhap.Visible = false;
        //    slideDangKy.Left = 40;

        //    separator.Left = btnDangKyHeader.Left;
        //    separator.Width = btnDangKyHeader.Width;
        //}
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tkDTO = new TaiKhoanDTO();
            tkDTO.TenTaiKhoan = txtTenDangNhap.Text;
            tkDTO.MatKhau = txtMatKhau.Text;
            TaiKhoanDTO result = tkBUS.checkQuyen(tkDTO);
            string TenQuyen = null;
            if (!string.IsNullOrEmpty(result.TenTaiKhoan))
            {
                TenQuyen = result.TenQuyen;
                frmQuanLy.quyen = TenQuyen;
                frmLoading d = new frmLoading(txtTenDangNhap.Text);
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nhập Sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Text = null;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }
    }
}
