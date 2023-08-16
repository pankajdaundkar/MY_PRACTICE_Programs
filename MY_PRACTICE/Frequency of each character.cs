using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Frequency_of_each_character
    {

        public void GetCharacter(string str)
        {
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                int count = 1;
                bool flag = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[i] == ch[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[j] == ch[i])
                        {
                            count++;
                        }
                       
                    }
                    if (ch[i] != ' ')
                    {
                        Console.WriteLine(ch[i] + " " + count);

                    }

                }
            }
        }
                static void Main(string[] args)
                {
                    string str = "I Love India";

                    Frequency_of_each_character c = new Frequency_of_each_character();
                    c.GetCharacter(str);
                }
            
        
    }
}

