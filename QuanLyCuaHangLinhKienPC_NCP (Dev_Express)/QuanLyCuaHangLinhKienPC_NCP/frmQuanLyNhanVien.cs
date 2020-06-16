using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLyNhanVien : Form
    {

        NhanVienBUS nvBUS = new NhanVienBUS();

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
           
            dgvDanhSachNV.AutoGenerateColumns = false;
            dgvDanhSachNV.DataSource = nvBUS.loadDataBUS();

            
        }
        

        private void btnXemTTK_Click(object sender, EventArgs e)
        {
            panelThongTinKhac.Visible = false;
            //
            lblChucVu.Visible = true;
            lblTenTaiKhoan.Visible = true;
            lblMatKhau.Visible = true;
            //
            cboChucVu.Visible = true;
            txtTenTaiKhoan.Visible = true;
            txtMatKhau.Visible = true;
            //
            btnXemTTK.Visible = false;
            btnDongTTK.Visible = true;
            //
            panelThongTinKhac.Size = new Size(447, 231);
            transitionPanelTTK.ShowSync(panelThongTinKhac);
        }

        private void btnDongTTK_Click(object sender, EventArgs e)
        {
            panelThongTinKhac.Visible = false;
            //
            btnDongTTK.Visible = false;
            btnXemTTK.Visible = true;
            //
            lblChucVu.Visible = false;
            lblTenTaiKhoan.Visible = false;
            lblMatKhau.Visible = false;
            //
            cboChucVu.Visible = false;
            txtTenTaiKhoan.Visible = false;
            txtMatKhau.Visible = false;
            //
            panelThongTinKhac.Size = new Size(447, 110);
            transitionPanelTTK.ShowSync(panelThongTinKhac);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            panelTTNVContent.Enabled = true;
            btnCapNhat.Visible = false;
            btnLuuCapNhat.Visible = true;
            txtHoTen.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            panelTTNVContent.Enabled = false;
            btnLuuCapNhat.Visible = false;
            btnCapNhat.Visible = true;
            NhanVienDTO nvDTO = new NhanVienDTO(txtMaNV.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.EditValue.ToString()), cboGioiTinh.Text, txtSDT.Text, txtDiaChi.Text);
            if(nvBUS.CapNhapNhanVien(nvDTO))
            {

                MessageBox.Show("Cập Nhật Thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachNV.DataSource = nvBUS.loadDataBUS();
                txtMaNV.ResetText();
                txtHoTen.ResetText();
                dtpNgaySinh.EditValue = DateTime.Now.ToString();
                txtSDT.ResetText();
                txtDiaChi.ResetText();
                cboGioiTinh.ResetText();

            }    
            else
            {
                MessageBox.Show("Cập Nhật không Thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCapNhatTTK_Click(object sender, EventArgs e)
        {
            btnCapNhatTTK.Visible = false;
            btnLuuCapNhatTTK.Visible = true;
            cboChucVu.Enabled = true;
            txtTenTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            cboChucVu.Focus();
        }

        private void btnLuuCapNhatTTK_Click(object sender, EventArgs e)
        {
            btnCapNhatTTK.Visible = true;
            btnLuuCapNhatTTK.Visible = false;
            cboChucVu.Enabled = false;
            txtTenTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienDTO nvDTO = new NhanVienDTO(txtMaNV.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.EditValue.ToString()),cboGioiTinh.Text,txtSDT.Text,txtDiaChi.Text);
                if(nvBUS.ThemNhanVien(nvDTO))
                {
                    dgvDanhSachNV.DataSource = nvBUS.loadDataBUS();
                    MessageBox.Show("Thêm  Nhân Viên Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dgvDanhSachNV.DataSource = nvBUS.loadDataBUS();
                    txtMaNV.ResetText();
                    txtHoTen.ResetText();
                    dtpNgaySinh.EditValue = DateTime.Now.ToString();
                    txtSDT.ResetText();
                    txtDiaChi.ResetText();
                    cboGioiTinh.ResetText();
                }    
                else
                {
                    MessageBox.Show("Thêm  Nhân Viên Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {

            }
        }

        private void dgvDanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            if (dgvDanhSachNV.Rows[e.RowIndex].Cells[e.ColumnIndex]!=null)
            {
                txtMaNV.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboGioiTinh.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSDT.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[5].Value.ToString();
            }    
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVienDTO nvDTO = new NhanVienDTO(txtMaNV.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.EditValue.ToString()), cboGioiTinh.Text, txtSDT.Text, txtDiaChi.Text);
            if (nvBUS.XoaNhanVien(nvDTO))
            {
                MessageBox.Show("Xóa  Nhân Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachNV.DataSource = nvBUS.loadDataBUS();
                txtMaNV.ResetText();
                txtHoTen.ResetText();
                dtpNgaySinh.EditValue = DateTime.Now.ToString();
                txtSDT.ResetText();
                txtDiaChi.ResetText();
                cboGioiTinh.ResetText();
            }
            else
            {
                MessageBox.Show("Xóa  Nhân Viên Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }
    }
}
