using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class find_name_initial_word_and_write_full_surname
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any string");
            string str = Console.ReadLine();

            string[] array = str.Split(' ');
            string result = "";

            for (int i = 0; i < array.Length ; i++)
            {
                if (i == array.Length - 1)
                {
                    result = result + array[i];

                }
                else
                {
                    char[] ch = array[i].ToCharArray();

                    for (int j = 0; j < 1; j++)
                    {
                        result = result + ch[j] + ".";

                    }
                }

                
            }
            Console.WriteLine(result);
        }
    }
}
