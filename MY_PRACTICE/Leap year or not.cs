using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{//10. Write a program to check whether a year is leap year or not
    internal class Leap_year_or_not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
           int y = Convert.ToInt32(Console.ReadLine());

           if (y % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
           else
            {
                Console.WriteLine("Not leap year");
            }
        }
    }
}
