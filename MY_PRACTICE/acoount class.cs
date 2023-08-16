using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Account
    {
        public int Account_no { set; get; }
        public string Type { set; get; }
        public double Balance { set; get; }

        public Account(int account_no,string type,double balance )
        {
            Account_no = account_no;
            Type = type;
            Balance = balance;

        }

        static void Main(string[] args)
        {

        }
    }
}
