using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpBascis
{
    class asyncAwait
    {
        public static string ReadFromFile()
        {
                 return GetCount();
        }

        private static string GetCount()
        {
            Thread.Sleep(5000);
            return ("Thread Sleep");

        }
    }
}
