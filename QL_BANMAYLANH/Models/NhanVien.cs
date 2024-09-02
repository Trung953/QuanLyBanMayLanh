using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BANMAYLANH.Models
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string MaBP { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
    }
}
