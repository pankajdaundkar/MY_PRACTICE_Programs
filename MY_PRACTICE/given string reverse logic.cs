using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class given_string_reverse_logic
    {
        static void Main(string[] args)
        {
            //string str = "nitin";
            Console.WriteLine("Enter string");
           string str = Console.ReadLine();
            string rev = "";
            str = str.ToLower();//optional if required.

            for (int i = str.Length-1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);
            if (rev ==str)
            {
                Console.WriteLine("Given string is Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palinddrome");
            }
        }
    }
}
