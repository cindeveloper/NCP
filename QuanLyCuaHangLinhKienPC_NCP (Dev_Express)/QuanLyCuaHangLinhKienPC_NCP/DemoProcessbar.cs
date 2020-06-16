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
    public partial class DemoProcessbar : Form
    {
       
        public DemoProcessbar()
        {
            InitializeComponent();
        }

        private void lbtitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width>=600)
            {
                timer1.Stop();
                frmQuanLy f = new frmQuanLy();
                f.Show();
                this.Hide();
                
            }    
        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DemoProcessbar_Load(object sender, EventArgs e)
        {
           
        }
    }
}
