namespace QL_BANMAYLANH
{
    partial class Form_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NhanVien));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DC = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MABP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 138);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 26);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(903, 128);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(244, 26);
            this.maskedTextBox1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBox1.Location = new System.Drawing.Point(583, 125);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(765, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Điện Thoại";
            // 
            // txt_DC
            // 
            this.txt_DC.Location = new System.Drawing.Point(903, 172);
            this.txt_DC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DC.Name = "txt_DC";
            this.txt_DC.Size = new System.Drawing.Size(244, 26);
            this.txt_DC.TabIndex = 18;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(583, 88);
            this.txt_TenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(564, 26);
            this.txt_TenNV.TabIndex = 19;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(196, 88);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(167, 39);
            this.txt_MaNV.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(765, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(436, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(196, 194);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 28);
            this.comboBox2.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Bộ Phận";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(583, 170);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(175, 26);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ngày Vào Làm";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(38, 244);
            this.txt_find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(403, 26);
            this.txt_find.TabIndex = 30;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(478, 241);
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(96, 40);
            this.btn_find.TabIndex = 31;
            this.btn_find.Text = "Tìm Kiếm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(614, 239);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(84, 42);
            this.btn_clear.TabIndex = 32;
            this.btn_clear.Text = "Xóa";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.MABP,
            this.TENNV,
            this.GITINH,
            this.NGAYVL,
            this.NGSINH,
            this.DIENTHOAI,
            this.DIACHI});
            this.dataGridView1.Location = new System.Drawing.Point(38, 289);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 299);
            this.dataGridView1.TabIndex = 40;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "MÃ NV";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.Width = 125;
            // 
            // MABP
            // 
            this.MABP.DataPropertyName = "MABP";
            this.MABP.HeaderText = "MÃ BP";
            this.MABP.MinimumWidth = 6;
            this.MABP.Name = "MABP";
            this.MABP.Width = 125;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "TÊN NHÂN VIÊN";
            this.TENNV.MinimumWidth = 6;
            this.TENNV.Name = "TENNV";
            this.TENNV.Width = 200;
            // 
            // GITINH
            // 
            this.GITINH.DataPropertyName = "GIOITINH";
            this.GITINH.HeaderText = "GIỚI TÍNH ";
            this.GITINH.MinimumWidth = 6;
            this.GITINH.Name = "GITINH";
            this.GITINH.Width = 125;
            // 
            // NGAYVL
            // 
            this.NGAYVL.DataPropertyName = "NGAYVAOLAM";
            this.NGAYVL.HeaderText = "NGÀY VL";
            this.NGAYVL.MinimumWidth = 6;
            this.NGAYVL.Name = "NGAYVL";
            this.NGAYVL.Width = 125;
            // 
            // NGSINH
            // 
            this.NGSINH.DataPropertyName = "NGAYSINH";
            this.NGSINH.HeaderText = "NGÀY SINH ";
            this.NGSINH.MinimumWidth = 6;
            this.NGSINH.Name = "NGSINH";
            this.NGSINH.Width = 125;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "ĐIỆN THOẠI";
            this.DIENTHOAI.MinimumWidth = 6;
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Width = 125;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "ĐỊA CHỈ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 300;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(518, 70);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(502, 26);
            this.txt_ten.TabIndex = 19;
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(803, 138);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(217, 26);
            this.txt_adress.TabIndex = 18;
            // 
            // btn_save
            // 
            this.btn_save.Image = global::QL_BANMAYLANH.Properties.Resources.save_file__1_;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(864, 595);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 54);
            this.btn_save.TabIndex = 36;
            this.btn_save.Text = "&Lưu";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Image = global::QL_BANMAYLANH.Properties.Resources.repair__1_;
            this.btn_fix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fix.Location = new System.Drawing.Point(614, 595);
            this.btn_fix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(109, 54);
            this.btn_fix.TabIndex = 37;
            this.btn_fix.Text = "&Sửa";
            this.btn_fix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Image = global::QL_BANMAYLANH.Properties.Resources.remove__1_;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(341, 595);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(101, 54);
            this.btn_remove.TabIndex = 38;
            this.btn_remove.Text = "&Xóa";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(104, 595);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 54);
            this.btn_Add.TabIndex = 39;
            this.btn_Add.Text = "&Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 664);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_DC);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_NhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DC;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
    }
}