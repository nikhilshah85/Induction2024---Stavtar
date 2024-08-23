// See https://aka.ms/new-console-template for more information
using LINQ_Demo;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

#region List data
List<Employee> employees = new List<Employee>
        {
            new Employee { empNo = 1, empName = "Amit Sharma", empDesignation = "Manager", empCity = "Mumbai", empSalary = 75000, empIsPermanent = true },
            new Employee { empNo = 2, empName = "Priya Singh", empDesignation = "Developer", empCity = "Bangalore", empSalary = 85000, empIsPermanent = true },
            new Employee { empNo = 3, empName = "Ravi Kumar", empDesignation = "Analyst", empCity = "Chennai", empSalary = 65000, empIsPermanent = false },
            new Employee { empNo = 4, empName = "Anjali Mehta", empDesignation = "Designer", empCity = "Hyderabad", empSalary = 70000, empIsPermanent = true },
            new Employee { empNo = 5, empName = "Vikram Patel", empDesignation = "Tester", empCity = "Pune", empSalary = 60000, empIsPermanent = false },
            new Employee { empNo = 6, empName = "Neha Gupta", empDesignation = "HR", empCity = "Delhi", empSalary = 72000, empIsPermanent = true },
            new Employee { empNo = 7, empName = "Arjun Reddy", empDesignation = "Support", empCity = "Kolkata", empSalary = 55000, empIsPermanent = false },
            new Employee { empNo = 8, empName = "Sanya Iyer", empDesignation = "Consultant", empCity = "Ahmedabad", empSalary = 90000, empIsPermanent = true },
            new Employee { empNo = 9, empName = "Rohan Desai", empDesignation = "Architect", empCity = "Surat", empSalary = 95000, empIsPermanent = true },
            new Employee { empNo = 10, empName = "Kavya Nair", empDesignation = "Engineer", empCity = "Jaipur", empSalary = 80000, empIsPermanent = true },
            new Employee { empNo = 11, empName = "Manish Joshi", empDesignation = "Developer", empCity = "Lucknow", empSalary = 85000, empIsPermanent = false },
            new Employee { empNo = 12, empName = "Pooja Verma", empDesignation = "Manager", empCity = "Nagpur", empSalary = 78000, empIsPermanent = true },
            new Employee { empNo = 13, empName = "Rahul Chawla", empDesignation = "Analyst", empCity = "Indore", empSalary = 67000, empIsPermanent = false },
            new Employee { empNo = 14, empName = "Sneha Rao", empDesignation = "Designer", empCity = "Bhopal", empSalary = 71000, empIsPermanent = true },
            new Employee { empNo = 15, empName = "Aakash Jain", empDesignation = "Tester", empCity = "Patna", empSalary = 62000, empIsPermanent = false }
            };
#endregion
#region Select with where
//var myEmp = (from e in employees
//            where e.empNo == 101
//            select e).Single();

//Console.WriteLine(myEmp.empName);
//Console.WriteLine(myEmp.empNo);
//Console.WriteLine(myEmp.empDesignation);
#endregion
#region select with where and list and && operator
//var myManagers = (from e in employees
//                 where e.empDesignation == "Manager" && e.empCity == "Pune"
//                 select e).ToList();

//foreach (var item in myManagers)
//{
//    Console.WriteLine(item.empName);
//    Console.WriteLine(item.empNo);
//    Console.WriteLine(item.empDesignation);
//}
#endregion

//var myEmp = (from e in employees
//            where e.empName.StartsWith("N")
//            select e).ToList();

var totalActiveEmp = employees.Count(em => em.empIsPermanent == true);
//var totalSalaryInMumbai = employees.Sum(em => em.empCity.Equals("Mumbai"));

var totalSalary = (from e in employees
                  where e.empCity == "Mumbai"
                  select e.empSalary).Sum();

//Console.WriteLine(totalSalary);


//var sortedEmployees = (from e in employees
//                       where e.empCity == "Pune"
//                       orderby e.empName 
//                       select e).ToList();

//use for each to display
//var salaryDetails = (from e in employees
//                     where e.empIsPermanent == true
//                     select new
//                     {
//                         Salary = e.empSalary,
//                         Bonus = e.empSalary * 0.1,
//                         Reward = e.empSalary * 0.2,
//                         Tax = e.empSalary * 0.4
//                     }).ToList();

//foreach (var employee in salaryDetails)
//{
//    Console.WriteLine(employee.Salary);
//    Console.WriteLine(employee.Bonus);
//    Console.WriteLine(employee.Reward);
//    Console.WriteLine(employee.Tax);
//}


















