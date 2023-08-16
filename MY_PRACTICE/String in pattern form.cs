using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class String_in_pattern_form
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string ");
            string str = Console.ReadLine();
            string[] str1 = str.Split(' ');
             for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" "  + str1[j]);
                }
                Console.WriteLine();
            }
               
        }
    }
}
