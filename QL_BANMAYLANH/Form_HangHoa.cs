using QL_BANMAYLANH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BANMAYLANH
{
    public partial class Form_HangHoa : Form
    {
        public Form_HangHoa()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        void HienthiDSHangHoa_dtgv()
        {
            string ctv = "select * from HANGHOA";
            dt = db.getDataTable(ctv);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
        }
        void LKDL(DataTable pdt)
        {
            textBoxMH.DataBindings.Clear();
            textBoxTH.DataBindings.Clear();
            //dataGridViewHA.DataBindings.Clear();
            textBoxGN.DataBindings.Clear();
            textBoxSL.DataBindings.Clear();
            textBoxMH.DataBindings.Add("Text", pdt, "MAHH");
            textBoxTH.DataBindings.Add("Text", pdt, "TENHH");
            textBoxGN.DataBindings.Add("Text", pdt, "GIANHAP");
            //dataGridViewHA.DataBindings.Add("Text", pdt, "HINHANH");
            textBoxSL.DataBindings.Add("Text", pdt, "SOLUONG");
            cb_maloai.DataBindings.Add("text", pdt, "MALOAI");
            textBoxMNCC.DataBindings.Add("text", pdt, "MANCC");
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["MAHH"] = textBoxMH.Text;
            dr["TENHH"] = textBoxTH.Text;
            dr["GIANHAP"] = textBoxGN.Text;
            /*  dr["HINHANH"] = dataGridViewHA.Text*/
            ;
            dr["SOLUONG"] = textBoxSL.Text;
            dr["MALOAI"] = cb_maloai.SelectedIndex.ToString();
            dr["MANCC"] = textBoxMNCC.Text;
            dt.Rows.Add(dr);
            string ctv = "select * from HANGHOA";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }
        void _LoadComBobox()
        {
            DBConnect db = new DBConnect();
            string ctv = "select * from LOAI_HANGHOA";
            DataTable dt = db.getDataTable(ctv);
            cb_maloai.DataSource = dt;
            cb_maloai.DisplayMember = "MALOAI";
            cb_maloai.ValueMember = "TENLOAI";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienthiDSHangHoa_dtgv();
            LKDL(dt);
            _LoadComBobox();
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // tìm ra dòng tin cần xóa trong dt;
            DataRow dr = dt.Rows.Find(textBoxMH.Text);
            //xoa dt
            if (dr != null)
                dr.Delete();
            string ctv = "select * from HANGHOA";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã xóa", "Thông báo");
            else
                MessageBox.Show("Chưa xóa", "Thông báo");
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            // tìm ra dòng tin cần sửa trong dt;
            DataRow dr = dt.Rows.Find(textBoxMH.Text);
            //sửa dt
            if (dr != null)
            {
                dr["TENHH"] = textBoxTH.Text;
                dr["GIANHAP"] = textBoxGN.Text;
                dr["HINHANH"] = dataGridViewHA.Text;
                dr["SOLUONG"] = textBoxSL.Text;
            }
            // cập nhập trong CSDL
            string ctv = "select * from HANGHOA";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã sửa", "Thông báo");
            else
                MessageBox.Show("Chưa sửa", "Thông báo");
        }
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string ctv = "select * from HANGHOA";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void dataGridViewHA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            string mahh = textBoxMH.Text;
            string ctv = "select * from HANGHOA where MAHH like N'%" + mahh + "%'";
            DataTable dt = db.getDataTable(ctv);
            dataGridView1.DataSource = dt;
        }
        
        private void btn_tskt_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(maHangHoaDuocChon))
            {
                Form_ThongSoKiThuat_HH  tskt = new Form_ThongSoKiThuat_HH();
                tskt.ShowDialog();
            }
            else
            {
                // Thông báo người dùng chưa chọn hàng hóa
                MessageBox.Show("Vui lòng chọn một hàng hóa trước khi xem thông tin.");
            }
        }
        private string maHangHoaDuocChon = "";
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy giá trị của ô cột "MaHangHoa" của dòng được chọn
                string maHangHoa = dataGridView1.SelectedRows[0].Cells["MAHH"].Value.ToString();

                // Lưu mã hàng hóa vào một biến toàn cục hoặc sử dụng nó theo cách bạn muốn
                // Ví dụ: lưu vào một biến toàn cục
                maHangHoaDuocChon = maHangHoa;
            }
        }

        private void textBoxMH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}