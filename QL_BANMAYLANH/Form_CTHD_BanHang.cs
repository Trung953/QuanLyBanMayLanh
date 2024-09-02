using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace QL_BANMAYLANH
{
    public partial class Form_CTHD_BanHang : Form
    {
        public Form_CTHD_BanHang()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        bool xong = false;
        void HienThiDS_ThongKe()
        {
            string ctv = "select * from CHITIETHOADON_BANHANG";
            dt = db.getDataTable(ctv);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            datagv_HDBH.DataSource = dt;
        }
        void LKDL(DataTable pdt)
        {
            txt_MAHDX.DataBindings.Clear();
            combo_MAHH.DataBindings.Clear();
            txt_giamgia.DataBindings.Clear();
            txt_Soluong.DataBindings.Clear();
            txt_TENHH.DataBindings.Clear();
            label_DONGIA.DataBindings.Clear();
            label_TONGTIEN.DataBindings.Clear();
            txt_MAHDX.DataBindings.Add("Text", pdt, "MAHDX");
            combo_MAHH.DataBindings.Add("Text", pdt, "MAHH");
            txt_giamgia.DataBindings.Add("Text", pdt, "GIAMGIA");
            txt_Soluong.DataBindings.Add("Text", pdt, "SOLUONG");
            txt_TENHH.DataBindings.Add("Text", pdt, "TENHH");
            label_TONGTIEN.DataBindings.Add("Text", pdt, "THANHTIEN");

        }
        void show_combobox_MaHH()
        {
            dt = new DataTable();
            string ctv = "select * from HANGHOA";
            dt = db.getDataTable(ctv);
            combo_MAHH.DataSource = dt;
            combo_MAHH.DisplayMember = "MAHH";
            combo_MAHH.ValueMember = "MAHH";
            xong = true;
        }
        public decimal TinhThanhTien(decimal donGia, int soLuong, decimal giamGia)
        {
            decimal thanhTien = donGia * soLuong;
            thanhTien -= thanhTien * (giamGia / 100);
            return thanhTien;
        }
        private void TinhVaHienThiThanhTien()
        {
            if (!string.IsNullOrEmpty(txt_Soluong.Text) && !string.IsNullOrEmpty(txt_giamgia.Text))
            {
                int soLuong = int.Parse(txt_Soluong.Text);
                decimal giamGia = decimal.Parse(txt_giamgia.Text);
                decimal donGia = decimal.Parse(label_DONGIA.Text);
                decimal thanhTien = TinhThanhTien(donGia, soLuong, giamGia);
                label_TONGTIEN.Text = thanhTien.ToString();
            }
        }
        private void combo_MAHH_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (xong == true && combo_MAHH.SelectedValue != null)
                {
                    string ctv = "SELECT * FROM HANGHOA WHERE MAHH = '" + combo_MAHH.SelectedValue.ToString() + "'";
                    dt = db.getDataTable(ctv);
                    if (dt.Rows.Count == 1)
                    {
                        label_DONGIA.Text = dt.Rows[0]["GIANHAP"].ToString();
                        txt_TENHH.Text = dt.Rows[0]["TENHH"].ToString();
                        TinhVaHienThiThanhTien();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin sản phẩm.");
                    }
                }
        }
        private void HOADON_BANHANG_Load(object sender, EventArgs e)
        {
            HienThiDS_ThongKe();
            LKDL(dt);
            show_combobox_MaHH();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void HOADON_BANHANG_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form_Main main = new Form_Main();
            //main.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)datagv_HDBH.DataSource;
            DataRow newRow = dt.NewRow();
            newRow["MAHDX"] = txt_MAHDX.Text;
            newRow["MAHH"] = combo_MAHH.SelectedValue;
            newRow["TENHH"] = txt_TENHH.Text;
            newRow["SOLUONG"] = txt_Soluong.Text;
            newRow["DONGIABAN"] = label_DONGIA.Text;
            newRow["GIAMGIA"] = txt_giamgia.Text;
            newRow["THANHTIEN"] = double.Parse(txt_giamgia.Text) / 100 * double.Parse(label_DONGIA.Text);
            dt.Rows.Add(newRow); 
            dt.AcceptChanges();
            string query = "SELECT * FROM CHITIETHOADON_BANHANG";
            int rowsAffected = db.UpdateDataTable(dt, query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // tìm ra dòng tin cần sửa trong dt;
            DataRow[] foundRows = dt.Select("MAHDX = '" + txt_MAHDX.Text + "'");
            if (foundRows.Length > 0)
            {
                DataRow dr = foundRows[0];
                dr["MAHH"] = combo_MAHH.Text;
                dr["TENHH"] = txt_TENHH.Text;
                dr["SOLUONG"] = txt_Soluong.Text;
                dr["DONGIABAN"] = label_DONGIA.Text;
                dr["MAHDX"] =txt_MAHDX.Text;
                dr["GIAMGIA"] = txt_giamgia.Text;
                dr["THANHTIEN"] = label_TONGTIEN.Text;
                show_combobox_MaHH();
                datagv_HDBH.DataSource = dt;
                string ctv = "select * from CHITIETHOADON_BANHANG";
                int k = db.UpdateDataTable(dt, ctv);
                if (k != 0)
                    MessageBox.Show("Đã sửa", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã HDX", "Thông báo");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (datagv_HDBH.SelectedRows.Count > 0)
            {
                DataRow dr = dt.Rows.Find(txt_MAHDX.Text);
                //xoa dt
                if (dr != null)
                    dr.Delete();
                string ctv = "select * from CHITIETHOADON_BANHANG";
                int k = db.UpdateDataTable(dt, ctv);
                if (k != 0)
                    MessageBox.Show("Đã xóa", "Thông báo");
                else
                    MessageBox.Show("Chưa xóa", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa", "Thông báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)datagv_HDBH.DataSource;
            string ctv = "select * from CHITIETHOADON_BANHANG";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mahdx = txtSearch.Text;
            string ctv = "select * from HOADON_BANHANG where MAHDX like N'%" + mahdx + "%'";
            DataTable dt = db.getDataTable(ctv);
            datagv_HDBH.DataSource = dt;
        }

        private void datagv_CTHD_HB_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow editedRow = datagv_HDBH.Rows[e.RowIndex];
            string maHH = editedRow.Cells["MAHH"].Value.ToString();
            string tenHH = editedRow.Cells["TENHH"].Value.ToString();
            string soLuong = editedRow.Cells["SOLUONG"].Value.ToString();
            string donGia = editedRow.Cells["DONGIABAN"].Value.ToString();
            string maHDX = editedRow.Cells["MAHDX"].Value.ToString();
            string giamGia = editedRow.Cells["GIAMGIA"].Value.ToString();
            string thanhTien = editedRow.Cells["THANHTIEN"].Value.ToString();

            DataRow[] foundRows = dt.Select($"MaHDX = '{maHDX}'");
            if (foundRows.Length > 0)
            {
                DataRow dr = foundRows[0];
                dr["MAHH"] = maHH;
                dr["TENHH"] = tenHH;
                dr["SOLUONG"] = soLuong;
                dr["DONGIABAN"] = donGia;
                dr["GIAMGIA"] = giamGia;
                dr["THANHTIEN"] = thanhTien;
                dr["MAHDX"] = maHDX;

                dr.AcceptChanges();
                show_combobox_MaHH();
                datagv_HDBH.DataSource = dt;
                string ctv = "select * from CHITIETHOADON_BANHANG";
                int k = db.UpdateDataTable(dt, ctv);
                if (k != 0)
                    MessageBox.Show("Đã sửa", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
            }
        }
    }
}
