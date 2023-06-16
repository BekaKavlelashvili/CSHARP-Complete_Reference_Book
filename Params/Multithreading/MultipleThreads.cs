using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class MyThread2
    {
        public int Count;
        public Thread Thrd;
        public MyThread2(string name)
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
                Console.WriteLine("In " + Thrd.Name +
                ", Count is " + Count);
                Count++;
            } while (Count < 10);
            Console.WriteLine(Thrd.Name + " terminating.");
        }
    }
    public class MultipleThreads
    {
        public static void MultipleThreadsMain()
        {
            Console.WriteLine("\n=== Create Multiple Threads ===");

            Console.WriteLine("Main thread starting.");

            MyThread2 mt1 = new MyThread2("Child #1");
            MyThread2 mt2 = new MyThread2("Child #2");
            MyThread2 mt3 = new MyThread2("Child #3");

            do
            {
                Console.Write(".");
                Thread.Sleep(100);
            } while (mt1.Count < 10 || mt2.Count < 10 || mt3.Count < 10);

            Console.WriteLine("Main thread ending.");
        }
    }
}
