using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{//6. Write a program to enter marks of five subjects and calculate total, average and percentage
    internal class Marks_in_subject
    {
        static void Main(string[] args)
        {
            double total, ave, per;
            Console.WriteLine("Marks in Mrathi");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marks in English");
            int e1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marks in Maths");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marks in Science");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marks in Physics");
            int p1 = Convert.ToInt32(Console.ReadLine());

            total =( m1 + e1 + m2 + s1 + p1 );

            ave = total / 5;

            per = (total / 500) * 100;

            Console.WriteLine($"Total Marks is  {total}\navarage is  {ave}\npercentage is  {per}");
        }
    }
}
