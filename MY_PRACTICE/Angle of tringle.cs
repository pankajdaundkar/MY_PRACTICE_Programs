using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{ // 3. Accept two angles of the triangle and find the third angle.
    internal class Angle_of_tringle
    {
        static void Main(string[] args)
        {
            int a1, a2, a3;

            Console.WriteLine("Enter 1st angle");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd angle");
            a2 = Convert.ToInt32(Console.ReadLine());

            a3 = 180 - (a1 + a2);

            Console.WriteLine($"3 rd Angle is + {a3}");

        }
    }
}
