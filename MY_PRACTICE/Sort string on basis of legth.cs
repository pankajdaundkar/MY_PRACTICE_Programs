using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Sort_string_on_basis_of_legth
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Enter any string");
        //    string str = Console.ReadLine();

        //    string[] s = str.Split();
        //    string temp = "";

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = i+1; j < s.Length; j++)
        //        {
        //            if (s[i].Length > s[j].Length)    //logic for assending order i.e 1 to num
        //            {
        //                temp = s[i];
        //                s[i] = s[j];
        //                s[j] = temp;
        //            }
        //        }
                
        //    }
        //    foreach (string item in s)
        //    {
        //        Console.WriteLine(item);
        //    }

           // Console.WriteLine("----------sorting of int array-------------");


            ////sort array by using without inbuilt method

            //int[]array = new int[] { 10,2,32,47,5,60 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = i+1; j < array.Length; j++)
            //    {
            //        if (array[j] > array[i])//condition for assending order   //for desending just array[i]<array[j]
            //        {
            //            int temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //    Console.WriteLine(array[i]);
            //}



            //Console.WriteLine("-------sort string basis of length but when same length-----------");

            Console.WriteLine("Enter any string");
            string str = Console.ReadLine() ;

            string[] s = str.Split();
            string temp = "" ;

            for (int i = 0 ; i < s.Length ; i++)
            {
                for (int j= i+1 ; j< s.Length ; j++)
                {
                   
                     if(s[i].Length > s[j].Length)
                    {
                        temp = s[i] ;
                        s[i] = s[j] ;
                        s[j] = temp ;

                    }
                    else if (s[i].Length == s[j].Length)
                    {
                        int a = s[i].CompareTo(s[j]);//this method gives o/p in 1 or 0 
                        if(a == 1)
                        {
                            string temp2 = s[i] ;
                            s[i] = s[j];
                            s[j] = temp2;
                        }
                    }
                        
                }
                
            }
            foreach (string item in s)
            {
                Console.WriteLine(item);
            }

        }
    }
}
