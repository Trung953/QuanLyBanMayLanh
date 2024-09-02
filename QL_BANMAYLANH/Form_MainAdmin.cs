using QL_BANMAYLANH.ADO;
using QL_BANMAYLANH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BANMAYLANH
{
    public partial class Form_MainAdmin : Form
    {
        
        private string dataFromForm1;
        private string idEmployee;// Biến để lưu giá tr
        public Form_MainAdmin(string dataFromForm1, string idEmployee)
        {
            this.dataFromForm1 = dataFromForm1;
            this.idEmployee = idEmployee;
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        public Form_MainAdmin()
        {
            InitializeComponent();
        }

        private Form FormChild;
        private void OpenChildForm(Form child)
        {
            if (FormChild != null)
            {
                FormChild.Close();
            }
            FormChild = child;  
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnChild.Controls.Clear();
            pnChild.Controls.Add(child);
            pnChild.Tag = child;
            child.BringToFront();
            child.Show();
        }



        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đóng ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ptbAdmin_Click(object sender, EventArgs e)
        {
            if (FormChild != null)
            {
                FormChild.Close();
            }
            lbMenu.Text = "       Home";
            Form_TrangChu x = new Form_TrangChu();
            OpenChildForm(x);
            lbMenu.Text = "       " + x.Text;
        }

        

        //setup thanh công cụ
        private void ptbMaxSize_RestoreDown_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ptbMaxSize_RestoreDown_MouseEnter(object sender, EventArgs e)
        {
            ptbMaxSize_RestoreDown.BackColor = Color.Gainsboro;
        }

        private void ptbMaxSize_RestoreDown_MouseLeave(object sender, EventArgs e)
        {
            ptbMaxSize_RestoreDown.BackColor = Color.Transparent;
        }

        private void ptbClose_MouseEnter(object sender, EventArgs e)
        {
            ptbClose.BackColor = Color.Gainsboro;
        }

        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {
            ptbClose.BackColor = Color.Transparent;
        }
        private void ptbMinisize_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = this.Handle;

            // Sử dụng hàm ShowWindow để thu nhỏ cửa sổ
            ShowWindow(hWnd, 6);
        }
        private void ptbMinisize_MouseEnter(object sender, EventArgs e)
        {
            ptbMinisize.BackColor = Color.Gainsboro;
        }

        private void ptbMinisize_MouseLeave(object sender, EventArgs e)
        {
            ptbMinisize.BackColor = Color.Transparent;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Form_TrangChu x = new Form_TrangChu();
            OpenChildForm(x);
            lbMenu.Text = "       " + x.Text;
        }

        private void btnNhapHang_Click_1(object sender, EventArgs e)
        {
            Form_HoaDonNhap nhap = new Form_HoaDonNhap();
            OpenChildForm(nhap);
            lbMenu.Text = "       " + nhap.Text;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            Form_HoaDonBanHang0 ban = new Form_HoaDonBanHang0(idEmployee);
            OpenChildForm(ban);
            lbMenu.Text = "       " + ban.Text;
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Form_NhaCungCap ncc = new Form_NhaCungCap();
            OpenChildForm(ncc);
            lbMenu.Text = "       " + ncc.Text;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Form_KhachHang kh = new Form_KhachHang();
            OpenChildForm(kh);
            lbMenu.Text = "      " + kh.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Form_NhanVien nv = new Form_NhanVien();
            OpenChildForm(nv);
            lbMenu.Text = "      " + nv.Text;
        }

        private void btnThongk_Click(object sender, EventArgs e)
        {
            THONGKE tk = new THONGKE();
            OpenChildForm(tk);
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            Form_BoPhan bp = new Form_BoPhan();
            OpenChildForm(bp);
            lbMenu.Text = "     "+bp.Text;
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            Form_LoaiHang lh = new Form_LoaiHang();
            OpenChildForm(lh);
            lbMenu.Text = "     " + lh.Text;
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            Form_HangHoa hh = new Form_HangHoa();
            OpenChildForm(hh);
            lbMenu.Text = "     " + hh.Text;
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            Form_NguoiDung nd = new Form_NguoiDung();
            OpenChildForm(nd);
            lbMenu.Text = "      " + nd.Text;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Form_DangNhap form_DangNhap = new Form_DangNhap();
            form_DangNhap.Show();
            this.Hide();
        }

        private void btnThongSoKT_Click(object sender, EventArgs e)
        {
            Form_ThongSoKiThuat_HH tskt = new Form_ThongSoKiThuat_HH();
            OpenChildForm(tskt);
            lbMenu.Text = "       " + tskt.Text;
        }

        private void pnChild_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
