using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionTest
{
    class ExceptionTest
    {
        public static void Main()
        {
            int x = 10;
            int y = 0;
            Console.WriteLine(Divide(x, y));
        }

        public static int Divide(int x, int y)
        {
            int results = 0;
            try
            {
                results = x / y;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(
                 "ArithmeticException Handler: {0}",
                 e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(
                 "Generic Exception Handler: {0}",
                 e.ToString());
            }
            return results;
        }
    }

}
