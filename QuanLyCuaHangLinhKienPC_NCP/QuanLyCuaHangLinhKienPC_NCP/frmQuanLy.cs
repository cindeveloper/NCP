using BUS;
using DevExpress.Utils.DirectXPaint;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraRichEdit.Import.Doc;
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
    public partial class frmQuanLy : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        private static Point coorMenuTmp = new Point(205, 31);
        private static Point coorMenuChildTmp = new Point(12, 87);
        private static Point coorLogoTmp = new Point(12, 6);
        public static string quyen;
        private string tenTK = null;
        public frmQuanLy()
        {
            InitializeComponent();
        }

        public frmQuanLy(string tenTK):this()
        {
            this.tenTK = tenTK;
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            panelContent.Width = 1112;
            panelContent.Height = 710;
            NhanVienDTO nv = nvBUS.TimKiemNVBUS(tenTK);
            txtTenNV.Text = nv.HoTen;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menu.Width == 70)
            {
                menu.Visible = false;
                txtTenNV.Visible = true; ;
                menu.Width = 246;
                menuChild.Width = 228;
                iconUser.Width = 81;
                iconUser.Height = 81;
                Point coorIconUser = new Point(72, 7);
                iconUser.Location = coorIconUser;
                panelContent.Width = 1107;
                panelContent.Height = 722;
                panelContent.Location = new Point(254, 36);
                btnMenu.Location = coorMenuTmp;
                PanelAnimator.ShowSync(menu);
                logoAnimator.ShowSync(logo);
            }
            else
            {
                logoAnimator.Hide(logo);
                menu.Visible = false;
                txtTenNV.Visible = false;
                menu.Width = 70;
                menuChild.Width = 52;
                panelContent.Width = 1286;
                panelContent.Height = 722;
                panelContent.Location = new Point(75,36);
                iconUser.Width = 50;
                iconUser.Height = 50;
                Point coorIconUser = new Point(1, 50);
                iconUser.Location = coorIconUser;
                Point coorIconMenu = new Point(22, 28);
                btnMenu.Location = coorIconMenu;
                PanelAnimator.ShowSync(menu);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLyNhanVien frmNV = new frmQuanLyNhanVien() {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmNV);
            frmNV.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmNV.Show();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLyTaiKhoan frmTK = new frmQuanLyTaiKhoan()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmTK);
            frmTK.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmTK.Show();
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLyKhachHang frmKH = new frmQuanLyKhachHang() {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmKH);
            frmKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmKH.Show();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLySanPham frmSP = new frmQuanLySanPham()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmSP);
            frmSP.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSP.Show();
        }

        private void btnQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLyNhaCungCap frmNCC = new frmQuanLyNhaCungCap()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmNCC);
            frmNCC.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmNCC.Show();
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLyBaoHanh frmBH = new frmQuanLyBaoHanh()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmBH);
            frmBH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmBH.Show();
        }

        //private void btnNhapHang_Click(object sender, EventArgs e)
        //{
        //    panelContent.Controls.Clear();
        //    frmNhapHang frmNH = new frmNhapHang()
        //    {
        //        Dock = DockStyle.Fill,
        //        TopLevel = false,
        //        TopMost = true,
        //    };
        //    panelContent.Controls.Add(frmNH);
        //    frmNH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    frmNH.Show();
        //}

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            NhanVienDTO nv = nvBUS.TimKiemNVBUS(tenTK);
            frmQuanLyHoaDon frmHD = new frmQuanLyHoaDon(nv.MaNV)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            panelContent.Controls.Add(frmHD);
            frmHD.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmHD.Show();
        }

        private void menuChild_Paint(object sender, PaintEventArgs e)
        {
            if(quyen=="Nhân Viên")
            {
                btnQuanLyNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = false;
            }    

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muôn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
                this.Hide();
            }
        }
    }
}
