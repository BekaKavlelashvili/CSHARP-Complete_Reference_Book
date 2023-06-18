using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class TickTock
    {
        object lockOn = new object();

        public void Tick(bool running)
        {
            lock (lockOn)
            {
                if (!running)
                {
                    Monitor.Pulse(lockOn);
                    return;
                }

                Console.WriteLine("Tick");
                Monitor.Pulse(lockOn);

                Monitor.Wait(lockOn);
            }
        }

        public void Tock(bool running)
        {
            lock (lockOn)
            {
                if (!running)
                {
                    Monitor.Pulse(lockOn);
                    return;
                }

                Console.WriteLine("Tock");
                Monitor.Pulse(lockOn);

                Monitor.Wait(lockOn);
            }
        }
    }

    class MyThread7
    {
        public Thread Thrd;
        TickTock tt;

        public MyThread7(string name, TickTock ttObj)
        {
            Thrd = new Thread(this.Run);
            tt = ttObj;
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            if (Thrd.Name == "Tick")
            {
                for (int i = 0; i < 5; i++)
                    tt.Tick(true);
                tt.Tick(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    tt.Tock(true);
                tt.Tock(false);
            }
        }
    }

    public class UseWaitAndPulse
    {
        public static void UseWaitAndPulseMain()
        {
            Console.WriteLine("\n=== Use Wait And Pulse ===");

            TickTock tt = new TickTock();
            MyThread7 mt1 = new("Tick", tt);
            MyThread7 mt2 = new("Tock", tt);

            mt1.Thrd.Join();
            mt2.Thrd.Join();
            Console.WriteLine("Clock stopped");
        }
    }
}
