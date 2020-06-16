namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmQuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblBannerQuanLyNhanVien = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvDanhSachTK = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colTenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiSoHuu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemNhanh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTimKiemNhanh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnXoaTK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDangKy = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTK)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblBannerQuanLyNhanVien
            // 
            this.lblBannerQuanLyNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBannerQuanLyNhanVien.AutoSize = true;
            this.lblBannerQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerQuanLyNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblBannerQuanLyNhanVien.Location = new System.Drawing.Point(346, 9);
            this.lblBannerQuanLyNhanVien.Name = "lblBannerQuanLyNhanVien";
            this.lblBannerQuanLyNhanVien.Size = new System.Drawing.Size(467, 42);
            this.lblBannerQuanLyNhanVien.TabIndex = 2;
            this.lblBannerQuanLyNhanVien.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // dgvDanhSachTK
            // 
            this.dgvDanhSachTK.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachTK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachTK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.dgvDanhSachTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachTK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDanhSachTK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachTK.ColumnHeadersHeight = 35;
            this.dgvDanhSachTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenTK,
            this.colMK,
            this.colNguoiSoHuu,
            this.colQuyenHan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachTK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachTK.DoubleBuffered = true;
            this.dgvDanhSachTK.EnableHeadersVisualStyles = false;
            this.dgvDanhSachTK.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.dgvDanhSachTK.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDanhSachTK.Location = new System.Drawing.Point(12, 130);
            this.dgvDanhSachTK.Name = "dgvDanhSachTK";
            this.dgvDanhSachTK.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachTK.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.dgvDanhSachTK.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachTK.RowTemplate.Height = 30;
            this.dgvDanhSachTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachTK.Size = new System.Drawing.Size(1088, 568);
            this.dgvDanhSachTK.TabIndex = 29;
            this.dgvDanhSachTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachTK_CellClick);
            // 
            // colTenTK
            // 
            this.colTenTK.DataPropertyName = "TenTaiKhoan";
            this.colTenTK.HeaderText = "Tên tài khoản";
            this.colTenTK.Name = "colTenTK";
            // 
            // colMK
            // 
            this.colMK.DataPropertyName = "MatKhau";
            this.colMK.HeaderText = "Mật khẩu";
            this.colMK.Name = "colMK";
            // 
            // colNguoiSoHuu
            // 
            this.colNguoiSoHuu.DataPropertyName = "TenNhanVien";
            this.colNguoiSoHuu.HeaderText = "Người sở hữu";
            this.colNguoiSoHuu.Name = "colNguoiSoHuu";
            // 
            // colQuyenHan
            // 
            this.colQuyenHan.DataPropertyName = "TenQuyen";
            this.colQuyenHan.HeaderText = "Quyền hạn";
            this.colQuyenHan.Name = "colQuyenHan";
            // 
            // txtTimKiemNhanh
            // 
            this.txtTimKiemNhanh.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtTimKiemNhanh.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTimKiemNhanh.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtTimKiemNhanh.BorderThickness = 2;
            this.txtTimKiemNhanh.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemNhanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanh.ForeColor = System.Drawing.Color.Silver;
            this.txtTimKiemNhanh.isPassword = false;
            this.txtTimKiemNhanh.Location = new System.Drawing.Point(368, 86);
            this.txtTimKiemNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemNhanh.MaxLength = 32767;
            this.txtTimKiemNhanh.Name = "txtTimKiemNhanh";
            this.txtTimKiemNhanh.Size = new System.Drawing.Size(350, 28);
            this.txtTimKiemNhanh.TabIndex = 31;
            this.txtTimKiemNhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemNhanh.OnValueChanged += new System.EventHandler(this.txtTimKiemNhanh_OnValueChanged);
            // 
            // lblTimKiemNhanh
            // 
            this.lblTimKiemNhanh.AutoSize = true;
            this.lblTimKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemNhanh.ForeColor = System.Drawing.Color.White;
            this.lblTimKiemNhanh.Location = new System.Drawing.Point(240, 89);
            this.lblTimKiemNhanh.Name = "lblTimKiemNhanh";
            this.lblTimKiemNhanh.Size = new System.Drawing.Size(128, 20);
            this.lblTimKiemNhanh.TabIndex = 30;
            this.lblTimKiemNhanh.Text = "Tìm kiếm nhanh :";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.ActiveBorderThickness = 1;
            this.btnXoaTK.ActiveCornerRadius = 1;
            this.btnXoaTK.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.btnXoaTK.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoaTK.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.btnXoaTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnXoaTK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaTK.BackgroundImage")));
            this.btnXoaTK.ButtonText = "Xóa tài khoản";
            this.btnXoaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.White;
            this.btnXoaTK.IdleBorderThickness = 1;
            this.btnXoaTK.IdleCornerRadius = 1;
            this.btnXoaTK.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnXoaTK.IdleForecolor = System.Drawing.Color.White;
            this.btnXoaTK.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnXoaTK.Location = new System.Drawing.Point(792, 73);
            this.btnXoaTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(149, 49);
            this.btnXoaTK.TabIndex = 32;
            this.btnXoaTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.ActiveBorderThickness = 1;
            this.btnDangKy.ActiveCornerRadius = 1;
            this.btnDangKy.ActiveFillColor = System.Drawing.Color.LightSkyBlue;
            this.btnDangKy.ActiveForecolor = System.Drawing.Color.White;
            this.btnDangKy.ActiveLineColor = System.Drawing.Color.LightSkyBlue;
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnDangKy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangKy.BackgroundImage")));
            this.btnDangKy.ButtonText = "Đăng ký";
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.IdleBorderThickness = 1;
            this.btnDangKy.IdleCornerRadius = 1;
            this.btnDangKy.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnDangKy.IdleForecolor = System.Drawing.Color.White;
            this.btnDangKy.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnDangKy.Location = new System.Drawing.Point(949, 73);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(149, 49);
            this.btnDangKy.TabIndex = 32;
            this.btnDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1112, 710);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.txtTimKiemNhanh);
            this.Controls.Add(this.lblTimKiemNhanh);
            this.Controls.Add(this.dgvDanhSachTK);
            this.Controls.Add(this.lblBannerQuanLyNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "frmQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerQuanLyNhanVien;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDanhSachTK;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimKiemNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiSoHuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuyenHan;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDangKy;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoaTK;
    }
}