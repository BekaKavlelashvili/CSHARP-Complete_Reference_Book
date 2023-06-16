using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class MyThread1
    {
        public int Count;
        public Thread Thrd;

        public MyThread1(string name)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " starting.");

            do
            {
                Thread.Sleep(500);

                Console.WriteLine("In " + Thrd.Name + ", Count is " + Count);

                Count++;
            } while (Count < 10);

            Console.WriteLine(Thrd.Name + " terminating.");
        }
    }

    public class ImproveThreadClass
    {
        public static void ImproveThreadClassMain()
        {
            Console.WriteLine("\n=== Improvement of Thread class ===");

            Console.WriteLine("Main Thread starting");

            MyThread1 thread1 = new MyThread1("Child #1");

            do
            {
                Console.Write('.');
                Thread.Sleep(100);
            } while (thread1.Count != 10);

            Console.WriteLine("Main thread ending.");
        }
    }
}
