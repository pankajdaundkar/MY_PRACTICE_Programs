using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class Palindrom_number
    {
        static void Main(string[] args)
        {
            int num, rem,temp, sum = 0;
            Console.WriteLine("Enter any number");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while (num !=  0)
            {
                rem = num % 10;
                sum = (sum*10)+ rem;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Number is palindrom");
            }
            else
            {
                Console.WriteLine("Not palindrom");
            }
        }
    }
}
