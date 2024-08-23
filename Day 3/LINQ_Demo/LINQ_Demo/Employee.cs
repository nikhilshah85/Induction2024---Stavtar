using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    internal class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public string empCity { get; set; } = "";
        public double empSalary { get; set; }
        public bool empIsPermanent { get; set; }
    }
}
