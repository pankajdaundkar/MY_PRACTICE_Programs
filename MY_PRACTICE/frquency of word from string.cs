using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class frquency_of_word_from_string
    {

        public void GetFrequency(string fre)
        {
            string[] str = fre.Split();

            // string str1 = " ";


            for (int i = 0; i < str.Length; i++)
            {
                int count = 1;
                bool flag = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (str[i] == str[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[j] == str[i])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(str[i] + " " + count);
                }

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any String");
            string str = Console.ReadLine();

            frquency_of_word_from_string f = new frquency_of_word_from_string();
            f.GetFrequency(str);


        }
    }
}
