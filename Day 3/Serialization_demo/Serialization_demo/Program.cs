// See https://aka.ms/new-console-template for more information
using Serialization_demo;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");

#region Serialization
//Accounts acc = new Accounts()
//{
//    AccountNumber = 504,
//    AccountBalance = 12000,
//    AccIsActive = false,
//    AccountName = "Karthik",
//    AccountType = "Current"
//};

//FileStream myFile = new FileStream("501.xml",FileMode.Append,FileAccess.Write);

////choose  fotmatter for data format
////BinaryFormatter formatter = new BinaryFormatter(); //For Binary Format
//XmlSerializer xml = new XmlSerializer(typeof(Accounts));
////JsonSerializer //for JSON Format

////use serialize method to store the object
////use Deserialize method to open the object or to bring it in the same state
//xml.Serialize(myFile, acc);
//myFile.Close();
//Console.WriteLine("Object Serialized");



//List<Accounts> acclist = new List<Accounts>()
//{
//    new Accounts(){ AccountNumber=101, AccountName="Sahil", AccIsActive=true, AccountBalance=5000, AccountType="Savings" },
//    new Accounts(){ AccountNumber=102, AccountName="Raashi", AccIsActive=false, AccountBalance=5000, AccountType="Savings" },
//    new Accounts(){ AccountNumber=103, AccountName="Sangeeta", AccIsActive=true, AccountBalance=5000, AccountType="Current" },
//    new Accounts(){ AccountNumber=104, AccountName="Manali", AccIsActive=true, AccountBalance=5000, AccountType="Savings" },
//    new Accounts(){ AccountNumber=105, AccountName="Kabir", AccIsActive=false, AccountBalance=5000, AccountType="Savings" },
//    new Accounts(){ AccountNumber=106, AccountName="Sonal", AccIsActive=true, AccountBalance=5000, AccountType="Current" },
//    new Accounts(){ AccountNumber=107, AccountName="Shrusti", AccIsActive=true, AccountBalance=5000, AccountType="Savings" }
//};

//FileStream myFile = new FileStream("myaccounts.json",FileMode.Create,FileAccess.Write);
////XmlSerializer xml = new XmlSerializer(typeof(List<Accounts>));
////xml.Serialize(myFile, acclist);


////string serializedData = JsonSerializer.Serialize(acclist);
////File.WriteAllText("accounts.json", serializedData);


//JsonSerializer.Serialize(myFile, acclist);
//Console.WriteLine("All Accounts saved to file");

#endregion


//Accounts acc;
//FileStream myFile = new FileStream("502.xml",FileMode.Open,FileAccess.Read);
//XmlSerializer serializer = new XmlSerializer(typeof(Accounts));
//acc = (Accounts)serializer.Deserialize(myFile);

//Console.WriteLine(acc.AccountNumber);
//Console.WriteLine(acc.AccountName);
//Console.WriteLine(acc.AccountType);
//Console.WriteLine(acc.AccountBalance);

List<Accounts> myList;
FileStream myFile = new FileStream("Allaccounts.xml",FileMode.Open,FileAccess.Read);
//XmlSerializer xs = new XmlSerializer(typeof(List<Accounts>));
//myList =(List<Accounts>)xs.Deserialize(myFile);

// myList = JsonSerializer.Deserialize("accounts.json");

string fileName = "accounts.json";
string jsonString = File.ReadAllText(fileName);
myList= JsonSerializer.Deserialize<List<Accounts>>(jsonString);

foreach (var item in myList)
{
    Console.WriteLine("Account Number " + item.AccountNumber);
    Console.WriteLine("Account Name " + item.AccountName);
    Console.WriteLine("Account Type " + item.AccountType);
    Console.WriteLine("Account Balance " + item.AccountBalance);
    Console.WriteLine("Account Is Active " + item.AccIsActive);
    Console.WriteLine(" ------------------------ ");
}





