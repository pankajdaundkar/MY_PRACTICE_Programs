using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class Write_num_1_to_20
    {
        static void Main(string[] args)
        {
            int sum = 0;

            //num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 20; i++) 
            {
                sum = sum + i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"sum is {sum}");
        }
    }
}
