using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_demo
{
    internal class Accounts : ITransaction, IPaymentService, IApply
    {
        public double AccountBalance { get; set; }

        #region IApply
        public string ApplyATMCard()
        {
            return "ATM applied";
        }

        public string ApplyChequeBook()
        {
            return "Cheque Book Applied";
        }

        public string ApplyPINChange()
        {
            return "PIN Change applied";
            
        }
        #endregion

        #region ITransaction

        public double Deposit(int amount)
        {
            AccountBalance = AccountBalance + amount;
            return AccountBalance;
        }

        public double Transfer(int fromAcc, int toAcc, int amount)
        {
            return AccountBalance;
        }

        public double Withdraw(int amount)
        {
            AccountBalance = AccountBalance - amount;
            return AccountBalance;
        }
        #endregion

        #region IPayment
        public double PayElectricityBill(int meterNo, double amt)
        {
            return 20;
        }

        public double PayForInternet(int amt)
        {
            return 10;
        }
        #endregion

    }
}
