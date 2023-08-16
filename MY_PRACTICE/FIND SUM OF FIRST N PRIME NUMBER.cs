using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
   // internal class FIND_SUM_OF_FIRST_N_PRIME_NUMBER
    
        public class PrimeDemo
        {
            //FIND THE SUM OF 1ST N prime numbers.

            public static bool IsPrime(int n)
            {

                bool ischeck = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        ischeck = false;
                        break;
                    }
                }

                return ischeck;

            }
            static void Main(string[] args)
            {

                Console.WriteLine("Enter the number how many prime no. you want");
                int numberofPrime = int.Parse(Console.ReadLine());
                int counter = 0;
                int sum = 0;
                for (int i = 2; i <= 50 ; i++)
                {
                    bool isprime = PrimeDemo.IsPrime(i);
                    if (isprime)
                    {
                        counter++;
                        Console.WriteLine(i);
                        sum = sum + i;
                    }
                    if (counter == numberofPrime)
                    {
                        break;
                    }
                }
                Console.WriteLine("sum=" + sum);


            }
        }
    }

