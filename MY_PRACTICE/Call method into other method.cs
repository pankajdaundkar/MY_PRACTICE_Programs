using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE
{
    public class Shopping
    {
        public int id;
        public string name;
        public int price;
        public int quantity;
        public int bill;

        public void AcceptDetails(int p_id, string p_name, int price, int quantity)
        {
            this.id = p_id;
            this.name = p_name;
            this.price = price;
            this.quantity = quantity;
        }

        public void CalculateBill()
        {
            if (this.quantity > 0)
            {
                this.bill = quantity * price;
                ShowDetails();
            }
            else
            {
                // Console.WriteLine("quantity must have non zero value");
                throw new Exception("quantity must have non zero value");
            }  
        }
        //public void ShowDetails() 
        //{
        //    Console.WriteLine($"{id},{name},{price},{quantity},{bill}");
        //}

        public string ShowDetails()
        {
            return ($"{id}, {name}, {price}, {quantity}, {bill}");
        }

        static void Main(string[] args)
        {
            Shopping shopping = new Shopping();
            shopping.AcceptDetails(1, "pen", 20, 5);
            shopping.CalculateBill();
            Console.WriteLine(shopping.ShowDetails());
        }
    }
}
