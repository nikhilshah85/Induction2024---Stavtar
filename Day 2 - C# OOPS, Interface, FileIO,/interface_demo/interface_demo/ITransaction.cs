using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace interface_demo
{
    internal interface ITransaction
    {
        double Withdraw(int amount);
        double Deposit(int amount);
        double Transfer(int fromAcc, int toAcc, int amount);
    }
}
