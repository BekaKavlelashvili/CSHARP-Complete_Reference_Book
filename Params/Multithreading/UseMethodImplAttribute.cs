using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class TickTock2
    {
        [MethodImplAttribute(MethodImplOptions.Synchronized)]
        public void Tick(bool running)
        {
            if (!running)
            {
                Monitor.Pulse(this);
                return;
            }

            Console.Write("Tick ");
            Monitor.Pulse(this);
            Monitor.Wait(this);
        }


        [MethodImplAttribute(MethodImplOptions.Synchronized)]
        public void Tock(bool running)
        {
            if (!running)
            {
                Monitor.Pulse(this);
                return;
            }

            Console.WriteLine("Tock");
            Monitor.Pulse(this);
            Monitor.Wait(this);
        }
    }

    class MyThread8
    {
        public Thread Thrd;
        TickTock2 ttOb;

        public MyThread8(string name, TickTock2 tt)
        {
            Thrd = new Thread(this.Run);
            ttOb = tt;
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            if (Thrd.Name == "Tick")
            {
                for (int i = 0; i < 5; i++)
                    ttOb.Tick(true);
                ttOb.Tick(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    ttOb.Tock(true);
                ttOb.Tock(false);
            }
        }
    }

    public class UseMethodImplAttribute
    {
        public static void UseMethodImplAttributeMain()
        {
            Console.WriteLine("\n=== Use MethodImplAttribute ===");

            TickTock2 tt = new TickTock2();
            MyThread8 mt1 = new MyThread8("Tick", tt);
            MyThread8 mt2 = new MyThread8("Tock", tt);

            mt1.Thrd.Join();
            mt2.Thrd.Join();
            Console.WriteLine("Clock Stopped");
        }
    }
}
