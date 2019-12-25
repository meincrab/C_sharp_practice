using System;
using System.Collections.Generic;
using System.Text;

namespace grokkingAlgorithms
{
    static class Recursion
    {
        public static int factorial(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            else
            {
                return (number * factorial(number - 1));
            }
        }
    }
}
