using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Spy_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int rem = 0;int sum = 0;int prod = 1;
            while (num>0)
            {
                rem = num % 10;
                sum += rem;
                prod *= rem;
                num /= 10; 
            }
            if(sum==prod)
            {
                Console.WriteLine("Given no. is spy number");
            }
            else
            {
                Console.WriteLine("Not spy numbrrer");
            }
        }
    }
}
