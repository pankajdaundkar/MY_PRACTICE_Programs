using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class Fibonacci_number
    {
        static void Main(string[] args)
        {
            int a ; int b ; int c = 0;

            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            a = 0 ;
            b = 1 ;

           Console.WriteLine(a + " " + b);

            for (int i = 0; i <= num; i++)
            {
                c = a + b; 
                Console.Write(" "+ c);
                a = b ;
                b = c ;
                Console.Write("\n");
            }
           


        }

    }
}





        