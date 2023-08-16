using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class Prime_no_or_not
    {
        static void Main(string[] args)
        {
            int count = 0;// a =1;
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            // or for(int i = 2; i<=n/2;i++)
            for (int i = 1; i <= num; i++)
            {    //if(num % i == 0)
                if (num % i == 0)

                {
                    count++;// Console.WriteLine("not prime");
                    // a = 0;
                    // break;
                }
            }
            if (count == 2)// if(a == 1) then prime number.
                {
                    Console.WriteLine("Number is prime number");

                }
                else { Console.WriteLine("not prime numbere"); }

            }

        }
    }

