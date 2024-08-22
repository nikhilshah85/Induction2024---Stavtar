// See https://aka.ms/new-console-template for more information

using CSharp_Fundamentals;

#region Banking Demo

//#region First Code
////Console.WriteLine("Hello, World!");

////Console.WriteLine("My Name is Nikhil and this is my very first C# language program");

////Console.WriteLine("Please Enter Your Name");
////string name = Console.ReadLine();

////Console.WriteLine("Welcome " + name + " nice to meet you");


////datatypes
////int, string, double, bool, char, long, float
//#endregion

//Console.WriteLine("!!~~~~~~~~~Welcome to Banking~~~~~~~~~~~!!");

//#region Variables
//string uName;
//string pwd;
//double dummyUserBalanceForTest = 10000;
//int menuChoicebyUser = 0;

//#endregion

//#region Login Details
//Console.WriteLine("Please Enter UserName");
// uName = Console.ReadLine();

//Console.WriteLine("Please Enter Password");
// pwd  = Console.ReadLine();
//#endregion

//#region Check login credentials
//if (uName == "Nikhil" &&  pwd == "nik@1234")
//{
//    #region Menu options
//    Console.Clear();
//    Console.WriteLine(" Welcome " + uName);
//    Console.WriteLine("1. Check Balance");
//    Console.WriteLine("2. Withdraw");
//    Console.WriteLine("3. Deposit");
//    Console.WriteLine("4. Transfer");
//    Console.WriteLine("5. Last 5 transactions");
//    Console.WriteLine("6. Exit");
//    #endregion

//    menuChoicebyUser = Convert.ToInt32(Console.ReadLine());

//    #region Switch case
//    switch (menuChoicebyUser)
//    {
//        #region Case 1 - Check Balance
//        case 1:
//            Console.WriteLine("Available Balance is " + dummyUserBalanceForTest);
//            break;
//        #endregion

//        #region Case 2 - Withdraw
//        case 2:
//            Console.WriteLine("Please Enter Amount to Withdraw");
//            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
//            dummyUserBalanceForTest = dummyUserBalanceForTest - withdrawAmount;
//            Console.WriteLine("Widraw Successful, new balance " + dummyUserBalanceForTest);
//            break;
//        #endregion

//        #region Case 3 - Deposit            
//        case 3:
//            Console.WriteLine("Please Enter Amount to deposit");
//            break;
//        #endregion


//    }
//    #endregion

//}
//else
//{
//    Console.WriteLine("Invalid Credentials");
//}
//#endregion
#endregion

//Calculations calObj = new Calculations();
//Console.WriteLine(calObj.Add(3, 7, 6, 5, 4, 5, 7, 7, 4563, 345, 676, 5676, 3, 67, 45));

Calculations cal = new Calculations();
try
{
    Console.WriteLine("Please enter your name");
    string name = Console.ReadLine();

   string result = cal.Greetings(name);
    Console.WriteLine(result);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


Accounts accObj = new Accounts(30, "Nik", AccountType.Current);

Accounts obj2 = new Accounts();
obj2.AccountNumber = 501;
obj2.AccountName = "Sohail";
obj2.AccountBalance = 5000;
obj2.AccountType = AccountType.Savings;
obj2.AccIsActive = true;

Console.WriteLine(obj2.AccountName);

List<string> list = new List<string>();
list.Add("Nikhil");
list.Add("Nikhil 2");
list.Add("Nikhil 3");
list.Add("Nikhil 4");
list.Add("Nikhil 5");

//Console.WriteLine(list[3]);
//list.IndexOf(3);



















