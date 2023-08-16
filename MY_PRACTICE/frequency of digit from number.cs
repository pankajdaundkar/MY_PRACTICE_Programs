using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class frequency_of_digit_from_number
    {
        static void Main(string[] args)
        {
          int num = 122311;
            int temp = num;
            for (int i = 0; i <= 9; i++)
            {
                int count = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    if (digit == i)
                    {
                        count++;
                    }
                    num /= 10;
                    
                }
                num = temp;
                if (count != 0)
                {
                    Console.WriteLine(i + " " + count);
                }
            }
        }
    }
}
