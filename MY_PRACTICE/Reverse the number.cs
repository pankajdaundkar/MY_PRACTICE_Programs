using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class Reverse_the_number
    {
        static void Main(string[] args)
        {
            int rem, sum = 0, Temp;
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;

            }
            Console.WriteLine($"Reverse_number is = {sum}");
        }
    }
}
