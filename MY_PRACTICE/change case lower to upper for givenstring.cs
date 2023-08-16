using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class change_case_lower_to_upper_for_givenstring
    {  
        //Toggle the charactor...
 
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter any string");
            string str = Console.ReadLine();

            // string[] s = str.Split(" ");
            string str1 = "";

            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsUpper(ch[i]))
                {
                    str1 = str1 + char.ToLower(ch[i]);
                }
                else if (char.IsLower(ch[i]))
                {
                    str1 = str1 + char.ToUpper(ch[i]);
                }
                else
                    str1 = str1 + ch[i];
               
            }
            Console.WriteLine(" " + str1);

        }
    }
}
