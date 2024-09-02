namespace QL_BANMAYLANH
{
    partial class Form_BoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BoPhan));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_TENBP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MABP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MABP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABP,
            this.TENBP});
            this.dataGridView1.Location = new System.Drawing.Point(545, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(376, 192);
            this.dataGridView1.TabIndex = 60;
            // 
            // btn_save
            // 
            this.btn_save.Image = global::QL_BANMAYLANH.Properties.Resources.save_file__1_;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(414, 194);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 43);
            this.btn_save.TabIndex = 56;
            this.btn_save.Text = "&Lưu";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Image = global::QL_BANMAYLANH.Properties.Resources.repair__1_;
            this.btn_fix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fix.Location = new System.Drawing.Point(277, 194);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(97, 43);
            this.btn_fix.TabIndex = 57;
            this.btn_fix.Text = "&Sửa";
            this.btn_fix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Image = global::QL_BANMAYLANH.Properties.Resources.remove__1_;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(147, 194);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(90, 43);
            this.btn_remove.TabIndex = 58;
            this.btn_remove.Text = "&Xóa";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(20, 194);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(89, 43);
            this.btn_Add.TabIndex = 59;
            this.btn_Add.Text = "&Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_TENBP
            // 
            this.txt_TENBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENBP.Location = new System.Drawing.Point(173, 129);
            this.txt_TENBP.Name = "txt_TENBP";
            this.txt_TENBP.Size = new System.Drawing.Size(331, 34);
            this.txt_TENBP.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "THÔNG TIN BỘ PHẬN";
            // 
            // txt_MABP
            // 
            this.txt_MABP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MABP.Location = new System.Drawing.Point(173, 73);
            this.txt_MABP.Name = "txt_MABP";
            this.txt_MABP.Size = new System.Drawing.Size(331, 34);
            this.txt_MABP.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tên Bộ Phận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mã Bộ Phận";
            // 
            // MABP
            // 
            this.MABP.DataPropertyName = "MABP";
            this.MABP.HeaderText = "MABP";
            this.MABP.MinimumWidth = 6;
            this.MABP.Name = "MABP";
            this.MABP.Width = 125;
            // 
            // TENBP
            // 
            this.TENBP.DataPropertyName = "TENBP";
            this.TENBP.HeaderText = "TENBP";
            this.TENBP.MinimumWidth = 6;
            this.TENBP.Name = "TENBP";
            this.TENBP.Width = 300;
            // 
            // Form_BoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 293);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_TENBP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MABP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form_BoPhan";
            this.Text = "Bộ phận";
            this.Load += new System.EventHandler(this.BOPHAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_TENBP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MABP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBP;
    }
}