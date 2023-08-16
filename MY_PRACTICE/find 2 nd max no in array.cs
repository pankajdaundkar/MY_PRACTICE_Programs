using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class find_2_nd_max_no_in_array
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 4, 6, 5, 8, 7 };
            int MaxValue = int.MinValue;
            int Max2 = array[0];

            for (int i = 0; i <array.Length; i++)
            {
               if (MaxValue < array[i])
                {
                    MaxValue = array[i];
                    Max2 = MaxValue;


                }
               else if(Max2 > MaxValue)
                {

                    Max2 =MaxValue;
                }
                
            }
            Console.WriteLine( "2nd max no. is "+ (Max2));
        }


    }
}
