using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QL_BANMAYLANH.ADO
{

    internal class NhanVienADO
    {
        private DBConnect db;

        public NhanVienADO(DBConnect dbConnect)
        {
            db = dbConnect;
        }

        public DataTable GetAllNhanVien()
        {
            try
            {
                string query = "SELECT * FROM NHANVIEN";
                return db.getDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình lấy dữ liệu nhân viên: " + ex.Message);
            }
        }

        
    }
}