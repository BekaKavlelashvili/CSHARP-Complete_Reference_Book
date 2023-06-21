using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class MyThread10
    {
        public Thread Thrd;
        ManualResetEvent mre;

        public MyThread10(string name, ManualResetEvent evt)
        {
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            mre = evt;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine("Inside thread " + Thrd.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Thrd.Name);
                Thread.Sleep(500);
            }
            Console.WriteLine(Thrd.Name + " Done!");
            mre.Set();
        }
    }


    public class UseManualEventObj
    {
        public static void UseManualEventObjMain()
        {
            Console.WriteLine("\n=== Use Manual Event Object ===");

            ManualResetEvent evtOb = new ManualResetEvent(false);

            MyThread10 mt1 = new MyThread10("Event thread 1", evtOb);

            Console.WriteLine("Main thread waiting for event.");

            evtOb.WaitOne();

            Console.WriteLine("Main thread received first event");

            evtOb.Reset();

            mt1 = new MyThread10("Event thread 2", evtOb);
            evtOb.WaitOne();

            Console.WriteLine("Main thread received second event");
        }
    }
}
