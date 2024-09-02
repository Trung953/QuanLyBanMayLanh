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
    public partial class Form_ThongKeNhapHang : Form
    {
        public Form_ThongKeNhapHang()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        void HienThiDS_ThongKe()
        {
            string ctv = "select * from HOADONNHAP";
            dt = db.getDataTable(ctv);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            datagv_ThongKe.DataSource = dt;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainAdmin main = new Form_MainAdmin();
            main.ShowDialog();
        }
        private void Form_ThongKeNhapHang_Load(object sender, EventArgs e)
        {
            HienThiDS_ThongKe();
        }
        decimal tongDoanhThu = 0;
        private void TinhTongDoanhThu(DataTable data)
        {
            if (data != null && data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    if (row["TONGTIEN"] != DBNull.Value)
                    {
                        tongDoanhThu += Convert.ToDecimal(row["TONGTIEN"]);
                    }
                }
            }
        }
        private void FilterDataByDateRange()
        {
            DateTime fromDateValue = dateTimePicker1.Value;
            DateTime toDateValue = dateTimePicker2.Value;
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("NGAY_GIONHAP >= #{0:M/d/yyyy}# AND NGAY_GIONHAP <= #{1:M/d/yyyy}#", fromDateValue, toDateValue);
            DataTable filteredData = dv.ToTable();
            datagv_ThongKe.DataSource = filteredData;

            TinhTongDoanhThu(filteredData);

            txt_DoanhThu.Text = tongDoanhThu.ToString();
        }
        private void button_XemThongTin_Click(object sender, EventArgs e)
        {
            FilterDataByDateRange();
        }
        private void combobox_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    string selectedStatus = combobox_TrangThai.SelectedItem.ToString();
        //    DataView dv = dt.DefaultView;
        //    dv.RowFilter = $"TRANGTHAI = '{selectedStatus}'"; 
        //    datagv_ThongKe.DataSource = dv.ToTable();
        }
    
    }
}
