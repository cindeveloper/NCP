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
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaoTaiKhoan frm = new frmTaoTaiKhoan();
            frm.ShowDialog();
        }
    }
}
