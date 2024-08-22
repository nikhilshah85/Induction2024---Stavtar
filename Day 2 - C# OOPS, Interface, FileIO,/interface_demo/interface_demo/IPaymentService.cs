using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_demo
{
    internal interface IPaymentService
    {
        double PayElectricityBill(int meterNo, double amt);
        double PayForInternet(int amt);
    }
}
