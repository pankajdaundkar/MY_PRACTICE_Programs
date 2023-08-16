using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MY_PRACTICE
{// 9. Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)

    internal class Temp_convert_in_C
    {
        static void Main(string[] args)
        {
            int f, c;
            Console.WriteLine("Enter temoreture");
            f = Convert.ToInt32(Console.ReadLine());

            c = (f - 32) * 5 / 9;
            Console.WriteLine("Tempreture in celsius is " + c);

        }
    }
}
