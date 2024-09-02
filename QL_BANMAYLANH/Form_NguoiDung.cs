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
    public partial class Form_NguoiDung : Form
    {
        public Form_NguoiDung()
        {
            InitializeComponent();
        }

        DBConnect conn = new DBConnect();
        DataTable dt;

        public void LoadDataGridView_NGUOIDUNG()
        {
            string strSQL = "SELECT * FROM NGUOIDUNG";
            dt = conn.getDataTable(strSQL);
            dataGridView1.DataSource = dt;

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = dt.Columns[0];
            dt.PrimaryKey = primaryKey;
        }

        public void dataBindings(DataTable pTable)
        {
            txt_ND.DataBindings.Clear();
            txt_MK.DataBindings.Clear();
            cbo_ND.DataBindings.Add("Text", pTable, "MANV");
            txt_ND.DataBindings.Add("Text", pTable, "username");
            txt_MK.DataBindings.Add("Text", pTable, "password");
            cb_quyen.DataBindings.Add("Text", pTable, "QuyenTC");
        }

        void hienthi_DSND()
        {
            DBConnect db = new DBConnect();
            string ctv = "select MANV,TENNV from NHANVIEN";
            DataTable dt = db.getDataTable(ctv);
            cbo_ND.DataSource = dt;
            cbo_ND.DisplayMember = "MANV";
            cbo_ND.ValueMember = "TENNV";
        }

        bool KTMaNDTrung(string mND)
        {
            DBConnect db = new DBConnect();
            string ctv = "select count(*) from NGUOIDUNG where MANV='" + mND + "'";
            int kq = (int)db.getScalar(ctv);
            if (kq == 0)
                return true;
            return false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
             if (cbo_ND.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn mã người dùng. Vui lòng nhập !!!");
                cbo_ND.Focus();
                return;
            }
            else if (txt_ND.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên người dùng. Vui lòng nhập !!!");
                txt_ND.Focus();
                return;
            }
            else if (txt_MK.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu. Vui lòng nhập !!!");
                txt_MK.Focus();
                return;
            }
             else if(cb_quyen.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn quyền truy cập. Vui lòng nhập !!!");
                cb_quyen.Focus();
                return;
            }    
             if (KTMaNDTrung(cbo_ND.Text))
             {
                 DataRow newRow = dt.NewRow();
                 newRow["MANV"] = cbo_ND.Text;
                 newRow["username"] = txt_ND.Text;
                 newRow["password"] = txt_MK.Text;
                 newRow["QuyenTC"] = cb_quyen.Text;
                dt.Rows.Add(newRow);
                 string ctv = "select*from NGUOIDUNG";
                 int k = conn.UpdateDataTable(dt, ctv);
                 if (k != 0)

                     MessageBox.Show("Thêm thành công!", "Thông Báo");
                 else
                     MessageBox.Show("Thêm không thành công!", "Thông Báo");
             }
             else
             {
                cbo_ND.Focus();
                MessageBox.Show("Trùng mã người dùng", "Thông Báo");
             }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.No)
                return;

            //Tiến hành kiểm tra và lưu dữ liệu
            string mand = cbo_ND.Text.Trim();
            //Lưu cập nhật
            DataRow deleteRow = dt.Rows.Find(mand);
            deleteRow.Delete();

            //Cập nhật dữ liệu xuống CSDL
            string ctv = "select * from NGUOIDUNG";
            int k = conn.UpdateDataTable(dt, ctv);
            if (k != 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa không thành công!");
            txt_ND.Clear();
            txt_MK.Clear();
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(cbo_ND.Text);

            //sửa dt
            if (dr != null)
            {
                dr["username"] = txt_ND.Text;
                dr["password"] = txt_MK.Text;
                dr["QuyenTC"] = cb_quyen.Text;
            }
            // cập nhập trong CSDL
            string ctv = "select * from NGUOIDUNG";
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

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataGridView_NGUOIDUNG();
            hienthi_DSND();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainAdmin main = new Form_MainAdmin();
            main.ShowDialog();
        }

        
    }
}
