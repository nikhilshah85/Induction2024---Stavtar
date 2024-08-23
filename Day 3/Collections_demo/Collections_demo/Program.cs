// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

#region Array
//string[] friends = new string[5];
//friends[0] = "Raashi";
//friends[1] = "Kriti";
//friends[2] = "Sam";
//friends[3] = "Alex";
//friends[4] = "Mohit";

//Console.WriteLine(friends[3]);

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(friends[i]);
//}


#endregion

#region Arraylist
//Array list, no fix size, no fixed data type

//it has to do boxing and unboxing in the memory
//ArrayList myList = new ArrayList();
//myList.Add(1);
//myList.Add("Hello");
//myList.Add(true);
//myList.Add(20.30);
#endregion

#region List
//no fix size but for a fixed datatype

//List<string> list = new List<string>();
//list.Add("Hello");
//list.Add("Hello 2");
//list.Add("Hello 3");
//list.Add("Hello 4");
//list.Add("Hello 5");

//foreach (string item in list)
//{
//    Console.WriteLine(item);
//}

#endregion
//Key and a value pair
#region Hashtable
//1. Hashtable, which is no fix datatype and size, same like ArrayList
//Hashtable myvalue = new Hashtable();
//myvalue.Add(1, "Nikhil");
//myvalue.Add("One", "Kriti");
//myvalue.Add(true, "Sunil");
//myvalue.Add(3, "Mohan");
//myvalue.Add(4, "Moorty");
//myvalue.Add(5, "Suman");


//Console.WriteLine(myvalue[3]);
//Console.WriteLine(myvalue.Keys + " " + myvalue.Values);
#endregion

#region Dictionary

//Dictionary<int,string> guestList = new Dictionary<int,string>();
//guestList.Add(101, "Roshan");
//guestList.Add(102, "Swati");
//guestList.Add(103, "Mansi");
//guestList.Add(104, "Krina");
//guestList.Add(105, "Suchit");
//guestList.Add(106, "Santosh");

//foreach (var guest in guestList)
//{
//    Console.WriteLine(guest.Key + " : " + guest.Value);
//}

#endregion