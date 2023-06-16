using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class MyThread4
    {
        public int Count;
        public Thread Thrd;

        public MyThread4(string name, int num)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start(num);
        }

        void Run(object num)
        {
            Console.WriteLine(Thrd.Name + " starting with count of " + num);
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In " + Thrd.Name + ", Count is " + Count);
                Count++;
            } while (Count < (int)num);

            Console.WriteLine(Thrd.Name + " terminating.");
        }
    }

    public class PassArgToThreadMethod
    {
        public static void PassArgToThreadMethodMain()
        {
            Console.WriteLine("\n=== Pass argument to a thread method ===");

            MyThread4 mt = new MyThread4("Child #1", 5);
            MyThread4 mt2 = new MyThread4("Child #2", 3);

            do
            {
                Thread.Sleep(100);
            } while (mt.Thrd.IsAlive | mt2.Thrd.IsAlive);

            Console.WriteLine("Main thread ending.");
        }
    }
}
