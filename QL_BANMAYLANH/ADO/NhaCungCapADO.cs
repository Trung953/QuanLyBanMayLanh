using QL_BANMAYLANH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
//using System.Data.linq;

namespace QL_BANMAYLANH.ADO
{
    class NhaCungCapADO
    {

        private DBConnect db;

        public NhaCungCapADO(DBConnect dbConnect)
        {
            db = dbConnect;
        }

        public DataTable GetAllNhaCungCap()
        {
            try
            {
                string query = "SELECT * FROM NHACUNGCAP";
                return db.getDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình lấy dữ liệu nhà cung cấp: " + ex.Message);
            }
        }

        public int InsertNhaCungCap(NhaCungCap item)
        {
            try
            {
                string query = string.Format( "INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHI) VALUES ('{0}', N'{1}',N'{2}')",item.MaNCC, item.TenNCC, item.DiaChi);
                return db.getNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình thêm nhà cung cấp: " + ex.Message);
            }
        }

        public int UpdateNhaCungCap(NhaCungCap item)
        {
            try
            {
                string query = string.Format("UPDATE NHACUNGCAP " +
                               "SET TENNCC = N'{0}', DIACHI = N'{1}' " +
                               "WHERE MANCC = '{2}'", item.TenNCC, item.DiaChi, item.MaNCC);
                return db.getNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình cập nhật nhà cung cấp: " + ex.Message);
            }
        }

        public int DeleteNhaCungCap(string maNCC)
        {
            try
            {
                string checkExistQuery = "SELECT COUNT(*) FROM NHACUNGCAP WHERE MANCC = '@maNCC'";
                checkExistQuery = checkExistQuery.Replace("@maNCC", maNCC);
                if (db.checkForExistence(checkExistQuery))
                {

                    string query = "DELETE FROM NHACUNGCAP WHERE MANCC = '@maNCC'";
                    query = query.Replace("@maNCC", maNCC);
                    return db.getNonQuery(query);
                }
                else
                {
                    throw new Exception("Nhà cung cấp không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình xóa nhà cung cấp: " + ex.Message);
            }
        }
        public DataTable SearchNhaCungCap_ten(string keyword)
        {
            try
            {
                string query = "SELECT * FROM NHACUNGCAP WHERE TENNCC LIKE '%@keyword%' OR TENNCC LIKE '%@keyword%'";
                query = query.Replace("@keyword", keyword);
                return db.getDataTable(query);
            }
            catch (Exception ex) 
            {
                throw new Exception("Lỗi trong quá trình tìm kiếm nhà cung cấp: " + ex.Message);
            }
        }
    }
}