using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{//7. Write a  program to enter P, T, R and calculate Compound Interest.
    internal class Compound_intrest
    {
        static void Main(string[] args)
        {
            int  a,p,t,total;
            int r;

            Console.WriteLine("Enter amount");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter Principle amount");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter tenure");
            t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("rate of intrest");
            r = Convert.ToInt32(Console.ReadLine());

            total = a * ((1 + r / p) * (p * t));
            Console.WriteLine("Compound intrest is " + total);
        }
    }
}
