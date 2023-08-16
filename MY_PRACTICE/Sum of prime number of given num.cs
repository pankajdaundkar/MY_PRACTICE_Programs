using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class PrimeNo //sum of prime number from given no.
    {
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
               if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int num = 12357333;
            int sum = 0;


            while (num > 0)
            {
                int digit = num % 10;
                if (PrimeNo.IsPrime(digit))
                {
                    sum += digit;
                }
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }

}
