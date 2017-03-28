using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBascis
{
   
     class GenericsExample
    {
        public static bool IsEqualStronglyType(int first, int second)
        {
            if (first == second)
            {
                return true;
            }
            else
                return false;
        }
        public static bool IsEqualObjectType(object first, object second)
        {
            return object.Equals(first, second);
            
        }
        public static bool IsGenericEqual <T>(T first, T second)
        {
            return object.Equals(first, second);

        }

    }

    class GenericClassExample <T>
    {
         public static bool IsGenericEqual(T first, T second)
        {
            return object.Equals(first, second);

        }

    }

}
