//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MY_PRACTICE
//{
//    public class Reverse_the_array
//    {

//        public static int[] ArrayRev(int[]a)
//        {
//            int j = a.Length - 1;
//            for (int i = 0; i < a.Length / 2; i++)
//            {


//                int temp = a[i];
//                a[i] = a[j];
//                a[j] = temp;
//                j--;

//            }
//            return a;
//        }
//        public static void Display(int[]array)
//        {
//            foreach (int item in array)
//            {
//                Console.WriteLine(item);
//            }


//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter any array");
//            int[]array = new int[5];
//            for(int i=0;i<array.Length;i++)
//            {
//                array[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Console.WriteLine("............before revers.....................");
//            Reverse_the_array.Display(array);
//            Console.WriteLine(  ".......................After revers   ...................................");

//            int[] revarray= Reverse_the_array.ArrayRev(array);

//            Reverse_the_array.Display(revarray);


//        }
//    }
//}
