using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class sort_the_array
    {
        // sort half array in assending and halft in decending
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 8, 3, 2, 9, 1 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length / 2; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }

                }
            }
                    for (int i = array.Length/2+1; i < array.Length; i++)
                    {
                        for (int j = i+1; j < array.Length; j++)
                        {
                            if (array[i] > array[j])
                            {
                                int temp = array[i];
                                array[i] = array[i];
                                array[j] = temp;


                            }
                        }
                    }
                                foreach (int item in array)
                           {
                                 Console.WriteLine(item);
                           }


        }
            }
           

        }
    

