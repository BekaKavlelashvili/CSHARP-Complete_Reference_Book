using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class SharedRes
    {
        public static int Count = 0;
        public static Mutex Mtx = new Mutex();
    }

    class IncThread
    {
        int num;
        public Thread Thrd;

        public IncThread(string name, int n)
        {
            Thrd = new Thread(this.Run);
            num = n;
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " is waiting for the mutex.");

            SharedRes.Mtx.WaitOne();

            Console.WriteLine(Thrd.Name + " acquires the mutex.");

            do
            {
                Thread.Sleep(500);
                SharedRes.Count++;
                Console.WriteLine("In " + Thrd.Name + ", SharedRec.Count is" + SharedRes.Count);
                num--;
            } while (num > 0);

            Console.WriteLine(Thrd.Name + " releases the mutex.");

            SharedRes.Mtx.ReleaseMutex();
        }
    }


    class DecThread
    {
        int num;
        public Thread Thrd;

        public DecThread(string name, int n)
        {
            Thrd = new Thread(new ThreadStart(this.Run));
            num = n;
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " is waiting for the mutex.");

            SharedRes.Mtx.WaitOne();

            Console.WriteLine(Thrd.Name + " acquires the mutex");

            do
            {
                Thread.Sleep(500);
                SharedRes.Count--;
                Console.WriteLine("In " + Thrd.Name + ", SharedRes.Count is " + SharedRes.Count);
                num--;
            } while (num > 0);

            Console.WriteLine(Thrd.Name + " releases the mutex.");

            SharedRes.Mtx.ReleaseMutex();
        }
    }


    public class UseMutex
    {
        public static void UseMutexMain()
        {
            Console.WriteLine("\n=== Use Mutex ===");

            IncThread mt1 = new IncThread("Increment Thread", 5);

            Thread.Sleep(1);

            DecThread mt2 = new DecThread("Decrement Thread", 5);

            mt1.Thrd.Join();
            mt2.Thrd.Join();
        }
    }
}
