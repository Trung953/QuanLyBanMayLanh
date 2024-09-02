using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_BANMAYLANH
{
    public partial class Form_LoaiHang : Form
    {
        public Form_LoaiHang()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();
        DataTable dt;
        void HienthiDSLoai_HangHoa_dtgv()
        {
            string ctv = "select * from LOAI_HANGHOA";
            dt = db.getDataTable(ctv);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
        }
        void LKDL(DataTable pdt)
        {
            textBoxML.DataBindings.Clear();
            textBoxTL.DataBindings.Clear();
            textBoxTruSoC.DataBindings.Clear();
            textBoxEmail.DataBindings.Clear();
            //textBoxSTT.DataBindings.Clear();
            textBoxML.DataBindings.Add("Text", pdt, "MALOAI");
            textBoxTL.DataBindings.Add("Text", pdt, "TENLOAI");
            textBoxTruSoC.DataBindings.Add("Text", pdt, "TRUSOCHINH");
            textBoxEmail.DataBindings.Add("Text", pdt, "EMAIL");
            //textBoxSTT.DataBindings.Add("Text", pdt, "STT");
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["MALOAI"] = textBoxML.Text;
            dr["TENLOAI"] = textBoxTL.Text;
            dr["TRUSOCHINH"] = textBoxTruSoC.Text;
            //dr["STT"] = textBoxSTT.Text;
            dr["EMAIL"] = textBoxEmail.Text;
            //dr["MALOAI"] = textBoxML.Text;
            //dr["MANCC"] = textBoxMNCC.Text;
            dt.Rows.Add(dr);
            string ctv = "select * from LOAI_HANGHOA";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void FormLHH_Load(object sender, EventArgs e)
        {
            HienthiDSLoai_HangHoa_dtgv();
            LKDL(dt);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // tìm ra dòng tin cần xóa trong dt, là số thứ tự;
            DataRow dr = dt.Rows.Find(textBoxML.Text);
            //xoa dt
            if (dr != null)
                dr.Delete();
            string ctv = "select * from LOAI_HANGHOA";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã xóa", "Thông báo");
            else
                MessageBox.Show("Chưa xóa", "Thông báo");
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            // tìm ra dòng tin cần sửa trong dt;
            DataRow dr = dt.Rows.Find(textBoxML.Text);

            //sửa dt
            if (dr != null)
            {
                dr["TENLOAI"] = textBoxTL.Text;
                dr["TRUSOCHINH"] = textBoxTruSoC.Text;
                dr["EMAIL"] = textBoxEmail.Text;
                dr["MALOAI"]=textBoxML.Text;
            }
            // cập nhập trong CSDL
            string ctv = "select * from LOAI_HANGHOA";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã sửa", "Thông báo");
            else
                MessageBox.Show("Chưa sửa", "Thông báo");
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string ctv = "select * from LOAI_HANGHOA";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            string MAL = textBoxML.Text;
            string ctv = "select * from LOAI_HANGHOA where MALOAI like N'%" + MAL + "%'";
            DataTable dt = db.getDataTable(ctv);
            dataGridView1.DataSource = dt;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
