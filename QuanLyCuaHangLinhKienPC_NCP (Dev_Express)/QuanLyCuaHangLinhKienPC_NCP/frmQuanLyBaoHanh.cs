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
    public partial class frmQuanLyBaoHanh : Form
    {
        BaoHanhBUS bhBus = new BaoHanhBUS();
        public frmQuanLyBaoHanh()
        {
            InitializeComponent();
        }

        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {
            string value = txtTimKiemNhanh.Text;
            dgvDanhSachBH.DataSource = bhBus.timKiemNhanhBus(value);
        }

        private void frmQuanLyBaoHanh_Load(object sender, EventArgs e)
        {
            dgvDanhSachBH.AutoGenerateColumns = false;
            dgvDanhSachBH.DataSource = bhBus.layDSBHBus();
        }
    }
}
