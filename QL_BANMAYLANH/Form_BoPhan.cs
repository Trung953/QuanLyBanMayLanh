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
    public partial class Form_BoPhan : Form
    {
        public Form_BoPhan()
        {
            InitializeComponent();
        }


        DBConnect conn = new DBConnect();
        
        DataTable dt;

        public void LoadDataGridView_BOPHAN()
        {
            string strSQL = "SELECT * FROM BOPHAN";
            dt = conn.getDataTable(strSQL);
            dataGridView1.DataSource = dt;

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = dt.Columns[0];
            dt.PrimaryKey = primaryKey;
        }

        public void dataBindings(DataTable pTable)
        {
            txt_MABP.DataBindings.Clear();
            txt_TENBP.DataBindings.Clear();
            txt_MABP.DataBindings.Add("Text", pTable, "MABP");
            txt_TENBP.DataBindings.Add("Text", pTable, "TENBP");
        }

        bool KTMaBPTrung(string mBP)
        {
            DBConnect db = new DBConnect();
            string ctv = "select count(*) from BOPHAN where MANV='" + mBP + "'";
            int kq = (int)db.getScalar(ctv);
            if (kq == 0)
                return true;
            return false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_MABP.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã Bộ Phận. Vui lòng nhập !!!");
                txt_MABP.Focus();
                return;
            }
            else if (txt_TENBP.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên Bộ Phận. Vui lòng nhập !!!");
                txt_TENBP.Focus();
                return;
            }
            if (KTMaBPTrung(txt_MABP.Text))
            {
                DataRow newRow = dt.NewRow();
                newRow["MABP"] = txt_MABP.Text;
                newRow["TENBP"] = txt_TENBP.Text;
                dt.Rows.Add(newRow);
                string ctv = "select*from BOPHAN";
                int k = conn.UpdateDataTable(dt, ctv);
                if (k != 0)

                    MessageBox.Show("Thêm thành công!", "Thông Báo");
                else
                    MessageBox.Show("Thêm không thành công!", "Thông Báo");
            }
            else
            {
                txt_MABP.Focus();
                MessageBox.Show("Trùng mã bộ phân", "Thông Báo");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.No)
                return;

            //Tiến hành kiểm tra và lưu dữ liệu
            string mabp = txt_MABP.Text.Trim();
            //Lưu cập nhật
            DataRow deleteRow = dt.Rows.Find(mabp);
            deleteRow.Delete();

            //Cập nhật dữ liệu xuống CSDL
            string ctv = "select * from BOPHAN";
            int k = conn.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa không thành công!");
            txt_MABP.Clear();
            txt_TENBP.Clear();
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MABP.Text);

            //sửa dt
            if (dr != null)
            {
                dr["TENBP"] = txt_TENBP.Text;
            }
            // cập nhập trong CSDL
            string ctv = "select * from BOPHAN";
            int k = conn.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Đã sửa", "Thông báo");

            else
                MessageBox.Show("Chưa sửa", "Thông báo");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string ctv = "select * from NGUOIDUNG";
            int k = conn.UpdateDataTable(dt, ctv);

            if (k != 0)
                MessageBox.Show("Đã Lưu", "thông báo");
            else
                MessageBox.Show("Chưa Lưu", "thông báo");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                Close();
        }

        private void BOPHAN_Load(object sender, EventArgs e)
        {
            LoadDataGridView_BOPHAN();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainAdmin main = new Form_MainAdmin();
            main.ShowDialog();
        }

    }
}
