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
    public partial class THONGKE : Form
    {
        public THONGKE()
        {
            InitializeComponent();
        }

        private void btn_tknh_Click(object sender, EventArgs e)
        {
            Form_ThongKeNhapHang tknh = new Form_ThongKeNhapHang();
            tknh.ShowDialog();
        }

        private void btn_tkbh_Click(object sender, EventArgs e)
        {
            Form_ThongkeBanHang tkbh = new Form_ThongkeBanHang();
            tkbh.ShowDialog();
        }
    }
}
