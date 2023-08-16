using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{// 11. Write a C# program to check whether a number is divisible by 5 and 11 or not 
    internal class Number_divisible_by_5___11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num1 = Convert.ToInt32(Console.ReadLine());

          if (num1 / 5 != 0 && num1 / 11 != 0)
            {
                Console.WriteLine("Number is divisible");
            }
            else
            {
                Console.WriteLine("Number is not divisible");
            }
        }
    }
}
