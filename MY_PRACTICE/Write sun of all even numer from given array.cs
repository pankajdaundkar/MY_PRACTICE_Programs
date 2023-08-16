using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Write_sun_of_all_even_numer_from_given_array
    {
        static void Main(string[] args)
        {
          int sum = 0;

            int[]arr = new int[10] {1,2,3,4,5,6,7,8,9,10};

            for (int i = 0; i < arr.Length ; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];
                }

            }
            Console.WriteLine(sum);
        }
    }
}
