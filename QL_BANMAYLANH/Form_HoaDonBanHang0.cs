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
    public partial class Form_HoaDonBanHang0 : Form
    {

        private string maNV;
        public Form_HoaDonBanHang0(string idEmployee)
        {
            InitializeComponent();
            this.maNV = idEmployee;
        }

        public Form_HoaDonBanHang0()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();
        DataTable dt;
        void HienThiDS_ThongKe()
        {
            string ctv = "select * from HOADON_BANHANG";
            dt = db.getDataTable(ctv);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            datagv_HDBH.DataSource = dt;
        }
        void LKDL(DataTable pdt)
        {
            combo_MAHDX.DataBindings.Clear();
            CB_MAKH.DataBindings.Clear();
            combo_MANV.DataBindings.Clear();
            label_TONGTIEN.DataBindings.Clear();
            date_NGAY_GIOXUAT.DataBindings.Clear();

            combo_MAHDX.DataBindings.Add("Text", pdt, "MAHDX");
            CB_MAKH.DataBindings.Add("Text", pdt, "MAKH");
            combo_MANV.DataBindings.Add("Text", pdt, "MANV");
            label_TONGTIEN.DataBindings.Add("Text", pdt, "TONGTIEN");
            date_NGAY_GIOXUAT.DataBindings.Add("Text", pdt, "NGAY_GIOXUAT");

        }
        void ShowComboBoxData(string tableName, ComboBox comboBox, string displayMember, string valueMember)
        {

            DataTable dt = new DataTable();
            string ctv = "SELECT * FROM " + tableName;
            dt = db.getDataTable(ctv);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedIndexChanged += new EventHandler(combo_MAHDX_SelectedIndexChanged);
        }
      
        private void HOADON_BANHANG_Load(object sender, EventArgs e)
        {
            HienThiDS_ThongKe();
            LKDL(dt);
            ShowComboBoxData("CHITIETHOADON_BANHANG", combo_MAHDX, "MAHDX", "MAHDX");
            ShowComboBoxData("KHACHHANG", CB_MAKH, "MAKH", "MAKH");
            ShowComboBoxData("NHANVIEN", combo_MANV, "MANV", "MANV");
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainAdmin main = new Form_MainAdmin();
            main.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahdx = combo_MAHDX.Text;
            string makh = CB_MAKH.Text;
            string manv = combo_MANV.Text;
            string tongtien = label_TONGTIEN.Text;
            string ngaygioxuat = date_NGAY_GIOXUAT.Text;
            

            // Tạo một DataRow và gán giá trị
            DataRow dr = dt.NewRow();
            dr["MAHDX"] = mahdx;
            dr["MAKH"] = makh;
            dr["MANV"] = manv;
            dr["TONGTIEN"] = tongtien;
            dr["NGAY_GIOXUAT"] = ngaygioxuat;
            dt.Rows.Add(dr);
            dt.AcceptChanges();
            try
            {
                string ctv = "SELECT * FROM HOADON_BANHANG";
                int k = db.UpdateDataTable(dt, ctv);
                if (k > 0)
                    MessageBox.Show("Đã thêm", "Thông báo");
                else
                    MessageBox.Show("Chưa thêm", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows = dt.Select("MAHDX = '" + combo_MAHDX.Text + "'");
            if (foundRows.Length > 0)
            {
                DataRow dr = foundRows[0];
                dr["MAHDX"] = combo_MAHDX.SelectedValue.ToString();
                dr["MAKH"] = CB_MAKH.SelectedValue.ToString();
                dr["MANV"] = combo_MANV.SelectedValue.ToString();
                if (double.TryParse(label_TONGTIEN.Text, out double totalAmount))
                    dr["TONGTIEN"] = totalAmount;
                else
                    dr["TONGTIEN"] = 0.0;

                dr["NGAY_GIOXUAT"] = date_NGAY_GIOXUAT.Value.ToString();
                datagv_HDBH.DataSource = dt;
                string ctv = "select * from HOADON_BANHANG";
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
            DataRow[] foundRows = dt.Select("MAHDX = '" + combo_MAHDX.Text + "'");

            //xoa dt
            if (foundRows.Length > 0)
            {
                DataRow dr = foundRows[0];
                dr.Delete();
                dt.AcceptChanges();
                string ctv = "select * from HOADON_BANHANG";
                int k = db.UpdateDataTable(dt, ctv);
                if (k != 0)
                    MessageBox.Show("Da xoa", "thong bao");
            }
            else
            {
                MessageBox.Show("Khong tim thay", "Thong bao");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)datagv_HDBH.DataSource;
            string ctv = "select * from HOADON_BANHANG";
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
            string ctv = "select * from CHITIETHOADON_BANHANG where MAHDX like N'%" + mahdx + "%'";
            DataTable dt = db.getDataTable(ctv);
            datagv_HDBH.DataSource = dt;
        }

        private void combo_MAHDX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMAHDX = combo_MAHDX.SelectedValue.ToString();
            string query = "SELECT SUM(THANHTIEN) AS TotalAmount FROM CHITIETHOADON_BANHANG WHERE MAHDX = '" + selectedMAHDX + "'";
            DataTable result = db.getDataTable(query);

            if (result.Rows.Count > 0)
            {
                string totalAmount = result.Rows[0]["TotalAmount"].ToString();
                label_TONGTIEN.Text = totalAmount;
            }
            else
            {
                label_TONGTIEN.Text = "0"; 
            }
        }
    }
}
