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
using QL_BANMAYLANH.ADO;

namespace QL_BANMAYLANH
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        DBConnect db =new DBConnect();
     
        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = db.GetConnection();
            try
            {
                //conn.Open();
                //string tk = txt_Ten.Text;
                //string mk = txt_Pass.Text;
                //string sql = "select NGUOIDUNG,MATKHAU from NGUOIDUNG where NGUOIDUNG='" + tk + "' and MATKHAU='" + mk + "'";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //SqlDataReader rd = cmd.ExecuteReader();
                //if (rd.Read() == true)
                //{
                //    MessageBox.Show("Đăng nhập thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    this.Hide();
                //    Form_Main formMain = new Form_Main();
                //    formMain.ShowDialog();
                //}
                //else
                //{
                //    MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập. Không thể đăng nhập !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                object id_Employe = (object)AccountADO.Instance.getIdEmployeeByLogin(txt_Ten.Text, txt_Pass.Text);
                object result = (object)AccountADO.Instance.kiemTraAccount(txt_Ten.Text, txt_Pass.Text);
                if (result != null)
                {
                    string id = ((string)id_Employe).Trim();
                    string qtc = ((string)result).Trim();
                    if (string.Compare(qtc, "admin",StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        MessageBox.Show("Dăng nhập thành công dưới quyền admin");
                        this.Hide();
                        Form_MainAdmin fm = new Form_MainAdmin(qtc,id);
                        fm.ShowDialog();
                    }
                    else if (string.Compare(qtc, "nhanvien", StringComparison.OrdinalIgnoreCase) == 0) 
                    {
                        MessageBox.Show("Dăng nhập  thành công dưới quyền nhân viên");
                        this.Hide();
                        Form_MainNV fmnv = new Form_MainNV(qtc,id);
                        fmnv.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Dăng nhập không thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại !!!");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đóng màn hình này không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                Close();
        }

        private void check_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Show.Checked == true)
            {
                txt_Pass.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                check_Show.Text = "Hide password";
            }
            else
            {
                txt_Pass.UseSystemPasswordChar = true;
                check_Show.Text = "Show password";
            }
        }

        private void btn_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }


    }
}
