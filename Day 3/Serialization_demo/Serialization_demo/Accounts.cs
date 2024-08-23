using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_demo
{
    [Serializable] //so the object can be moved from Ram to other place (disk or network)
    public class Accounts
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double AccountBalance { get; set; }
        public bool AccIsActive { get; set; }
        public string AccountType { get; set; }
        public double WithDraw(int amt)
        {
            AccountBalance = AccountBalance- amt;
            return AccountBalance;
        }
        public double Deposit(int amt)
        {
            AccountBalance = AccountBalance + amt;
            return AccountBalance;
        }
    }


}
