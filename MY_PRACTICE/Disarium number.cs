using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Disarium_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
            int temp = num;

            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            num = temp;

            while (num > 0)
            {
                int digit = num %  10;
                int power = 1;

                for (int i = 0; i < count; i++)
                {
                    power = power * digit;
                }
                sum += power;
                count--;
                num = num / 10;
            }
            num = temp;

            if(sum==num) 
            {
                Console.WriteLine("Number is Disarium");
            }
            else
            {
                Console.WriteLine("Not Disarium");
            }
           
            
        }
    }
}
