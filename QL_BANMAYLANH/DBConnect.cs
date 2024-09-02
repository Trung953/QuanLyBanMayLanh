using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BANMAYLANH
{

    class DBConnect
    {
        private SqlConnection conn;
        private string strConnect, strServerName, strDataBaseName, strUserName, strPassword;
        private DataSet dataSet;

        public string StrServerName
        {
            get { return strServerName; }
            set { strServerName = value; }
        }

        public string StrDataBaseName
        {
            get { return strDataBaseName; }
            set { strDataBaseName = value; }
        }

        public string StrUserName
        {
            get { return strUserName; }
            set { strUserName = value; }
        }

        public string StrPassword
        {
            get { return strPassword; }
            set { strPassword = value; }
        }

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public string StrConnection
        {
            get { return strConnect; }
            set { strConnect = value; }
        }

        public DataSet DataSet
        {
            get { return dataSet; }
            set { dataSet = value; }
        }

        public DBConnect()
        {
            StrServerName = @"DESKTOP-NEQHJEP\ROG_ZEPHYRUS";
            StrDataBaseName = "QL_BANMAYLANH";
            StrUserName = "sa";
            StrPassword = "123";
            StrConnection = @"Data Source=" + StrServerName + ";Initial Catalog=" + StrDataBaseName + ";Integrated Security=True";
            Conn = new SqlConnection(StrConnection);
            DataSet = new DataSet(StrDataBaseName);
        }

        public DBConnect(string pStrCon, string dataSetName)
        {
            StrServerName = @"DESKTOP-NEQHJEP\ROG_ZEPHYRUS";
            StrDataBaseName = dataSetName;
            StrUserName = "sa";
            StrPassword = "123";
            StrConnection = pStrCon;

            try
            {
                Conn = new SqlConnection(StrConnection);
                DataSet = new DataSet(dataSetName);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }

        public DBConnect(string strServerName, string strDataBaseName, string strUserName, string strPassword)
        {
            StrServerName = strServerName;
            StrDataBaseName = strDataBaseName;
            StrUserName = strUserName;
            StrPassword = strPassword;
            StrConnection = @"Data Source=" + StrServerName + ";Initial Catalog=" + StrDataBaseName + ";Integrated Security=True";

            try
            {
                Conn = new SqlConnection(StrConnection);
                DataSet = new DataSet(strDataBaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(StrConnection);
            return conn;
        }

        public void open()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình mở kết nối: " + ex.Message);
            }
        }

        public void close()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình đóng kết nối: " + ex.Message);
            }
        }

        public int getNonQuery(string chuoitruyvan)
        {
            open();

            try
            {
                SqlCommand cmd = new SqlCommand(chuoitruyvan, Conn);
                int kq = cmd.ExecuteNonQuery();
                close();
                return kq;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình thực hiện truy vấn: " + ex.Message);
            }
        }

        public int getCount(string strSQL)
        {
            open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conn;
                cmd.CommandText = strSQL;
                int count = (int)cmd.ExecuteScalar();
                close();
                return count;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình thực hiện truy vấn: " + ex.Message);
            }
        }

        public bool checkForExistence(string strSQL)
        {
            open();
            try
            {
                SqlDataAdapter dap = new SqlDataAdapter(strSQL, Conn);
                DataTable ds = new DataTable();
                dap.Fill(ds);
                close();
                return ds.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình kiểm tra sự tồn tại: " + ex.Message);
            }
        }

        public object getScalar(string chuoitruyvan)
        {
            open();
            try
            {
                SqlCommand cmd = new SqlCommand(chuoitruyvan, Conn);
                object kq = cmd.ExecuteScalar();
                close();
                return kq;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình thực hiện truy vấn: " + ex.Message);
            }
        }

        public DataTable getDataTable(string chuoitruyvan)
        {
            open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(chuoitruyvan, Conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình lấy dữ liệu: " + ex.Message);
            }
        }

        public int UpdateDataTable(DataTable dt, string ctv)
        {
            open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(ctv, Conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                int kq = da.Update(dt);
                close();
                return kq;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình cập nhật dữ liệu: " + ex.Message);
            }
        }
    }
}
