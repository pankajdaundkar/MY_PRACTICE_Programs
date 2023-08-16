using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Perfect_number
    {
        static void Main(string[] args)
        {
            int sum = 0,temp;

            Console.WriteLine("Enter any Number");
            int num = Convert.ToInt32(Console.ReadLine());

            temp = num;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
                
            }
            if(sum == temp)
            {
                Console.WriteLine("Given Number is Perfect Numbre");
            }
            else
            {
                Console.WriteLine("Number is not Perfect");
            }
        }
       
        
    }
}
