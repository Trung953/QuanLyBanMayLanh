using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BANMAYLANH
{
    public partial class Form_ThongkeBanHang : Form
    {
        public Form_ThongkeBanHang()
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
            dataGridViewDSBHang.DataSource = dt;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form_Main main = new Form_Main();
            //main.ShowDialog();
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
        private void Locdata()
        {

            // Lấy giá trị ngày từ DateTimePickers
            DateTime tungay = dateTimePickerTuNgay.Value;
            DateTime toingay = dateTimePickerToiNgay.Value;

            // Lọc và tính toán tổng doanh thu bằng LINQ
            var filteredData = dt.AsEnumerable()
                .Where(row => row.Field<DateTime>("NGAY_GIONHAP") >= tungay && row.Field<DateTime>("NGAY_GIONHAP") <= toingay)
                .CopyToDataTable();

            dataGridViewDSBHang.DataSource = filteredData;

            // Tính toán tổng doanh thu
            decimal tongDoanhThu = filteredData.AsEnumerable().Sum(row => row.Field<decimal>("DoanhThu"));

            // Hiển thị tổng doanh thu trong TextBox
            textBoxTongDoanhThu.Text = tongDoanhThu.ToString();
        }

        private void Form_ThongkeBanHang_Load(object sender, EventArgs e)
        {
            HienThiDS_ThongKe();
        }
    }
}
