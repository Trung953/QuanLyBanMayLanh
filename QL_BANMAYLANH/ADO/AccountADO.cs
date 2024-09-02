using QL_BANMAYLANH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using QL_BANMAYLANH.DTO;

namespace QL_BANMAYLANH.ADO
{
    public class AccountADO
    {
        private static AccountADO instance;

        public static AccountADO Instance
        {
            get { if (instance == null) instance = new AccountADO(); return AccountADO.instance; }
            private set { AccountADO.instance = value; }
        }
        public List<AccountDTO> LoadLoginList()
        {

            List<AccountDTO> list = new List<AccountDTO>();
            string sql = "select * from NGUOIDUNG";
            DataTable data = Dataprovider.Instance.ExcuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                list.Add(account);
            }
            return list;
        }
        public object kiemTraAccount(string username, string password)
        {
            return Dataprovider.Instance.ExcuteScalar("exec Usp_KiemTraAccount @username , @password ", new object[] { username, password });
        }
        public object getIdEmployeeByLogin(string username, string password)
        {
            return Dataprovider.Instance.ExcuteScalar("exec USP_getIdEmPloyee @username , @password", new object[] { username, password });
        }
    }
}
