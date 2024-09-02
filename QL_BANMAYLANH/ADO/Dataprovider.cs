using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BANMAYLANH.ADO
{
    public class Dataprovider
    {
        private static Dataprovider instance;
        public static Dataprovider Instance
        {
            get { if (instance == null) instance = new Dataprovider(); return Dataprovider.instance; }
            private set { Dataprovider.instance = value; }
        }

        private string ConStr = @"Data Source=NGUYENTHITHUHIE;Initial Catalog=QL_BANMAYLANH;User ID=sa;Password=123";
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    cmd.Parameters.Clear();
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                data = cmd.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }

        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    //cmd.Parameters.Clear();
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                data = cmd.ExecuteScalar();
                con.Close();
            }
            return data;
        }
    }
}
