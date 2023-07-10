using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class DemonstrateContinuation
    {
        // A method to be run as a task.
        static void MyTask()
        {
            Console.WriteLine("\nMyTask() starting");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Task count is  " + i);
            }

            Console.WriteLine("MyTask() terminating");
        }


        // A method to be run as a continuation.
        static void ContTask(Task t)
        {
            Console.WriteLine("\nContinuation starting");

            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Continuation count is " + count);
            }

            Console.WriteLine("Continuation terminating");
        }


        public static void DemonstrateContinuationMain()
        {
            Console.WriteLine("\n=== Demonstrate Continuation ===");

            Console.WriteLine("\nMain thread starting");

            Task tsk = new Task(MyTask);

            Task tsk1 = tsk.ContinueWith(ContTask);

            tsk.Start();
            tsk1.Wait();

            tsk.Dispose();
            tsk1.Dispose();

            Console.WriteLine("Main thread ending");
        }
    }
}
