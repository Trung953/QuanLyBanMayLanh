using QL_BANMAYLANH.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QL_BANMAYLANH.ADO
{
    class ChiTietHoaDonNhapADO
    {
        private DBConnect db;

        public ChiTietHoaDonNhapADO(DBConnect dbConnect)
        {
            db = dbConnect;
        }
        public DataTable GetChiTietHoaDonNhap()
        {
            try
            {
                string query = "SELECT * FROM CHITIETHOADONNHAP";
                return db.getDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình lấy chi tiết hóa đơn nhập: " + ex.Message);
            }
        }

        public DataTable GetChiTietHoaDonNhap(string maHDN)
        {
            try
            {
                string query = "SELECT * FROM CHITIETHOADONNHAP WHERE MAHDN = '@maHDN'";
                query = query.Replace("@maHDN", maHDN);
                return db.getDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình lấy chi tiết hóa đơn nhập: " + ex.Message);
            }
        }

        public int InsertChiTietHoaDonNhap(ChiTietHoaDonNhap item)
        {
            try
            {
                string query = string.Format( "INSERT INTO CHITIETHOADONNHAP (MAHDN, MAHH, TENHH, SOLUONG, DONGIA, GIAMGIA, THANHTIEN) VALUES ('{0}', '{1}', N'{2}', {3}, {4}, {5}, {6})", 
                    item.MaHDN, item.MaHH, item.TenHH, item.SoLuong, item.DonGia, item.GiamGia, item.ThanhTien);
                return db.getNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình thêm chi tiết hóa đơn nhập: " + ex.Message);
            }
        }

        public int UpdateChiTietHoaDonNhap(ChiTietHoaDonNhap item)
        {
            try
            {
                string query = string.Format("UPDATE CHITIETHOADONNHAP " +
                               "SET SOLUONG = {0}, DONGIA = {1}, GIAMGIA = {2}, THANHTIEN = {3} " +
                               "WHERE MAHDN = '{4}' AND MAHH = '{5}'", item.SoLuong, item.DonGia, item.GiamGia, item.ThanhTien, item.MaHDN, item.MaHH);
                return db.getNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình cập nhật chi tiết hóa đơn nhập: " + ex.Message);
            }
        }

        public int DeleteChiTietHoaDonNhap(string maHDN, string maHH)
        {
            try
            {
                string checkExistQuery = "SELECT COUNT(*) FROM CHITIETHOADONNHAP WHERE MAHDN = '@maHDN' AND MAHH = '@maHH'";
                checkExistQuery = checkExistQuery.Replace("@maHDN", maHDN);
                checkExistQuery = checkExistQuery.Replace("@maHH", maHH);
                if (db.checkForExistence(checkExistQuery))
                {
                    string query = "DELETE FROM CHITIETHOADONNHAP WHERE MAHDN = '@maHDN' AND MAHH = '@maHH'";
                    query = query.Replace("@maHDN", maHDN);
                    query = query.Replace("@maHH", maHH);
                    return db.getNonQuery(query);
                }
                else
                {
                    throw new Exception("Chi tiết hóa đơn nhập không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình xóa chi tiết hóa đơn nhập: " + ex.Message);
            }
        }
        public DataTable SearchChiTietHoaDonNhap(string keyword)
        {
            try
            {
                string query =  "SELECT * FROM CHITIETHOADONNHAP " +
                                "WHERE MAHDN LIKE '%@keyword%' OR " +
                                "TENHH LIKE '%@keyword%'";
                query = query.Replace("@keyword", keyword);
                return db.getDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình tìm kiếm chi tiết hóa đơn nhập: " + ex.Message);
            }
        }

    }
}
