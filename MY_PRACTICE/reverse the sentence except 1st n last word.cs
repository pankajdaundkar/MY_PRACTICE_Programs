using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    internal class reverse_the_sentence_except_1st_n_last_word
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any string");
            string str = Console.ReadLine();
            string[]array = str.Split(' ');

            String reverse = " ";


            for (int i = 0; i < array.Length; i++)

                if (i == 0 || i == array.Length - 1)

                {
                    reverse = reverse + " " + array[i];
                }
            else
                {
                    string word = array[i];
                    string result = "";
                    int j = word.Length - 1;

                    while(j>=0)
                    {
                        result = result + word[j];
                        j--;
                    }
                    reverse = reverse + result + " ";
            }
            Console.WriteLine(reverse);
        }
    }
}
