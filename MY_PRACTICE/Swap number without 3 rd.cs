using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class Swap_number_without_3_rd
    {
        static void Main(string[] args)
        {
            int a = 10; int b = 20;

            Console.WriteLine($"Befor swap =  {a} ,{b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Before swap = {a}, {b}");
        }
    }
}
