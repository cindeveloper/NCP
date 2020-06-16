namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmQuanLyBaoHanh
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblBannerBaoHanhSanPham = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvDanhSachBH = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiHanBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemNhanh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTimKiemNhanh = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBH)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblBannerBaoHanhSanPham
            // 
            this.lblBannerBaoHanhSanPham.AutoSize = true;
            this.lblBannerBaoHanhSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerBaoHanhSanPham.ForeColor = System.Drawing.Color.White;
            this.lblBannerBaoHanhSanPham.Location = new System.Drawing.Point(352, 9);
            this.lblBannerBaoHanhSanPham.Name = "lblBannerBaoHanhSanPham";
            this.lblBannerBaoHanhSanPham.Size = new System.Drawing.Size(435, 42);
            this.lblBannerBaoHanhSanPham.TabIndex = 2;
            this.lblBannerBaoHanhSanPham.Text = "BẢO HÀNH SẢN PHẨM";
            // 
            // dgvDanhSachBH
            // 
            this.dgvDanhSachBH.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachBH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachBH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.dgvDanhSachBH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachBH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDanhSachBH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachBH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachBH.ColumnHeadersHeight = 35;
            this.dgvDanhSachBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSDT,
            this.coMaHD,
            this.colNgayLapHD,
            this.colMaSP,
            this.colTenSP,
            this.colSoLuong,
            this.colKhuyenMai,
            this.colThanhTien,
            this.colThoiHanBaoHanh});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachBH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachBH.DoubleBuffered = true;
            this.dgvDanhSachBH.EnableHeadersVisualStyles = false;
            this.dgvDanhSachBH.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.dgvDanhSachBH.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDanhSachBH.Location = new System.Drawing.Point(12, 112);
            this.dgvDanhSachBH.Name = "dgvDanhSachBH";
            this.dgvDanhSachBH.ReadOnly = true;
            this.dgvDanhSachBH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachBH.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.dgvDanhSachBH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachBH.RowTemplate.Height = 30;
            this.dgvDanhSachBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachBH.Size = new System.Drawing.Size(1088, 586);
            this.dgvDanhSachBH.TabIndex = 3;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "sdt";
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            // 
            // coMaHD
            // 
            this.coMaHD.DataPropertyName = "maHoaDon";
            this.coMaHD.HeaderText = "Mã hóa đơn";
            this.coMaHD.Name = "coMaHD";
            this.coMaHD.ReadOnly = true;
            // 
            // colNgayLapHD
            // 
            this.colNgayLapHD.DataPropertyName = "ngaylapHD";
            this.colNgayLapHD.HeaderText = "Ngày lập HD";
            this.colNgayLapHD.Name = "colNgayLapHD";
            this.colNgayLapHD.ReadOnly = true;
            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "maSanPham";
            this.colMaSP.HeaderText = "Mã sản phẩm";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "tenSanPham";
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "soLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colKhuyenMai
            // 
            this.colKhuyenMai.DataPropertyName = "khuyenMai";
            this.colKhuyenMai.HeaderText = "Khuyến mãi";
            this.colKhuyenMai.Name = "colKhuyenMai";
            this.colKhuyenMai.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "thanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // colThoiHanBaoHanh
            // 
            this.colThoiHanBaoHanh.DataPropertyName = "thoihanBaoHanh";
            this.colThoiHanBaoHanh.HeaderText = "Thời hạn BH";
            this.colThoiHanBaoHanh.Name = "colThoiHanBaoHanh";
            this.colThoiHanBaoHanh.ReadOnly = true;
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
            this.txtTimKiemNhanh.Location = new System.Drawing.Point(293, 77);
            this.txtTimKiemNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemNhanh.MaxLength = 32767;
            this.txtTimKiemNhanh.Name = "txtTimKiemNhanh";
            this.txtTimKiemNhanh.Size = new System.Drawing.Size(350, 28);
            this.txtTimKiemNhanh.TabIndex = 5;
            this.txtTimKiemNhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemNhanh.OnValueChanged += new System.EventHandler(this.txtTimKiemNhanh_OnValueChanged);
            // 
            // lblTimKiemNhanh
            // 
            this.lblTimKiemNhanh.AutoSize = true;
            this.lblTimKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemNhanh.ForeColor = System.Drawing.Color.White;
            this.lblTimKiemNhanh.Location = new System.Drawing.Point(165, 77);
            this.lblTimKiemNhanh.Name = "lblTimKiemNhanh";
            this.lblTimKiemNhanh.Size = new System.Drawing.Size(128, 20);
            this.lblTimKiemNhanh.TabIndex = 4;
            this.lblTimKiemNhanh.Text = "Tìm kiếm nhanh :";
            // 
            // frmQuanLyBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1112, 710);
            this.Controls.Add(this.txtTimKiemNhanh);
            this.Controls.Add(this.lblTimKiemNhanh);
            this.Controls.Add(this.dgvDanhSachBH);
            this.Controls.Add(this.lblBannerBaoHanhSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyBaoHanh";
            this.Text = "frmQuanLyBaoHanh";
            this.Load += new System.EventHandler(this.frmQuanLyBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerBaoHanhSanPham;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDanhSachBH;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimKiemNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn coMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiHanBaoHanh;
    }
}