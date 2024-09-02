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
    public partial class Form_NhanVien : Form
    {
        public Form_NhanVien()
        {
            InitializeComponent();
        }
        DBConnect conn = new DBConnect();
        DataTable dt;

        public void LoadDataGridView_NHANVIEN()
        {
            string strSQL = "SELECT * FROM NHANVIEN";
            dt = conn.getDataTable(strSQL);
            dataGridView1.DataSource = dt;

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = dt.Columns[0];
            dt.PrimaryKey = primaryKey;
        }


        public void dataBindings(DataTable pTable)
        {
            txt_MaNV.DataBindings.Clear();
            txt_TenNV.DataBindings.Clear();
            txt_MaNV.DataBindings.Add("Text", pTable, "MANV");
            txt_TenNV.DataBindings.Add("Text", pTable, "TENNV");
            comboBox1.DataBindings.Add("Text", pTable, "GIOITINH");
            comboBox2.DataBindings.Add("Text", pTable, "MABP");
            txt_DC.DataBindings.Add("Text", pTable, "DIACHI");
            maskedTextBox1.DataBindings.Add("Text", pTable, "DIENTHOAI");
            dateTimePicker1.DataBindings.Add("Text", pTable, "NGAYSINH");
            dateTimePicker2.DataBindings.Add("Text", pTable, "NGAYVAOLAM");

        }

        void hienthi_DSBP()
        {
            DBConnect db = new DBConnect();
            string ctv = "select * from BOPHAN";
            DataTable dt = db.getDataTable(ctv);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "MABP";
            comboBox2.ValueMember = "TENBP";
        }

        bool KTMaNVTrung(string mNV)
        {
            DBConnect db = new DBConnect();
            string ctv = "select count(*) from NHANVIEN where MANV='" + mNV + "'";
            int kq = (int)db.getScalar(ctv);
            if (kq == 0)
                return true;
            return false;
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên. Vui lòng nhập !!!");
                txt_MaNV.Focus();
                return;
            }
            else if (txt_TenNV.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên. Vui lòng nhập !!!");
                txt_TenNV.Focus();
                return;
            }
            else if (txt_DC.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ. Vui lòng nhập !!!");
                txt_DC.Focus();
                return;
            }
            else if (maskedTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại. Vui lòng nhập !!!");
                maskedTextBox1.Focus();
                return;
            }
            else if (dateTimePicker1.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh. Vui lòng nhập !!!");
                dateTimePicker1.Focus();
                return;
            }
            else if (dateTimePicker2.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập ngày vào làm. Vui lòng nhập !!!");
                dateTimePicker2.Focus();
                return;
            }
            else if (comboBox2.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập bộ phận. Vui lòng nhập !!!");
                comboBox2.Focus();
                return;
            }
            if (KTMaNVTrung(txt_MaNV.Text))
            {
                DataRow newRow = dt.NewRow();
                newRow["MANV"] = txt_MaNV.Text;
                newRow["TENNV"] = txt_TenNV.Text;
                newRow["GIOITINH"] = comboBox1.Text;
                newRow["MABP"] = comboBox2.Text;
                newRow["DIACHI"] = txt_DC.Text;
                newRow["DIENTHOAI"] = maskedTextBox1.Text;
                newRow["NGAYSINH"] = dateTimePicker1.Text;
                newRow["NGAYVAOLAM"] = dateTimePicker2.Text;
                dt.Rows.Add(newRow);
                string ctv = "select*from NHANVIEN";
                int k = conn.UpdateDataTable(dt, ctv);
                if (k != 0)

                    MessageBox.Show("Thêm thành công!","Thông Báo");
                else
                    MessageBox.Show("Thêm không thành công!","Thông Báo");
            }
            else
            {
                txt_MaNV.Focus();
                MessageBox.Show("Trùng mã nhân viên", "Thông Báo");
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string ctv = "select * from NHANVIEN";
            int k = conn.UpdateDataTable(dt, ctv);

            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
           // DialogResult res = MessageBox.Show("Bạn muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo,
           //MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
           // if (res == DialogResult.Yes)
           //     Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.No)
                return;

            //Tiến hành kiểm tra và lưu dữ liệu
            string manv = txt_MaNV.Text.Trim();
            string strSQL = "SELECT count(*) FROM HOADON_BANHANG WHERE MANV='" + manv + "'";
            if (conn.checkForExistence(strSQL))
            {
                MessageBox.Show("Nhân viên này đã tồn tại khóa ngoại trên bảng HOADON_BANHANG!");
                return;
            }
            //Lưu cập nhật
            DataRow deleteRow = dt.Rows.Find(manv);
            deleteRow.Delete();

            //Cập nhật dữ liệu xuống CSDL
            string ctv = "select * from NHANVIEN";
            int k = conn.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa không thành công!");
            txt_MaNV.Clear();
            txt_TenNV.Clear();
            txt_DC.Clear();
            dateTimePicker1.Text = null;
            dateTimePicker2.Text = null;
            maskedTextBox1.Clear();
            comboBox1.Text = null;
            comboBox2.Text = null;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView_NHANVIEN();
            hienthi_DSBP();
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaNV.Text);

            //sửa dt
            if (dr != null)
            {
                dr["TENNV"] = txt_TenNV.Text;
                dr["MABP"] = comboBox2.Text;
                dr["GIOITINH"] = comboBox1.Text;
                dr["NGAYVAOLAM"] = dateTimePicker2.Text;
                dr["NGAYSINH"] = dateTimePicker1.Text;
                dr["DIENTHOAI"] = maskedTextBox1.Text;
                dr["DIACHI"] = txt_DC.Text;
            }
            // cập nhập trong CSDL
            string ctv = "select * from NHANVIEN";
            int k = conn.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã sửa", "Thông báo");

            else
                MessageBox.Show("Chưa sửa", "Thông báo");

        }

     

        private void btn_find_Click(object sender, EventArgs e)
        {
            string ten = txt_find.Text;

            string ctv = "select * from NHANVIEN where TENNV like N'%" + ten + "%'";
            DataTable dt = conn.getDataTable(ctv);

            dataGridView1.DataSource = dt;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_find.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainAdmin main = new Form_MainAdmin();
            main.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
