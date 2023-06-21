using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class SharedRes2
    {
        public static int Count = 0;
    }

    class IncThread2
    {
        public Thread Thrd;

        public IncThread2(string name)
        {
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Interlocked.Increment(ref SharedRes.Count);
                Console.WriteLine(Thrd.Name + " Count is " + SharedRes.Count);
            }
        }
    }

    class DecThread2
    {
        public Thread Thrd;

        public DecThread2(string name)
        {
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Interlocked.Decrement(ref SharedRes.Count);
                Console.WriteLine(Thrd.Name + " Count is " + SharedRes.Count);
            }
        }
    }


    public class UseInterlockedOperations
    {
        public static void UseInterlockedOperationsMain()
        {
            Console.WriteLine("\n=== Use Interlocked Operations ===");

            IncThread2 mt1 = new IncThread2("Increment Thread");
            DecThread2 mt2 = new DecThread2("Decrement Thread");

            mt1.Thrd.Join();
            mt2.Thrd.Join();
        }
    }
}
