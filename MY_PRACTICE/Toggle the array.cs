using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Toggle_the_array

    {
        public static  char[] ToggleCase(char[] ch)
        {

            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsUpper(ch[i])) //if(ch[i] >== 'A' && ch[i]<'Z'
                {
                   ch[i]= char.ToLower(ch[i]);//c[i] =(char)(ch[i]+32);
                }
                else if (char.IsLower(ch[i]))//if(ch[i] >== 'a' && ch[i]<'z'
                {
                   ch[i]= char.ToUpper(ch[i]);//c[i] =(char)(ch[i]-32);
                }
                else { ch[i] = ch[i]; }
            }
            return ch;

        }

        
    static void Main(string[] args)
        {
            char[] ch = { 'T', 'Q', 'a', 'D', 'e' };
             //for (int i = 0; i < ch.Length; i++)
            
             char[]c = Toggle_the_array.ToggleCase(ch);
            
            //foreach (char item in c)
            //{
                Console.Write(string.Join(" " ,c));
            //}

        }
    }
}
