using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{// 2. Accept length and breadth of a rectangle and find perimeter.
    internal class Perimeter_of_Rectangle
    {
          static void Main(string[] args)
        {
            int l, b;
            int per;

            Console.WriteLine("Enter lengh");
            l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter breadth");
            b = Convert.ToInt32(Console.ReadLine());

            per = 2* (l + b);

            Console.WriteLine($"Perimeter of Rectangle is + {per}");
        }
    }
}
