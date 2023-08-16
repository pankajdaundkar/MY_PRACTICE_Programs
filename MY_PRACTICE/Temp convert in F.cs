using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{//8. Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
    internal class Temp_convert_in_F
    {
        static void Main(string[] args)
        {
            int c, f;
            Console.WriteLine("Enter tempreture in celsius");
             c = Convert.ToInt32(Console.ReadLine());

            f = (c * 9 / 5) + 32;
            Console.WriteLine("Tempreture in fharenheit is " + f);
        }
    }
}
