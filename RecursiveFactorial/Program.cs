using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = Factorial(5);
            Console.WriteLine(result);
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;  //base case
            }
            else
            {
                return n * Factorial(n - 1);  //recursive case
            }
        }
    }
}
