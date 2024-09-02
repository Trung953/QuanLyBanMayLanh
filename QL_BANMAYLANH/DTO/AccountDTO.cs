using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BANMAYLANH.DTO
{
    public class AccountDTO
    {
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string MatKhau
        {
            get { return password; }
            set { password = value; }
        }

        private string quyenTC;
        public string QuyenTC
        {
            get { return quyenTC; }
            set { quyenTC = value; }
        }

        private string manv;
        public string MaND
        {
            get { return manv; }
            set { manv = value; }
        }

        public AccountDTO(string username, string password, string quyentc, string manv)
        {
            this.username = username;
            this.password = password;
            this.quyenTC= quyentc;
            this.manv = manv;
        }

        public AccountDTO(DataRow row)
        {
            this.username = row["username"].ToString();
            this.password = row["password"].ToString();
            this.quyenTC = row["QuyenTC"].ToString();
            this.manv = row["MANV"].ToString();
        }
    }
}
