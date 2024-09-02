using QL_BANMAYLANH.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BANMAYLANH.ADO
{
    class HoaDonNhapADO
    {
        private DBConnect db;

        public HoaDonNhapADO(DBConnect dbConnect)
        {
            db = dbConnect;
        }
        public DataTable SearchHoaDonNhap(string keyword)
        {
            try
            {
                string query = "SELECT * FROM HOADONNHAP WHERE MAHDN LIKE '%@keyword%' OR MANCC LIKE '%@keyword%' OR MANV LIKE '%@keyword%'";
                query = query.Replace("@keyword", keyword);
                return db.getDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình tìm kiếm hóa đơn nhập: " + ex.Message);
            }
        }
        public DataTable GetAllHoaDonNhap()
        {
            try
            {
                string query = "SELECT * FROM HOADONNHAP";
                return db.getDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình lấy dữ liệu hóa đơn nhập: " + ex.Message);
            }
        }
        public DataTable GetHoaDonNhap(string maHDN)
        {
            try
            {
                string query = "SELECT * FROM HOADONNHAP WHERE MAHDN = '@maHDN'";
                query = query.Replace("@maHDN", maHDN);
                return db.getDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình lấy  hóa đơn nhập: " + ex.Message);
            }
        }
        public int InsertHoaDonNhap(HoaDonNhap item)
        {
            try
            {
                string query = string.Format("INSERT INTO HOADONNHAP (MAHDN, MANV, MANCC, TONGTIEN, NGAY_GIONHAP) VALUES ('{0}', '{1}', '{2}', {3}, '{4}')",
                item.MaHDN, item.MaNV, item.MaNCC, item.TongTien, item.NgayGioNhap.ToString("yyyy-MM-dd HH:mm:ss"));
                return db.getNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình thêm hóa đơn nhập: " + ex.Message);
            }
        }

        public int UpdateHoaDonNhap(HoaDonNhap item)
        {
            try
            {
                string query = string.Format("UPDATE HOADONNHAP " +
               "SET MANV = '{0}', MANCC = '{1}', TONGTIEN = {2}, NGAY_GIONHAP = '{3}' " +
               "WHERE MAHDN = '{4}'", item.MaNV, item.MaNCC, item.TongTien, item.NgayGioNhap.ToString("yyyy-MM-dd HH:mm:ss"), item.MaHDN);

                return db.getNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình cập nhật hóa đơn nhập: " + ex.Message);
            }
        }

        public int DeleteHoaDonNhap(string maHDN)
        {
            try
            {
                string checkExistQuery = "SELECT COUNT(*) FROM HOADONNHAP WHERE MAHDN = '@maHDN'";
                checkExistQuery = checkExistQuery.Replace("@maHDN", maHDN);
                if (db.checkForExistence(checkExistQuery))
                {

                    string query = "DELETE FROM HOADONNHAP WHERE MAHDN = '@maHDN'";
                    query = query.Replace("@maHDN", maHDN);
                    return db.getNonQuery(query);
                }
                else
                {
                    throw new Exception("Hóa đơn nhập không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình xóa hóa đơn nhập: " + ex.Message);
            }
        }
        public int UpdateTongTienHoaDonNhap(string maHDN)
        {
            try
            {
                string query = "UPDATE HOADONNHAP " +
                               "SET TONGTIEN = (SELECT SUM(THANHTIEN) FROM CHITIETHOADONNHAP WHERE MAHDN = '@maHDN') " +
                               "WHERE MAHDN = '@maHDN'";
                query = query.Replace("@maHDN", maHDN);
                return db.getNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình cập nhật tổng tiền hóa đơn nhập: " + ex.Message);
            }
        }
    }
}
