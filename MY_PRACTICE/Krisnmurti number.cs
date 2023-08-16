using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Krisnmurti_number
    {
        static void Main(string[] args)
        {
            int num = 145;
            int temp = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                    
                }
                sum = sum + fact;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine(" number is krishnmurti");
            }
            else
            {
                Console.WriteLine("not krishnmurti");
            }
        }
    }
}
