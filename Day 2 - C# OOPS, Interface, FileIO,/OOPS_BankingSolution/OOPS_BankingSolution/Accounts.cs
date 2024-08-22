using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_BankingSolution
{

    enum AccountTypes
    {
        Savings,Current,PF
    }

    internal abstract class Accounts
    {
        #region Properties
        public int AccNo { get; set; }
        public string AccName { get; set; }
        public AccountTypes AccType { get; set; }
        public double AccBalance { get; set; }
        public bool AccIsActive { get; set; }
        #endregion

        #region Methods
        public virtual double Withdraw(int amount)
        {
            if(amount < 0) 
            {
                throw new Exception("Please do not enter negative value");
            }
            AccBalance = AccBalance - amount;
            return AccBalance;
        }
        public double Deposit(int amount)
        {
            AccBalance = AccBalance + amount;
            return AccBalance;
        }

        #endregion
    }
}



