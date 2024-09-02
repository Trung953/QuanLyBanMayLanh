namespace QL_BANMAYLANH
{
    partial class Form_HangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HangHoa));
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.labelMHH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGN = new System.Windows.Forms.Label();
            this.labelSL = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewHA = new System.Windows.Forms.DataGridView();
            this.textBoxMH = new System.Windows.Forms.TextBox();
            this.textBoxTH = new System.Windows.Forms.TextBox();
            this.textBoxGN = new System.Windows.Forms.TextBox();
            this.textBoxSL = new System.Windows.Forms.TextBox();
            this.labelML = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMNCC = new System.Windows.Forms.TextBox();
            this.buttonTK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_tskt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_maloai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHA)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(19, 240);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(111, 44);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonXoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.Image")));
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoa.Location = new System.Drawing.Point(151, 240);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(111, 44);
            this.buttonXoa.TabIndex = 0;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Image = ((System.Drawing.Image)(resources.GetObject("buttonSua.Image")));
            this.buttonSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSua.Location = new System.Drawing.Point(313, 240);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(111, 44);
            this.buttonSua.TabIndex = 0;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Image = ((System.Drawing.Image)(resources.GetObject("buttonLuu.Image")));
            this.buttonLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLuu.Location = new System.Drawing.Point(459, 240);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(111, 44);
            this.buttonLuu.TabIndex = 0;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // labelMHH
            // 
            this.labelMHH.AutoSize = true;
            this.labelMHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMHH.Location = new System.Drawing.Point(3, 0);
            this.labelMHH.Name = "labelMHH";
            this.labelMHH.Size = new System.Drawing.Size(86, 22);
            this.labelMHH.TabIndex = 1;
            this.labelMHH.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hàng";
            // 
            // labelGN
            // 
            this.labelGN.AutoSize = true;
            this.labelGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGN.Location = new System.Drawing.Point(3, 80);
            this.labelGN.Name = "labelGN";
            this.labelGN.Size = new System.Drawing.Size(91, 22);
            this.labelGN.TabIndex = 1;
            this.labelGN.Text = "Giá nhập";
            // 
            // labelSL
            // 
            this.labelSL.AutoSize = true;
            this.labelSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSL.Location = new System.Drawing.Point(3, 121);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(89, 22);
            this.labelSL.TabIndex = 1;
            this.labelSL.Text = "Số lượng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHH,
            this.TENHH,
            this.GIANHAP,
            this.HINHANH,
            this.SOLUONG,
            this.MALOAI,
            this.MANCC});
            this.dataGridView1.Location = new System.Drawing.Point(19, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 259);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "MÃ HÀNG";
            this.MAHH.MinimumWidth = 6;
            this.MAHH.Name = "MAHH";
            this.MAHH.Width = 125;
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "TÊN HÀNG";
            this.TENHH.MinimumWidth = 6;
            this.TENHH.Name = "TENHH";
            this.TENHH.Width = 125;
            // 
            // GIANHAP
            // 
            this.GIANHAP.DataPropertyName = "GIANHAP";
            this.GIANHAP.HeaderText = "GIÁ NHẬP";
            this.GIANHAP.MinimumWidth = 6;
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.Width = 125;
            // 
            // HINHANH
            // 
            this.HINHANH.DataPropertyName = "HINHANH";
            this.HINHANH.HeaderText = "HÌNH ẢNH";
            this.HINHANH.MinimumWidth = 6;
            this.HINHANH.Name = "HINHANH";
            this.HINHANH.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "SỐ LƯỢNG";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 125;
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "MÃ LOẠI";
            this.MALOAI.MinimumWidth = 6;
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.Width = 125;
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "MÃ NCC";
            this.MANCC.MinimumWidth = 6;
            this.MANCC.Name = "MANCC";
            this.MANCC.Width = 125;
            // 
            // dataGridViewHA
            // 
            this.dataGridViewHA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHA.Location = new System.Drawing.Point(795, 62);
            this.dataGridViewHA.Name = "dataGridViewHA";
            this.dataGridViewHA.RowHeadersWidth = 51;
            this.dataGridViewHA.RowTemplate.Height = 24;
            this.dataGridViewHA.Size = new System.Drawing.Size(240, 159);
            this.dataGridViewHA.TabIndex = 2;
            this.dataGridViewHA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHA_CellContentClick);
            // 
            // textBoxMH
            // 
            this.textBoxMH.Location = new System.Drawing.Point(148, 3);
            this.textBoxMH.Multiline = true;
            this.textBoxMH.Name = "textBoxMH";
            this.textBoxMH.Size = new System.Drawing.Size(210, 34);
            this.textBoxMH.TabIndex = 3;
            this.textBoxMH.TextChanged += new System.EventHandler(this.textBoxMH_TextChanged);
            // 
            // textBoxTH
            // 
            this.textBoxTH.Location = new System.Drawing.Point(148, 43);
            this.textBoxTH.Multiline = true;
            this.textBoxTH.Name = "textBoxTH";
            this.textBoxTH.Size = new System.Drawing.Size(210, 34);
            this.textBoxTH.TabIndex = 3;
            // 
            // textBoxGN
            // 
            this.textBoxGN.Location = new System.Drawing.Point(148, 83);
            this.textBoxGN.Multiline = true;
            this.textBoxGN.Name = "textBoxGN";
            this.textBoxGN.Size = new System.Drawing.Size(210, 35);
            this.textBoxGN.TabIndex = 3;
            // 
            // textBoxSL
            // 
            this.textBoxSL.Location = new System.Drawing.Point(148, 124);
            this.textBoxSL.Multiline = true;
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.Size = new System.Drawing.Size(210, 32);
            this.textBoxSL.TabIndex = 3;
            // 
            // labelML
            // 
            this.labelML.AutoSize = true;
            this.labelML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelML.Location = new System.Drawing.Point(412, 0);
            this.labelML.Name = "labelML";
            this.labelML.Size = new System.Drawing.Size(74, 22);
            this.labelML.TabIndex = 5;
            this.labelML.Text = "Mã loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã NCC";
            // 
            // textBoxMNCC
            // 
            this.textBoxMNCC.Location = new System.Drawing.Point(520, 43);
            this.textBoxMNCC.Multiline = true;
            this.textBoxMNCC.Name = "textBoxMNCC";
            this.textBoxMNCC.Size = new System.Drawing.Size(227, 34);
            this.textBoxMNCC.TabIndex = 7;
            // 
            // buttonTK
            // 
            this.buttonTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTK.Image = ((System.Drawing.Image)(resources.GetObject("buttonTK.Image")));
            this.buttonTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTK.Location = new System.Drawing.Point(905, 244);
            this.buttonTK.Name = "buttonTK";
            this.buttonTK.Size = new System.Drawing.Size(120, 44);
            this.buttonTK.TabIndex = 8;
            this.buttonTK.Text = "Tìm kiếm";
            this.buttonTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTK.UseVisualStyleBackColor = true;
            this.buttonTK.Click += new System.EventHandler(this.buttonTK_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.52239F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.47762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tableLayoutPanel1.Controls.Add(this.labelMHH, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelGN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSL, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMH, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTH, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelML, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSL, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMNCC, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_tskt, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_maloai, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 159);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btn_tskt
            // 
            this.btn_tskt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tskt.Location = new System.Drawing.Point(520, 124);
            this.btn_tskt.Name = "btn_tskt";
            this.btn_tskt.Size = new System.Drawing.Size(247, 32);
            this.btn_tskt.TabIndex = 8;
            this.btn_tskt.Text = "Xem thông số kỹ thuật ";
            this.btn_tskt.UseVisualStyleBackColor = true;
            this.btn_tskt.Click += new System.EventHandler(this.btn_tskt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 248);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 40);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(330, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "DANH SÁCH HÀNG HÓA";
            // 
            // cb_maloai
            // 
            this.cb_maloai.FormattingEnabled = true;
            this.cb_maloai.Location = new System.Drawing.Point(520, 3);
            this.cb_maloai.Name = "cb_maloai";
            this.cb_maloai.Size = new System.Drawing.Size(227, 24);
            this.cb_maloai.TabIndex = 9;
            // 
            // Form_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonTK);
            this.Controls.Add(this.dataGridViewHA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Name = "Form_HangHoa";
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHA)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Label labelMHH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGN;
        private System.Windows.Forms.Label labelSL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewHA;
        private System.Windows.Forms.TextBox textBoxMH;
        private System.Windows.Forms.TextBox textBoxTH;
        private System.Windows.Forms.TextBox textBoxGN;
        private System.Windows.Forms.TextBox textBoxSL;
        private System.Windows.Forms.Label labelML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMNCC;
        private System.Windows.Forms.Button buttonTK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.Button btn_tskt;
        private System.Windows.Forms.ComboBox cb_maloai;
    }
}

