using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class Minimun_no_in_array
    {
        static void Main(string[] args)
        {
            int[]array = new int[10] {2,3,4,5,1,6,7,7,8,9};
            int min = array[0];

            for (int i = 1; i <array.Length; i++) 
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
