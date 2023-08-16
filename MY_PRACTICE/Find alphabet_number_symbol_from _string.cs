using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Find_alphabet_number_symbol_from__string
    {
        static void Main(string[] args)
        {
            int alphabet = 0, number = 0, symbol = 0; ;

            Console.WriteLine("Enter any Sting");
            String str = Console.ReadLine(); 

            for (int i = 0; i < str.Length; i++)
            { 
             char ch = str[i];

             if (str[i] >= 'a' && str[i]<= 'z' || str[i] >= 'A' && str[i]<= 'Z')
                {
                    alphabet++;
                }
             else if (str[i] >= '0' && str[i]<= '9') 
                {
                    number++;
                }
             else
                
                {
                  symbol++;
                }

                
            }
            Console.WriteLine($"Alphabet = {alphabet},Number = {number},Symbol = {symbol}");



        }
    }
}
