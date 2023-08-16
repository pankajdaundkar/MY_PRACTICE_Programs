using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class FIND_2ND_MAX_NO__IN_ARRAY
  
        {
            static void Main(string[] args)
            {
                int[] array = { 1,2,87,55,20,97 };
                int MaxValue = array[0];
                int Max2 = array[0];

                for (int i = 0; i < array.Length; i++)
                {
                    if (MaxValue < array[i])
                    {
                    Max2 = MaxValue;
                    MaxValue = array[i];
                       

                    
                    }
                else if (array[i] > Max2 && array[i] != MaxValue)
                {

                    Max2 = array[i];
                }

            }
                Console.WriteLine("2nd max no. is " + (Max2));
            }


        }
    }

