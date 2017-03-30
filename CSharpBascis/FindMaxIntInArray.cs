using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBascis
{
    class FindMaxIntInArray
    {
        public static int FindMax()
        {
            int [] arr = { 1, 70, 50 };

            if (arr.Length == 0)
                return 0;
            var max = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i >=0; i--)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
