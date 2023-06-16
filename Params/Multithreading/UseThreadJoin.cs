using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class MyThread3
    {
        public int Count;
        public Thread Thrd;
        public MyThread3(string name)
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


    public class UseThreadJoin
    {
        public static void UseThreadJoinMain()
        {
            Console.WriteLine("\n=== Use Thread Join() ===");

            Console.WriteLine("Main thread starting.");

            MyThread3 mt1 = new MyThread3("Child #1");
            MyThread3 mt2 = new MyThread3("Child #2");
            MyThread3 mt3 = new MyThread3("Child #3");

            mt1.Thrd.Join();
            Console.WriteLine("Child #1 joined.");

            mt2.Thrd.Join();
            Console.WriteLine("Child #2 joined.");

            mt3.Thrd.Join();
            Console.WriteLine("Child #3 joined.");

            Console.WriteLine("Main thread ending.");
        }
    }
}
