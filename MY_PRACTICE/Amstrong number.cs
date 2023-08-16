using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class Amstrong_number
    {
        static void Main(string[] args)
        {
            int rem, sum =0, temp ;
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }
                if(sum == temp)
                {
                    Console.WriteLine("Number is armstrong number");
                }
                else
                {
                    Console.WriteLine("Not armstrong");
                }
            }
          
        }  
        
    }

