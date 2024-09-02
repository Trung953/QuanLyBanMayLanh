
namespace QL_BANMAYLANH
{
    partial class Form_ThongKeNhapHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_XemThongTin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_DoanhThu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datagv_ThongKe = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MATK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_ThongKe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_XemThongTin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_DoanhThu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1112, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê nhập hàng";
            // 
            // button_XemThongTin
            // 
            this.button_XemThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XemThongTin.Location = new System.Drawing.Point(893, 81);
            this.button_XemThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_XemThongTin.Name = "button_XemThongTin";
            this.button_XemThongTin.Size = new System.Drawing.Size(189, 36);
            this.button_XemThongTin.TabIndex = 10;
            this.button_XemThongTin.Text = "Xem thống kê";
            this.button_XemThongTin.UseVisualStyleBackColor = true;
            this.button_XemThongTin.Click += new System.EventHandler(this.button_XemThongTin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng tiền nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tới ngày:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(359, 83);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 28);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2023, 12, 9, 17, 52, 50, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 79);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 28);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 9, 17, 52, 41, 0);
            // 
            // txt_DoanhThu
            // 
            this.txt_DoanhThu.Enabled = false;
            this.txt_DoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DoanhThu.Location = new System.Drawing.Point(637, 85);
            this.txt_DoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DoanhThu.Name = "txt_DoanhThu";
            this.txt_DoanhThu.Size = new System.Drawing.Size(225, 28);
            this.txt_DoanhThu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh sách đơn hàng";
            // 
            // datagv_ThongKe
            // 
            this.datagv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_ThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATK,
            this.MANV,
            this.MANCC,
            this.TONGTIEN,
            this.NGAY});
            this.datagv_ThongKe.Location = new System.Drawing.Point(15, 49);
            this.datagv_ThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagv_ThongKe.Name = "datagv_ThongKe";
            this.datagv_ThongKe.RowHeadersWidth = 62;
            this.datagv_ThongKe.RowTemplate.Height = 28;
            this.datagv_ThongKe.Size = new System.Drawing.Size(1112, 368);
            this.datagv_ThongKe.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 180);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagv_ThongKe);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(11, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 438);
            this.panel2.TabIndex = 53;
            // 
            // MATK
            // 
            this.MATK.DataPropertyName = "MAHDN";
            this.MATK.HeaderText = "Mã hóa đơn nhập";
            this.MATK.MinimumWidth = 8;
            this.MATK.Name = "MATK";
            this.MATK.Width = 140;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.MinimumWidth = 8;
            this.MANV.Name = "MANV";
            this.MANV.Width = 150;
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã nhà cung cấp";
            this.MANCC.MinimumWidth = 8;
            this.MANCC.Name = "MANCC";
            this.MANCC.Width = 150;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.MinimumWidth = 8;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Width = 150;
            // 
            // NGAY
            // 
            this.NGAY.DataPropertyName = "NGAY_GIONHAP";
            this.NGAY.HeaderText = "Ngày";
            this.NGAY.MinimumWidth = 8;
            this.NGAY.Name = "NGAY";
            this.NGAY.Width = 200;
            // 
            // Form_ThongKeNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_ThongKeNhapHang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_ThongKeNhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_ThongKe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_XemThongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_DoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView datagv_ThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY;
    }
}