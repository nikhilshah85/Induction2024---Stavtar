using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    internal class Calculations
    {
        //public int Add(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //public int Add(int num1, int num2, int num3)
        //{
        //    return num1 + num2 + num3;
        //}
        //public int Add(int num1, int num2, int num3,int num4)
        //{
        //    return num1 + num2 + num3 + 4;
        //}

        public int Add(int num1, int num2, params int[] numbers)
        {
            int result  = num1 + num2;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i];
            }
            return result;
        }


        //method over loading

        public double SimpleIntrest(int principal, double roi, int duration_year)
        {
            double calculate = ((principal * roi) / 100) * duration_year;
            return calculate;
        }
   
        public string Greetings(string name)
        {
            if(name == "")
            {
                throw new Exception("Please pass a valid name");
            }
            else if(name.Length < 3)
            {
                throw new Exception("Name should be minimum 3 charcters");
            }
            return "Hello and Welcome to My Program";
        }
    
    }
}



