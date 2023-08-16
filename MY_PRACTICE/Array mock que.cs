using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Array_mock_que
    {
        static void Main(string[] args)
        {
            //    int[] array = { 10, 20, 30, 40, 50 };
            //    for (int i = 0; i <array.Length-2 ; i++)
            //    {
            //        Console.WriteLine(array[i] + array[i+2]);

            //    }
            //    Console.ReadLine();
            //

            int[] array = { 1, 2, 3, 1, 2, 3, 1, 8 };
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                bool isvisible = false;

                for (int k = i-1; k >=0; k--)
                {
                    if (array[k] == array[i])
                    {
                        isvisible = true;
                        break;
                    }

                }
                if (isvisible == false)
                {
                    for (int j = i+1; j < array.Length; j++)
                    {

                        if (array[j] == array[i])
                        {
                            count++;
                        }
                       
                    }
                    if(count == 1)
                    {
                        Console.WriteLine(array[i] + " " + count);

                    }
                   
                }
               

            }

        }
    }
}
