using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
//1.Accept radius of a circle.Display area of a circle.


    internal class Redius_of_circle
    {
        static void Main(string[] args)
        {
            int r;
            double area;

            Console.WriteLine("Enter Redius of circle");
             r = Convert.ToInt32(Console.ReadLine());

            area = 3.14 * r * r;

            Console.WriteLine($"Area of circle is +  {area}");
        }
    }
}
