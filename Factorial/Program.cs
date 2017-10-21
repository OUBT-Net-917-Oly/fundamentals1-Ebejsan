using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
    public class Factorial
    {
        static public void Main()
        {
            Console.Write("Please enter a number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of {0} is: {1}",
                number, ComputeFactorial(number));
        }

        private static int ComputeFactorial(int number)
        {
            int factorial = 1;

            while (number > 1)
            {
                factorial *= number--;
            }

            return factorial;
        }
    }

}
