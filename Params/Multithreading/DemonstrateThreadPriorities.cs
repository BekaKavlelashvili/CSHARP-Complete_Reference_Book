using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class MyThread5
    {
        public int Count;
        public Thread Thrd;

        static bool stop = false;
        static string currentName;

        public MyThread5(string name)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            currentName = name;
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " starting.");

            do
            {
                Count++;
                if (currentName != Thrd.Name)
                {
                    currentName = Thrd.Name;
                    Console.WriteLine("In " + currentName);
                }
            } while (stop == false && Count < 1000000000);
            stop = true;

            Console.WriteLine(Thrd.Name + " terminating.");
        }
    }

    public class DemonstrateThreadPriorities
    {
        public static void DemonstrateThreadPrioritiesMain()
        {
            Console.WriteLine("\n=== Demonstrate Thread Priorities ===");

            MyThread5 mt1 = new("High Priority");
            MyThread5 mt2 = new("Low Priority");

            mt1.Thrd.Priority = ThreadPriority.AboveNormal;
            mt2.Thrd.Priority = ThreadPriority.BelowNormal;

            mt1.Thrd.Start();
            mt2.Thrd.Start();

            mt1.Thrd.Join();
            mt2.Thrd.Join();

            Console.WriteLine();
            Console.WriteLine(mt1.Thrd.Name + " thread counted to " + mt1.Count);
            Console.WriteLine(mt2.Thrd.Name + " thread counted to " + mt2.Count);
        }
    }
}
