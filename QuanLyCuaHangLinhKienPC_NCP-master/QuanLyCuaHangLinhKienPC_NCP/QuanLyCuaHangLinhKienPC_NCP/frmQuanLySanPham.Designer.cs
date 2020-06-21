namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmQuanLySanPham
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Tất Cả");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Tai Nghe");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Chuột");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Card Đồ Họa");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Case");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("MainBroad");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("CPU");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Micro");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Bàn Di Chuột");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Bàn Phím");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Fan");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Màn Hình PC");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySanPham));
            this.panelDanhMucSP = new System.Windows.Forms.Panel();
            this.lvwDanhMucSanPham = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDanhMucSanPham = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvDanhSachSP = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaGoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.numericKhuyenMai = new DevExpress.XtraEditors.SpinEdit();
            this.numericSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.cboXuatXu = new System.Windows.Forms.ComboBox();
            this.lblXuatXu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBaoHanh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtpBaoHanh = new DevExpress.XtraEditors.DateEdit();
            this.dtpNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTenSP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTenSP = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtGiaBan = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtGiaGoc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblGiaBan = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMaNCC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMaSP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblKhuyenMai = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGiaGoc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSoLuong = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMaSP = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLuuCapNhat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThongTinSPBanner = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCapNhat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNhapHang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTimKiemNhanh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTimKiemNhanh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBannerQuanLySP = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnQuayVeTrangChinh = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelDanhMucSP.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKhuyenMai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaoHanh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaoHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDanhMucSP
            // 
            this.panelDanhMucSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDanhMucSP.Controls.Add(this.lvwDanhMucSanPham);
            this.panelDanhMucSP.Controls.Add(this.panel2);
            this.panelDanhMucSP.Location = new System.Drawing.Point(5, 122);
            this.panelDanhMucSP.Name = "panelDanhMucSP";
            this.panelDanhMucSP.Size = new System.Drawing.Size(176, 602);
            this.panelDanhMucSP.TabIndex = 6;
            // 
            // lvwDanhMucSanPham
            // 
            this.lvwDanhMucSanPham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvwDanhMucSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDanhMucSanPham.ForeColor = System.Drawing.Color.Black;
            this.lvwDanhMucSanPham.HideSelection = false;
            this.lvwDanhMucSanPham.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lvwDanhMucSanPham.Location = new System.Drawing.Point(3, 46);
            this.lvwDanhMucSanPham.Name = "lvwDanhMucSanPham";
            this.lvwDanhMucSanPham.Size = new System.Drawing.Size(170, 556);
            this.lvwDanhMucSanPham.TabIndex = 7;
            this.lvwDanhMucSanPham.UseCompatibleStateImageBehavior = false;
            this.lvwDanhMucSanPham.View = System.Windows.Forms.View.Tile;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblDanhMucSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 35);
            this.panel2.TabIndex = 0;
            // 
            // lblDanhMucSanPham
            // 
            this.lblDanhMucSanPham.AutoSize = true;
            this.lblDanhMucSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucSanPham.ForeColor = System.Drawing.Color.Black;
            this.lblDanhMucSanPham.Location = new System.Drawing.Point(7, 6);
            this.lblDanhMucSanPham.Name = "lblDanhMucSanPham";
            this.lblDanhMucSanPham.Size = new System.Drawing.Size(156, 20);
            this.lblDanhMucSanPham.TabIndex = 0;
            this.lblDanhMucSanPham.Text = "Danh mục sản phẩm";
            // 
            // dgvDanhSachSP
            // 
            this.dgvDanhSachSP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSP.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDanhSachSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachSP.ColumnHeadersHeight = 35;
            this.dgvDanhSachSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoai,
            this.colGiaGoc,
            this.colGiaBan,
            this.colSoLuongTon,
            this.colBaoHanh,
            this.colKhuyenMai,
            this.colMaNCC,
            this.colXuatXu,
            this.colNgayNhap});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachSP.DoubleBuffered = true;
            this.dgvDanhSachSP.EnableHeadersVisualStyles = false;
            this.dgvDanhSachSP.HeaderBgColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachSP.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachSP.Location = new System.Drawing.Point(186, 122);
            this.dgvDanhSachSP.Name = "dgvDanhSachSP";
            this.dgvDanhSachSP.ReadOnly = true;
            this.dgvDanhSachSP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachSP.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDanhSachSP.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachSP.RowTemplate.Height = 30;
            this.dgvDanhSachSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachSP.Size = new System.Drawing.Size(1096, 300);
            this.dgvDanhSachSP.TabIndex = 24;
            this.dgvDanhSachSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSP_CellClick);
            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "MaSP";
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.HeaderText = "Tên SP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colLoai
            // 
            this.colLoai.DataPropertyName = "LoaiSP";
            this.colLoai.HeaderText = "Loại";
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colGiaGoc
            // 
            this.colGiaGoc.DataPropertyName = "GiaGoc";
            this.colGiaGoc.HeaderText = "Giá gốc";
            this.colGiaGoc.Name = "colGiaGoc";
            this.colGiaGoc.ReadOnly = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "GiaBan";
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "SLT";
            this.colSoLuongTon.HeaderText = "SL tồn";
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.ReadOnly = true;
            // 
            // colBaoHanh
            // 
            this.colBaoHanh.DataPropertyName = "BaoHanh";
            this.colBaoHanh.HeaderText = "Bảo hành";
            this.colBaoHanh.Name = "colBaoHanh";
            this.colBaoHanh.ReadOnly = true;
            // 
            // colKhuyenMai
            // 
            this.colKhuyenMai.DataPropertyName = "KM";
            this.colKhuyenMai.HeaderText = "KM (%)";
            this.colKhuyenMai.Name = "colKhuyenMai";
            this.colKhuyenMai.ReadOnly = true;
            // 
            // colMaNCC
            // 
            this.colMaNCC.DataPropertyName = "MaNCC";
            this.colMaNCC.HeaderText = "Mã NCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.ReadOnly = true;
            // 
            // colXuatXu
            // 
            this.colXuatXu.DataPropertyName = "XuatXu";
            this.colXuatXu.HeaderText = "Xuất xứ";
            this.colXuatXu.Name = "colXuatXu";
            this.colXuatXu.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.DataPropertyName = "NgayNhap";
            this.colNgayNhap.HeaderText = "Ngày nhập";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel.Controls.Add(this.numericKhuyenMai);
            this.panel.Controls.Add(this.numericSoLuong);
            this.panel.Controls.Add(this.cboXuatXu);
            this.panel.Controls.Add(this.lblXuatXu);
            this.panel.Controls.Add(this.lblBaoHanh);
            this.panel.Controls.Add(this.cboLoai);
            this.panel.Controls.Add(this.bunifuCustomLabel3);
            this.panel.Controls.Add(this.dtpBaoHanh);
            this.panel.Controls.Add(this.dtpNgayNhap);
            this.panel.Controls.Add(this.bunifuCustomLabel2);
            this.panel.Controls.Add(this.txtTenSP);
            this.panel.Controls.Add(this.lblTenSP);
            this.panel.Controls.Add(this.txtGiaBan);
            this.panel.Controls.Add(this.txtGiaGoc);
            this.panel.Controls.Add(this.lblGiaBan);
            this.panel.Controls.Add(this.txtMaNCC);
            this.panel.Controls.Add(this.txtMaSP);
            this.panel.Controls.Add(this.lblKhuyenMai);
            this.panel.Controls.Add(this.lblGiaGoc);
            this.panel.Controls.Add(this.bunifuCustomLabel1);
            this.panel.Controls.Add(this.lblSoLuong);
            this.panel.Controls.Add(this.lblMaSP);
            this.panel.Controls.Add(this.btnLuuCapNhat);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.btnCapNhat);
            this.panel.Controls.Add(this.btnXoa);
            this.panel.Controls.Add(this.btnNhapHang);
            this.panel.Location = new System.Drawing.Point(186, 428);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1097, 296);
            this.panel.TabIndex = 25;
            // 
            // numericKhuyenMai
            // 
            this.numericKhuyenMai.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericKhuyenMai.Enabled = false;
            this.numericKhuyenMai.Location = new System.Drawing.Point(384, 174);
            this.numericKhuyenMai.Name = "numericKhuyenMai";
            this.numericKhuyenMai.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericKhuyenMai.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.numericKhuyenMai.Properties.Appearance.Options.UseFont = true;
            this.numericKhuyenMai.Properties.Appearance.Options.UseForeColor = true;
            this.numericKhuyenMai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numericKhuyenMai.Properties.IsFloatValue = false;
            this.numericKhuyenMai.Properties.Mask.EditMask = "N00";
            this.numericKhuyenMai.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericKhuyenMai.Size = new System.Drawing.Size(85, 26);
            this.numericKhuyenMai.TabIndex = 16;
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericSoLuong.Enabled = false;
            this.numericSoLuong.Location = new System.Drawing.Point(161, 115);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSoLuong.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.numericSoLuong.Properties.Appearance.Options.UseFont = true;
            this.numericSoLuong.Properties.Appearance.Options.UseForeColor = true;
            this.numericSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numericSoLuong.Properties.IsFloatValue = false;
            this.numericSoLuong.Properties.Mask.EditMask = "N00";
            this.numericSoLuong.Size = new System.Drawing.Size(85, 26);
            this.numericSoLuong.TabIndex = 16;
            // 
            // cboXuatXu
            // 
            this.cboXuatXu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboXuatXu.Enabled = false;
            this.cboXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboXuatXu.ForeColor = System.Drawing.Color.Black;
            this.cboXuatXu.FormattingEnabled = true;
            this.cboXuatXu.Items.AddRange(new object[] {
            "Admin",
            "Thu Ngân",
            "Chăm Sóc Khách Hàng"});
            this.cboXuatXu.Location = new System.Drawing.Point(647, 170);
            this.cboXuatXu.Name = "cboXuatXu";
            this.cboXuatXu.Size = new System.Drawing.Size(138, 28);
            this.cboXuatXu.TabIndex = 15;
            // 
            // lblXuatXu
            // 
            this.lblXuatXu.AutoSize = true;
            this.lblXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXuatXu.ForeColor = System.Drawing.Color.Black;
            this.lblXuatXu.Location = new System.Drawing.Point(550, 177);
            this.lblXuatXu.Name = "lblXuatXu";
            this.lblXuatXu.Size = new System.Drawing.Size(71, 20);
            this.lblXuatXu.TabIndex = 12;
            this.lblXuatXu.Text = "Xuất xứ :";
            // 
            // lblBaoHanh
            // 
            this.lblBaoHanh.AutoSize = true;
            this.lblBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoHanh.ForeColor = System.Drawing.Color.Black;
            this.lblBaoHanh.Location = new System.Drawing.Point(805, 118);
            this.lblBaoHanh.Name = "lblBaoHanh";
            this.lblBaoHanh.Size = new System.Drawing.Size(86, 20);
            this.lblBaoHanh.TabIndex = 12;
            this.lblBaoHanh.Text = "Bảo hành :";
            // 
            // cboLoai
            // 
            this.cboLoai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboLoai.Enabled = false;
            this.cboLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoai.ForeColor = System.Drawing.Color.Black;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "Admin",
            "Thu Ngân",
            "Chăm Sóc Khách Hàng"});
            this.cboLoai.Location = new System.Drawing.Point(897, 56);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(158, 28);
            this.cboLoai.TabIndex = 15;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(805, 60);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(47, 20);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Loại :";
            // 
            // dtpBaoHanh
            // 
            this.dtpBaoHanh.EditValue = new System.DateTime(2020, 6, 7, 0, 0, 0, 0);
            this.dtpBaoHanh.Enabled = false;
            this.dtpBaoHanh.Location = new System.Drawing.Point(897, 115);
            this.dtpBaoHanh.Name = "dtpBaoHanh";
            this.dtpBaoHanh.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBaoHanh.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dtpBaoHanh.Properties.Appearance.Options.UseFont = true;
            this.dtpBaoHanh.Properties.Appearance.Options.UseForeColor = true;
            this.dtpBaoHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBaoHanh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBaoHanh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpBaoHanh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpBaoHanh.Size = new System.Drawing.Size(158, 26);
            this.dtpBaoHanh.TabIndex = 14;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.EditValue = new System.DateTime(2020, 6, 7, 23, 51, 32, 0);
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Location = new System.Drawing.Point(647, 58);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dtpNgayNhap.Properties.Appearance.Options.UseFont = true;
            this.dtpNgayNhap.Properties.Appearance.Options.UseForeColor = true;
            this.dtpNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayNhap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpNgayNhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgayNhap.Size = new System.Drawing.Size(138, 26);
            this.dtpNgayNhap.TabIndex = 14;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(548, 61);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(93, 20);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Ngày nhập :";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.txtTenSP.BorderColorIdle = System.Drawing.Color.Black;
            this.txtTenSP.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.txtTenSP.BorderThickness = 2;
            this.txtTenSP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.Enabled = false;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.isPassword = false;
            this.txtTenSP.Location = new System.Drawing.Point(384, 60);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.MaxLength = 32767;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(141, 28);
            this.txtTenSP.TabIndex = 13;
            this.txtTenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.Black;
            this.lblTenSP.Location = new System.Drawing.Point(264, 60);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(118, 20);
            this.lblTenSP.TabIndex = 12;
            this.lblTenSP.Text = "Tên sản phẩm :";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.txtGiaBan.BorderColorIdle = System.Drawing.Color.Black;
            this.txtGiaBan.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.txtGiaBan.BorderThickness = 2;
            this.txtGiaBan.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.ForeColor = System.Drawing.Color.Black;
            this.txtGiaBan.isPassword = false;
            this.txtGiaBan.Location = new System.Drawing.Point(647, 110);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBan.MaxLength = 32767;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(138, 28);
            this.txtGiaBan.TabIndex = 13;
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.txtGiaGoc.BorderColorIdle = System.Drawing.Color.Black;
            this.txtGiaGoc.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.txtGiaGoc.BorderThickness = 2;
            this.txtGiaGoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGiaGoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaGoc.Enabled = false;
            this.txtGiaGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaGoc.ForeColor = System.Drawing.Color.Black;
            this.txtGiaGoc.isPassword = false;
            this.txtGiaGoc.Location = new System.Drawing.Point(384, 113);
            this.txtGiaGoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaGoc.MaxLength = 32767;
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.Size = new System.Drawing.Size(141, 28);
            this.txtGiaGoc.TabIndex = 13;
            this.txtGiaGoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.ForeColor = System.Drawing.Color.Black;
            this.lblGiaBan.Location = new System.Drawing.Point(548, 118);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(73, 20);
            this.lblGiaBan.TabIndex = 12;
            this.lblGiaBan.Text = "Giá bán :";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaNCC.BorderColorIdle = System.Drawing.Color.Black;
            this.txtMaNCC.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaNCC.BorderThickness = 2;
            this.txtMaNCC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.ForeColor = System.Drawing.Color.Black;
            this.txtMaNCC.isPassword = false;
            this.txtMaNCC.Location = new System.Drawing.Point(161, 170);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.MaxLength = 32767;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(85, 28);
            this.txtMaNCC.TabIndex = 13;
            this.txtMaNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaSP.BorderColorIdle = System.Drawing.Color.Black;
            this.txtMaSP.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaSP.BorderThickness = 2;
            this.txtMaSP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.isPassword = false;
            this.txtMaSP.Location = new System.Drawing.Point(161, 60);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.MaxLength = 32767;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(85, 28);
            this.txtMaSP.TabIndex = 13;
            this.txtMaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblKhuyenMai
            // 
            this.lblKhuyenMai.AutoSize = true;
            this.lblKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.lblKhuyenMai.Location = new System.Drawing.Point(264, 177);
            this.lblKhuyenMai.Name = "lblKhuyenMai";
            this.lblKhuyenMai.Size = new System.Drawing.Size(99, 20);
            this.lblKhuyenMai.TabIndex = 12;
            this.lblKhuyenMai.Text = "Khuyến mãi :";
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGoc.ForeColor = System.Drawing.Color.Black;
            this.lblGiaGoc.Location = new System.Drawing.Point(270, 118);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(72, 20);
            this.lblGiaGoc.TabIndex = 12;
            this.lblGiaGoc.Text = "Giá gốc :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 177);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(111, 20);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Nhà cung cấp:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuong.Location = new System.Drawing.Point(41, 118);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(80, 20);
            this.lblSoLuong.TabIndex = 12;
            this.lblSoLuong.Text = "Số lượng :";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.Color.Black;
            this.lblMaSP.Location = new System.Drawing.Point(41, 60);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(113, 20);
            this.lblMaSP.TabIndex = 12;
            this.lblMaSP.Text = "Mã sản phẩm :";
            // 
            // btnLuuCapNhat
            // 
            this.btnLuuCapNhat.ActiveBorderThickness = 1;
            this.btnLuuCapNhat.ActiveCornerRadius = 1;
            this.btnLuuCapNhat.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.btnLuuCapNhat.ActiveForecolor = System.Drawing.Color.White;
            this.btnLuuCapNhat.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.btnLuuCapNhat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLuuCapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuuCapNhat.BackgroundImage")));
            this.btnLuuCapNhat.ButtonText = "Lưu cập nhật";
            this.btnLuuCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnLuuCapNhat.IdleBorderThickness = 1;
            this.btnLuuCapNhat.IdleCornerRadius = 1;
            this.btnLuuCapNhat.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnLuuCapNhat.IdleForecolor = System.Drawing.Color.White;
            this.btnLuuCapNhat.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnLuuCapNhat.Location = new System.Drawing.Point(606, 227);
            this.btnLuuCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuuCapNhat.Name = "btnLuuCapNhat";
            this.btnLuuCapNhat.Size = new System.Drawing.Size(110, 49);
            this.btnLuuCapNhat.TabIndex = 7;
            this.btnLuuCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuuCapNhat.Visible = false;
            this.btnLuuCapNhat.Click += new System.EventHandler(this.btnLuuCapNhat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.lblThongTinSPBanner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblThongTinSPBanner
            // 
            this.lblThongTinSPBanner.AutoSize = true;
            this.lblThongTinSPBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinSPBanner.ForeColor = System.Drawing.Color.Black;
            this.lblThongTinSPBanner.Location = new System.Drawing.Point(461, 6);
            this.lblThongTinSPBanner.Name = "lblThongTinSPBanner";
            this.lblThongTinSPBanner.Size = new System.Drawing.Size(167, 20);
            this.lblThongTinSPBanner.TabIndex = 0;
            this.lblThongTinSPBanner.Text = "Thông tin sản phẩm";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ActiveBorderThickness = 1;
            this.btnCapNhat.ActiveCornerRadius = 1;
            this.btnCapNhat.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(188)))), ((int)(((byte)(66)))));
            this.btnCapNhat.ActiveForecolor = System.Drawing.Color.Black;
            this.btnCapNhat.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(188)))), ((int)(((byte)(66)))));
            this.btnCapNhat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.BackgroundImage")));
            this.btnCapNhat.ButtonText = "Cập nhật";
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.IdleBorderThickness = 1;
            this.btnCapNhat.IdleCornerRadius = 1;
            this.btnCapNhat.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnCapNhat.IdleForecolor = System.Drawing.Color.Black;
            this.btnCapNhat.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnCapNhat.Location = new System.Drawing.Point(606, 227);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 49);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveBorderThickness = 1;
            this.btnXoa.ActiveCornerRadius = 1;
            this.btnXoa.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.btnXoa.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoa.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.btnXoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleCornerRadius = 1;
            this.btnXoa.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnXoa.IdleForecolor = System.Drawing.Color.White;
            this.btnXoa.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnXoa.Location = new System.Drawing.Point(488, 227);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 49);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.ActiveBorderThickness = 1;
            this.btnNhapHang.ActiveCornerRadius = 1;
            this.btnNhapHang.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(223)))));
            this.btnNhapHang.ActiveForecolor = System.Drawing.Color.White;
            this.btnNhapHang.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(223)))));
            this.btnNhapHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhapHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.BackgroundImage")));
            this.btnNhapHang.ButtonText = "Nhập hàng";
            this.btnNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.IdleBorderThickness = 1;
            this.btnNhapHang.IdleCornerRadius = 1;
            this.btnNhapHang.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnNhapHang.IdleForecolor = System.Drawing.Color.White;
            this.btnNhapHang.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnNhapHang.Location = new System.Drawing.Point(370, 227);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(110, 49);
            this.btnNhapHang.TabIndex = 5;
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // txtTimKiemNhanh
            // 
            this.txtTimKiemNhanh.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.txtTimKiemNhanh.BorderColorIdle = System.Drawing.Color.Black;
            this.txtTimKiemNhanh.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.txtTimKiemNhanh.BorderThickness = 2;
            this.txtTimKiemNhanh.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemNhanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanh.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemNhanh.isPassword = false;
            this.txtTimKiemNhanh.Location = new System.Drawing.Point(529, 80);
            this.txtTimKiemNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemNhanh.MaxLength = 32767;
            this.txtTimKiemNhanh.Name = "txtTimKiemNhanh";
            this.txtTimKiemNhanh.Size = new System.Drawing.Size(350, 28);
            this.txtTimKiemNhanh.TabIndex = 27;
            this.txtTimKiemNhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemNhanh.OnValueChanged += new System.EventHandler(this.txtTimKiemNhanh_OnValueChanged);
            // 
            // lblTimKiemNhanh
            // 
            this.lblTimKiemNhanh.AutoSize = true;
            this.lblTimKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemNhanh.ForeColor = System.Drawing.Color.Black;
            this.lblTimKiemNhanh.Location = new System.Drawing.Point(401, 82);
            this.lblTimKiemNhanh.Name = "lblTimKiemNhanh";
            this.lblTimKiemNhanh.Size = new System.Drawing.Size(128, 20);
            this.lblTimKiemNhanh.TabIndex = 26;
            this.lblTimKiemNhanh.Text = "Tìm kiếm nhanh :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.lblBannerQuanLySP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1290, 67);
            this.panel3.TabIndex = 47;
            // 
            // lblBannerQuanLySP
            // 
            this.lblBannerQuanLySP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBannerQuanLySP.AutoSize = true;
            this.lblBannerQuanLySP.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerQuanLySP.ForeColor = System.Drawing.Color.White;
            this.lblBannerQuanLySP.Location = new System.Drawing.Point(418, 12);
            this.lblBannerQuanLySP.Name = "lblBannerQuanLySP";
            this.lblBannerQuanLySP.Size = new System.Drawing.Size(461, 42);
            this.lblBannerQuanLySP.TabIndex = 41;
            this.lblBannerQuanLySP.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // btnQuayVeTrangChinh
            // 
            this.btnQuayVeTrangChinh.ActiveBorderThickness = 1;
            this.btnQuayVeTrangChinh.ActiveCornerRadius = 1;
            this.btnQuayVeTrangChinh.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnQuayVeTrangChinh.ActiveForecolor = System.Drawing.Color.White;
            this.btnQuayVeTrangChinh.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnQuayVeTrangChinh.BackColor = System.Drawing.Color.White;
            this.btnQuayVeTrangChinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuayVeTrangChinh.BackgroundImage")));
            this.btnQuayVeTrangChinh.ButtonText = "Quay về trang chính";
            this.btnQuayVeTrangChinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayVeTrangChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVeTrangChinh.ForeColor = System.Drawing.Color.White;
            this.btnQuayVeTrangChinh.IdleBorderThickness = 1;
            this.btnQuayVeTrangChinh.IdleCornerRadius = 1;
            this.btnQuayVeTrangChinh.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.btnQuayVeTrangChinh.IdleForecolor = System.Drawing.Color.White;
            this.btnQuayVeTrangChinh.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.btnQuayVeTrangChinh.Location = new System.Drawing.Point(5, 69);
            this.btnQuayVeTrangChinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuayVeTrangChinh.Name = "btnQuayVeTrangChinh";
            this.btnQuayVeTrangChinh.Size = new System.Drawing.Size(160, 49);
            this.btnQuayVeTrangChinh.TabIndex = 48;
            this.btnQuayVeTrangChinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 729);
            this.Controls.Add(this.btnQuayVeTrangChinh);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtTimKiemNhanh);
            this.Controls.Add(this.lblTimKiemNhanh);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgvDanhSachSP);
            this.Controls.Add(this.panelDanhMucSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLySanPham";
            this.Load += new System.EventHandler(this.frmQuanLySanPham_Load);
            this.panelDanhMucSP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKhuyenMai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaoHanh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaoHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelDanhMucSP;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDanhMucSanPham;
        private System.Windows.Forms.ListView lvwDanhMucSanPham;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDanhSachSP;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblThongTinSPBanner;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimKiemNhanh;
        private DevExpress.XtraEditors.SpinEdit numericKhuyenMai;
        private DevExpress.XtraEditors.SpinEdit numericSoLuong;
        private System.Windows.Forms.ComboBox cboXuatXu;
        private Bunifu.Framework.UI.BunifuCustomLabel lblXuatXu;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBaoHanh;
        private System.Windows.Forms.ComboBox cboLoai;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private DevExpress.XtraEditors.DateEdit dtpNgayNhap;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTenSP;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTenSP;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGiaBan;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGiaGoc;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGiaBan;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMaSP;
        private Bunifu.Framework.UI.BunifuCustomLabel lblKhuyenMai;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGiaGoc;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSoLuong;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMaSP;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuuCapNhat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCapNhat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaGoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMaNCC;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private DevExpress.XtraEditors.DateEdit dtpBaoHanh;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerQuanLySP;
        private Bunifu.Framework.UI.BunifuThinButton2 btnQuayVeTrangChinh;
    }
}