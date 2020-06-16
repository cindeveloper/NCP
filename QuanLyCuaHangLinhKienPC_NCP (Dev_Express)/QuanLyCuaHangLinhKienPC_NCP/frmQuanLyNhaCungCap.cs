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
    public partial class frmQuanLyNhaCungCap : Form
    {
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = true;
            btnLuuCapNhat.Visible = true;
            btnCapNhat.Visible = false;
            txtMaNCC.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            btnLuuCapNhat.Visible = false;
            btnCapNhat.Visible = true;
            try
            {
                NhaCungCapDTO nccDTO = new NhaCungCapDTO(txtMaNCC.Text, txtTenNCC.Text);
                if (nccBUS.CapNhatNCC(nccDTO))
                {
                    MessageBox.Show("Cập Nhật Nhà Cung Cấp Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDanhSachNCC.DataSource = nccBUS.LoadDSNCC();

                }
                else
                {
                    MessageBox.Show("Cập nhật Nhà Cung Cấp Không Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch(Exception ex)
            {

            }


        }

        private void frmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvDanhSachNCC.AutoGenerateColumns = false;
            dgvDanhSachNCC.DataSource = nccBUS.LoadDSNCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCapDTO nccDTO = new NhaCungCapDTO(txtMaNCC.Text, txtTenNCC.Text);
                if(nccBUS.ThemNCC(nccDTO))
                {
                    MessageBox.Show("Thêm Nhà Cung Cấp Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmQuanLyNhaCungCap_Load(sender,e);
                    txtMaNCC.ResetText();
                    txtTenNCC.ResetText();
                    btnThem.Visible = false;
                    btnThemNCC.Visible = true;
                    txtMaNCC.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm Nhà Cung Cấp Không Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            btnThemNCC.Visible = false;
            btnThem.Visible = true;
            txtMaNCC.Focus();

        }

        private void dgvDanhSachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0)
            {
                return;

            }   
            else if(dgvDanhSachNCC.Rows[e.RowIndex].Cells[e.ColumnIndex]!=null)
            {
                txtMaNCC.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nccDTO = new NhaCungCapDTO(txtMaNCC.Text, txtTenNCC.Text);
            if(nccBUS.XoaNCC(nccDTO))
            {
                MessageBox.Show("Xóa Nhà Cung Cấp Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQuanLyNhaCungCap_Load(sender, e);
                txtMaNCC.ResetText();
                txtTenNCC.ResetText();
            }    
            else
            {
                MessageBox.Show("Xóa Nhà Cung Cấp Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
