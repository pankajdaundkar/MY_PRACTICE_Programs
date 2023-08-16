using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class duck_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            int duck = 0;
            int count = 0;

            while (num > 0)
            {
                duck = num % 10 ;

                if(duck == 0)
                {
                    count++;
                    
                }
                num = num / 10;

            }
            if(count==1) 
            {
                Console.WriteLine("Given number is duck number");
            }
            else
            {
                Console.WriteLine("Number is not duck number");
            }

            
        }
    }
}
