using QL_BANMAYLANH.ADO;
using QL_BANMAYLANH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BANMAYLANH
{
    public partial class Form_NhaCungCap : Form
    {
        public Form_NhaCungCap()
        {
            InitializeComponent();
        }
        DBConnect _dbConnect;
        NhaCungCapADO _nhaCungCap;
        bool _them;
        string _id;
        void _loadDataGV()
        {
            dataGridV_NCC.DataSource = _nhaCungCap.GetAllNhaCungCap();
            dataGridV_NCC.ReadOnly = true;
            dataGridV_NCC.AllowUserToAddRows = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            _dbConnect = new DBConnect();
            _nhaCungCap = new NhaCungCapADO(_dbConnect);
            _loadDataGV();
            _them = false;
        }
        void _SaveData()
        {
            NhaCungCap item = new NhaCungCap();
            item.MaNCC = txt_mancc.Text;
            item.TenNCC = txt_tenncc.Text;
            item.DiaChi = txt_diachi.Text;


            if (_them)
            {
                _nhaCungCap.InsertNhaCungCap(item);
                _loadDataGV();
            }
            else
            {
                _nhaCungCap.UpdateNhaCungCap(item);
                _loadDataGV();
            }
        }
        void _ShowHide(bool e)
        {
            btnHuy.Enabled = !e;
            btnLuu.Enabled = !e;
            txt_mancc.Enabled = !e;
            txt_tenncc.Enabled = !e;
            txt_diachi.Enabled = !e;

            btnThem.Enabled = e;
            btnSua.Enabled = e;
            btnXoa.Enabled = e;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                _them = true;
                _ShowHide(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                _them = false;
                _ShowHide(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = txt_mancc.Text;
                if (_nhaCungCap.DeleteNhaCungCap(maNCC) == 1)
                {
                    MessageBox.Show("Đã xóa khỏi CSDL");
                    _loadDataGV();
                }
                else
                {
                    MessageBox.Show("Lỗi! Chưa xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _SaveData();
            _them = false;
            _ShowHide(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _them = false;
            _ShowHide(true);
        }

        private void dataGridV_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridV_NCC.Rows[e.RowIndex];

                    foreach (DataGridViewRow gridViewRow in dataGridV_NCC.Rows)
                    {
                        gridViewRow.DefaultCellStyle.BackColor = Color.White;
                    }

                    _id = txt_mancc.Text = row.Cells["MANCC"].Value.ToString();
                    txt_tenncc.Text = row.Cells["TENNCC"].Value.ToString();
                    txt_diachi.Text = row.Cells["DIACHI"].Value.ToString();

                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text;
                dataGridV_NCC.DataSource = _nhaCungCap.SearchNhaCungCap_ten(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                _loadDataGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
