using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discount
{
    public class Discount
    {
        static public void Main()
        {
            Console.Write("Please enter quantity: ");
            int quantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your discount is: {0}%", CalculateDiscount(quantity));
        }

        private static int CalculateDiscount(int quantity)
        {
            int discount;

            if (quantity >= 100)
                discount = 20;
            else if (quantity >= 50)
                discount = 15;
            else if (quantity >= 10)
                discount = 10;
            else
                discount = 5;

            return discount;
        }
    }

}
