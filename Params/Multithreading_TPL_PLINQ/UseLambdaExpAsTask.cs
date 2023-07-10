using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class UseLambdaExpAsTask
    {
        public static void UseLambdaExpAsTaskMain()
        {
            Console.WriteLine("\n=== Use Lamba Expression as a Task ===");

            Console.WriteLine("\nMain Thread starting");

            Task tsk = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Task starting");

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Task count is  " + i);
                }

                Console.WriteLine("Task terminating");
            });


            tsk.Wait();
            tsk.Dispose();

            Console.WriteLine("Main thread ending");
        }
    }
}
