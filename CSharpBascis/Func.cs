using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBascis
{
    class FuncExample
    {
        //Fun with one input parameter
        Func<int, string> func=(x) => string.Format("string {0}" + x);
        
    }
}
