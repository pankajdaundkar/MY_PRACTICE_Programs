using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
   internal class Pyramid_pattern
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= i - 1; ++j)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k == (2 * i) - 1; k++)
                {
                    Console.WriteLine(" *");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
