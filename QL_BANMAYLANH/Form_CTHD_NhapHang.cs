//using DevExpress.Internal;
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
    public partial class Form_CTHD_NhapHang : Form
    {
        public string _id;
        public string _idhh;
        private HangHoaADO _hangHoa;
        private HoaDonNhapADO _hoaDonNhap;
        private DBConnect _dbConnect;
        private ChiTietHoaDonNhapADO _chiTietHoaDonNhap;
        double _tongTien;
        bool _them;
        //private static extern int GetWindowZOrder(IntPtr hWnd);

        //public int GetZOrder()
        //{
        //    return GetWindowZOrder(this.Handle);
        //}
        public Form_CTHD_NhapHang()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaHoaDon.Text = _id;
                txtMaHoaDon.Enabled = false;
                _dbConnect = new DBConnect();
                _hoaDonNhap = new HoaDonNhapADO(_dbConnect);
                _hangHoa = new HangHoaADO(_dbConnect);
                _chiTietHoaDonNhap = new ChiTietHoaDonNhapADO(_dbConnect);
                _LoadComBoBox();
                txtTongTien.Enabled = false;
                txtDonGia.Enabled = false;
                _LoaDataGv();
                _them = false;
                _ShowHide(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load Form: " + ex.Message);
            }
        }

        void _ShowHide(bool e)
        {
            btnHuy.Enabled = !e;
            btnLuu.Enabled = !e;
            cboHangHoa.Enabled = !e;
            nbGiamGia.Enabled = !e;
            nbSoLuong.Enabled = !e;
            txtMaHoaDon.Enabled = false;
            txtDonGia.Enabled = false;
            btnThem.Enabled = e;
            btnSua.Enabled = e;
            btnXoa.Enabled = e;
            txtTongTien.Enabled = false;
        }
        void _LoadComBoBox()
        {
            cboHangHoa.DataSource = _hangHoa.GetAllHangHoa();
            cboHangHoa.DisplayMember = "TENHH";
            cboHangHoa.ValueMember = "MAHH";
        }

        private void cboHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                var dt = _hangHoa.GetItemHangHoa(cboHangHoa.SelectedValue.ToString());
                if (dt != null)
                {
                    txtDonGia.Text = dt.GIANHAP.ToString();
                }
                else
                {
                    txtDonGia.Text = "0"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void _SaveData()
        {
            ChiTietHoaDonNhap item = new ChiTietHoaDonNhap();
            item.MaHDN = txtMaHoaDon.Text;
            item.MaHH = cboHangHoa.SelectedValue.ToString();
            item.TenHH = cboHangHoa.Text;
            item.SoLuong = int.Parse(nbSoLuong.Value.ToString());
            item.GiamGia = int.Parse(nbGiamGia.Value.ToString());
            item.DonGia = double.Parse(txtDonGia.Text);
            item.ThanhTien = double.Parse(txtTongTien.Text);
            if (_them)
            {
                _chiTietHoaDonNhap.InsertChiTietHoaDonNhap(item);
                _hoaDonNhap.UpdateTongTienHoaDonNhap(item.MaHDN);
                _LoaDataGv();
            }
            else
            {
                _chiTietHoaDonNhap.UpdateChiTietHoaDonNhap(item);
                _hoaDonNhap.UpdateTongTienHoaDonNhap(item.MaHDN);
                _LoaDataGv();

            }
        }
        void _LoadTongTien()
        {
            double soLuong = (double)nbSoLuong.Value;
            double giaSanPham = double.Parse(txtDonGia.Text);
            double phanTramGiamGia = (double)nbGiamGia.Value;
            double tongTien = soLuong * giaSanPham * (1 - phanTramGiamGia / 100);
            txtTongTien.Text = tongTien.ToString();
        }
        private void nbSoLuong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _LoadTongTien();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        void _LoaDataGv()
        {
            if (_id != null && _id != "")
            {
                gv_chitiethd.DataSource = _chiTietHoaDonNhap.GetChiTietHoaDonNhap(_id);

            }
            else
                gv_chitiethd.DataSource = _chiTietHoaDonNhap.GetChiTietHoaDonNhap();
            gv_chitiethd.ReadOnly = true;
            // Ẩn dòng cuối cùng Trên 
            gv_chitiethd.AllowUserToAddRows = false;
        }
        private void nbGiamGia_ValueChanged(object sender, EventArgs e)
        {

            _LoadTongTien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            _ShowHide(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _ShowHide(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                string maHD = txtMaHoaDon.Text;
                string maHH = cboHangHoa.SelectedValue.ToString();
                if (_chiTietHoaDonNhap.DeleteChiTietHoaDonNhap(maHD, maHH) == 1)
                {
                    MessageBox.Show("Đã xóa khỏi CSDL");
                    _LoaDataGv();
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

        private void gvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gv_chitiethd.Rows[e.RowIndex];

                    foreach (DataGridViewRow gridViewRow in gv_chitiethd.Rows)
                    {
                        gridViewRow.DefaultCellStyle.BackColor = Color.White;
                    }

                    _id = txtMaHoaDon.Text = row.Cells["MAHDN"].Value.ToString();
                    cboHangHoa.SelectedValue = row.Cells["MAHH"].Value;
                    _idhh = row.Cells["MAHH"].Value.ToString();
                    nbSoLuong.Value = Convert.ToDecimal(row.Cells["SOLUONG"].Value.ToString());
                    nbGiamGia.Value = Convert.ToDecimal(row.Cells["GIAMGIA"].Value.ToString());
                    _idhh = row.Cells["MAHH"].Value.ToString();
                    txtTongTien.Text = row.Cells["THANHTIEN"].Value.ToString();

                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                    double soLuong = (double)nbSoLuong.Value;
                    double giaSanPham = double.Parse(txtDonGia.Text);
                    double phanTramGiamGia = (double)nbGiamGia.Value;
                    double tongTien = soLuong * giaSanPham * (1 - phanTramGiamGia / 100);
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
                gv_chitiethd.DataSource = _chiTietHoaDonNhap.SearchChiTietHoaDonNhap(keyword);
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
                _LoaDataGv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

