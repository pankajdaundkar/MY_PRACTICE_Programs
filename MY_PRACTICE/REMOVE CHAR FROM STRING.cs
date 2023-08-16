using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    //internal class REMOVE_CHAR_FROM_STRING
    //remove the char from 1st string which are present in second string
        public class RemoveString
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the 1st string");
                string s1 = Console.ReadLine();
                Console.WriteLine("Enter the 2nd string");
                string s2 = Console.ReadLine();

                string s3 = "";

                char[] ch1 = s1.ToCharArray();
                char[] ch2 = s2.ToCharArray();
                for (int i = 0; i < ch1.Length; i++)
                {
                    for (int j = 0; j < ch2.Length; j++)
                    {
                        if (ch1[i] == ch2[j])
                        {
                            ch1[i] = ' ';
                        }
                    }
                    if (ch1[i] != ' ')
                    {

                        //Console.WriteLine(ch1[i]);
                        s3 = s3 + ch1[i];

                    }
                }

                Console.WriteLine(s3);




                char[] ch = { 'h', 'e', 'l', 'l', 'o' };

                String str = new string(ch);

                Console.WriteLine(str);

            }
        }
    }

