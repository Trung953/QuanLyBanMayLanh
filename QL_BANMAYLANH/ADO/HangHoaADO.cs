using QL_BANMAYLANH.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BANMAYLANH.ADO
{
    class HangHoaADO
    {
        private DBConnect db;

        public HangHoaADO(DBConnect dbConnect)
        {
            db = dbConnect;
        }
        public HangHoa GetItemHangHoa(string maHH)
        {
            try
            {
                string query = "SELECT * FROM HANGHOA WHERE MAHH = '@maHH'";
                query = query.Replace("@maHH", maHH);
                DataTable dataTable = db.getDataTable(query);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];

                    HangHoa hangHoa = new HangHoa
                    {
                        MAHH = row["MAHH"].ToString(),
                        TENHH = row["TENHH"].ToString(),
                        GIANHAP = (decimal)row["GIANHAP"],
                        HINHANH = row["HINHANH"].ToString(),
                        SOLUONG = (int)row["SOLUONG"],
                        MALOAI = row["MALOAI"].ToString(),
                        MANCC = row["MANCC"].ToString()
                    };

                    return hangHoa;
                }

                return null; // Trả về null nếu không tìm thấy hàng hóa với mã HH tương ứng
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình lấy dữ liệu hàng hóa: " + ex.Message);
            }
        }

        public DataTable GetAllHangHoa()
        {
            try
            {
                string query = "SELECT * FROM HANGHOA";
                return db.getDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình lấy dữ liệu hàng hóa: " + ex.Message);
            }
        }

        
    }
}
