using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{//4. Accept two numbers & find the greater number.
    internal class Find_greter_number
    {
        static void Main(string[] args)
        {
            int Num1, Num2;

            Console.WriteLine("Enter 1st number");
            Num1 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            Num2 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2)
            {
                Console.WriteLine("Num1 is greter");
            }
            else
            {
                Console.WriteLine("Num2 is greter");
            }
        }
    }
}
