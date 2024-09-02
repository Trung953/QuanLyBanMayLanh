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
    public partial class Form_ThongSoKiThuat_HH : Form
    {
        public Form_ThongSoKiThuat_HH()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();
        DataTable dt;
        void HienthiDSThốngKiThuat_HH_dtgv()
        {
            string ctv = "select * from THONGSOKT_HH";
            dt = db.getDataTable(ctv);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
        }
        void LKDL(DataTable pdt)
        {
            textBoxMHH.DataBindings.Clear();
            textBoxKT.DataBindings.Clear();
            textBoxCS.DataBindings.Clear();
            textBoxTKD.DataBindings.Clear();
            textBoxTL.DataBindings.Clear();
            textBoxNSX.DataBindings.Clear();
            textBoxBH.DataBindings.Clear();

            textBoxMHH.DataBindings.Add("text", pdt, "MAHH");
            textBoxKT.DataBindings.Add("Text", pdt, "KICHTHUOC");
            textBoxCS.DataBindings.Add("Text", pdt, "CONGSUAT");
            textBoxTKD.DataBindings.Add("text", pdt, "TIETKIEMDIEN");
            textBoxTL.DataBindings.Add("Text", pdt, "TRONGLUONG");
            textBoxNSX.DataBindings.Add("text", pdt, "NAMSX");
            textBoxBH.DataBindings.Add("Text", pdt, "BAOHANH");

        }
        private void button_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["MAHH"] = textBoxMHH.Text;
            dr["KICHTHUOC"] = textBoxKT.Text;
            dr["CONGSUAT"] = textBoxCS.Text;
            dr["TIETKIEMDIEN"] = textBoxTKD.Text;
            dr["TRONGLUONG"] = textBoxTL.Text;
            dr["NAMSX"] = textBoxNSX.Text;
            dr["BAOHANH"] = textBoxBH.Text;
            dt.Rows.Add(dr);
            string ctv = "select * from THONGSOKT_HH";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

            // tìm ra dòng tin cần xóa trong dt;
            DataRow dr = dt.Rows.Find(textBoxMHH.Text);
            //xoa dt
            if (dr != null)
                dr.Delete();
            string ctv = "select * from THONGSOKT_HH";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã xóa", "Thông báo");
            else
                MessageBox.Show("Chưa xóa", "Thông báo");
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            // tìm ra dòng tin cần sửa trong dt;
            DataRow dr = dt.Rows.Find(textBoxMHH.Text);
            //sửa dt
            if (dr != null)
            {
                dr["KICHTHUOC"] = textBoxKT.Text;
                dr["CONGSUAT"] = textBoxCS.Text;
                dr["TIETKKIMDIEN"] = textBoxTKD.Text;
                dr["TRONGLUONG"] = textBoxTL.Text;
                dr["NAMSX"] = textBoxNSX.Text;
                dr["BAOHANH"] = textBoxBH.Text;
            }
            // cập nhập trong CSDL
            string ctv = "select * from THONGSOKT_HH";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã sửa", "Thông báo");
            else
                MessageBox.Show("Chưa sửa", "Thông báo");
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string ctv = "select * from THONGSOKT_HH";
            int k = db.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã thêm", "thông báo");
            else
                MessageBox.Show("Chưa thêm", "thông báo");
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            string mhh = textBoxMHH.Text;
            string ctv = "select * from THONGSOKT_HH where MAHH like N'%" + mhh + "%'";
            DataTable dt = db.getDataTable(ctv);
            dataGridView1.DataSource = dt;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormThongSoKiThuat_HH_Load(object sender, EventArgs e)
        {
            HienthiDSThốngKiThuat_HH_dtgv();
            LKDL(dt);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
