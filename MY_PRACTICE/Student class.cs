using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Student
    {
        int id;
        string name;
        int m1;
        int m2;
        int m3;
        double per;

        public void AcceptDetail(int id,string name,int m1,int m2,int m3)
        {
            this.id = id;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public void CalculatePer()
        {
            per = (m1 + m2 + m3) / 3;
            Gread();
            DisplyDetail();
        }
         public void Gread()
        {
            if(per <=100 && per >= 80)
            {
                Console.WriteLine("A Gread");
            }
            else if(per <=80 && per >=60)
            {
                Console.WriteLine("B");
            }
            else if (per <= 60 && per >= 40)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

           
        }
        public void DisplyDetail()
        {
            Console.WriteLine($"{id},{name},{m1},{m2},{m3},{per}");
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptDetail(1, "pankaj", 87, 90, 88);
            student.CalculatePer();
        }
        
    }
}
