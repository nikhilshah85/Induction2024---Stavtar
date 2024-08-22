// See https://aka.ms/new-console-template for more information
using System.IO;
#region Write to file - 1
//Console.WriteLine("Hello, World!");

//FileStream myFile = new FileStream("myDetails.txt", FileMode.Create, FileAccess.Write);
//StreamWriter pen = new StreamWriter(myFile);
//try
//{
//   pen.WriteLine("Hello and Welcome");
//    pen.WriteLine("My name is Nikhil");
//    pen.WriteLine("I am from Mumbai");
//    pen.WriteLine("I love India");
//}
//catch (IOException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    pen.Close();
//    myFile.Close();
//}
#endregion

#region Write to File - 2
//Console.WriteLine("Please enter your name");
//string guestName = Console.ReadLine();

//FileStream myFile = new FileStream(guestName + ".txt",FileMode.Create,FileAccess.Write);
//StreamWriter myWriter = new StreamWriter(myFile);

//bool moreDetails = true;
//Console.WriteLine("Say something about you, Type End when done");
//while (moreDetails)
//{
//   string details = Console.ReadLine();
//    if (details == "End")
//    {
//        moreDetails = false;
//    }
//    myWriter.WriteLine(details);
//}
//myWriter.Close();
//myFile.Close();
#endregion

#region Read A File
//FileStream myFile = new FileStream("myDetails.txt",FileMode.Open,FileAccess.Read);
//StreamReader rd = new StreamReader(myFile);

//Console.WriteLine(rd.ReadToEnd());

//rd.Close();
//myFile.Close();
#endregion