using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class MyThread9
    {
        public Thread Thrd;

        static Semaphore sem = new Semaphore(2, 2);

        public MyThread9(string name)
        {
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " is waiting for a permit.");

            sem.WaitOne();

            Console.WriteLine(Thrd.Name + " acquires a permit.");

            for (char ch  = 'A'; ch < 'D'; ch++)
            {
                Console.WriteLine(Thrd.Name + " : " + ch + " ");
                Thread.Sleep(500);
            }

            Console.WriteLine(Thrd.Name + " releases a permit.");

            sem.Release();
        }
    }

    public class UseSemaphore
    {
        public static void UseSemaphoreMain()
        {
            Console.WriteLine("\n=== Use Semaphore ===");

            MyThread9 mt1 = new MyThread9("Thread #1");
            MyThread9 mt2 = new MyThread9("Thread #2");
            MyThread9 mt3 = new MyThread9("Thread #3");

            mt1.Thrd.Join();
            mt2.Thrd.Join();
            mt3.Thrd.Join();
        }
    }
}
