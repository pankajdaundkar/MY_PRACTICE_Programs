using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class frequency_number
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 1, 2, 3, 4, 4, 6, 7 };
            for (int i = 0; i <array.Length; i++) 
            {
                int count = 1;
                bool Isvisible = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (array[k] == array[i])
                    {
                        Isvisible = true;
                        break;
                    }
                }
                    if(Isvisible==false)
                    {
                        for(int j=i+1; j < array.Length; j++)
                        {
                            if(array[i] == array[j])
                            { 
                                count++;
                            }
                        }
                    
                        Console.WriteLine( array[i] +" "+count);
                    

                    //for find duplicate number condition is 
                    //(if count > 1)
                    //for find unique number condition is
                    //(if count == 1)   

                    // Console.WriteLine(array[i] + " =  "  + count);
                }
              //  if (count > 1)
               
            }
           
        }
    }
}
