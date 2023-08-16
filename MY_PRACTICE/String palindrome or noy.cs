using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class String_palindrome_or_noy
    {
        static void Main(string[] args)
        {
            int a = 0;string str;
             Console.WriteLine("Enter any string");
            str = Console.ReadLine();
            a = str[0];
            for (int i = str.Length-1 ; i >= 0; i--) 
            {
                a = a + str[i];
            }

            if (str[0] == a)
            {
                Console.WriteLine("string is  palindrom");
            }
            else
            {
                Console.WriteLine("not palindrom");
            }

        }
    }
}
