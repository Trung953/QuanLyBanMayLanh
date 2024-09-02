namespace QL_BANMAYLANH
{
    partial class Form_CTHD_NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CTHD_NhapHang));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btn_quaylai = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.nbGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboHangHoa = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.nbSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_chitiethd = new System.Windows.Forms.DataGridView();
            this.MAHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnGvHoaDon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMnXoa = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_chitiethd)).BeginInit();
            this.mnGvHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gv_chitiethd);
            this.splitContainer1.Size = new System.Drawing.Size(1166, 966);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator1,
            this.btnSua,
            this.toolStripSeparator2,
            this.btnXoa,
            this.toolStripSeparator3,
            this.btnLuu,
            this.toolStripSeparator4,
            this.btnHuy,
            this.toolStripSeparator5,
            this.txtSearch,
            this.btnTimKiem,
            this.btnRefresh,
            this.btn_quaylai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 191);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1166, 41);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 36);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 36);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 36);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 36);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 41);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 36);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 41);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 41);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(138, 36);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 36);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("btn_quaylai.Image")));
            this.btn_quaylai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(185, 36);
            this.btn_quaylai.Text = "Quay lại HDN";
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(331, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(548, 38);
            this.label4.TabIndex = 17;
            this.label4.Text = "CHI TIẾT HÓA ĐƠN NHẬP HÀNG";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 374F));
            this.tableLayoutPanel1.Controls.Add(this.txtMaHoaDon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nbGiamGia, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTongTien, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboHangHoa, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDonGia, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nbSoLuong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 51);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 137);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(124, 4);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(250, 32);
            this.txtMaHoaDon.TabIndex = 22;
            // 
            // nbGiamGia
            // 
            this.nbGiamGia.Location = new System.Drawing.Point(124, 83);
            this.nbGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.nbGiamGia.Name = "nbGiamGia";
            this.nbGiamGia.Size = new System.Drawing.Size(177, 32);
            this.nbGiamGia.TabIndex = 21;
            this.nbGiamGia.ValueChanged += new System.EventHandler(this.nbGiamGia_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 52);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giảm Giá (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 52);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(495, 83);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(356, 32);
            this.txtTongTien.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 42);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã Hàng hóa\r\n";
            // 
            // cboHangHoa
            // 
            this.cboHangHoa.FormattingEnabled = true;
            this.cboHangHoa.Location = new System.Drawing.Point(499, 6);
            this.cboHangHoa.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.cboHangHoa.Name = "cboHangHoa";
            this.cboHangHoa.Size = new System.Drawing.Size(358, 34);
            this.cboHangHoa.TabIndex = 1;
            this.cboHangHoa.SelectedIndexChanged += new System.EventHandler(this.cboHangHoa_SelectedIndexChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(495, 46);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(356, 32);
            this.txtDonGia.TabIndex = 17;
            // 
            // nbSoLuong
            // 
            this.nbSoLuong.Location = new System.Drawing.Point(124, 46);
            this.nbSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.nbSoLuong.Name = "nbSoLuong";
            this.nbSoLuong.Size = new System.Drawing.Size(177, 32);
            this.nbSoLuong.TabIndex = 19;
            this.nbSoLuong.ValueChanged += new System.EventHandler(this.nbSoLuong_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Đơn giá";
            // 
            // gv_chitiethd
            // 
            this.gv_chitiethd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_chitiethd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHDN,
            this.MAHH,
            this.TENHH,
            this.SOLUONG,
            this.DONGIA,
            this.GIAMGIA,
            this.THANHTIEN});
            this.gv_chitiethd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_chitiethd.Location = new System.Drawing.Point(0, 0);
            this.gv_chitiethd.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gv_chitiethd.Name = "gv_chitiethd";
            this.gv_chitiethd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_chitiethd.RowHeadersWidth = 51;
            this.gv_chitiethd.RowTemplate.ContextMenuStrip = this.mnGvHoaDon;
            this.gv_chitiethd.Size = new System.Drawing.Size(1166, 727);
            this.gv_chitiethd.TabIndex = 0;
            this.gv_chitiethd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvChiTietHoaDon_CellClick);
            // 
            // MAHDN
            // 
            this.MAHDN.DataPropertyName = "MAHDN";
            this.MAHDN.HeaderText = "MÃ HDN";
            this.MAHDN.MinimumWidth = 6;
            this.MAHDN.Name = "MAHDN";
            this.MAHDN.Width = 125;
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "MÃ HÀNG HÓA";
            this.MAHH.MinimumWidth = 6;
            this.MAHH.Name = "MAHH";
            this.MAHH.Width = 200;
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "TÊN HÀNG HÓA";
            this.TENHH.MinimumWidth = 6;
            this.TENHH.Name = "TENHH";
            this.TENHH.Width = 260;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "SỐ LƯỢNG";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 150;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "ĐƠN GIÁ";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 125;
            // 
            // GIAMGIA
            // 
            this.GIAMGIA.DataPropertyName = "GIAMGIA";
            this.GIAMGIA.HeaderText = "GIẢM GIÁ";
            this.GIAMGIA.MinimumWidth = 6;
            this.GIAMGIA.Name = "GIAMGIA";
            this.GIAMGIA.Width = 125;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "THANHTIEN";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Width = 125;
            // 
            // mnGvHoaDon
            // 
            this.mnGvHoaDon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnGvHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMnSua,
            this.btnMnXoa});
            this.mnGvHoaDon.Name = "mnGvHoaDon";
            this.mnGvHoaDon.Size = new System.Drawing.Size(120, 68);
            // 
            // btnMnSua
            // 
            this.btnMnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnMnSua.Image")));
            this.btnMnSua.Name = "btnMnSua";
            this.btnMnSua.Size = new System.Drawing.Size(119, 32);
            this.btnMnSua.Text = "Sửa";
            this.btnMnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnMnXoa
            // 
            this.btnMnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnMnXoa.Image")));
            this.btnMnXoa.Name = "btnMnXoa";
            this.btnMnXoa.Size = new System.Drawing.Size(119, 32);
            this.btnMnXoa.Text = "Xóa";
            this.btnMnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form_CTHD_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 966);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_CTHD_NhapHang";
            this.Text = "Chi tiết hóa đơn nhập hàng";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_chitiethd)).EndInit();
            this.mnGvHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboHangHoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.DataGridView gv_chitiethd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbSoLuong;
        private System.Windows.Forms.NumericUpDown nbGiamGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ContextMenuStrip mnGvHoaDon;
        private System.Windows.Forms.ToolStripMenuItem btnMnSua;
        private System.Windows.Forms.ToolStripMenuItem btnMnXoa;
        private System.Windows.Forms.ToolStripButton btn_quaylai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}