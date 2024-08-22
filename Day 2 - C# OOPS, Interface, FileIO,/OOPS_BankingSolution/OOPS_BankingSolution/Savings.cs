using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_BankingSolution
{
    internal class Savings : Accounts
    {
        public override double Withdraw(int amount)
        {   
            if(amount > 20000)
            {
                throw new Exception("You can withdraw max 20,000");
            }
            else if (amount > AccBalance) 
            {
                throw new Exception("Insufficient Balance");
            }
            return base.Withdraw(amount);
        }
    }
}
