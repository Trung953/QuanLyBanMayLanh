namespace QL_BANMAYLANH
{
    partial class THONGKE
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
            this.btn_tknh = new System.Windows.Forms.Button();
            this.btn_tkbh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tknh
            // 
            this.btn_tknh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tknh.Location = new System.Drawing.Point(88, 74);
            this.btn_tknh.Name = "btn_tknh";
            this.btn_tknh.Size = new System.Drawing.Size(254, 99);
            this.btn_tknh.TabIndex = 0;
            this.btn_tknh.Text = "Thống kê nhập hàng";
            this.btn_tknh.UseVisualStyleBackColor = true;
            this.btn_tknh.Click += new System.EventHandler(this.btn_tknh_Click);
            // 
            // btn_tkbh
            // 
            this.btn_tkbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tkbh.Location = new System.Drawing.Point(437, 74);
            this.btn_tkbh.Name = "btn_tkbh";
            this.btn_tkbh.Size = new System.Drawing.Size(254, 99);
            this.btn_tkbh.TabIndex = 1;
            this.btn_tkbh.Text = "Thống kê bán hàng";
            this.btn_tkbh.UseVisualStyleBackColor = true;
            this.btn_tkbh.Click += new System.EventHandler(this.btn_tkbh_Click);
            // 
            // THONGKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 231);
            this.Controls.Add(this.btn_tkbh);
            this.Controls.Add(this.btn_tknh);
            this.Name = "THONGKE";
            this.Text = "THONGKE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tknh;
        private System.Windows.Forms.Button btn_tkbh;
    }
}