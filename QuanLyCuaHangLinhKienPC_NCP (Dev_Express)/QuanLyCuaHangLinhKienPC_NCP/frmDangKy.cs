using BUS;
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
    public partial class frmDangKy : Form
    {
        NhanVienBUS nvBus = new NhanVienBUS();
        PhanQuyenBUS quyenBus = new PhanQuyenBUS();
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();

        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadMaNVInCombobox()
        {
            foreach (NhanVienDTO nv in nvBus.loadDataBUS())
            {
                cboMaNV.Items.Add(nv.MaNV);
            }
        }

        public void loadMaQuyenInCombobox()
        {
            cboChucVu.DataSource = quyenBus.loadDataBUS();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            loadMaNVInCombobox();
            loadMaQuyenInCombobox();
        }

        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            int dem = 0;
            List<NhanVienDTO> list = nvBus.loadDataBUS();
            foreach (NhanVienDTO nv in list)
            {
                if (cboMaNV.Text == nv.MaNV)
                {
                    txtHoTen.Text = nv.HoTen;
                    txtSoDienThoai.Text = nv.Sdt;
                    txtDiaChi.Text = nv.DiaChi;
                    dtpNgaySinh.EditValue = nv.NamSinh.ToString("dd/MM/yyyy");
                    if (nv.GioiTinh == "Nam")
                    {
                        radgrpGioiTinh.SelectedIndex = 0;
                    }
                    else
                    {
                        radgrpGioiTinh.SelectedIndex = 1;
                    }

                }
                else
                {
                    dem++;
                }
            }
            if (dem == list.Count())
            {
                txtHoTen.ResetText();
                txtSoDienThoai.ResetText();
                txtDiaChi.ResetText();
                dtpNgaySinh.ResetText();
            }
        }

        private void btnDangKyDK_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanDTO TK = new TaiKhoanDTO(txtTenDangNhap.Text, txtMatKhau.Text, cboMaNV.Text, Convert.ToInt32(cboChucVu.SelectedValue.ToString()));
              
                    if(tkBUS.ThemTaiKhoan(TK))
                    {

                        MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenDangNhap.ResetText();
                        txtMatKhau.ResetText();
                        cboMaNV.ResetText();
                        cboChucVu.ResetText();
                        
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài  khoản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                  
            }
            catch(Exception ex)
            {

            }
        }
    }
}
