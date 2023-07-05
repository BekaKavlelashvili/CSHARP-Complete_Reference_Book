using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class DemonstrateTaskID
    {
        static void MyTask()
        {
            Console.WriteLine("MyTask() #" + Task.CurrentId + " starting");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In MyTask() #" + Task.CurrentId + ", count is " + i);
            }

            Console.WriteLine("MyTask #" + Task.CurrentId + " terminating");
        }

        public static void DemonstrateTaskIDMain()
        {
            Console.WriteLine("\n=== Demonstrate Task ID ===");

            Console.WriteLine("Main Task starting.");

            Task tsk1 = new Task(MyTask);
            Task tsk2 = new Task(MyTask);

            tsk1.Start();
            tsk2.Start();

            Console.WriteLine("TaskId for tsk1: " + tsk1.Id);
            Console.WriteLine("TaskId for tsk2: " + tsk2.Id);

            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Main thread ending");
        }
    }
}
