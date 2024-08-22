using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_BankingSolution
{
    internal class Current :Accounts
    {
        public bool OdIsEnabled { get; set; }

        public override double Withdraw(int amount)
        {
            if((amount > AccBalance) && OdIsEnabled)
            {
                if((amount - AccBalance) > 100000)
                {
                    throw new Exception("OD limit exceeded");
                }
            }

            return base.Withdraw(amount);
        }
    }
}



