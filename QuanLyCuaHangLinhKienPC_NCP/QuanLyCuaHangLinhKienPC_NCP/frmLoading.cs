using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmLoading : Form
    {
        private string tenTK;
        public frmLoading()
        {
            InitializeComponent();
        }

        public frmLoading(string tenTK) : this()
        {
            this.tenTK = tenTK;
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition.ShowAsyc(this);
        }
        private void bunifuFormFadeTransition_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            icon.Enabled = true;
        }
        private void icon_delay_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            icon_delay.Stop();
            Thread.Sleep(1000);
            frmQuanLy frm = new frmQuanLy(tenTK);
            frm.Show();
            this.Hide();
        }
    }
}
