using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QL_BANMAYLANH
{
    public partial class THONGKE1 : Form
    {
        public THONGKE1()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        void HienThiDS_ThongKe()
        {
            string ctv = "select * from THONGKE";
            dt = db.getDataTable(ctv);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            datagv_ThongKe.DataSource = dt;
        }
        void LKDL(DataTable pdt)
        {
            txt_MaTK.DataBindings.Clear();
            txt_MaHH.DataBindings.Clear();
            txt_TenHH.DataBindings.Clear();
            txt_Soluong.DataBindings.Clear();
            txt_TenNCC.DataBindings.Clear();
            dateTime_NgayTK.DataBindings.Clear();
            txt_DonGia.DataBindings.Clear();
            txt_TongTien.DataBindings.Clear();
            txt_MaHDX.DataBindings.Clear();
            txt_MaHH.DataBindings.Add("Text", pdt, "MAHH");
            txt_TenHH.DataBindings.Add("Text", pdt, "TENHH");
            txt_Soluong.DataBindings.Add("Text", pdt, "SOLUONG");
            txt_TenNCC.DataBindings.Add("Text", pdt, "TENNCC");
            dateTime_NgayTK.DataBindings.Add("Text", pdt, "NGAY");
            txt_DonGia.DataBindings.Add("Text", pdt, "DONGIA");
            txt_TongTien.DataBindings.Add("Text", pdt, "TONGTIEN");
            txt_MaTK.DataBindings.Add("Text", pdt, "MATK");
            txt_MaHDX.DataBindings.Add("Text", pdt, "MAHDX");
        }
        private void THONGKE_Load(object sender, EventArgs e)

        {
            HienThiDS_ThongKe();
            LKDL(dt);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["MATK"] = txt_MaTK.Text;
            dr["MAHH"] = txt_MaHH.Text;
            dr["TENHH"] = txt_TenHH.Text;
            dr["SOLUONG"] = txt_Soluong.Text;
            dr["TENNCC"] = txt_TenNCC.Text;
            dr["NGAY"] = dateTime_NgayTK.Text;
            dr["DONGIA"] = txt_DonGia.Text;
            dr["TONGTIEN"] = txt_TongTien.Text;
            dr["MAHDX"] = txt_MaHDX.Text;
            dt.Rows.Add(dr);
            string ctv = "select * from THONGKE";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            // tìm ra dòng tin cần xóa trong dt;
            DataRow[] foundRows = dt.Select("MATK = '" + txt_MaTK.Text + "'");

            //xoa dt
            if (foundRows.Length > 0)
            {
                DataRow dr = foundRows[0];
                dr.Delete();
                dt.AcceptChanges();
                string ctv = "select * from THONGKE";
                int k = db.UpdateDataTable(dt, ctv);
                if (k != 0)
                    MessageBox.Show("Đã xóa", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dt = (DataTable)datagv_ThongKe.DataSource;
            string ctv = "select * from THONGKE";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            // tìm ra dòng tin cần sửa trong dt;
            DataRow[] foundRows = dt.Select("MATK = '" + txt_MaTK.Text + "'");


            //sửa dt
            if (foundRows.Length > 0)
            {
                DataRow dr = foundRows[0];
                dr["MATK"] = txt_MaTK.Text;
                dr["MAHDX"] = txt_MaHDX.Text;
                dr["MAHH"] = txt_MaHH.Text;
                dr["TENHH"] = txt_TenHH.Text;
                dr["SOLUONG"] = txt_Soluong.Text;
                dr["TENNCC"] = txt_TenNCC.Text;
                dr["NGAY"] = dateTime_NgayTK.Text;
                dr["DONGIA"] = txt_DonGia.Text;
                dr["TONGTIEN"] = txt_TongTien.Text;
                dt.AcceptChanges();
                string ctv = "select * from THONGKE";
                int k = db.UpdateDataTable(dt, ctv);
                if (k != 0)
                    MessageBox.Show("Đã sửa", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string matk = txt_MaTK.Text;
            string ctv = "select * from THONGKE where MATK like N'%" + matk + "%'";
            DataTable dt = db.getDataTable(ctv);
            datagv_Find.DataSource = dt;
        }

        private void THONGKE_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void datagv_ThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main main = new Form_Main();
            main.ShowDialog();
        }
    }
}
