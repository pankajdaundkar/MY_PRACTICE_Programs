using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
   // internal class SUM_OF_DIGIT_FROM_STRING_USING_METHOD
    
        internal class StringDigitSum
        {
            public static int SumOfDigit(String str)
            {
                Console.WriteLine(str);
                int sum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                    {
                        sum = sum + ((int)(char.GetNumericValue(str[i])));
                    }
                }
                return sum;

            }
            public static int CalculateDigitSum(String s)
            {
                int sum = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsDigit(s[i]))
                    {
                        sum = sum + ((int)(char.GetNumericValue(s[i])));
                    }
                }
                return sum;
            }
            static void Main(string[] args)
            {
                String s = "pu3n6e7";
                /* int sum=StringDigitSum.SumOfDigit(s);
                 Console.WriteLine(  "Sum of Digit= "+sum);*/

                Console.WriteLine("Sum= " + StringDigitSum.CalculateDigitSum(s));
            }
        }
    }

