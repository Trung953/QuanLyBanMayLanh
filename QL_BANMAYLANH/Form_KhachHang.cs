using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_BANMAYLANH
{
    public partial class Form_KhachHang : Form
    {
        public Form_KhachHang()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();
        DataTable dt;
        void HienthiDSKhachHang_dtgv()
        {
            string ctv = "select * from KHACHHANG";
            dt = db.getDataTable(ctv);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            datagv_KH.DataSource = dt;
        }
        void LKDL(DataTable pdt)
        {
            txt_MaKH.DataBindings.Clear();
            txt_TenKH.DataBindings.Clear();
            masked_Phone.DataBindings.Clear();
            txt_Address.DataBindings.Clear();
            txt_GhiChu.DataBindings.Clear();
            txt_MaKH.DataBindings.Add("Text", pdt, "MAKH");
            txt_TenKH.DataBindings.Add("Text", pdt, "TENKH");
            txt_Address.DataBindings.Add("Text", pdt, "DIACHI");
            masked_Phone.DataBindings.Add("Text", pdt, "SDT");
            txt_GhiChu.DataBindings.Add("Text", pdt, "GHICHU");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienthiDSKhachHang_dtgv();
            LKDL(dt);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

            

        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            // tìm ra dòng tin cần sửa trong dt;
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            
        }

        private void KHACHHANG_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult r;
            //r = MessageBox.Show("Bạn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (r == DialogResult.No)
            //    e.Cancel = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainAdmin main = new Form_MainAdmin();
            main.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["MAKH"] = txt_MaKH.Text;
            dr["TENKH"] = txt_TenKH.Text;
            dr["DIACHI"] = txt_Address.Text;

            string cleanedPhone = masked_Phone.Text;
            cleanedPhone = cleanedPhone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            dr["SDT"] = cleanedPhone;

            dr["GHICHU"] = txt_GhiChu.Text;
            dt.Rows.Add(dr);
            string ctv = "select * from KHACHHANG";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows = dt.Select("MAKH = '" + txt_MaKH.Text + "'");


            //sửa dt
            if (foundRows.Length > 0)
            {
                DataRow dr = foundRows[0];

                dr["MAKH"] = txt_MaKH.Text;
                dr["TENKH"] = txt_TenKH.Text;
                dr["DIACHI"] = txt_Address.Text;
                string cleanedPhone = masked_Phone.Text;
                cleanedPhone = cleanedPhone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                dr["SDT"] = cleanedPhone;
                dr["GHICHU"] = txt_GhiChu.Text;
                dt.AcceptChanges();
                string ctv = "select * from KHACHHANG";
                int k = db.UpdateDataTable(dt, ctv);
                if (k != 0)
                    MessageBox.Show("Đã sửa", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // tìm ra dòng tin cần xóa trong dt;
            DataRow[] foundRows = dt.Select("MAKH = '" + txt_MaKH.Text + "'");

            //xoa dt
            if (foundRows.Length > 0)
            {
                DataRow dr = foundRows[0];
                dr.Delete();
                dt.AcceptChanges();
                string ctv = "select * from KHACHHANG";
                int k = db.UpdateDataTable(dt, ctv);
                if (k != 0)
                    MessageBox.Show("Đã xóa", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)datagv_KH.DataSource;
            string ctv = "select * from KHACHHANG";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string makh = txtSearch.Text;
            string ctv = "select * from KHACHHANG where MAKH like N'%" + makh + "%'";
            DataTable dt = db.getDataTable(ctv);
            datagv_KH.DataSource = dt;
        }
    }
}
