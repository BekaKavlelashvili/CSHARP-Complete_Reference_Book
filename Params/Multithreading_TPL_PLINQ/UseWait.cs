using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class UseWait
    {
        static void MyTask()
        {
            Console.WriteLine("MyTask #" + Task.CurrentId + " starting");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In MyTask #" + Task.CurrentId + ", count is " + i);
            }

            Console.WriteLine("MyTask #" + Task.CurrentId + " terminating");
        }


        public static void UseWaitMain()
        {
            Console.WriteLine("\n=== Use Wait ===");

            Console.WriteLine("Main thread starting");

            Task tsk = new Task(MyTask);
            Task tsk2 = new Task(MyTask);

            tsk.Start();
            tsk2.Start();

            Console.WriteLine("Task id for tsk is " + tsk.Id);
            Console.WriteLine("Task id for tsk2 is " + tsk2.Id);

            tsk.Wait();
            tsk2.Wait();

            Console.WriteLine("Main thread ending");
        }
    }
}
