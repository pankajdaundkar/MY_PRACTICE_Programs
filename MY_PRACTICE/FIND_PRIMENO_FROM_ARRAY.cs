using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class CheckPrimeArray
    {
        //find prime no. from array and avarage of that numbers

        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                    break;
                }
            }
            return true;

        }
    

    static void Main(string[] args)
    {
        int[] a = { 1, 3, 6, 12, 9, 5, 2, 11, 4, 13 };
            int sum = 0;
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                
                if (CheckPrimeArray.IsPrime(a[i]))
                { 
                    Console.WriteLine(a[i]);
                    sum = sum + a[i];
                    count++;

                }          
            }
            Console.WriteLine("avg"+ "  " + sum / count);

        }

    }

}       
    
