using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Print_alternate_charctor
    {
        public static char[] AlternateChar(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'X')
                {
                    ch[i] = (char)(ch[i] + 2);
                }
                else if((ch[i] >= 'a' && ch[i] <= 'x'))
                {
                    ch[i] = (char)(ch[i] + 2);
                }
                else if (ch[i] == 'Y' || ch[i] == 'Z' || ch[i] == 'y' || ch[i] == 'z')
                {
                    ch[i] = (char)(ch[i]-24);
                }

             
            }
            return ch;
            
        }
        static void Main(string[] args)
        {

            char[] ch = { 'p', 'A', 'Y', 't', 'z' };
            //for (int i = 0; i < ch.Length; i++)

            char[] c = Print_alternate_charctor.AlternateChar(ch);

            foreach (char item in c) 
            {
                Console.Write(item);
            }
        }
    }
}
