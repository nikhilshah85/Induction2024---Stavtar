// See https://aka.ms/new-console-template for more information
using OOPS_BankingSolution;

Console.WriteLine("Hello, World!");

Savings sav = new Savings()
{
    AccNo = 101,
    AccName = "Shalini",
    AccBalance = 10000,
    AccIsActive = true,
    AccType = AccountTypes.Savings
};



Current curr = new Current()
{
    AccNo = 102,
    AccName = "Poonam",
    AccBalance = 10000,
    AccIsActive = false,
    AccType = AccountTypes.Current
};
curr.OdIsEnabled = true;

PF pf = new PF()
{
    AccNo = 101,
    AccName = "Mohan",
    AccBalance = 10000,
    AccIsActive = true,
    AccType = AccountTypes.PF
};


bool doTransaction = true;
try
{

    while (doTransaction)
    {
        
       
        Console.WriteLine("Enter Amount to Withdraw");
        int amt = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1. Savings Account ");
        Console.WriteLine("2. Current Account ");
        Console.WriteLine("3. PF Account");
        Console.WriteLine("4. Exit");
        int acctype = Convert.ToInt32(Console.ReadLine());
        switch (acctype)
        {
            case 1:
                Console.WriteLine(sav.Withdraw(amt));
                break;
            case 2:
                Console.WriteLine(curr.Withdraw(amt));
                break;
            case 3:
                Console.WriteLine(pf.Withdraw(amt));
                break;
            case 4:
                Console.WriteLine("Thank you for Banking");
                doTransaction = false;
                break;
            default:
                Console.WriteLine("Sorry wrong choice, please enter again");
                break;
        }
        Console.ReadLine();
        Console.Clear();
    }
}
catch(Exception es)
{
    Console.WriteLine(es.Message);
}















