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
        public async static void ReadFromFile()
        {
            //Create a new task
            Task<string> task = new Task<string>(GetCount);
            //start the task
            task.Start();

            //ask the task to await
            var message = await task;
                            
        }

        private static string GetCount()
        {

            Thread.Sleep(5000);
            return "asyn call";

        }
    }
}
