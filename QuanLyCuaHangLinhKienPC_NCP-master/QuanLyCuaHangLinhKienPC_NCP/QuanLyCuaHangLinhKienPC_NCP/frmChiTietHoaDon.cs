using BUS;
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
    public partial class frmChiTietHoaDon : Form
    {
        private string maHD;
        private string stdKhachHang;
        private DateTime ngayLap;
        private string maNV;
        private string tenNV;
        //...
        ChiTietHoaDonBUS cthdBUS = new ChiTietHoaDonBUS();
        public frmChiTietHoaDon(string maHD, DateTime ngayLap, string maNV, string tenNV, string stdKhachHang) : this()
        {
            this.maHD = maHD;
            this.ngayLap = ngayLap;
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.stdKhachHang = stdKhachHang;
        }

        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            dgvDanhSachCTHD.AutoGenerateColumns = false;
            dgvDanhSachCTHD.DataSource = cthdBUS.loadDataBUS(txtMaHD.Text);
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = maHD;
            txtsdtKH.Text = stdKhachHang;
            dtpNgayLap.EditValue = ngayLap;
            txtMaNV.Text = maNV;
            txtTenNV.Text = tenNV;
            //...
            loadData();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
