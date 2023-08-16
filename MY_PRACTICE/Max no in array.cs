using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class Max_no_in_array
    {
        static void Main(string[] args)
        {
            int[]array = new int[10] {130,44,53,55,11,3,95,6,7,5,};
            int max = array[0];

            for(int i  = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Maximun element is  +{ max}");
        }
    }
}
