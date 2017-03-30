using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBascis
{
    class ReverseIntegerArray
    {
        public static int [] Reverse()
        {
            int[] arr = { 1, 5, 20 };
            
            for(int i= 0;i< (arr.Length)/2;i++)
            {
                int temp = arr[i];
                //Keep traversing from last
                arr[i] = arr[arr.Length - 1-i];
                arr[arr.Length - 1 - i] = temp;
            }

            return arr;
        }
    }
}
