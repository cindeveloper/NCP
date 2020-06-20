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

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLyNhanVien : Form
    {
        
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // dgvDanhSachNV.Rows.Add(
            //     new object[]
            //     {
            //         "NV01",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //     }
            // );
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV02",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV03",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV04",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV05",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV06",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV07",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV08",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV09",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV010",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV011",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV012",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            // dgvDanhSachNV.Rows.Add(
            //    new object[]
            //    {
            //         "NV013",
            //         "Nguyễn Văn A",
            //         "012345678",
            //         "Quận 1",
            //         "2000"
            //    }
            //);
            
            //...
            //Đổ dữ liệu vào datagridview
            
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

        private void btnThemNVMoi_Click(object sender, EventArgs e)
        {
            //Mã NV tự phát sinh
            
            //...
            panelTTNVContent.Enabled = true;
            btnThemNVMoi.Visible = false;
            btnThem.Visible = true;
            txtHoTen.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelTTNVContent.Enabled = false;
            btnThem.Visible = false;
            btnThemNVMoi.Visible = true;
        }
    }
}
