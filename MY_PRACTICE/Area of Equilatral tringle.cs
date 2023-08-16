using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{//  5. Write a program to calculate the area of an equilateral triangle.

    internal class Area_of_Equilatral_tringle
    {
        static void Main(string[] args)
        {
            int l,b;
            int area;

            Console.WriteLine("Enter length of equilatral tringle");

            l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter breadth of rectangle");

            b = Convert.ToInt32(Console.ReadLine());

            area = 2 * l / b;

            Console.WriteLine($"Area of Equilatral tringle is + {area}");

           

           
            
        }
    }
}
