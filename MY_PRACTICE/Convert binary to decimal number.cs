using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Convert_binary_to_decimal_number
    {
        static void Main(string[] args)
        {
           // to calulate power of given number
            /* int bnum = 2;
             int expo = 3;
             int power = 1;
             for (int i = 1; i < expo; i++) 
             {
                 power = power * bnum;
             }
             Console.WriteLine("power of given number  " + power);
            */

             //convert binary into decimal
            Console.WriteLine("------------ convert binary into decimal------------------");
             int num = 1101, sum = 0, index = 0;
             while (num > 0)
             {
                 int digit = num % 10;
                 int power = 1;
                 for (int i = 0; i < index; i++)
                 {
                     power = power * 2;

                 }
                 int ans = power * digit;
                 sum += ans;
                 num = num/ 10;
                 index++;
             }
            Console.WriteLine("sum of binary number is  " + sum);

        //    Console.WriteLine("-------Convert decimal into binary---------------");

        //    Console.Write("Enter the Decimal Number : ");
        //    int number = int.Parse(Console.ReadLine());
        //    int i;
        //    int[] numberArray = new int[10];
        //    for (i = 0; number > 0; i++)
        //    {
        //        numberArray[i] = number % 2;
        //        number = number / 2;
        //    }
        //    Console.Write("Binary Represenation of the given Number : ");
        //    for (i = i - 1; i >= 0; i--)
        //    {
        //        Console.Write(numberArray[i]);
        //    }
         }
    }
}
