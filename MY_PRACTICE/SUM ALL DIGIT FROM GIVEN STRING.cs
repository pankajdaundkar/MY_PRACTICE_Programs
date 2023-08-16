using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class SUM_ALL_DIGIT_FROM_GIVEN_STRING
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("enter any strin");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
           int sum = 0;
            for (int i = 0; i <str.Length; i++)
            {
                if (ch[i] >= '0' && ch[i]<= '9')
                {
                    Console.WriteLine(ch[i]);
                    int x = (int) char.GetNumericValue(ch[i]);//convert char into int inbuild method
                    sum = sum + x;
                }
             
            }
                   Console.WriteLine(sum);




        }
    }
}
