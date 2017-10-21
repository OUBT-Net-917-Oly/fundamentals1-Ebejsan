using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    public class Reverse
    {
        static public void Main()
        {
            Console.Write("Please enter a number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} has {1} digits",
                number, CountDigits(number));
        }

        private static int CountDigits(int number)
        {
            if (number / 10 == 0)
                return 1;
            else
                return 1 + CountDigits(number / 10);
        }
    }

}
