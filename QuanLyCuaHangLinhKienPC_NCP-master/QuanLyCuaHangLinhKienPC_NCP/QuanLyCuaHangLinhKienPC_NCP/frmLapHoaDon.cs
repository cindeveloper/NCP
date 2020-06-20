using BUS;
using DevExpress.Utils.DirectXPaint.Svg;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmLapHoaDon : Form
    {
        private string maNV = null;
        HoaDonBUS hdBUS = new HoaDonBUS();
        public frmLapHoaDon()
        {
            InitializeComponent();
        }
        public frmLapHoaDon(string maNV):this()
        {
            this.maNV = maNV;
        }
        private void btnTaoMoiKhachHang_Click(object sender, EventArgs e)
        {
            btnTaoMoiKhachHang.Visible = false;
            btnLuuKH.Visible = true;
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDTKH.Enabled = true;
            txtTenKH.Focus();
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            btnTaoMoiKhachHang.Visible = true;
            btnLuuKH.Visible = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn cập nhật khách hàng này?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //...
            try
            {
                if (result == DialogResult.Yes)
                {
                    HoaDonDTO hd = new HoaDonDTO(txtMaHD.Text, Convert.ToDateTime(dtpNgayLap.EditValue), txtMaNV.Text, txtSDTKH.Text);
                    if (hdBUS.ThemHoaDonBUS(hd))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lõi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            //Phát sinh mã
            int maHD = hdBUS.DemTongHDBUS() + 1;
            string phatSinhMa = "HD" + maHD;
            txtMaHD.Text = phatSinhMa;
            //...
            txtMaNV.Text = maNV;
        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
