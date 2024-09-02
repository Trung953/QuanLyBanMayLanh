namespace QL_BANMAYLANH
{
    partial class Form_ThongkeBanHang
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
            this.groupBoxDoanhThu = new System.Windows.Forms.GroupBox();
            this.buttonXemTT = new System.Windows.Forms.Button();
            this.textBoxTongDoanhThu = new System.Windows.Forms.TextBox();
            this.labelTongDoanhThu = new System.Windows.Forms.Label();
            this.dateTimePickerToiNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.labelToiNgay = new System.Windows.Forms.Label();
            this.labelTuNgay = new System.Windows.Forms.Label();
            this.groupBoxDSDonHang = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSBHang = new System.Windows.Forms.DataGridView();
            this.MAHDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_GIOXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDoanhThu.SuspendLayout();
            this.groupBoxDSDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSBHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDoanhThu
            // 
            this.groupBoxDoanhThu.Controls.Add(this.buttonXemTT);
            this.groupBoxDoanhThu.Controls.Add(this.textBoxTongDoanhThu);
            this.groupBoxDoanhThu.Controls.Add(this.labelTongDoanhThu);
            this.groupBoxDoanhThu.Controls.Add(this.dateTimePickerToiNgay);
            this.groupBoxDoanhThu.Controls.Add(this.dateTimePickerTuNgay);
            this.groupBoxDoanhThu.Controls.Add(this.labelToiNgay);
            this.groupBoxDoanhThu.Controls.Add(this.labelTuNgay);
            this.groupBoxDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDoanhThu.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDoanhThu.Name = "groupBoxDoanhThu";
            this.groupBoxDoanhThu.Size = new System.Drawing.Size(1113, 180);
            this.groupBoxDoanhThu.TabIndex = 0;
            this.groupBoxDoanhThu.TabStop = false;
            this.groupBoxDoanhThu.Text = "Thống kê bán hàng";
            // 
            // buttonXemTT
            // 
            this.buttonXemTT.Location = new System.Drawing.Point(876, 83);
            this.buttonXemTT.Name = "buttonXemTT";
            this.buttonXemTT.Size = new System.Drawing.Size(231, 39);
            this.buttonXemTT.TabIndex = 5;
            this.buttonXemTT.Text = "Xem thống kê";
            this.buttonXemTT.UseVisualStyleBackColor = true;
            // 
            // textBoxTongDoanhThu
            // 
            this.textBoxTongDoanhThu.Location = new System.Drawing.Point(619, 86);
            this.textBoxTongDoanhThu.Name = "textBoxTongDoanhThu";
            this.textBoxTongDoanhThu.Size = new System.Drawing.Size(227, 28);
            this.textBoxTongDoanhThu.TabIndex = 4;
            // 
            // labelTongDoanhThu
            // 
            this.labelTongDoanhThu.AutoSize = true;
            this.labelTongDoanhThu.Location = new System.Drawing.Point(615, 61);
            this.labelTongDoanhThu.Name = "labelTongDoanhThu";
            this.labelTongDoanhThu.Size = new System.Drawing.Size(121, 22);
            this.labelTongDoanhThu.TabIndex = 2;
            this.labelTongDoanhThu.Text = "Tổng tiền bán";
            // 
            // dateTimePickerToiNgay
            // 
            this.dateTimePickerToiNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToiNgay.Location = new System.Drawing.Point(334, 86);
            this.dateTimePickerToiNgay.Name = "dateTimePickerToiNgay";
            this.dateTimePickerToiNgay.Size = new System.Drawing.Size(245, 28);
            this.dateTimePickerToiNgay.TabIndex = 1;
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(39, 86);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(248, 28);
            this.dateTimePickerTuNgay.TabIndex = 1;
            // 
            // labelToiNgay
            // 
            this.labelToiNgay.AutoSize = true;
            this.labelToiNgay.Location = new System.Drawing.Point(330, 61);
            this.labelToiNgay.Name = "labelToiNgay";
            this.labelToiNgay.Size = new System.Drawing.Size(83, 22);
            this.labelToiNgay.TabIndex = 0;
            this.labelToiNgay.Text = "Tới Ngày";
            // 
            // labelTuNgay
            // 
            this.labelTuNgay.AutoSize = true;
            this.labelTuNgay.Location = new System.Drawing.Point(35, 61);
            this.labelTuNgay.Name = "labelTuNgay";
            this.labelTuNgay.Size = new System.Drawing.Size(76, 22);
            this.labelTuNgay.TabIndex = 0;
            this.labelTuNgay.Text = "Từ ngày";
            // 
            // groupBoxDSDonHang
            // 
            this.groupBoxDSDonHang.Controls.Add(this.dataGridViewDSBHang);
            this.groupBoxDSDonHang.Location = new System.Drawing.Point(13, 216);
            this.groupBoxDSDonHang.Name = "groupBoxDSDonHang";
            this.groupBoxDSDonHang.Size = new System.Drawing.Size(1113, 409);
            this.groupBoxDSDonHang.TabIndex = 0;
            this.groupBoxDSDonHang.TabStop = false;
            this.groupBoxDSDonHang.Text = "Danh sách đơn hàng";
            // 
            // dataGridViewDSBHang
            // 
            this.dataGridViewDSBHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSBHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHDX,
            this.MANV,
            this.MAKH,
            this.NGAY_GIOXUAT,
            this.TONGTIEN});
            this.dataGridViewDSBHang.Location = new System.Drawing.Point(13, 38);
            this.dataGridViewDSBHang.Name = "dataGridViewDSBHang";
            this.dataGridViewDSBHang.RowHeadersWidth = 51;
            this.dataGridViewDSBHang.RowTemplate.Height = 24;
            this.dataGridViewDSBHang.Size = new System.Drawing.Size(1076, 344);
            this.dataGridViewDSBHang.TabIndex = 0;
            // 
            // MAHDX
            // 
            this.MAHDX.DataPropertyName = "MAHDX";
            this.MAHDX.HeaderText = "MAHDX";
            this.MAHDX.MinimumWidth = 6;
            this.MAHDX.Name = "MAHDX";
            this.MAHDX.Width = 125;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "MANV";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.Width = 125;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "MAKH";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 125;
            // 
            // NGAY_GIOXUAT
            // 
            this.NGAY_GIOXUAT.DataPropertyName = "NGAY_GIOXUAT";
            this.NGAY_GIOXUAT.HeaderText = "NGÀY BÁN";
            this.NGAY_GIOXUAT.MinimumWidth = 6;
            this.NGAY_GIOXUAT.Name = "NGAY_GIOXUAT";
            this.NGAY_GIOXUAT.Width = 150;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "TỔNG DOANH THU";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Width = 200;
            // 
            // Form_ThongkeBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 659);
            this.Controls.Add(this.groupBoxDSDonHang);
            this.Controls.Add(this.groupBoxDoanhThu);
            this.Name = "Form_ThongkeBanHang";
            this.Text = "Form_ThongkeBanHang";
            this.Load += new System.EventHandler(this.Form_ThongkeBanHang_Load);
            this.groupBoxDoanhThu.ResumeLayout(false);
            this.groupBoxDoanhThu.PerformLayout();
            this.groupBoxDSDonHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSBHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDoanhThu;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.Label labelToiNgay;
        private System.Windows.Forms.Label labelTuNgay;
        private System.Windows.Forms.GroupBox groupBoxDSDonHang;
        private System.Windows.Forms.Button buttonXemTT;
        private System.Windows.Forms.TextBox textBoxTongDoanhThu;
        private System.Windows.Forms.Label labelTongDoanhThu;
        private System.Windows.Forms.DateTimePicker dateTimePickerToiNgay;
        private System.Windows.Forms.DataGridView dataGridViewDSBHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_GIOXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
    }
}