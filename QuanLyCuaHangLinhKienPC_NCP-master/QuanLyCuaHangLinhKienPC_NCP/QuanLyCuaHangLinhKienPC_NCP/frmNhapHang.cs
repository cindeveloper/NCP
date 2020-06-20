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
    public partial class frmNhapHang : Form
    {
        SanPhamBUS spBUS = new SanPhamBUS();
        public frmNhapHang()
        {
            InitializeComponent();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                
                SanPhamDTO spDTO = new SanPhamDTO(txtMaSP.Text, txtTenSP.Text, cboLoai.Text, Convert.ToDecimal(txtGiaGoc.Text), Convert.ToDecimal(txtGiaBan.Text), Convert.ToInt32(numericSoLuong.Text), Convert.ToDateTime(dtpBH.Value.ToString("yyyy/MM/dd")), Convert.ToInt32(numericKhuyenMai.Text), txtNCC.Text, cboXuatXu.Text);

                if (spBUS.ThenSanPham(spDTO))
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception err)
            {
                
            }
        } 
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tạo phiếu không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //panel thông tin sản phẩm
                txtMaSP.Enabled = true;
                txtTenSP.Enabled = true;
                cboLoai.Enabled = true;
                numericSoLuong.Enabled = true;
                txtGiaGoc.Enabled = true;
                txtGiaBan.Enabled = true;
                dtpBH.Enabled = true;
                numericKhuyenMai.Enabled = true;
                cboXuatXu.Enabled = true;
                txtNCC.Enabled = true;
                txtMaSP.Focus();

                //panel thông tin phiếu nhập
                txtMaPhieu.Enabled = false;
                dtpNgayNhapOfTTPN.Enabled = false;
                cboNhaCungCapOfTTPN.Enabled = false;
                numericSoLuongNhapOfTTPN.Enabled = false;
                cboMaNhanVien.Enabled = false;
                txtTenNhanVien.Enabled = false;
                //...
                btnTaoPhieu.Visible = false;
                btnHuyPhieu.Visible = true;
                txtMaSP.Focus();
                //...
                btnThem.Visible = true;
                btnXoa.Visible = true;
                btnLuuCapNhat.Visible = true;
                btnCapNhat.Visible = true;
            }
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy phiếu không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //panel thông tin sản phẩm

                txtMaSP.Enabled = false;
                txtTenSP.Enabled = false;
                cboLoai.Enabled = false;
                numericSoLuong.Enabled = false;
                txtGiaGoc.Enabled = false;
                txtGiaBan.Enabled = false;
                dtpBH.Enabled = false;
                numericKhuyenMai.Enabled = false;
                cboXuatXu.Enabled = false;
                txtNCC.Enabled = false;

                //panel thông tin phiếu nhập
                txtMaPhieu.Enabled = true;
                dtpNgayNhapOfTTPN.Enabled = true;
                cboNhaCungCapOfTTPN.Enabled = true;
                numericSoLuongNhapOfTTPN.Enabled = true;
                cboMaNhanVien.Enabled = true;
                txtTenNhanVien.Enabled = true;
                
                //...
                btnTaoPhieu.Visible = true;
                btnHuyPhieu.Visible = false;
                txtMaPhieu.Focus();

                //...
                btnThem.Visible = false;
                btnXoa.Visible = false;
                btnLuuCapNhat.Visible = false;
                btnCapNhat.Visible = false;
            }
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

        }
    }
}
