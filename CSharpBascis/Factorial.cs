using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBascis
{
    class Factorial
    {
        /// <summary>
        /// Find the factorial using normal calculation
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double GetFactorial(int n)
        {
            if (n == 1)
                return 1;
            double fact = 1;
            for (int i=n;i>=1;i--)
            {
                fact = fact * i;
            }
            return fact;

        }
        /// <summary>
        /// Find factorial using recursive function
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double GetFactorialRecursive(int n)
        {
            if (n == 1)
                return 1;
            return n * GetFactorialRecursive(n - 1);
        }
    }
}
