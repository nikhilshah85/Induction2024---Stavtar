using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_BankingSolution
{
    internal class PF : Accounts
    {
        public override double Withdraw(int amount)
        {
            if(amount > (AccBalance * 0.6))
            {
                throw new Exception("Sorry you can withdraw max " + (AccBalance * 0.6));
            }
            return base.Withdraw(amount);
        }
    }
}




