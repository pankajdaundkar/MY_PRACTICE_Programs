using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class Swap_the_array
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 8, 5, 1, 2, 9, 4, 0 };

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i+1; j <= array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach(var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
