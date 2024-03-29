﻿using System;
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
using Bunifu;
using DevExpress.XtraPrinting.Native.Lines;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLySanPham : Form
    {
        SanPhamBUS spBUS = new SanPhamBUS();
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            btnCapNhat.Visible = false;
            btnLuuCapNhat.Visible = true;
            txtTenSP.Enabled = true;
            dtpNgayNhap.Enabled = false;
            cboLoai.Enabled = true;
            numericSoLuong.Enabled = false;
            txtGiaGoc.Enabled = true;
            txtGiaBan.Enabled = true;
            //dtpBaoHanh.Enabled = true;
            numericKhuyenMai.Enabled = true;
            cboXuatXu.Enabled = true;
            txtTenSP.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            btnCapNhat.Visible = true;
            btnLuuCapNhat.Visible = false;
            txtTenSP.Enabled = false;
            dtpNgayNhap.Enabled = false;
            cboLoai.Enabled = false;
            numericSoLuong.Enabled = false;
            txtGiaGoc.Enabled = false;
            txtGiaBan.Enabled = false;
            numericKhuyenMai.Enabled = false;
            cboXuatXu.Enabled = false;
            //dtpBaoHanh.Enabled = false;
            //try
            //{
            //    SanPhamDTO spDTO = new SanPhamDTO(txtMaSP.Text, txtTenSP.Text, cboLoai.Text, Convert.ToDecimal(txtGiaGoc.Text), Convert.ToDecimal(txtGiaBan.Text), Convert.ToInt32(numericSoLuong.Text), Convert.ToDateTime(dtpBaoHanh.EditValue.ToString()), Convert.ToInt32(numericKhuyenMai.Text), txtMaNCC.Text, cboXuatXu.Text);

            //    if (spBUS.SuaSanPham(spDTO))
            //    {
            //        MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        dgvDanhSachSP.DataSource = spBUS.LayDanhSachSanPham();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sửa không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //    txtTenSP.Focus();
            //}
            //catch(Exception ex)
            //{

            //}
           

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNH = new frmNhapHang();
            frmNH.ShowDialog();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            SanPhamBUS SPBUS = new SanPhamBUS();
            dgvDanhSachSP.AutoGenerateColumns = false;
            dgvDanhSachSP.DataSource = SPBUS.LayDanhSachSanPham();
        }

        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>0)
            {
                return;
            }
            else if (dgvDanhSachSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhSachSP.CurrentRow.Selected = true;
                txtMaSP.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboLoai.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGiaGoc.Text= dgvDanhSachSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                 txtGiaBan.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[4].Value.ToString();
                numericSoLuong.Text= dgvDanhSachSP.Rows[e.RowIndex].Cells[5].Value.ToString();
                numericKhuyenMai.Text= dgvDanhSachSP.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtMaNCC.Text= dgvDanhSachSP.Rows[e.RowIndex].Cells[7].Value.ToString();
                cboXuatXu.Text= dgvDanhSachSP.Rows[e.RowIndex].Cells[8].Value.ToString();
                dtpNgayNhap.Text= dgvDanhSachSP.Rows[e.RowIndex].Cells[9].Value.ToString();
            }


        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SanPhamDTO spDTO = new SanPhamDTO(txtMaSP.Text, txtTenSP.Text, cboLoai.Text, Convert.ToDecimal(txtGiaGoc.Text), Convert.ToDecimal(txtGiaBan.Text), Convert.ToInt32(numericSoLuong.Text), Convert.ToDateTime(dtpBaoHanh.EditValue.ToString()), Convert.ToInt32(numericKhuyenMai.Text), txtMaNCC.Text, cboXuatXu.Text);
            //    if (spBUS.XoaSanPham(spDTO))
            //    {
            //        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        dgvDanhSachSP.DataSource = spBUS.LayDanhSachSanPham();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
          
            //}
            //catch(Exception ex)
            //{

            //}

           
        }

        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
