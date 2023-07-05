using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{

    class MyTaskClass
    {
        public void MyTask()
        {
            Console.WriteLine("MyTask() starting");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In MyTask(), count is " + i);
            }

            Console.WriteLine("MyTask() terminating");
        }
    }

    public class CreateAndRunTask
    {
        public static void CreateAndRunTaskMain()
        {
            Console.WriteLine("\n=== Create and run Task ===");

            Console.WriteLine("Main thread starting");

            MyTaskClass my = new MyTaskClass();

            Task tsk = new Task(my.MyTask);
            tsk.Start();

            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine("Main thread ending");
        }     
    }
}
