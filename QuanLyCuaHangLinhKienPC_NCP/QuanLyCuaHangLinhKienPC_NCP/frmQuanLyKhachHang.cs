using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLyKhachHang : Form
    {
        KhachHangBUS khBus = new KhachHangBUS();
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            panelTTKHContent.Enabled = true;
            btnCapNhat.Visible = false;
            btnLuuCapNhat.Visible = true;
            txtSDT.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn cập nhật khách hàng này?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // ...
            try
            {
                KhachHangDTO khDTO = new KhachHangDTO(txtMaKH.Text, txtSDT.Text, txtHoTen.Text, txtDiaChi.Text, true);
                if (result == DialogResult.Yes)
                {
                    if (khBus.capNhatKHBus(khDTO))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyKhachHang_Load(sender, e);
                        // ...
                        panelTTKHContent.Enabled = false;
                        btnLuuCapNhat.Visible = false;
                        btnCapNhat.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dgvDanhSachKH.AutoGenerateColumns = false;
            dgvDanhSachKH.DataSource = khBus.layDSKHBus();
        }

        private void dgvDanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhSachKH.CurrentRow.Selected = true;
                txtSDT.Text = dgvDanhSachKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHoTen.Text = dgvDanhSachKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvDanhSachKH.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // ...
            try
            {
                KhachHangDTO khDTO = new KhachHangDTO(txtSDT.Text);
                if (result == DialogResult.Yes)
                {
                    if (khBus.xoaKHBus(khDTO))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyKhachHang_Load(sender, e);
                        // ...
                        panelTTKHContent.Enabled = false;
                        btnLuuCapNhat.Visible = false;
                        btnCapNhat.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thêm khách hàng này?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // ...
            try
            {
                KhachHangDTO khDTO = new KhachHangDTO(txtMaKH.Text, txtSDT.Text, txtHoTen.Text, txtDiaChi.Text, true);

                if (result == DialogResult.Yes)
                {
                    if (khBus.themKHBus(khDTO))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyKhachHang_Load(sender, e);
                        // ...
                        panelTTKHContent.Enabled = false;
                        btnThemKHMoi.Visible = true;
                        btnThem.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btnThemKHMoi_Click(object sender, EventArgs e)
        {
            panelTTKHContent.Enabled = true;
            txtSDT.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            // ...
            btnThemKHMoi.Visible = false;
            btnThem.Visible = true;
            txtSDT.Focus();
        }

        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {
            string value = txtTimKiemNhanh.Text;
            dgvDanhSachKH.DataSource = khBus.timKiemNhanhBus(value);
        }
    }
}
