using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class String_Reverse
    {
        static void Main(string[] args)
        {
            string str = "pankaj";
            Console.WriteLine(str);

            for (int i = str.Length-1; i >= 0; i--) 
            {
                Console.Write(str[i]);
            }
        }
    }
}
