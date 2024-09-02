using QL_BANMAYLANH.ADO;
using QL_BANMAYLANH.Models;
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
    public partial class Form_HoaDonNhap : Form
    {
        NhanVienADO _nhanVien;
        NhaCungCapADO _nhaCungCap;
        HoaDonNhapADO _hoaDonNhap;
        DBConnect _dbConnect;
        bool _them;
        string _id;
        public Form_HoaDonNhap()
        {
            InitializeComponent();
        }



        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            _dbConnect = new DBConnect();
            _nhanVien = new NhanVienADO(_dbConnect);
            _nhaCungCap = new NhaCungCapADO(_dbConnect);
            _hoaDonNhap = new HoaDonNhapADO(_dbConnect);
            txtTongTien.Text = "0";
            _LoadComBobox();
            _LoadDataGv();
            _them = false;
            _ShowHide(true);
        }
        void _SaveData()
        {
            HoaDonNhap item = new HoaDonNhap();
            item.MaHDN = txtMaHoaDon.Text;
            item.MaNV = cboNhanVien.SelectedValue.ToString();
            item.MaNCC = cboNhaCungCap.SelectedValue.ToString();
            item.TongTien = Convert.ToDouble(txtTongTien.Text);
            item.NgayGioNhap = dateNgay.Value;

            if (_them)
            {
                _hoaDonNhap.InsertHoaDonNhap(item);
                _LoadDataGv();
            }
            else
            {
                _hoaDonNhap.UpdateHoaDonNhap(item);
                _LoadDataGv();
            }
        }
        void _ShowHide(bool e)
        {
            btnHuy.Enabled = !e;
            btnLuu.Enabled = !e;
            txtMaHoaDon.Enabled = !e;
            dateNgay.Enabled = !e;
            cboNhaCungCap.Enabled = !e;
            cboNhanVien.Enabled = !e;

            btnThem.Enabled = e;
            btnSua.Enabled = e;
            btnXoa.Enabled = e;
            txtTongTien.Enabled = false;
        }
        void _LoadDataGv()
        {
            
            gvHoaDonNhap.DataSource = _hoaDonNhap.GetAllHoaDonNhap();
            gvHoaDonNhap.ReadOnly = true;
            // Ẩn dòng cuối cùng Trên 
            gvHoaDonNhap.AllowUserToAddRows = false;
        }
        void _LoadComBobox()
        {
            cboNhanVien.DataSource = _nhanVien.GetAllNhanVien();
            cboNhanVien.DisplayMember = "TENNV";
            cboNhanVien.ValueMember = "MANV";

            cboNhaCungCap.DataSource = _nhaCungCap.GetAllNhaCungCap();
            cboNhaCungCap.DisplayMember = "TENNCC";
            cboNhaCungCap.ValueMember = "MANCC";
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
                string maHDN = txtMaHoaDon.Text;
                if (_hoaDonNhap.DeleteHoaDonNhap(maHDN) == 1)
                {
                    MessageBox.Show("Đã xóa khỏi CSDL");
                    _LoadDataGv();
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

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            Form_CTHD_NhapHang frm = new Form_CTHD_NhapHang();
            frm._id = _id;
            frm.ShowDialog();
        }

        private void gvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gvHoaDonNhap.Rows[e.RowIndex];

                    foreach (DataGridViewRow gridViewRow in gvHoaDonNhap.Rows)
                    {
                        gridViewRow.DefaultCellStyle.BackColor = Color.White;
                    }

                    _id = txtMaHoaDon.Text = row.Cells["MAHDN"].Value.ToString();
                    cboNhaCungCap.SelectedValue = row.Cells["MANCC"].Value;
                   
                    cboNhanVien.SelectedValue = row.Cells["MANV"].Value;
                    txtTongTien.Text = row.Cells["TONGTIEN"].Value.ToString();
                    dateNgay.Value = Convert.ToDateTime(row.Cells["NGAY_GIONHAP"].Value);

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
                gvHoaDonNhap.DataSource = _hoaDonNhap.SearchHoaDonNhap(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool isEventRunning = false;
        private void btnDsChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (!isEventRunning)
            {
                isEventRunning = true;

                try
                {

                    Form_CTHD_NhapHang frm = new Form_CTHD_NhapHang();
                    //frm.TopMost = true;
                    frm.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                _LoadDataGv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}