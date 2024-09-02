namespace QL_BANMAYLANH
{
    partial class Form_LoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LoaiHang));
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.labelML = new System.Windows.Forms.Label();
            this.labelTL = new System.Windows.Forms.Label();
            this.labelTruSoC = new System.Windows.Forms.Label();
            this.textBoxML = new System.Windows.Forms.TextBox();
            this.textBoxTL = new System.Windows.Forms.TextBox();
            this.textBoxTruSoC = new System.Windows.Forms.TextBox();
            this.buttonTK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRUSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelSTT = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(12, 165);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(94, 48);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.Image")));
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoa.Location = new System.Drawing.Point(123, 167);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(89, 48);
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
            this.buttonSua.Location = new System.Drawing.Point(229, 167);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(85, 49);
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
            this.buttonLuu.Location = new System.Drawing.Point(331, 168);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(80, 48);
            this.buttonLuu.TabIndex = 0;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // labelML
            // 
            this.labelML.AutoSize = true;
            this.labelML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelML.Location = new System.Drawing.Point(3, 0);
            this.labelML.Name = "labelML";
            this.labelML.Size = new System.Drawing.Size(74, 22);
            this.labelML.TabIndex = 1;
            this.labelML.Text = "Mã loại";
            // 
            // labelTL
            // 
            this.labelTL.AutoSize = true;
            this.labelTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTL.Location = new System.Drawing.Point(3, 45);
            this.labelTL.Name = "labelTL";
            this.labelTL.Size = new System.Drawing.Size(83, 22);
            this.labelTL.TabIndex = 1;
            this.labelTL.Text = "Tên loại";
            // 
            // labelTruSoC
            // 
            this.labelTruSoC.AutoSize = true;
            this.labelTruSoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTruSoC.Location = new System.Drawing.Point(339, 0);
            this.labelTruSoC.Name = "labelTruSoC";
            this.labelTruSoC.Size = new System.Drawing.Size(122, 22);
            this.labelTruSoC.TabIndex = 1;
            this.labelTruSoC.Text = "Trụ sở chính";
            // 
            // textBoxML
            // 
            this.textBoxML.Location = new System.Drawing.Point(111, 3);
            this.textBoxML.Multiline = true;
            this.textBoxML.Name = "textBoxML";
            this.textBoxML.Size = new System.Drawing.Size(191, 32);
            this.textBoxML.TabIndex = 2;
            // 
            // textBoxTL
            // 
            this.textBoxTL.Location = new System.Drawing.Point(111, 48);
            this.textBoxTL.Multiline = true;
            this.textBoxTL.Name = "textBoxTL";
            this.textBoxTL.Size = new System.Drawing.Size(191, 32);
            this.textBoxTL.TabIndex = 2;
            // 
            // textBoxTruSoC
            // 
            this.textBoxTruSoC.Location = new System.Drawing.Point(473, 3);
            this.textBoxTruSoC.Multiline = true;
            this.textBoxTruSoC.Name = "textBoxTruSoC";
            this.textBoxTruSoC.Size = new System.Drawing.Size(278, 32);
            this.textBoxTruSoC.TabIndex = 2;
            // 
            // buttonTK
            // 
            this.buttonTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTK.Image = ((System.Drawing.Image)(resources.GetObject("buttonTK.Image")));
            this.buttonTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTK.Location = new System.Drawing.Point(566, 168);
            this.buttonTK.Name = "buttonTK";
            this.buttonTK.Size = new System.Drawing.Size(118, 48);
            this.buttonTK.TabIndex = 3;
            this.buttonTK.Text = "Tìm kiếm";
            this.buttonTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTK.UseVisualStyleBackColor = true;
            this.buttonTK.Click += new System.EventHandler(this.buttonTK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAI,
            this.TENLOAI,
            this.TRUSO,
            this.EMAIL});
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 261);
            this.dataGridView1.TabIndex = 4;
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "MÃ LOẠI ";
            this.MALOAI.MinimumWidth = 6;
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.Width = 125;
            // 
            // TENLOAI
            // 
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "TÊN LOẠI";
            this.TENLOAI.MinimumWidth = 6;
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.Width = 200;
            // 
            // TRUSO
            // 
            this.TRUSO.DataPropertyName = "TRUSOCHINH";
            this.TRUSO.HeaderText = "TRỤ SỞ";
            this.TRUSO.MinimumWidth = 6;
            this.TRUSO.Name = "TRUSO";
            this.TRUSO.Width = 200;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 200;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(339, 45);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 22);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(473, 48);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(278, 32);
            this.textBoxEmail.TabIndex = 6;
            // 
            // labelSTT
            // 
            this.labelSTT.AutoSize = true;
            this.labelSTT.Location = new System.Drawing.Point(396, 276);
            this.labelSTT.Name = "labelSTT";
            this.labelSTT.Size = new System.Drawing.Size(0, 16);
            this.labelSTT.TabIndex = 7;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.Image")));
            this.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoat.Location = new System.Drawing.Point(690, 168);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(98, 49);
            this.buttonThoat.TabIndex = 10;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(208, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "DANH SÁCH LOẠI HÀNG HÓA";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.15259F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.84741F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tableLayoutPanel1.Controls.Add(this.labelEmail, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTruSoC, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelML, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxML, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEmail, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTruSoC, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 90);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 179);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 37);
            this.textBox1.TabIndex = 21;
            // 
            // Form_LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(818, 506);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.labelSTT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTK);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Name = "Form_LoaiHang";
            this.Text = "Loại Hàng";
            this.Load += new System.EventHandler(this.FormLHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label labelML;
        private System.Windows.Forms.Label labelTL;
        private System.Windows.Forms.Label labelTruSoC;
        private System.Windows.Forms.TextBox textBoxML;
        private System.Windows.Forms.TextBox textBoxTL;
        private System.Windows.Forms.TextBox textBoxTruSoC;
        private System.Windows.Forms.Button buttonTK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelSTT;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRUSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.TextBox textBox1;
    }
}