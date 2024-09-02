namespace QL_BANMAYLANH
{
    partial class Form_NguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NguoiDung));
            this.txt_ND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbo_ND = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYENTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_quyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ND
            // 
            this.txt_ND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ND.Location = new System.Drawing.Point(189, 144);
            this.txt_ND.Name = "txt_ND";
            this.txt_ND.Size = new System.Drawing.Size(258, 34);
            this.txt_ND.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // txt_MK
            // 
            this.txt_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK.Location = new System.Drawing.Point(189, 189);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(258, 34);
            this.txt_MK.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(327, -270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.NGUOIDUNG,
            this.MATKHAU,
            this.QUYENTC});
            this.dataGridView1.Location = new System.Drawing.Point(530, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(447, 209);
            this.dataGridView1.TabIndex = 47;
            // 
            // cbo_ND
            // 
            this.cbo_ND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ND.FormattingEnabled = true;
            this.cbo_ND.Location = new System.Drawing.Point(189, 93);
            this.cbo_ND.Name = "cbo_ND";
            this.cbo_ND.Size = new System.Drawing.Size(258, 37);
            this.cbo_ND.TabIndex = 48;
            // 
            // btn_save
            // 
            this.btn_save.Image = global::QL_BANMAYLANH.Properties.Resources.save_file__1_;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(718, 366);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 43);
            this.btn_save.TabIndex = 43;
            this.btn_save.Text = "&Lưu";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Image = global::QL_BANMAYLANH.Properties.Resources.repair__1_;
            this.btn_fix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fix.Location = new System.Drawing.Point(572, 366);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(97, 43);
            this.btn_fix.TabIndex = 44;
            this.btn_fix.Text = "&Sửa";
            this.btn_fix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Image = global::QL_BANMAYLANH.Properties.Resources.remove__1_;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(415, 366);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(90, 43);
            this.btn_remove.TabIndex = 45;
            this.btn_remove.Text = "&Xóa";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(257, 366);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(89, 43);
            this.btn_Add.TabIndex = 46;
            this.btn_Add.Text = "&Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "MANV";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.Width = 125;
            // 
            // NGUOIDUNG
            // 
            this.NGUOIDUNG.DataPropertyName = "username";
            this.NGUOIDUNG.HeaderText = "UserName";
            this.NGUOIDUNG.MinimumWidth = 6;
            this.NGUOIDUNG.Name = "NGUOIDUNG";
            this.NGUOIDUNG.Width = 145;
            // 
            // MATKHAU
            // 
            this.MATKHAU.DataPropertyName = "password";
            this.MATKHAU.HeaderText = "Password";
            this.MATKHAU.MinimumWidth = 6;
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.Width = 125;
            // 
            // QUYENTC
            // 
            this.QUYENTC.DataPropertyName = "QuyenTC";
            this.QUYENTC.HeaderText = "QUYỀN TC";
            this.QUYENTC.MinimumWidth = 6;
            this.QUYENTC.Name = "QUYENTC";
            this.QUYENTC.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 49;
            this.label6.Text = "Quyền TC";
            // 
            // cb_quyen
            // 
            this.cb_quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_quyen.FormattingEnabled = true;
            this.cb_quyen.Items.AddRange(new object[] {
            "admin",
            "nhanvien"});
            this.cb_quyen.Location = new System.Drawing.Point(189, 241);
            this.cb_quyen.Name = "cb_quyen";
            this.cb_quyen.Size = new System.Drawing.Size(258, 37);
            this.cb_quyen.TabIndex = 50;
            // 
            // Form_NguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 436);
            this.Controls.Add(this.cb_quyen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_ND);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ND);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_NguoiDung";
            this.Text = "NguoiDung";
            this.Load += new System.EventHandler(this.NguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbo_ND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYENTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_quyen;
    }
}